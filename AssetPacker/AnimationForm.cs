using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetPacker
{
    public partial class AnimationForm : Form
    {
        private Model.Project project = null;
        private Model.Asset asset = null;
        private List<string> dirs = new List<string>();

        public AnimationForm()
        {
            InitializeComponent();

            btn_Add.Enabled = false;
            btn_Remove.Enabled = false;
        }

        public void SetData(Model.Project project, Model.Asset asset)
        {
            if (project == null || asset == null)
            {
                Close();
                return;
            }

            this.project = project;
            this.asset = asset;
            
            string rootpath = project.MakeAbsolutePath(asset.Path);
            List<string> dirs = GetLastDirs(rootpath, rootpath);
            this.dirs = dirs;

            lst_Frames.LargeImageList = new ImageList();
            foreach (Model.Sprite sprite in asset.Atlas.Sprites)
            {
                lst_Frames.LargeImageList.Images.Add(sprite.ImageName, sprite.Image);
            }

            RefreshList();
        }

        private List<string> GetLastDirs(string path, string rootpath)
        {
            var list = new List<string>();
            var dirs = System.IO.Directory.GetDirectories(path);
            if (dirs.Length > 0)
            {
                foreach (var dir in dirs)
                {
                    list.AddRange(GetLastDirs(dir, rootpath));
                }
            }
            else
            {
                var len = System.IO.Path.GetFileName(rootpath).Length;
                var basepath = path.Substring(rootpath.Length - len);
                basepath = basepath.Replace("\\", "/");
                list.Add(basepath);
            }
            return list;
        }

        private void RefreshList()
        {
            lst_Dirs.Items.Clear();
            foreach (string dir in dirs)
            {
                if (!dir.Contains(txt_Search.Text))
                    continue;

                lst_Dirs.Items.Add(dir);
            }

            lst_Animations.Items.Clear();
            foreach (Model.Animation ani in asset.Atlas.Animations)
            {
                if (!ani.Name.Contains(txt_Search.Text))
                    continue;

                lst_Animations.Items.Add(ani);
                lst_Dirs.Items.Remove(ani.Name);
            }
        }

        private void FromForm()
        {
            if (lst_Animations.SelectedItems.Count == 0)
                return;

            foreach (var item in lst_Animations.SelectedItems)
            {
                var ani = (Model.Animation)item;
                if (null == ani)
                    return;

                if (float.TryParse(txt_FPS.Text, out float delay))
                    ani.DelayPerUnit = delay;
                else
                    txt_FPS.Text = ani.DelayPerUnit.ToString();
                ani.RestoreOriginalFrame = chk_ResetFrame.Checked;

                if (int.TryParse(txt_Loops.Text, out int loops))
                    ani.Loops = loops;
                else
                    txt_Loops.Text = ani.Loops.ToString();
            }
        }

        private void ToForm()
        {
            txt_FPS.Enabled = false;
            txt_Loops.Enabled = false;
            chk_ResetFrame.Enabled = false;

            if (lst_Animations.SelectedItems.Count == 0)
                return;

            var ani = (Model.Animation)lst_Animations.SelectedItems[0];
            if (null == ani)
            {
                labelName.Text = "";
                txt_FPS.Text = "1.0";
                txt_Loops.Text = "1";
                chk_ResetFrame.Checked = false;
                return;
            }

            labelName.Text = ani.Name;
            if (ani.DelayPerUnit == 0f)
                ani.DelayPerUnit = 1f;
            txt_FPS.Text = ani.DelayPerUnit.ToString();
            chk_ResetFrame.Checked = ani.RestoreOriginalFrame;
            if (ani.Loops == 0)
                ani.Loops = 1;
            txt_Loops.Text = ani.Loops.ToString();
            btn_Add.Enabled = lst_Dirs.SelectedItems.Count > 0;
            btn_Remove.Enabled = lst_Animations.SelectedItems.Count > 0;

            lst_Frames.Items.Clear();
            if (null != ani.Frames)
            {
                foreach (var frame in ani.Frames)
                {
                    lst_Frames.Items.Add(new ListViewItem(frame, frame));
                }
            }

            txt_FPS.Enabled = true;
            txt_Loops.Enabled = true;
            chk_ResetFrame.Enabled = true;
        }

        private void AddAnimation()
        {
            if (lst_Dirs.SelectedItems.Count == 0)
                return;

            foreach (var item in lst_Dirs.SelectedItems)
            {
                var name = (string)item;
                var ani = new Model.Animation();
                asset.Atlas.Animations.Add(ani);
                ani.Name = name;

                var files = System.IO.Directory.GetFiles(project.MakeAbsolutePath(name));
                var filesList = new List<string>(files);
                filesList.Sort((a, b) => {
                    var aname = System.IO.Path.GetFileNameWithoutExtension(a);
                    var bname = System.IO.Path.GetFileNameWithoutExtension(b);
                    if (int.TryParse(aname, out int anum)
                        && int.TryParse(bname, out int bnum))
                        return anum.CompareTo(bnum);
                    return string.Compare(aname, bname);
                });
                foreach (var file in filesList)
                {
                    var filename = System.IO.Path.GetFileName(file);
                    ani.Frames.Add(name + "/" + filename);
                }
                lst_Animations.Items.Add(name);
            }
            RefreshList();
        }

        private void DeleteSelectedAnimation()
        {
            foreach (object item in lst_Animations.SelectedItems)
            {
                var ani = (Model.Animation)item;
                asset.Atlas.Animations.Remove(ani);
            }

            RefreshList();
            ToForm();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (lst_Frames.SelectedIndices.Count != 1)
                return;

            int idx = lst_Frames.SelectedIndices[0];
            if (idx == 0)
                return;

            object item = lst_Animations.SelectedItems[0];
            var ani = (Model.Animation)item;
            if (null == ani)
                return;

            var selected = ani.Frames[idx];
            ani.Frames.RemoveAt(idx);
            ani.Frames.Insert(idx - 1, selected);

            ToForm();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (lst_Frames.SelectedIndices.Count != 1)
                return;

            if (lst_Animations.SelectedItems.Count == 0)
                return;

            int idx = lst_Frames.SelectedIndices[0];
            if (idx == lst_Frames.Items.Count - 1)
                return;

            object item = lst_Animations.SelectedItems[0];
            var ani = (Model.Animation)item;
            if (null == ani)
                return;

            var selected = ani.Frames[idx];
            ani.Frames.RemoveAt(idx);
            ani.Frames.Insert(idx + 1, selected);

            ToForm();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (lst_Frames.SelectedIndices.Count != 1)
                return;

            int idx = lst_Frames.SelectedIndices[0];
            object item = lst_Animations.SelectedItems[0];
            var ani = (Model.Animation)item;
            if (null == ani)
                return;

            string selected = ani.Frames[idx];
            ani.Frames.Insert(idx + 1, selected);

            ToForm();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (lst_Frames.SelectedIndices.Count != 1)
                return;

            int idx = lst_Frames.SelectedIndices[0];
            object item = lst_Animations.SelectedItems[0];
            var ani = (Model.Animation)item;
            if (null == ani)
                return;

            ani.Frames.RemoveAt(idx);

            ToForm();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddAnimation();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            DeleteSelectedAnimation();
        }

        private void Dirs_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Add.Enabled = lst_Dirs.SelectedItems.Count > 0;

            if (lst_Dirs.SelectedItems.Count == 0)
                return;

            txt_FPS.Enabled = false;
            txt_Loops.Enabled = false;
            chk_ResetFrame.Enabled = false;

            labelName.Text = "";
            txt_FPS.Text = "1.0";
            txt_Loops.Text = "1";
            chk_ResetFrame.Checked = false;

            lst_Frames.Items.Clear();
            var dir = (string)lst_Dirs.SelectedItems[0];
            var files = System.IO.Directory.GetFiles(project.MakeAbsolutePath(dir));
            foreach (var file in files)
            {
                var filename = System.IO.Path.GetFileName(file);
                var path = dir + "/" + filename;
                lst_Frames.Items.Add(new ListViewItem(path, path));
            }
        }

        private void Animations_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToForm();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog()
            {
                Filter = "png files|*png",
            };
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string savename = dlg.FileName;
                if (System.IO.Path.HasExtension(savename))
                {
                    savename = System.IO.Path.ChangeExtension(savename, "");
                }
                else
                {
                    savename += ".";
                }
                asset.Atlas.SaveAnimation(savename + "plist");
            }
        }

        private void FormChanged(object sender, EventArgs e)
        {
            FromForm();
        }
    }
}
