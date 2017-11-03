using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingSystem
{
    public partial class TrainingSystem : Form
    {
        public string flag = "Offline";
        private Point? _Previous = null;

        public TrainingSystem()
        {
            InitializeComponent();
        }

        private void btnOffline_Click(object sender, EventArgs e)
        {
            picBefore.Image = null;
            flag = "Offline";
            lblOffline.Visible = true;
            lblOnline.Visible = false;
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {
            picBefore.Image = null;
            flag = "Online";
            lblOnline.Visible = true;
            lblOffline.Visible = false;
        }

        private void picBefore_Click(object sender, EventArgs e)
        {
            if(flag == "Offline")
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Open Image";
                    dlg.Filter = "png files (*.png)|*.png";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        picBefore.Image = Image.FromFile(dlg.FileName);
                    }
                }
            }
        }

        private void picBefore_MouseDown(object sender, MouseEventArgs e)
        {
            if(flag == "Online")
            {
                _Previous = e.Location;
                picBefore_MouseMove(sender, e);
            }
        }

        private void picBefore_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag == "Online")
            {
                if (_Previous != null)
                {
                    if (picBefore.Image == null)
                    {
                        Bitmap bmp = new Bitmap(picBefore.Width, picBefore.Height);
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            g.Clear(Color.White);
                        }
                        picBefore.Image = bmp;
                    }
                    using (Graphics g = Graphics.FromImage(picBefore.Image))
                    {
                        g.DrawLine(Pens.Black, _Previous.Value, e.Location);
                    }
                    picBefore.Invalidate();
                    _Previous = e.Location;
                }
            }           
        }

        private void picBefore_MouseUp(object sender, MouseEventArgs e)
        {
            if(flag == "Online")
            {
                _Previous = null;
                SaveFileDialog dlg = new SaveFileDialog();

                dlg.Title = "Save Image";
                dlg.Filter = "png files (*.png)|*.png";

                if (dlg.ShowDialog(this) == DialogResult.OK && dlg.FileName.Substring(dlg.FileName.Length - 3) == "png")
                {
                    picBefore.Image.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Saved.", "Training System");
                }
                else
                {
                    MessageBox.Show("Not saved.", "Training System");
                }
            }
        }
    }
}
