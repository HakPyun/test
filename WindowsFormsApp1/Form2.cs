using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void 이미지열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory =@"C:\";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image_file = openFileDialog1.FileName;
            }
            pictureBox1.Image = Bitmap.FromFile(image_file);
        }

        private void 이미지저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
