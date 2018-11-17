using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AssetPacker.Model
{
    public class ImagePair
    {
        public ImagePair(string path, Bitmap image)
        {
            Path = path;
            Image = image;
        }

        public string Path { get; set; }
        public Bitmap Image { get; set; }
    }

    public class Rect
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }

        public Rect(int x, int y, int w, int h)
        {
            X = x;
            Y = y;
            W = w;
            H = h;
        }
        public Rect Clone()
        {
            return new Rect(X, Y, W, H);
        }

        public List<Rect> SplitVertical(int y)
        {
            var rects = new List<Rect>
            {
                new Rect(X, Y, W, y),
                new Rect(X, Y + y, W, H - y)
            };
            return rects;
        }

        public List<Rect> SplitHorizontal(int x)
        {
            var rects = new List<Rect>
            {
                new Rect(X, Y, x, H),
                new Rect(X + x, Y, W - x, H)
            };
            return rects;
        }

        public int Area()
        {
            return W * H;
        }

        public int MaxSide()
        {
            return Math.Max(W, H);
        }

        public bool CanContain(int w, int h)
        {
            return W >= w && H >= h;
        }

        public bool IsCongruentWith(int w, int h)
        {
            return W == w && H == h;
        }
        public override string ToString()
        {
            return string.Format("<({0}, {1}) - ({2}, {3})>", X, Y, W, H);
        }
        public bool ShouldSplitVertically(int w, int h)
        {
            if (W == w)
                return true;
            else if (H == h)
                return false;
            // TODO: come up with a better heuristic
            var vertRects = SplitVertical(h);
            var horzRects = SplitHorizontal(w);
            return vertRects[1].Area() > horzRects[1].Area();
        }
        public bool ShouldGrowVertically(int w, int h)
        {
            var canGrowVert = W >= w;
            var canGrowHorz = H >= h;
            if (!canGrowVert && !canGrowHorz)
                throw new Exception("Unable to grow!");
            if (canGrowVert && !canGrowHorz)
                return true;
            if (canGrowHorz && !canGrowVert)
                return false;
            return (H + h < W + w);
        }
    }

    public class Offset
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Offset(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Sprite
    {
        public string ImageName { get; set; }
        public Bitmap Image { get; set; }
        public Rect Rect { get; set; }
        public Offset Offset { get; set; }
        public List<Sprite> Children { get; set; }

        public Sprite(ImagePair imagePair, Rect rect, List<Sprite> children = null)
        {
            if (null != imagePair)
            {
                ImageName = imagePair.Path;
                Image = imagePair.Image;
            }
            else
            {
                ImageName = "";
                Image = null;
            }
            Rect = rect;
            Offset = new Offset(0, 0);
            if (null != children)
                Children = children;
            else
                Children = new List<Sprite>();
        }

        public Sprite Clone()
        {
            if (IsLeaf())
                return new Sprite(new ImagePair(ImageName, Image), Rect.Clone());
            else
            {
                var children = new List<Sprite>() {
                    Children[0].Clone(),
                    Children[1].Clone()
                };
                return new Sprite(new ImagePair(ImageName, Image), Rect.Clone(), children);
            }
        }

        public bool IsLeaf()
        {
            return Children.Count == 0;
        }

        public bool IsEmptyLeaf()
        {
            return (IsLeaf() && Image == null);
        }

        public void SplitNode(ImagePair imagePair)
        {
            if (!IsLeaf())
                throw new Exception("Attempted to split non-leaf");

            var imageW = imagePair.Image.Width;
            var imageH = imagePair.Image.Height;
            if (!Rect.CanContain(imageW, imageH))
                throw new Exception("Attempted to place an img in a node it doesn't fit");

            //if it fits exactly then we are done
            if (Rect.IsCongruentWith(imageW, imageH))
            {
                ImageName = imagePair.Path;
                Image = imagePair.Image;
            }
            else
            {
                if (Rect.ShouldSplitVertically(imageW, imageH))
                {
                    var vertRects = Rect.SplitVertical(imageH);
                    var top = new Sprite(null, vertRects[0]);
                    var bottom = new Sprite(null, vertRects[1]);
                    Children.Add(top);
                    Children.Add(bottom);
                }
                else
                {
                    var horzRects = Rect.SplitHorizontal(imageW);
                    var left = new Sprite(null, horzRects[0]);
                    var right = new Sprite(null, horzRects[1]);
                    Children.Add(left);
                    Children.Add(right);
                }
                Children[0].SplitNode(imagePair);
            }
        }

        public void GrowNode(ImagePair imagePair)
        {
            if (IsEmptyLeaf())
                throw new Exception("Attempted to grow an empty leaf");

            var imageW = imagePair.Image.Width;
            var imageH = imagePair.Image.Height;
            var newChild = Clone();
            Children.Clear();
            Children.Add(newChild);
            Image = null;
            ImageName = "";
            if (Rect.ShouldGrowVertically(imageW, imageH))
            {
                Children.Add(new Sprite(null, new Rect(Rect.X, Rect.Y + Rect.H, Rect.W, imageH)));
                Rect.H += imageH;
            }
            else
            {
                Children.Add(new Sprite(null, new Rect(Rect.X + Rect.W, Rect.Y, imageW, Rect.H)));
                Rect.W += imageW;
            }
            Children[1].SplitNode(imagePair);
        }

        public override string ToString()
        {
            if (IsLeaf())
                return string.Format("[ {0}: {1} ]", ImageName, Rect.ToString());
            else
                return string.Format("[ {0}: {1} | {2} {3}]", ImageName, Rect.ToString(), Children[0].ToString(), Children[1].ToString());
        }

        public void Render(Graphics gr)
        {
            if (IsLeaf())
            {
                if (null != Image)
                    gr.DrawImage(Image, Rect.X, Rect.Y);
            }
            else
            {
                Children[0].Render(gr);
                Children[1].Render(gr);
            }
        }

        public string ToXml()
        {
            var xml = new StringBuilder();
            xml.AppendFormat("        <key>{0}</key>\n", ImageName);
            xml.AppendFormat("        <dict>\n");
            xml.AppendFormat("        <key>frame</key>\n");
            xml.AppendFormat("            <string>{{{{{0},{1}}},{{{2},{3}}}}}</string>\n", Rect.X, Rect.Y, Rect.W, Rect.H);
            xml.AppendFormat("            <key>offset</key>\n");
            xml.AppendFormat("            <string>{{{0},{1}}}</string>\n", Offset.X, Offset.Y);
            xml.AppendFormat("            <key>rotated</key>\n");
            xml.AppendFormat("            <false/>\n");
            xml.AppendFormat("            <key>sourceColorRect</key>\n");
            xml.AppendFormat("            <string>{{{{0,0}},{{{0},{1}}}}}</string>\n", Rect.W, Rect.H);
            xml.AppendFormat("            <key>sourceSize</key>\n");
            xml.AppendFormat("           <string>{{{0},{1}}}</string>\n", Rect.W, Rect.H);
            xml.AppendFormat("        </dict>\n");
            return xml.ToString();
        }

        public string ToChar()
        {
            return string.Format("char id={0}\tx={1}\ty={2}\twidth={3}\theight={4}\txoffset={5}\tyoffset={6}\txadvance={7}\tpage={8}\tchnl={9}\n",
                System.IO.Path.GetFileNameWithoutExtension(ImageName), Rect.X, Rect.Y, Rect.W, Rect.H, Offset.X, Offset.Y, Rect.W, 0, 15);
        }
    }
}
