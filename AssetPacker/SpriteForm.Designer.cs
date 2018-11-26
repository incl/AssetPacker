namespace AssetPacker
{
    partial class SpriteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpriteForm));
            this.listView = new System.Windows.Forms.ListView();
            this.panelSprite = new System.Windows.Forms.Panel();
            this.panelOffset = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numOffsetX = new System.Windows.Forms.NumericUpDown();
            this.numOffsetY = new System.Windows.Forms.NumericUpDown();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripZoomLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripZoom = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripZoom_8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripZoom_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripZoom_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripZoom_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSprite.SuspendLayout();
            this.panelOffset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(250, 462);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.SmallIcon;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.ListIndexChanged);
            // 
            // panelSprite
            // 
            this.panelSprite.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSprite.Controls.Add(this.panelOffset);
            this.panelSprite.Controls.Add(this.pictureBox);
            this.panelSprite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSprite.Location = new System.Drawing.Point(250, 0);
            this.panelSprite.Name = "panelSprite";
            this.panelSprite.Size = new System.Drawing.Size(434, 462);
            this.panelSprite.TabIndex = 1;
            // 
            // panelOffset
            // 
            this.panelOffset.BackColor = System.Drawing.SystemColors.Control;
            this.panelOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOffset.Controls.Add(this.label3);
            this.panelOffset.Controls.Add(this.label2);
            this.panelOffset.Controls.Add(this.label1);
            this.panelOffset.Controls.Add(this.numOffsetX);
            this.panelOffset.Controls.Add(this.numOffsetY);
            this.panelOffset.Location = new System.Drawing.Point(6, 6);
            this.panelOffset.Name = "panelOffset";
            this.panelOffset.Size = new System.Drawing.Size(144, 86);
            this.panelOffset.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Offset";
            // 
            // numOffsetX
            // 
            this.numOffsetX.Location = new System.Drawing.Point(21, 27);
            this.numOffsetX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numOffsetX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numOffsetX.Name = "numOffsetX";
            this.numOffsetX.Size = new System.Drawing.Size(114, 21);
            this.numOffsetX.TabIndex = 0;
            this.numOffsetX.ValueChanged += new System.EventHandler(this.Offset_Changed);
            // 
            // numOffsetY
            // 
            this.numOffsetY.Location = new System.Drawing.Point(21, 56);
            this.numOffsetY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numOffsetY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numOffsetY.Name = "numOffsetY";
            this.numOffsetY.Size = new System.Drawing.Size(114, 21);
            this.numOffsetY.TabIndex = 1;
            this.numOffsetY.ValueChanged += new System.EventHandler(this.Offset_Changed);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(168, 168);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripZoomLabel,
            this.toolStripZoom});
            this.statusStrip1.Location = new System.Drawing.Point(250, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(434, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripZoomLabel
            // 
            this.toolStripZoomLabel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripZoomLabel.Name = "toolStripZoomLabel";
            this.toolStripZoomLabel.Size = new System.Drawing.Size(38, 17);
            this.toolStripZoomLabel.Text = "100%";
            // 
            // toolStripZoom
            // 
            this.toolStripZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripZoom_8,
            this.toolStripZoom_4,
            this.toolStripZoom_2,
            this.toolStripZoom_1});
            this.toolStripZoom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripZoom.Image")));
            this.toolStripZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripZoom.Name = "toolStripZoom";
            this.toolStripZoom.Size = new System.Drawing.Size(32, 20);
            this.toolStripZoom.Text = "tool_Zoom";
            this.toolStripZoom.ButtonClick += new System.EventHandler(this.Zoom_ButtonClick);
            // 
            // toolStripZoom_8
            // 
            this.toolStripZoom_8.Name = "toolStripZoom_8";
            this.toolStripZoom_8.Size = new System.Drawing.Size(105, 22);
            this.toolStripZoom_8.Text = "800%";
            this.toolStripZoom_8.Click += new System.EventHandler(this.ZoomTool_Click);
            // 
            // toolStripZoom_4
            // 
            this.toolStripZoom_4.Name = "toolStripZoom_4";
            this.toolStripZoom_4.Size = new System.Drawing.Size(105, 22);
            this.toolStripZoom_4.Text = "400%";
            this.toolStripZoom_4.Click += new System.EventHandler(this.ZoomTool_Click);
            // 
            // toolStripZoom_2
            // 
            this.toolStripZoom_2.Name = "toolStripZoom_2";
            this.toolStripZoom_2.Size = new System.Drawing.Size(105, 22);
            this.toolStripZoom_2.Text = "200%";
            this.toolStripZoom_2.Click += new System.EventHandler(this.ZoomTool_Click);
            // 
            // toolStripZoom_1
            // 
            this.toolStripZoom_1.Name = "toolStripZoom_1";
            this.toolStripZoom_1.Size = new System.Drawing.Size(105, 22);
            this.toolStripZoom_1.Text = "100%";
            this.toolStripZoom_1.Click += new System.EventHandler(this.ZoomTool_Click);
            // 
            // SpriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelSprite);
            this.Controls.Add(this.listView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpriteForm";
            this.Text = "Sprite editor";
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.panelSprite.ResumeLayout(false);
            this.panelOffset.ResumeLayout(false);
            this.panelOffset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Panel panelSprite;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripZoomLabel;
        private System.Windows.Forms.ToolStripSplitButton toolStripZoom;
        private System.Windows.Forms.ToolStripMenuItem toolStripZoom_8;
        private System.Windows.Forms.ToolStripMenuItem toolStripZoom_4;
        private System.Windows.Forms.ToolStripMenuItem toolStripZoom_2;
        private System.Windows.Forms.ToolStripMenuItem toolStripZoom_1;
        private System.Windows.Forms.Panel panelOffset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numOffsetX;
        private System.Windows.Forms.NumericUpDown numOffsetY;
    }
}