using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AssetPacker.Model
{
    public class Atlas
    {
        [Newtonsoft.Json.JsonIgnore]
        public List<Sprite> Sprites { get; set; }
        public Dictionary<string, Offset> Offsets { get; set; }
        public List<Animation> Animations { get; set; }

        private Bitmap image;

        public Atlas()
        {
            Sprites = new List<Sprite>();
            Offsets = new Dictionary<string, Offset>();
            Animations = new List<Animation>();
        }

        public Bitmap GenerateSpriteSheetImage(string path, int padding, bool npot, bool copyBorder)
        {
            List<string> paths = GetImagePaths(path);
            if (paths.Count == 0)
                return null;

            List<ImagePair> images = GetImages(path, paths, copyBorder, padding);
            images = SortImages(images);
            Sprite root = PackImages(images);
            Sprites = Flatten(root);
            foreach (var sprite in Sprites)
            {
                if (Offsets.ContainsKey(sprite.ImageName))
                {
                    Offset offset = Offsets[sprite.ImageName];
                    sprite.Offset.X = offset.X;
                    sprite.Offset.Y = offset.Y;
                }
            }
            int width = root.Rect.W;
            int height = root.Rect.H;
            if (npot)
            {
                width = height = NearestPowerOfTwo(Math.Max(width, height));
            }
            image = new Bitmap(width, height);
            var gr = Graphics.FromImage(image);
            gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            root.Render(gr);
            return image;
        }

        private List<string> GetImagePaths(string rootpath, string path = null)
        {
            var list = new List<string>();
            if (string.IsNullOrEmpty(path))
                path = rootpath;
            var dirs = System.IO.Directory.GetDirectories(path);
            foreach (var dir in dirs)
            {
                list.AddRange(GetImagePaths(rootpath, dir));
            }
            var files = System.IO.Directory.GetFiles(path);
            foreach (var file in files)
            {
                if (!file.EndsWith(".png"))
                    continue;
                list.Add(file);
            }
            return list;
        }

        private List<ImagePair> GetImages(string rootpath, List<string> paths, bool copyBorder, int padding)
        {
            var images = new List<ImagePair>();
            foreach (var file in paths)
            {
                if (!file.EndsWith(".png"))
                    continue;
                
                if (copyBorder)
                    padding += 1;

                Bitmap origin = new Bitmap(file);
                Bitmap copy = new Bitmap(origin.Width + (padding * 2), origin.Height + (padding * 2));
                var gr = Graphics.FromImage(copy);
                gr.DrawImage(origin, padding, padding);
                if (copyBorder)
                    CopyBorder(copy, padding);

                int len = System.IO.Path.GetFileName(rootpath).Length;
                string basepath = rootpath.Substring(0, rootpath.Length - len);
                string spriteName = file.Substring(basepath.Length).Replace('\\', '/');
                images.Add(new ImagePair(spriteName, copy));
            }
            return images;
        }

        private void CopyBorder(Bitmap img, int pad)
        {
            int x, y;

            // top
            for (x = pad; x < img.Width - pad; ++x)
            {
                var color = img.GetPixel(x, pad);
                img.SetPixel(x, pad - 1, color);
            }

            // left
            for (y = pad; y < img.Height - pad; ++y)
            {
                var color = img.GetPixel(pad, y);
                img.SetPixel(pad - 1, y, color);
            }

            // right
            for (y = pad; y < img.Height - pad; ++y)
            {
                var color = img.GetPixel(img.Width - pad - 1, y);
                img.SetPixel(img.Width - pad, y, color);
            }

            // bottom
            for (x = pad; x < img.Width - pad; ++x)
            {
                var color = img.GetPixel(x, img.Height - pad - 1);
                img.SetPixel(x, img.Height - pad, color);
            }
        }

        private List<ImagePair> SortImages(List<ImagePair> images)
        {
            // sort by area
            images.Sort((a, b) => {
                return (b.Image.Width * b.Image.Height).CompareTo((a.Image.Width * a.Image.Height));
            });
            // sort by max dimension
            images.Sort((a, b) => {
                return Math.Max(b.Image.Width, b.Image.Height).CompareTo(Math.Max(a.Image.Width, a.Image.Height));
            });
            return images;
        }

        private Sprite FindEmptyLeaf(Sprite node, Bitmap image)
        {
            var imageW = image.Width;
            var imageH = image.Height;
            if (node.IsEmptyLeaf())
            {
                if (node.Rect.CanContain(imageW, imageH))
                    return node;
                else
                    return null;
            }
            else
            {
                if (node.IsLeaf())
                    return null;
                var leaf = FindEmptyLeaf(node.Children[0], image);
                if (leaf != null)
                    return leaf;
                else
                    return FindEmptyLeaf(node.Children[1], image);
            }
        }

        private Sprite PackImages(List<ImagePair> images)
        {
            var root = new Sprite(null, new Rect(0, 0, images[0].Image.Width, images[0].Image.Height));
            for (int i = 0; i < images.Count; ++i)
            {
                var imagePair = images[i];
                var leaf = FindEmptyLeaf(root, imagePair.Image);
                if (leaf != null)
                    leaf.SplitNode(imagePair);
                else
                    root.GrowNode(imagePair);
            }
            return root;
        }

        private List<Sprite> Flatten(Sprite node)
        {
            var nodes = new List<Sprite>();
            if (node.IsLeaf())
            {
                if (null != node.Image)
                    nodes.Add(node);
                return nodes;
            }
            else
            {
                var left = Flatten(node.Children[0]);
                var right = Flatten(node.Children[1]);
                left.AddRange(right);
                return left;
            }
        }

        private int NearestPowerOfTwo(int n)
        {
            var log2 = Math.Log(n) / Math.Log(2);
            return (int)Math.Pow(2, (Math.Ceiling(log2)));
        }

        public void SaveImage(string path)
        {
            image.Save(path);
        }

        private string GetPlistHead()
        {
            var xml = new StringBuilder();
            xml.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>\n");
            xml.Append("<!DOCTYPE plist PUBLIC \"-//Apple//DTD PLIST 1.0//EN\" \"http://www.apple.com/DTDs/PropertyList-1.0.dtd\">\n");
            xml.Append("<plist version=\"1.0\">\n<dict>\n    <key>frames</key>\n    <dict>\n");
            return xml.ToString();
        }

        private string GetPlistTail()
        {
            var xml = new StringBuilder();
            xml.Append("    </dict>\n    <key>metadata</key>\n    <dict>\n");
            xml.Append("        <key>format</key>\n");
            xml.Append("        <integer>2</integer>\n");
            xml.Append("        <key>size</key>\n");
            xml.AppendFormat("        <string>{{{0},{1}}}</string>\n", image.Width, image.Height);
            xml.Append("    </dict>\n</dict>\n</plist>\n");
            return xml.ToString();
        }

        public void SavePlist(string path)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path))
            {
                file.Write(GetPlistHead());
                foreach (var sprite in Sprites)
                {
                    file.Write(sprite.ToXml());
                }
                file.Write(GetPlistTail());
            }
        }
        
        public void SaveFnt(string path)
        {
            string filename = System.IO.Path.GetFileName(path);
            int fontsize = 0;
            if (Sprites.Count > 0)
            {
                fontsize = Sprites[0].Image.Height;
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path))
            {
                var sb = new StringBuilder();
                sb.AppendFormat("info face=\"{0}\" size={1} bold=0 italic=0 charset=\"\" unicode=0 stretchH=100 smooth=1 aa=1 padding=0,0,0,0 spacing=1,1\n", filename, fontsize);
                sb.AppendFormat("common lineHeight={0} base=28 scaleW={1} scaleH={2} pages=1 packed=0\n", fontsize, image.Width, image.Height);
                sb.AppendFormat("page id=0 file=\"{0}.png\"\n", filename);
                sb.AppendFormat("chars count={0}\n", Sprites.Count);
                file.Write(sb.ToString());
                foreach (var sprite in Sprites)
                {
                    file.Write(sprite.ToChar());
                }
                file.Write("kernings count=-1");
            }
        }

        public void SaveAnimation(string path)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path))
            {
                var xml = new StringBuilder();
                xml.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>\n");
                xml.Append("<!DOCTYPE plist PUBLIC \"-//Apple//DTD PLIST 1.0//EN\" \"http://www.apple.com/DTDs/PropertyList-1.0.dtd\">\n");
                xml.Append("<plist version=\"1.0\">\n");
                xml.Append("<dict>\n");
                xml.Append("    <key>animations</key>\n");
                xml.Append("    <dict>\n");
                // animations
                foreach (var i in Animations)
                {
                    xml.Append(i.ToXml("        "));
                }
                xml.Append("    </dict>\n");
                xml.Append("    <key>properties</key>\n");
                xml.Append("    <dict>\n");
                xml.Append("        <key>spritesheets</key>\n");
                xml.Append("        <array>\n");
                // spritesheets
                //foreach (var i in Atlas)
                //{
                //    xml.AppendFormat("            <string>{0}.plist</string>\n", System.IO.Path.GetFileName(i.Path));
                //}
                xml.Append("        </array>\n");
                xml.Append("        <key>format</key>\n");
                xml.Append("        <integer>2</integer>\n");
                xml.Append("    </dict>\n");
                xml.Append("</dict>\n");
                xml.Append("</plist>\n");

                file.Write(xml.ToString());
            }
        }
    }
}
