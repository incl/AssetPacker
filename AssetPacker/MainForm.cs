using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;
using System;

namespace AssetPacker
{
    public partial class MainForm : Form
    {
        public Model.Project project = null;
        public bool dirty = false;

        public MainForm()
        {
            InitializeComponent();
            UpdateTitle();
            UpdateMenuEnable();

            menu_About.Enabled = true;

            txtPrivateKey.KeyPress += new KeyPressEventHandler(
                (object sender, KeyPressEventArgs e) => {
                    if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^a-z^+^A-Z^]"))
                    {
                        e.Handled = true;
                    }
                });
        }

        public void UpdateTitle()
        {
            if (project != null)
            {
                if (dirty)
                    Text = project.Name + " * - Asset Packer";
                else
                    Text = project.Name + " - " + "Asset Packer";
            }
        }

        public void UpdateMenuEnable()
        {
            Func<string, bool> check = name => {
                string[] names = name.Split('_');
                if (names.Length > 1)
                {
                    System.Reflection.Assembly assem = typeof(MainForm).Assembly;
                    Type t = assem.GetType(string.Format("AssetPacker.Command.{0}", names[1]));
                    if (t != null)
                    {
                        Command.ICommand command = (Command.ICommand)System.Activator.CreateInstance(t, this);
                        return command.Check();
                    }
                }
                return false;
            };
            foreach (var obj in menuStrip.Items)
            {
                if (obj is ToolStripMenuItem item)
                {
                    foreach (var obj2 in item.DropDownItems)
                    {
                        if (obj2 is ToolStripItem item2)
                        {
                            item2.Enabled = check(item2.Name);
                        }
                    }
                }
            }
            foreach (var i in toolStripMenu.Items)
            {
                if (i is ToolStripButton item)
                {
                    item.Enabled = check(item.Name);
                }
            }
            foreach (var i in toolStripAssets.Items)
            {
                if (i is ToolStripButton item)
                {
                    item.Enabled = check(item.Name);
                }
            }
            panelSetting.Enabled = project != null;
        }

        public void RefreshAssetList()
        {
            listAssets.Items.Clear();
            if (project != null)
            {
                foreach (var asset in project.Assets)
                {
                    listAssets.Items.Add(new ListViewItem(asset.ToString(), 0));
                }
            }
        }

        public List<Model.Asset> GetSelectedAssetList()
        {
            List<Model.Asset> items = new List<Model.Asset>();
            if (project == null)
                return items;

            var indices = listAssets.SelectedIndices;
            foreach (var index in indices)
            {
                items.Add(project.Assets[(int)index]);
            }
            
            return items;
        }
        
        private void CommandHandler(object sender, System.EventArgs e)
        {
            string[] names = new string[0];
            if (sender is ToolStripItem item)
            {
                names = item.Name.Split('_');
            }
            else if (sender is Control control)
            {
                names = control.Name.Split('_');
            }
            if (names.Length > 1)
            {
                System.Reflection.Assembly assem = typeof(MainForm).Assembly;
                System.Type t = assem.GetType(string.Format("AssetPacker.Command.{0}", names[1]));
                if (t != null)
                {
                    Command.ICommand command = (Command.ICommand)System.Activator.CreateInstance(t, this);
                    command.Execute();
                }
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var path in paths)
            {
                var attr = System.IO.File.GetAttributes(path);
                var ext = System.IO.Path.GetExtension(path);
                if (attr == System.IO.FileAttributes.Directory)
                {
                    if (project != null)
                    {
                        project.AddAsset(path);
                        RefreshAssetList();
                        dirty = true;
                        UpdateTitle();
                    }
                }
                else if (ext == Model.Project.Ext)
                {
                    if (project == null)
                    {
                        project = new Model.Project();
                    }
                    ClearForm();
                    project.Open(path);
                    ProjectSettingToForm();
                    UpdateTitle();
                    RefreshAssetList();
                    UpdateMenuEnable();
                    dirty = false;
                    UpdateTitle();
                }
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ListAssetDirs_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (null == project && listAssets.SelectedIndices.Count > 0)
                return;

            int index = listAssets.SelectedIndices[0];
            Model.Asset asset = project.Assets[index];
            if (asset == null)
                return;
            
            labelSelected.Text = string.Format("[{0}]", asset.Name);
            groupSpriteAtlas.Enabled = true;
            groupBMFont.Enabled = true;

            bool btnEnabled = asset.Atlas.Sprites.Count > 0;
            btn_EditSprite.Enabled = btnEnabled;
            btn_EditAnimation.Enabled = btnEnabled;
            btn_ExportSpriteAtlas.Enabled = btnEnabled;
            btn_ExportBMFontAtlas.Enabled = btnEnabled;
        }

        private void ListAssets_DoubleClick(object sender, EventArgs e)
        {
            if (null == project && listAssets.SelectedIndices.Count > 0)
                return;

            int index = listAssets.SelectedIndices[0];
            Model.Asset asset = project.Assets[index];
            System.Diagnostics.Process.Start(
                "explorer.exe",
                asset.Path
            );
        }

        public async void RunMakeAtlas(bool useSetting)
        {
            int index = listAssets.SelectedIndices[0];
            var makeAtlasTask = Task<Bitmap>.Run(() => MakeAtlas(index, useSetting));
            toolStripProgressBar.Value = 99;
            Bitmap bitmap = await makeAtlasTask;
            toolStripProgressBar.Value = 0;

            if (bitmap == null)
                return;

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Width = bitmap.Width;
            pictureBox.Height = bitmap.Height;
            pictureBox.Image = bitmap;

            if (useSetting)
            {
                btn_EditSprite.Enabled = true;
                btn_EditAnimation.Enabled = true;
                btn_ExportSpriteAtlas.Enabled = true;
            }
            else
            {
                btn_ExportBMFontAtlas.Enabled = true;
            }
        }
        
        private Bitmap MakeAtlas(int index, bool useSetting)
        {
            var asset = project.Assets[index];
            if (asset.Atlas == null)
                asset.Atlas = new Model.Atlas();

            if (useSetting)
            {
                return asset.Atlas.GenerateSpriteSheetImage(
                    project.MakeAbsolutePath(asset.Path),
                    Decimal.ToInt32(numSpritePadding.Value),
                    checkSpriteAtlasNPOT.Checked,
                    checkSpriteAtlasCopyBorder.Checked);
            }
            else
            {
                return asset.Atlas.GenerateSpriteSheetImage(
                    project.MakeAbsolutePath(asset.Path), 0, true, false);
            }
        }

        private bool isMouseDown = false;
        private Point mouseDownLocation;
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (null == project)
                return;
            
            isMouseDown = true;
            mouseDownLocation = e.Location;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (null == project)
                return;

            if (!isMouseDown)
                return;

            var x = pictureBox.Location.X - (mouseDownLocation.X - e.Location.X);
            var y = pictureBox.Location.Y - (mouseDownLocation.Y - e.Location.Y);
            pictureBox.Location = new Point(x, y);
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (null == project)
                return;

            isMouseDown = false;
        }

        private void ProjectSettingChanged(object sender, EventArgs e)
        {
            dirty = true;
            UpdateTitle();
        }

        public void ClearForm()
        {
            labelSelected.Text = "[Select Asset]";

            groupSpriteAtlas.Enabled = false;
            groupBMFont.Enabled = false;
            pictureBox.Image = null;
            pictureBox.Location = new Point(0, 0);
        }

        public bool FormToProjectSetting()
        {
            if (project != null)
            {
                project.SpriteAtlasSettings.Padding = Decimal.ToInt32(numSpritePadding.Value);
                project.SpriteAtlasSettings.NPOT = checkSpriteAtlasNPOT.Checked;
                project.SpriteAtlasSettings.Border = checkSpriteAtlasCopyBorder.Checked;
                
                project.PackageSettings.SourcePath = txtPackPath.Text;
                project.PackageSettings.PrivateKey = txtPrivateKey.Text;

                return true;
            }

            return false;
        }

        public bool ProjectSettingToForm()
        {
            if (project != null)
            {
                numSpritePadding.Value = project.SpriteAtlasSettings.Padding;
                checkSpriteAtlasNPOT.Checked = project.SpriteAtlasSettings.NPOT;
                checkSpriteAtlasCopyBorder.Checked = project.SpriteAtlasSettings.Border;

                txtPackPath.Text = project.PackageSettings.SourcePath;
                txtPrivateKey.Text = project.PackageSettings.PrivateKey;

                return true;
            }

            return false;
        }

        private void About_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
    }
}
