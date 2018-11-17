using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AssetPacker
{
    public partial class SpriteForm : Form
    {
        public Model.Atlas Atlas { get; set; }
        public Model.Sprite SelectedSprite { get; set; }
        public float ZoomFactor { get; set; }

        private int anchorSize = 4;

        public SpriteForm()
        {
            InitializeComponent();
            SelectedSprite = null;
            ZoomFactor = 1.0f;
        }

        public void UpdateList()
        {
            if (Atlas == null)
                return;

            listView.Items.Clear();
            foreach (Model.Sprite sprite in Atlas.Sprites)
            {
                listView.Items.Add(sprite.ImageName);
            }
            SelectedSprite = null;
        }

        public void PaintSprite()
        {
            Bitmap img = new Bitmap(panelSprite.Width, panelSprite.Height);

            using (Graphics gr = Graphics.FromImage(img))
            {
                gr.ScaleTransform(ZoomFactor, ZoomFactor);
                gr.DrawImage(SelectedSprite.Image,
                    panelSprite.Width / (2 * (int)ZoomFactor) - SelectedSprite.Image.Width / 2,
                    panelSprite.Height / (2 * (int)ZoomFactor) - SelectedSprite.Image.Height / 2);

                gr.DrawRectangle(
                    new Pen(Color.DeepPink, 2.0f),
                    new Rectangle(
                        panelSprite.Width / (2 * (int)ZoomFactor) - (anchorSize / 2) + (SelectedSprite.Offset.X),
                        panelSprite.Height / (2 * (int)ZoomFactor) - (anchorSize / 2) + (SelectedSprite.Offset.Y),
                        anchorSize, anchorSize));
            }

            pictureBox.Image = img;
            pictureBox.Width = img.Width;
            pictureBox.Height = img.Height;
        }

        private void ListIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedIndices.Count == 0)
                return;

            SelectedSprite = null;
            int index = listView.SelectedIndices[0];
            numOffsetX.Value = Atlas.Sprites[index].Offset.X;
            numOffsetY.Value = Atlas.Sprites[index].Offset.Y;
            SelectedSprite = Atlas.Sprites[index];
            pictureBox.Location = new Point(0, 0);

            PaintSprite();
        }

        private bool isMouseDown = false;
        private Point mouseDownLocation;
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseDownLocation = e.Location;

            if (SelectedSprite != null)
            {
                // TODO: offset move
                //Rectangle rect = new Rectangle(
                //        panelSprite.Width / (2 * (int)zoomFactor) - (anchorSize / 2) + (selectedSprite.OffsetX),
                //        panelSprite.Height / (2 * (int)zoomFactor) - (anchorSize / 2) + (selectedSprite.OffsetY),
                //        anchorSize, anchorSize);
                //rect.Contains(e.Location);
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouseDown)
                return;
            
            var x = pictureBox.Location.X - (mouseDownLocation.X - e.Location.X);
            var y = pictureBox.Location.Y - (mouseDownLocation.Y - e.Location.Y);
            pictureBox.Location = new Point(x, y);
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            PaintSprite();
        }

        private void Offset_Changed(object sender, EventArgs e)
        {
            if (SelectedSprite != null)
            {
                foreach (int index in listView.SelectedIndices)
                {
                    Atlas.Sprites[index].Offset.X = Decimal.ToInt16(numOffsetX.Value);
                    Atlas.Sprites[index].Offset.Y = Decimal.ToInt16(numOffsetY.Value);
                }

                PaintSprite();
            }
        }

        private void Zoom_ButtonClick(object sender, EventArgs e)
        {
            if (ZoomFactor < 2.0f)
            {
                ZoomFactor = 2.0f;
            }
            else if (ZoomFactor < 4.0f)
            {
                ZoomFactor = 4.0f;
            }
            else if (ZoomFactor < 8.0f)
            {
                ZoomFactor = 8.0f;
            }
            else
            {
                ZoomFactor = 1.0f;
            }
            toolStripZoomLabel.Text = string.Format("{0}%", (int)ZoomFactor * 100);
            PaintSprite();
        }

        private void ZoomTool_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripItem tool)
            {
                ZoomFactor = int.Parse(tool.Name.Split('_')[1]);
                toolStripZoomLabel.Text = string.Format("{0}%", (int)ZoomFactor * 100);
                PaintSprite();
            }
        }
    }
}
