using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AssetPacker.Model
{
    public class SpriteAtlasSettings
    {
        public int Padding { get; set; }
        public bool NPOT { get; set; }
        public bool Border { get; set; }

        public SpriteAtlasSettings()
        {
            Padding = 0;
            NPOT = false;
            Border = false;
        }
    }

    public class PackageSettings
    {
        public string SourcePath { get; set; }
        [JsonIgnore]
        public string PrivateKey { get; set; }

        public PackageSettings()
        {
            PrivateKey = "";
        }
    }

    public class Project
    {
        public static string Ext = ".assetproj";

        public string Name { get; set; }
        public string Path { get; set; }
        public List<Asset> Assets { get; set; }
        public SpriteAtlasSettings SpriteAtlasSettings { get; set; }
        public PackageSettings PackageSettings { get; set; }

        public Project()
        {
            Clear();
        }

        public void Clear()
        {
            Name = "Untitled";
            Path = "";
            Assets = new List<Asset>();
            SpriteAtlasSettings = new SpriteAtlasSettings();
            PackageSettings = new PackageSettings();
        }

        public void Copy(Project other)
        {
            Name = other.Name;
            Path = other.Path;
            Assets = other.Assets;
            SpriteAtlasSettings = other.SpriteAtlasSettings;
            PackageSettings = other.PackageSettings;
        }

        public bool ShowConfirm(System.Func<bool> func = null)
        {
            DialogResult dlgResult = MessageBox.Show(
                "Save current project?", "", 
                MessageBoxButtons.YesNoCancel);

            if (dlgResult == DialogResult.Yes)
            {
                func?.Invoke();
                Save();
            }
            else if (dlgResult == DialogResult.Cancel)
            {
                return false;
            }

            return true;
        }

        private string GetPrivateFilePath()
        {
            return MakeAbsolutePath(string.Format("{0}.private_key", Name));
        }

        public void Save()
        {
            if (string.IsNullOrEmpty(Path))
            {
                if (!SaveAs())
                    return;
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Path))
            {
                if (Ext != System.IO.Path.GetExtension(Path))
                    Path += Ext;
                
                Name = System.IO.Path.GetFileNameWithoutExtension(Path);

                Assets.ForEach(a => a.Save());

                string json = JsonConvert.SerializeObject(this,
                    new JsonSerializerSettings()
                    {
                        Formatting = Formatting.Indented,
                        
                    });
                file.Write(json);
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(GetPrivateFilePath()))
            {
                file.Write(PackageSettings.PrivateKey);
            }
        }

        public bool SaveAs()
        {
            var dlg = new SaveFileDialog()
            {
                Filter = string.Format("{0} files (*{0})|*{0}", Ext)
            };
            DialogResult result = dlg.ShowDialog();
            if (result != DialogResult.OK)
                return false;

            if (string.IsNullOrEmpty(dlg.FileName))
                return false;

            Path = dlg.FileName;
            return true;
        }

        public void Open()
        {
            if (System.IO.File.Exists(GetPrivateFilePath()))
            {
                PackageSettings.PrivateKey = System.IO.File.ReadAllText(GetPrivateFilePath());
            }
        }

        public void AddAsset(string path)
        {
            if (string.IsNullOrEmpty(path))
                return;

            Assets.Add(new Asset
            {
                Name = System.IO.Path.GetFileName(path),
                Path = path,
            });
        }

        public void Open(string openPath = null)
        {
            if (string.IsNullOrEmpty(openPath))
            {
                var dlg = new OpenFileDialog()
                {
                    Filter = string.Format("{0} files (*{0})|*{0}", Ext)
                };
                DialogResult result = dlg.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;

                openPath = dlg.FileName;
                if (string.IsNullOrEmpty(openPath))
                    return;
            }

            string json = System.IO.File.ReadAllText(openPath);
            Project project = Newtonsoft.Json.JsonConvert.DeserializeObject<Project>(json);

            Clear();
            Copy(project);
        }

        public string MakeRelativePath(string toPath)
        {
            if (string.IsNullOrEmpty(Path))
                return toPath;

            System.Uri fromUri = new System.Uri(Path);
            System.Uri toUri = new System.Uri(toPath);

            if (fromUri.Scheme != toUri.Scheme) { return toPath; } // path can't be made relative.

            System.Uri relativeUri = fromUri.MakeRelativeUri(toUri);
            string relativePath = System.Uri.UnescapeDataString(relativeUri.ToString());

            if (toUri.Scheme.Equals("file", System.StringComparison.InvariantCultureIgnoreCase))
                relativePath = relativePath.Replace(System.IO.Path.AltDirectorySeparatorChar, System.IO.Path.DirectorySeparatorChar);

            return relativePath;
        }

        public string MakeAbsolutePath(string toPath)
        {
            var absolutePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Path), toPath);
            return absolutePath;
        }
    }
}
