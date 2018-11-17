using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AssetPacker.Command
{
    public class PackAssets : ICommand
    {
        private MainForm form;

        public PackAssets(MainForm form)
        {
            this.form = form;
        }

        public bool Check()
        {
            return form.project != null;
        }

        public void Execute()
        {
            if (!Check())
                return;

            var dlg = new SaveFileDialog()
            {
                FileName = form.project.Name,
                Filter = "assets files (*assets)|*assets",
            };
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            var savefile = dlg.FileName;
            if (string.IsNullOrEmpty(savefile))
                return;

            if (!System.IO.Path.HasExtension(savefile))
                savefile += ".assets";

            System.IO.FileStream fs = new System.IO.FileStream(savefile, System.IO.FileMode.Create);
            
            List<string> filepaths = GetFiles(form.txtPackPath.Text);
            foreach (string filepath in filepaths)
            {
                string filename = filepath.Substring(form.txtPackPath.Text.Length + 1).Replace('\\', '/');
                string ext = System.IO.Path.GetExtension(filename);
                if (ext == ".png")
                {
                    Bitmap image = new Bitmap(filepath);
                    byte[] nameBytes = Encrypt(System.Text.Encoding.UTF8.GetBytes(filename));
                    byte[] nameLenBytes = BitConverter.GetBytes(nameBytes.Length);
                    fs.Write(nameLenBytes, 0, nameLenBytes.Length);
                    fs.Write(nameBytes, 0, nameBytes.Length);
                    byte[] strBytes = EncryptImage(image);
                    byte[] strLenBytes = BitConverter.GetBytes(strBytes.Length);
                    fs.Write(strLenBytes, 0, strLenBytes.Length);
                    fs.Write(strBytes, 0, strBytes.Length);
                }
                else if (ext == ".bytes"
                         || ext == ".csv"
                         || ext == ".fnt"
                         || ext == ".htm"
                         || ext == ".html"
                         || ext == ".json"
                         || ext == ".plist"
                         || ext == ".tsv"
                         || ext == ".txt"
                         || ext == ".xml"
                         || ext == ".yaml")
                {
                    System.IO.StreamReader sr = System.IO.File.OpenText(filepath);
                    string datastr = sr.ReadToEnd();
                    datastr += "\r\n";
                    sr.Close();
                    byte[] nameBytes = Encrypt(System.Text.Encoding.UTF8.GetBytes(filename));
                    byte[] nameLenBytes = BitConverter.GetBytes(nameBytes.Length);
                    fs.Write(nameLenBytes, 0, nameLenBytes.Length);
                    fs.Write(nameBytes, 0, nameBytes.Length);
                    byte[] strBytes = Encrypt(System.Text.Encoding.UTF8.GetBytes(datastr));
                    byte[] strLenBytes = BitConverter.GetBytes(strBytes.Length);
                    fs.Write(strLenBytes, 0, strLenBytes.Length);
                    fs.Write(strBytes, 0, strBytes.Length);
                }
            }
            
            fs.Close();
            MessageBox.Show("complete");
        }

        private List<string> GetFiles(string rootpath, string path = null)
        {
            var list = new List<string>();
            if (string.IsNullOrEmpty(path))
            {
                path = rootpath;
            }
            string[] dirs = System.IO.Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                list.AddRange(GetFiles(rootpath, dir));
            }
            string[] files = System.IO.Directory.GetFiles(path);
            foreach (string file in files)
            {
                list.Add(file);
            }
            return list;
        }

        private byte[] Encrypt(byte[] ba)
        {
            byte[] key = System.Text.Encoding.UTF8.GetBytes(form.txtPrivateKey.Text);
            for (int c = 0; c < ba.Length; c++)
                ba[c] ^= key[c % key.Length];
            return ba;
        }

        private byte[] EncryptImage(Bitmap image)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                var ba = ms.ToArray();
                return Encrypt(ba);
            }
        }
    }
}
