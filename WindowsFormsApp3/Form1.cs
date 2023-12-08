using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int XSIZE = 512;
        int YSIZE = 512;
        byte[,] inImage;

        Bitmap bmp;

        void LoadImage(string fname)
        {
            BinaryReader fp = new BinaryReader(File.Open(fname, FileMode.Open));
            inImage = new byte[XSIZE, YSIZE];

            for(int i = 0; i < XSIZE; i++)
            {
                for(int k = 0; k < YSIZE; k++)
                {
                    inImage[i, k] = fp.ReadByte();
                }
            }
            fp.Close();
        }

        void DisplayImage()
        {
            for (int i = 0; i < XSIZE; i++)
            {
                for (int k = 0; k < YSIZE; k++)
                {
                    Byte data = inImage[k, i];
                    Color c = Color.FromArgb(data, data, data);
                    bmp.SetPixel(i, k, c);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(XSIZE, YSIZE);
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Size = new System.Drawing.Size(XSIZE, YSIZE);

            bmp = new Bitmap(XSIZE, YSIZE);
            string fileName = "C:\\Users\\kji99\\Documents\\컴퓨터시스템과\\2023년도\\C#응용\\20231027\\Project2-k\\photo\\lena.raw";
            LoadImage(fileName);
            DisplayImage();
            pictureBox1.Image = bmp;
        }
    }
}
