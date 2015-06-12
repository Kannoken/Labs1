using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        Bitmap pic1, picorig;
        Bitmap cpy;
        Bitmap bmp1;
        int y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файл BMP|*.bmp";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pic1 = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                // = picorig;
                comboBox2.Enabled = true;
                pictureBox1.Image = pic1;
                bmp1 = new Bitmap(pictureBox1.Image);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0: cpy = pic1.Clone(new Rectangle(0, 0, pic1.Width, pic1.Height), PixelFormat.Format32bppArgb); break;
                case 1: cpy = pic1.Clone(new Rectangle(0, 0, pic1.Width, pic1.Height), PixelFormat.Format24bppRgb); break;
                case 2: cpy = pic1.Clone(new Rectangle(0, 0, pic1.Width, pic1.Height), PixelFormat.Format16bppArgb1555); break;
                case 3: cpy = pic1.Clone(new Rectangle(0, 0, pic1.Width, pic1.Height), PixelFormat.Format8bppIndexed); break;
                case 4: cpy = pic1.Clone(new Rectangle(0, 0, pic1.Width, pic1.Height), PixelFormat.Format4bppIndexed); break;
                case 5: cpy = pic1.Clone(new Rectangle(0, 0, pic1.Width, pic1.Height), PixelFormat.Format1bppIndexed); break;
            }
            pictureBox1.Image = cpy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = 0;
            int w0 = -1;
            int h0 = -1;
            int w1 = 2;
            int h1 = 2; 
            int h = bmp1.Height;
            int w = bmp1.Width;
            int Green = 0;
            int Blue = 0;
            int Red = 0; 
            for (int i = 0; i < w - 1; i++)
                for (int j = 0; j < h - 1; j++)
                {
                    if (bmp1.GetPixel(i, j) == Color.FromArgb(255, 0, 0, 0))
                    {
                        if (i == 0)
                        {
                            w0 = 0; 
                        }
                        if (j == 0)
                        {
                            h0 = 0; 
                        }
                        if (i == w-1)
                        {
                            w1 = 1; 
                        }
                        if (j == h-1)
                        {
                            h1 = 1; 
                        }
                        for (int n = w0; n < w1; n++)
                            for (int m = h0; m < h1; m++)
                            {
                                if ((i + n) != 0 && (j + m) != 0 && (bmp1.GetPixel(i + n, j + m) != Color.FromArgb(255, 0, 0, 0)))
                                {
                                    Red += bmp1.GetPixel(i + n, j + m).R;
                                    Green += bmp1.GetPixel(i + n, j + m).G;
                                    Blue += bmp1.GetPixel(i + n, j + m).B;
                                    k++;
                                }
                            }
                        w0 = -1;
                        h0 = -1;
                        w1 = 2;
                        h1 = 2; 
                        if (k != 0)
                        {
                            Red /= k;
                            Green /= k;
                            Blue /= k;
                            bmp1.SetPixel(i, j, Color.FromArgb(255, Red, Green, Blue));
                        }
                    }
                   k = Red = Green = Blue = 0; 
                }
            pictureBox1.Image = bmp1; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int h = pic1.Height;
            int w = pic1.Width;
            int x = h*w/100 * 30; 
            Random r = new Random();
            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                {
                    int n = r.Next(0, h*w);
                    if (n < x)
                        bmp1.SetPixel(i, j, Color.FromArgb(255, 0, 0, 0));
                }
                pictureBox1.Image = bmp1;
         }
        
    }
}
