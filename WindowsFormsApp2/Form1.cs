using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 이미지열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image_file = openFileDialog1.FileName;
            }
            pictureBox1.Image = Bitmap.FromFile(image_file);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void 이미지저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string save_route = @"C:\TestImageFolder";

            if(!System.IO.Directory.Exists(save_route))
            {
                System.IO.Directory.CreateDirectory(save_route);

                pictureBox1.Image.Save(save_route + "\\test_image.png", System.Drawing.Imaging.ImageFormat.Png);
            }

        }
    }
}
