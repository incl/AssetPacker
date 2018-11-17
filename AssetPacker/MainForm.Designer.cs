namespace AssetPacker
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_OpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_SaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_SaveProjectAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAsset = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_OpenAnimation = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_OpenBMFont = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tool_NewProject = new System.Windows.Forms.ToolStripButton();
            this.tool_OpenProject = new System.Windows.Forms.ToolStripButton();
            this.tool_SaveProject = new System.Windows.Forms.ToolStripButton();
            this.panelAssets = new System.Windows.Forms.Panel();
            this.listAssets = new System.Windows.Forms.ListView();
            this.imageListAssetType = new System.Windows.Forms.ImageList(this.components);
            this.toolStripAssets = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_AddAsset = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_DeleteAsset = new System.Windows.Forms.ToolStripButton();
            this.checkSpriteAtlasNPOT = new System.Windows.Forms.CheckBox();
            this.btn_ExportSpriteAtlas = new System.Windows.Forms.Button();
            this.labelSpriteAtlasSpritePadding = new System.Windows.Forms.Label();
            this.numSpritePadding = new System.Windows.Forms.NumericUpDown();
            this.checkSpriteAtlasCopyBorder = new System.Windows.Forms.CheckBox();
            this.btn_EditSprite = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.groupBMFont = new System.Windows.Forms.GroupBox();
            this.btn_GenBMFontAtlas = new System.Windows.Forms.Button();
            this.btn_OpenASCIIForm = new System.Windows.Forms.Button();
            this.btn_ExportBMFontAtlas = new System.Windows.Forms.Button();
            this.labelSelected = new System.Windows.Forms.Label();
            this.groupPackage = new System.Windows.Forms.GroupBox();
            this.btn_OpenSourceDir = new System.Windows.Forms.Button();
            this.labelDir = new System.Windows.Forms.Label();
            this.txtPackPath = new System.Windows.Forms.TextBox();
            this.labelCopy = new System.Windows.Forms.Label();
            this.labelPrivateKey = new System.Windows.Forms.Label();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.btn_CopyKey = new System.Windows.Forms.Button();
            this.btn_GenKey = new System.Windows.Forms.Button();
            this.btn_PackAssets = new System.Windows.Forms.Button();
            this.groupSpriteAtlas = new System.Windows.Forms.GroupBox();
            this.btn_EditAnimation = new System.Windows.Forms.Button();
            this.btn_GenSpriteAtlas = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.panelAssets.SuspendLayout();
            this.toolStripAssets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpritePadding)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.groupBMFont.SuspendLayout();
            this.groupPackage.SuspendLayout();
            this.groupSpriteAtlas.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFile,
            this.menuStripAsset,
            this.menuStripHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuStripFile
            // 
            this.menuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_NewProject,
            this.menu_OpenProject,
            this.toolStripSeparator4,
            this.menu_SaveProject,
            this.menu_SaveProjectAs,
            this.toolStripSeparator1,
            this.menu_Quit});
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(37, 20);
            this.menuStripFile.Text = "File";
            // 
            // menu_NewProject
            // 
            this.menu_NewProject.Name = "menu_NewProject";
            this.menu_NewProject.ShortcutKeyDisplayString = "(N)";
            this.menu_NewProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menu_NewProject.Size = new System.Drawing.Size(168, 22);
            this.menu_NewProject.Text = "New project";
            this.menu_NewProject.Click += new System.EventHandler(this.CommandHandler);
            // 
            // menu_OpenProject
            // 
            this.menu_OpenProject.Name = "menu_OpenProject";
            this.menu_OpenProject.ShortcutKeyDisplayString = "(O)";
            this.menu_OpenProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menu_OpenProject.Size = new System.Drawing.Size(168, 22);
            this.menu_OpenProject.Text = "Open project";
            this.menu_OpenProject.Click += new System.EventHandler(this.CommandHandler);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(165, 6);
            // 
            // menu_SaveProject
            // 
            this.menu_SaveProject.Name = "menu_SaveProject";
            this.menu_SaveProject.ShortcutKeyDisplayString = "(S)";
            this.menu_SaveProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menu_SaveProject.Size = new System.Drawing.Size(168, 22);
            this.menu_SaveProject.Text = "Save project";
            this.menu_SaveProject.Click += new System.EventHandler(this.CommandHandler);
            // 
            // menu_SaveProjectAs
            // 
            this.menu_SaveProjectAs.Name = "menu_SaveProjectAs";
            this.menu_SaveProjectAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menu_SaveProjectAs.ShowShortcutKeys = false;
            this.menu_SaveProjectAs.Size = new System.Drawing.Size(168, 22);
            this.menu_SaveProjectAs.Text = "Save project as...";
            this.menu_SaveProjectAs.Click += new System.EventHandler(this.CommandHandler);
            // 
            // menuStripAsset
            // 
            this.menuStripAsset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_OpenAnimation,
            this.menu_OpenBMFont});
            this.menuStripAsset.Name = "menuStripAsset";
            this.menuStripAsset.Size = new System.Drawing.Size(47, 20);
            this.menuStripAsset.Text = "Asset";
            // 
            // menu_OpenAnimation
            // 
            this.menu_OpenAnimation.Name = "menu_OpenAnimation";
            this.menu_OpenAnimation.Size = new System.Drawing.Size(152, 22);
            this.menu_OpenAnimation.Text = "Animation";
            this.menu_OpenAnimation.Click += new System.EventHandler(this.CommandHandler);
            // 
            // menu_OpenBMFont
            // 
            this.menu_OpenBMFont.Name = "menu_OpenBMFont";
            this.menu_OpenBMFont.Size = new System.Drawing.Size(152, 22);
            this.menu_OpenBMFont.Text = "BMFont";
            this.menu_OpenBMFont.Click += new System.EventHandler(this.CommandHandler);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.toolStripMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 24);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1008, 25);
            this.panelTop.TabIndex = 1;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_NewProject,
            this.tool_OpenProject,
            this.tool_SaveProject});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1008, 25);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tool_NewProject
            // 
            this.tool_NewProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_NewProject.Image = ((System.Drawing.Image)(resources.GetObject("tool_NewProject.Image")));
            this.tool_NewProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_NewProject.Name = "tool_NewProject";
            this.tool_NewProject.Size = new System.Drawing.Size(23, 22);
            this.tool_NewProject.Text = "New project";
            this.tool_NewProject.ToolTipText = "New project";
            this.tool_NewProject.Click += new System.EventHandler(this.CommandHandler);
            // 
            // tool_OpenProject
            // 
            this.tool_OpenProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_OpenProject.Image = ((System.Drawing.Image)(resources.GetObject("tool_OpenProject.Image")));
            this.tool_OpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_OpenProject.Name = "tool_OpenProject";
            this.tool_OpenProject.Size = new System.Drawing.Size(23, 22);
            this.tool_OpenProject.Text = "Open project";
            this.tool_OpenProject.Click += new System.EventHandler(this.CommandHandler);
            // 
            // tool_SaveProject
            // 
            this.tool_SaveProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_SaveProject.Image = ((System.Drawing.Image)(resources.GetObject("tool_SaveProject.Image")));
            this.tool_SaveProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_SaveProject.Name = "tool_SaveProject";
            this.tool_SaveProject.Size = new System.Drawing.Size(23, 22);
            this.tool_SaveProject.Text = "Save project";
            this.tool_SaveProject.Click += new System.EventHandler(this.CommandHandler);
            // 
            // panelAssets
            // 
            this.panelAssets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAssets.Controls.Add(this.listAssets);
            this.panelAssets.Controls.Add(this.toolStripAssets);
            this.panelAssets.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAssets.Location = new System.Drawing.Point(0, 49);
            this.panelAssets.Name = "panelAssets";
            this.panelAssets.Size = new System.Drawing.Size(185, 553);
            this.panelAssets.TabIndex = 2;
            // 
            // listAssets
            // 
            this.listAssets.BackColor = System.Drawing.SystemColors.Window;
            this.listAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAssets.Location = new System.Drawing.Point(0, 25);
            this.listAssets.Name = "listAssets";
            this.listAssets.Size = new System.Drawing.Size(181, 524);
            this.listAssets.SmallImageList = this.imageListAssetType;
            this.listAssets.TabIndex = 1;
            this.listAssets.UseCompatibleStateImageBehavior = false;
            this.listAssets.View = System.Windows.Forms.View.SmallIcon;
            this.listAssets.SelectedIndexChanged += new System.EventHandler(this.ListAssetDirs_SelectedIndexChanged);
            this.listAssets.DoubleClick += new System.EventHandler(this.ListAssets_DoubleClick);
            // 
            // imageListAssetType
            // 
            this.imageListAssetType.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAssetType.ImageStream")));
            this.imageListAssetType.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAssetType.Images.SetKeyName(0, "folder.png");
            // 
            // toolStripAssets
            // 
            this.toolStripAssets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn_AddAsset,
            this.toolStripBtn_DeleteAsset});
            this.toolStripAssets.Location = new System.Drawing.Point(0, 0);
            this.toolStripAssets.Name = "toolStripAssets";
            this.toolStripAssets.Size = new System.Drawing.Size(181, 25);
            this.toolStripAssets.TabIndex = 2;
            this.toolStripAssets.Text = "toolStrip1";
            // 
            // toolStripBtn_AddAsset
            // 
            this.toolStripBtn_AddAsset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_AddAsset.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_AddAsset.Image")));
            this.toolStripBtn_AddAsset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_AddAsset.Name = "toolStripBtn_AddAsset";
            this.toolStripBtn_AddAsset.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_AddAsset.Text = "Add Asset";
            this.toolStripBtn_AddAsset.Click += new System.EventHandler(this.CommandHandler);
            // 
            // toolStripBtn_DeleteAsset
            // 
            this.toolStripBtn_DeleteAsset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_DeleteAsset.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_DeleteAsset.Image")));
            this.toolStripBtn_DeleteAsset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_DeleteAsset.Name = "toolStripBtn_DeleteAsset";
            this.toolStripBtn_DeleteAsset.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_DeleteAsset.Text = "Delete Asset";
            this.toolStripBtn_DeleteAsset.Click += new System.EventHandler(this.CommandHandler);
            // 
            // checkSpriteAtlasNPOT
            // 
            this.checkSpriteAtlasNPOT.AutoSize = true;
            this.checkSpriteAtlasNPOT.Location = new System.Drawing.Point(10, 46);
            this.checkSpriteAtlasNPOT.Name = "checkSpriteAtlasNPOT";
            this.checkSpriteAtlasNPOT.Size = new System.Drawing.Size(145, 16);
            this.checkSpriteAtlasNPOT.TabIndex = 3;
            this.checkSpriteAtlasNPOT.Text = "Nearest power of two";
            this.checkSpriteAtlasNPOT.UseVisualStyleBackColor = true;
            this.checkSpriteAtlasNPOT.CheckedChanged += new System.EventHandler(this.ProjectSettingChanged);
            // 
            // btn_ExportSpriteAtlas
            // 
            this.btn_ExportSpriteAtlas.Location = new System.Drawing.Point(134, 90);
            this.btn_ExportSpriteAtlas.Name = "btn_ExportSpriteAtlas";
            this.btn_ExportSpriteAtlas.Size = new System.Drawing.Size(120, 30);
            this.btn_ExportSpriteAtlas.TabIndex = 6;
            this.btn_ExportSpriteAtlas.Text = "Export Atlas";
            this.btn_ExportSpriteAtlas.UseVisualStyleBackColor = true;
            this.btn_ExportSpriteAtlas.Click += new System.EventHandler(this.CommandHandler);
            // 
            // labelSpriteAtlasSpritePadding
            // 
            this.labelSpriteAtlasSpritePadding.AutoSize = true;
            this.labelSpriteAtlasSpritePadding.Location = new System.Drawing.Point(73, 23);
            this.labelSpriteAtlasSpritePadding.Name = "labelSpriteAtlasSpritePadding";
            this.labelSpriteAtlasSpritePadding.Size = new System.Drawing.Size(86, 12);
            this.labelSpriteAtlasSpritePadding.TabIndex = 1;
            this.labelSpriteAtlasSpritePadding.Text = "Sprite padding";
            // 
            // numSpritePadding
            // 
            this.numSpritePadding.Location = new System.Drawing.Point(6, 19);
            this.numSpritePadding.Name = "numSpritePadding";
            this.numSpritePadding.Size = new System.Drawing.Size(62, 21);
            this.numSpritePadding.TabIndex = 2;
            this.numSpritePadding.ValueChanged += new System.EventHandler(this.ProjectSettingChanged);
            // 
            // checkSpriteAtlasCopyBorder
            // 
            this.checkSpriteAtlasCopyBorder.AutoSize = true;
            this.checkSpriteAtlasCopyBorder.Location = new System.Drawing.Point(10, 68);
            this.checkSpriteAtlasCopyBorder.Name = "checkSpriteAtlasCopyBorder";
            this.checkSpriteAtlasCopyBorder.Size = new System.Drawing.Size(94, 16);
            this.checkSpriteAtlasCopyBorder.TabIndex = 4;
            this.checkSpriteAtlasCopyBorder.Text = "Copy border";
            this.checkSpriteAtlasCopyBorder.UseVisualStyleBackColor = true;
            this.checkSpriteAtlasCopyBorder.CheckedChanged += new System.EventHandler(this.ProjectSettingChanged);
            // 
            // btn_EditSprite
            // 
            this.btn_EditSprite.Location = new System.Drawing.Point(6, 126);
            this.btn_EditSprite.Name = "btn_EditSprite";
            this.btn_EditSprite.Size = new System.Drawing.Size(120, 30);
            this.btn_EditSprite.TabIndex = 7;
            this.btn_EditSprite.Text = "Edit Sprite";
            this.btn_EditSprite.UseVisualStyleBackColor = true;
            this.btn_EditSprite.Click += new System.EventHandler(this.CommandHandler);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContent.Controls.Add(this.panelSetting);
            this.panelContent.Controls.Add(this.statusStrip);
            this.panelContent.Controls.Add(this.pictureBox);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(185, 49);
            this.panelContent.Margin = new System.Windows.Forms.Padding(6);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(823, 553);
            this.panelContent.TabIndex = 4;
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.SystemColors.Control;
            this.panelSetting.Controls.Add(this.groupBMFont);
            this.panelSetting.Controls.Add(this.labelSelected);
            this.panelSetting.Controls.Add(this.groupPackage);
            this.panelSetting.Controls.Add(this.groupSpriteAtlas);
            this.panelSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSetting.Location = new System.Drawing.Point(539, 0);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(280, 527);
            this.panelSetting.TabIndex = 2;
            // 
            // groupBMFont
            // 
            this.groupBMFont.Controls.Add(this.btn_GenBMFontAtlas);
            this.groupBMFont.Controls.Add(this.btn_OpenASCIIForm);
            this.groupBMFont.Controls.Add(this.btn_ExportBMFontAtlas);
            this.groupBMFont.Location = new System.Drawing.Point(10, 197);
            this.groupBMFont.Name = "groupBMFont";
            this.groupBMFont.Size = new System.Drawing.Size(260, 86);
            this.groupBMFont.TabIndex = 10;
            this.groupBMFont.TabStop = false;
            this.groupBMFont.Text = "BMFont Atlas";
            // 
            // btn_GenBMFontAtlas
            // 
            this.btn_GenBMFontAtlas.Location = new System.Drawing.Point(6, 20);
            this.btn_GenBMFontAtlas.Name = "btn_GenBMFontAtlas";
            this.btn_GenBMFontAtlas.Size = new System.Drawing.Size(120, 30);
            this.btn_GenBMFontAtlas.TabIndex = 9;
            this.btn_GenBMFontAtlas.Text = "Generate Atlas";
            this.btn_GenBMFontAtlas.UseVisualStyleBackColor = true;
            this.btn_GenBMFontAtlas.Click += new System.EventHandler(this.CommandHandler);
            // 
            // btn_OpenASCIIForm
            // 
            this.btn_OpenASCIIForm.Location = new System.Drawing.Point(6, 56);
            this.btn_OpenASCIIForm.Name = "btn_OpenASCIIForm";
            this.btn_OpenASCIIForm.Size = new System.Drawing.Size(248, 22);
            this.btn_OpenASCIIForm.TabIndex = 11;
            this.btn_OpenASCIIForm.Text = "Show ASCII Table";
            this.btn_OpenASCIIForm.UseVisualStyleBackColor = true;
            this.btn_OpenASCIIForm.Click += new System.EventHandler(this.CommandHandler);
            // 
            // btn_ExportBMFontAtlas
            // 
            this.btn_ExportBMFontAtlas.Location = new System.Drawing.Point(134, 20);
            this.btn_ExportBMFontAtlas.Name = "btn_ExportBMFontAtlas";
            this.btn_ExportBMFontAtlas.Size = new System.Drawing.Size(120, 30);
            this.btn_ExportBMFontAtlas.TabIndex = 10;
            this.btn_ExportBMFontAtlas.Text = "Export Atlas";
            this.btn_ExportBMFontAtlas.UseVisualStyleBackColor = true;
            this.btn_ExportBMFontAtlas.Click += new System.EventHandler(this.CommandHandler);
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Location = new System.Drawing.Point(8, 9);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(17, 12);
            this.labelSelected.TabIndex = 8;
            this.labelSelected.Text = "[]";
            // 
            // groupPackage
            // 
            this.groupPackage.Controls.Add(this.btn_OpenSourceDir);
            this.groupPackage.Controls.Add(this.labelDir);
            this.groupPackage.Controls.Add(this.txtPackPath);
            this.groupPackage.Controls.Add(this.labelCopy);
            this.groupPackage.Controls.Add(this.labelPrivateKey);
            this.groupPackage.Controls.Add(this.txtPrivateKey);
            this.groupPackage.Controls.Add(this.btn_CopyKey);
            this.groupPackage.Controls.Add(this.btn_GenKey);
            this.groupPackage.Controls.Add(this.btn_PackAssets);
            this.groupPackage.Location = new System.Drawing.Point(10, 289);
            this.groupPackage.Name = "groupPackage";
            this.groupPackage.Size = new System.Drawing.Size(260, 203);
            this.groupPackage.TabIndex = 11;
            this.groupPackage.TabStop = false;
            this.groupPackage.Text = "Package";
            // 
            // btn_OpenSourceDir
            // 
            this.btn_OpenSourceDir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_OpenSourceDir.BackgroundImage")));
            this.btn_OpenSourceDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_OpenSourceDir.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_OpenSourceDir.Location = new System.Drawing.Point(232, 37);
            this.btn_OpenSourceDir.Name = "btn_OpenSourceDir";
            this.btn_OpenSourceDir.Size = new System.Drawing.Size(22, 21);
            this.btn_OpenSourceDir.TabIndex = 0;
            this.btn_OpenSourceDir.TabStop = false;
            this.btn_OpenSourceDir.UseVisualStyleBackColor = true;
            this.btn_OpenSourceDir.Click += new System.EventHandler(this.CommandHandler);
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Location = new System.Drawing.Point(8, 22);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(74, 12);
            this.labelDir.TabIndex = 16;
            this.labelDir.Text = "Source Path";
            // 
            // txtPackPath
            // 
            this.txtPackPath.Location = new System.Drawing.Point(6, 37);
            this.txtPackPath.Name = "txtPackPath";
            this.txtPackPath.Size = new System.Drawing.Size(222, 21);
            this.txtPackPath.TabIndex = 12;
            // 
            // labelCopy
            // 
            this.labelCopy.AutoSize = true;
            this.labelCopy.Location = new System.Drawing.Point(157, 117);
            this.labelCopy.Name = "labelCopy";
            this.labelCopy.Size = new System.Drawing.Size(45, 12);
            this.labelCopy.TabIndex = 14;
            this.labelCopy.Text = "Copied";
            this.labelCopy.Visible = false;
            // 
            // labelPrivateKey
            // 
            this.labelPrivateKey.AutoSize = true;
            this.labelPrivateKey.Location = new System.Drawing.Point(8, 70);
            this.labelPrivateKey.Name = "labelPrivateKey";
            this.labelPrivateKey.Size = new System.Drawing.Size(141, 12);
            this.labelPrivateKey.TabIndex = 13;
            this.labelPrivateKey.Text = "Private key [a-z] [A-Z]";
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(6, 85);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(248, 21);
            this.txtPrivateKey.TabIndex = 13;
            this.txtPrivateKey.TextChanged += new System.EventHandler(this.ProjectSettingChanged);
            // 
            // btn_CopyKey
            // 
            this.btn_CopyKey.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CopyKey.Location = new System.Drawing.Point(82, 112);
            this.btn_CopyKey.Name = "btn_CopyKey";
            this.btn_CopyKey.Size = new System.Drawing.Size(70, 21);
            this.btn_CopyKey.TabIndex = 15;
            this.btn_CopyKey.TabStop = false;
            this.btn_CopyKey.Text = "Copy";
            this.btn_CopyKey.UseVisualStyleBackColor = true;
            this.btn_CopyKey.Click += new System.EventHandler(this.CommandHandler);
            // 
            // btn_GenKey
            // 
            this.btn_GenKey.Location = new System.Drawing.Point(6, 112);
            this.btn_GenKey.Name = "btn_GenKey";
            this.btn_GenKey.Size = new System.Drawing.Size(70, 21);
            this.btn_GenKey.TabIndex = 14;
            this.btn_GenKey.Text = "Generate";
            this.btn_GenKey.UseVisualStyleBackColor = true;
            this.btn_GenKey.Click += new System.EventHandler(this.CommandHandler);
            // 
            // btn_PackAssets
            // 
            this.btn_PackAssets.Location = new System.Drawing.Point(6, 139);
            this.btn_PackAssets.Name = "btn_PackAssets";
            this.btn_PackAssets.Size = new System.Drawing.Size(248, 56);
            this.btn_PackAssets.TabIndex = 16;
            this.btn_PackAssets.Text = "Pack Assets";
            this.btn_PackAssets.UseVisualStyleBackColor = true;
            this.btn_PackAssets.Click += new System.EventHandler(this.CommandHandler);
            // 
            // groupSpriteAtlas
            // 
            this.groupSpriteAtlas.Controls.Add(this.btn_EditAnimation);
            this.groupSpriteAtlas.Controls.Add(this.btn_GenSpriteAtlas);
            this.groupSpriteAtlas.Controls.Add(this.btn_EditSprite);
            this.groupSpriteAtlas.Controls.Add(this.labelSpriteAtlasSpritePadding);
            this.groupSpriteAtlas.Controls.Add(this.checkSpriteAtlasCopyBorder);
            this.groupSpriteAtlas.Controls.Add(this.checkSpriteAtlasNPOT);
            this.groupSpriteAtlas.Controls.Add(this.numSpritePadding);
            this.groupSpriteAtlas.Controls.Add(this.btn_ExportSpriteAtlas);
            this.groupSpriteAtlas.Location = new System.Drawing.Point(10, 28);
            this.groupSpriteAtlas.Name = "groupSpriteAtlas";
            this.groupSpriteAtlas.Size = new System.Drawing.Size(260, 163);
            this.groupSpriteAtlas.TabIndex = 9;
            this.groupSpriteAtlas.TabStop = false;
            this.groupSpriteAtlas.Text = "Sprite Atlas";
            // 
            // btn_EditAnimation
            // 
            this.btn_EditAnimation.Location = new System.Drawing.Point(134, 126);
            this.btn_EditAnimation.Name = "btn_EditAnimation";
            this.btn_EditAnimation.Size = new System.Drawing.Size(120, 30);
            this.btn_EditAnimation.TabIndex = 8;
            this.btn_EditAnimation.Text = "Edit Animation";
            this.btn_EditAnimation.UseVisualStyleBackColor = true;
            this.btn_EditAnimation.Click += new System.EventHandler(this.CommandHandler);
            // 
            // btn_GenSpriteAtlas
            // 
            this.btn_GenSpriteAtlas.Location = new System.Drawing.Point(6, 90);
            this.btn_GenSpriteAtlas.Name = "btn_GenSpriteAtlas";
            this.btn_GenSpriteAtlas.Size = new System.Drawing.Size(120, 30);
            this.btn_GenSpriteAtlas.TabIndex = 5;
            this.btn_GenSpriteAtlas.Text = "Generate Atlas";
            this.btn_GenSpriteAtlas.UseVisualStyleBackColor = true;
            this.btn_GenSpriteAtlas.Click += new System.EventHandler(this.CommandHandler);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolProgressLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 527);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(819, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolProgressLabel
            // 
            this.toolProgressLabel.BackColor = System.Drawing.SystemColors.Control;
            this.toolProgressLabel.Name = "toolProgressLabel";
            this.toolProgressLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(287, 281);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // menu_Quit
            // 
            this.menu_Quit.Name = "menu_Quit";
            this.menu_Quit.ShortcutKeyDisplayString = "Alt + F4";
            this.menu_Quit.Size = new System.Drawing.Size(168, 22);
            this.menu_Quit.Text = "Quit";
            // 
            // menuStripHelp
            // 
            this.menuStripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_About});
            this.menuStripHelp.Name = "menuStripHelp";
            this.menuStripHelp.Size = new System.Drawing.Size(44, 20);
            this.menuStripHelp.Text = "Help";
            // 
            // menu_About
            // 
            this.menu_About.Name = "menu_About";
            this.menu_About.Size = new System.Drawing.Size(152, 22);
            this.menu_About.Text = "About";
            this.menu_About.Click += new System.EventHandler(this.About_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 602);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelAssets);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Asset Packer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panelAssets.ResumeLayout(false);
            this.panelAssets.PerformLayout();
            this.toolStripAssets.ResumeLayout(false);
            this.toolStripAssets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpritePadding)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.groupBMFont.ResumeLayout(false);
            this.groupPackage.ResumeLayout(false);
            this.groupPackage.PerformLayout();
            this.groupSpriteAtlas.ResumeLayout(false);
            this.groupSpriteAtlas.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStripFile;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelAssets;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tool_NewProject;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.ToolStripButton tool_OpenProject;
        private System.Windows.Forms.ToolStripButton tool_SaveProject;
        private System.Windows.Forms.ToolStripMenuItem menu_NewProject;
        private System.Windows.Forms.ToolStripMenuItem menu_OpenProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menu_SaveProject;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStripAsset;
        private System.Windows.Forms.ToolStripMenuItem menu_OpenAnimation;
        private System.Windows.Forms.ToolStripMenuItem menu_OpenBMFont;
        private System.Windows.Forms.Button btn_EditSprite;
        public System.Windows.Forms.NumericUpDown numSpritePadding;
        private System.Windows.Forms.Button btn_ExportSpriteAtlas;
        private System.Windows.Forms.ToolStripMenuItem menu_SaveProjectAs;
        private System.Windows.Forms.ImageList imageListAssetType;
        public System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolProgressLabel;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Label labelSelected;
        public System.Windows.Forms.ListView listAssets;
        private System.Windows.Forms.GroupBox groupPackage;
        private System.Windows.Forms.GroupBox groupSpriteAtlas;
        private System.Windows.Forms.Label labelPrivateKey;
        private System.Windows.Forms.Button btn_GenKey;
        private System.Windows.Forms.Button btn_PackAssets;
        private System.Windows.Forms.Button btn_CopyKey;
        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.TextBox txtPrivateKey;
        public System.Windows.Forms.Label labelCopy;
        public System.Windows.Forms.Label labelSpriteAtlasSpritePadding;
        public System.Windows.Forms.CheckBox checkSpriteAtlasCopyBorder;
        public System.Windows.Forms.CheckBox checkSpriteAtlasNPOT;
        private System.Windows.Forms.GroupBox groupBMFont;
        private System.Windows.Forms.Button btn_OpenASCIIForm;
        private System.Windows.Forms.Button btn_ExportBMFontAtlas;
        private System.Windows.Forms.Button btn_EditAnimation;
        private System.Windows.Forms.Button btn_GenSpriteAtlas;
        private System.Windows.Forms.Button btn_GenBMFontAtlas;
        private System.Windows.Forms.Label labelDir;
        public System.Windows.Forms.TextBox txtPackPath;
        private System.Windows.Forms.ToolStrip toolStripAssets;
        private System.Windows.Forms.ToolStripButton toolStripBtn_AddAsset;
        private System.Windows.Forms.ToolStripButton toolStripBtn_DeleteAsset;
        private System.Windows.Forms.Button btn_OpenSourceDir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_Quit;
        private System.Windows.Forms.ToolStripMenuItem menuStripHelp;
        private System.Windows.Forms.ToolStripMenuItem menu_About;
    }
}

