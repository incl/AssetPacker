namespace AssetPacker
{
    partial class AnimationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationForm));
            this.lst_Dirs = new System.Windows.Forms.ListBox();
            this.lst_Animations = new System.Windows.Forms.ListBox();
            this.btn_ExportAnimation = new System.Windows.Forms.Button();
            this.btn_MoveLeft = new System.Windows.Forms.Button();
            this.btn_MoveRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.lst_Frames = new System.Windows.Forms.ListView();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_FPS = new System.Windows.Forms.TextBox();
            this.txt_Loops = new System.Windows.Forms.TextBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.chk_ResetFrame = new System.Windows.Forms.CheckBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Dirs
            // 
            this.lst_Dirs.FormattingEnabled = true;
            this.lst_Dirs.ItemHeight = 12;
            this.lst_Dirs.Location = new System.Drawing.Point(12, 36);
            this.lst_Dirs.Name = "lst_Dirs";
            this.lst_Dirs.Size = new System.Drawing.Size(330, 232);
            this.lst_Dirs.TabIndex = 0;
            this.lst_Dirs.TabStop = false;
            this.lst_Dirs.SelectedIndexChanged += new System.EventHandler(this.Dirs_SelectedIndexChanged);
            // 
            // lst_Animations
            // 
            this.lst_Animations.FormattingEnabled = true;
            this.lst_Animations.ItemHeight = 12;
            this.lst_Animations.Location = new System.Drawing.Point(442, 36);
            this.lst_Animations.Name = "lst_Animations";
            this.lst_Animations.Size = new System.Drawing.Size(330, 232);
            this.lst_Animations.TabIndex = 0;
            this.lst_Animations.TabStop = false;
            this.lst_Animations.SelectedIndexChanged += new System.EventHandler(this.Animations_SelectedIndexChanged);
            // 
            // btn_ExportAnimation
            // 
            this.btn_ExportAnimation.Location = new System.Drawing.Point(640, 274);
            this.btn_ExportAnimation.Name = "btn_ExportAnimation";
            this.btn_ExportAnimation.Size = new System.Drawing.Size(132, 50);
            this.btn_ExportAnimation.TabIndex = 0;
            this.btn_ExportAnimation.TabStop = false;
            this.btn_ExportAnimation.Text = "Export";
            this.btn_ExportAnimation.UseVisualStyleBackColor = true;
            this.btn_ExportAnimation.Click += new System.EventHandler(this.Export_Click);
            // 
            // btn_MoveLeft
            // 
            this.btn_MoveLeft.Location = new System.Drawing.Point(316, 365);
            this.btn_MoveLeft.Name = "btn_MoveLeft";
            this.btn_MoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btn_MoveLeft.TabIndex = 0;
            this.btn_MoveLeft.TabStop = false;
            this.btn_MoveLeft.Text = "<-";
            this.btn_MoveLeft.UseVisualStyleBackColor = true;
            this.btn_MoveLeft.Click += new System.EventHandler(this.Prev_Click);
            // 
            // btn_MoveRight
            // 
            this.btn_MoveRight.Location = new System.Drawing.Point(397, 365);
            this.btn_MoveRight.Name = "btn_MoveRight";
            this.btn_MoveRight.Size = new System.Drawing.Size(75, 23);
            this.btn_MoveRight.TabIndex = 0;
            this.btn_MoveRight.TabStop = false;
            this.btn_MoveRight.Text = "->";
            this.btn_MoveRight.UseVisualStyleBackColor = true;
            this.btn_MoveRight.Click += new System.EventHandler(this.Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Directories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Animations";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 325);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 12);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "[Selected]";
            // 
            // lst_Frames
            // 
            this.lst_Frames.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lst_Frames.BackgroundImage")));
            this.lst_Frames.BackgroundImageTiled = true;
            this.lst_Frames.Location = new System.Drawing.Point(12, 394);
            this.lst_Frames.Name = "lst_Frames";
            this.lst_Frames.Size = new System.Drawing.Size(760, 97);
            this.lst_Frames.TabIndex = 6;
            this.lst_Frames.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(478, 365);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(75, 23);
            this.btn_Copy.TabIndex = 0;
            this.btn_Copy.TabStop = false;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(559, 365);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.TabStop = false;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "FPS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loops";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Search";
            // 
            // txt_FPS
            // 
            this.txt_FPS.Location = new System.Drawing.Point(12, 367);
            this.txt_FPS.Name = "txt_FPS";
            this.txt_FPS.Size = new System.Drawing.Size(100, 21);
            this.txt_FPS.TabIndex = 1;
            this.txt_FPS.TextChanged += new System.EventHandler(this.FormChanged);
            // 
            // txt_Loops
            // 
            this.txt_Loops.Location = new System.Drawing.Point(118, 367);
            this.txt_Loops.Name = "txt_Loops";
            this.txt_Loops.Size = new System.Drawing.Size(100, 21);
            this.txt_Loops.TabIndex = 2;
            this.txt_Loops.TextChanged += new System.EventHandler(this.FormChanged);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(72, 274);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(270, 21);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.TabStop = false;
            this.txt_Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // chk_ResetFrame
            // 
            this.chk_ResetFrame.AutoSize = true;
            this.chk_ResetFrame.Location = new System.Drawing.Point(224, 369);
            this.chk_ResetFrame.Name = "chk_ResetFrame";
            this.chk_ResetFrame.Size = new System.Drawing.Size(92, 16);
            this.chk_ResetFrame.TabIndex = 3;
            this.chk_ResetFrame.Text = "Reset frame";
            this.chk_ResetFrame.UseVisualStyleBackColor = true;
            this.chk_ResetFrame.CheckedChanged += new System.EventHandler(this.FormChanged);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(348, 158);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(88, 23);
            this.btn_Remove.TabIndex = 0;
            this.btn_Remove.TabStop = false;
            this.btn_Remove.Text = "<-Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(348, 129);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(88, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.TabStop = false;
            this.btn_Add.Text = "Add->";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 503);
            this.Controls.Add(this.chk_ResetFrame);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.txt_Loops);
            this.Controls.Add(this.txt_FPS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lst_Animations);
            this.Controls.Add(this.lst_Dirs);
            this.Controls.Add(this.lst_Frames);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_MoveRight);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.btn_MoveLeft);
            this.Controls.Add(this.btn_ExportAnimation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimationForm";
            this.Text = "Sprite Animation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Dirs;
        private System.Windows.Forms.ListBox lst_Animations;
        private System.Windows.Forms.Button btn_ExportAnimation;
        private System.Windows.Forms.Button btn_MoveLeft;
        private System.Windows.Forms.Button btn_MoveRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListView lst_Frames;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_FPS;
        private System.Windows.Forms.TextBox txt_Loops;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.CheckBox chk_ResetFrame;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
    }
}