using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фрактал
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        Button btn1 = new Button();
        TextBox Textl = new TextBox();
        TextBox Texts = new TextBox();
        TextBox Textp = new TextBox();
        Label lbll = new Label();
        Label lbls = new Label();
        Label lblp = new Label(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            lbll.Top = 25;
            lbll.Left = 50;
            lbll.Text = "Высота ствола";
            lbll.Width = 100; 
            this.Controls.Add(lbll);
            

            this.Controls.Add(Textl);
            Textl.Top = 50;
            Textl.Left = 50;
            Textl.Text = "100";

            this.Controls.Add(lbls);
            lbls.Width = 150;
            lbls.Top = 75;
            lbls.Left = 50;
            lbls.Text = "Соотношение веток";

            this.Controls.Add(Texts);
            Texts.Top = 100;
            Texts.Left = 50;
            Texts.Text = "70";

            this.Controls.Add(lblp);
            lblp.Top = 125;
            lblp.Left = 50;
            lblp.Text = "Угол наклона ветви";

            this.Controls.Add(Textp);
            Textp.Top = 150;
            Textp.Left = 50;
            Textp.Text = "70";

            this.Controls.Add(btn1);
            btn1.Text = "Построить дерево с заданными параметрами";
            btn1.Top = 200;
            btn1.Left = 25;
            btn1.Height = 50;
            btn1.Width = 150;

            pic.Size = this.Size;
            bmp = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bmp);
            pic.Image = bmp;

            btn1.Click += btn1_Click;
        }
        int x, y, l, s;
        double p;
        PictureBox pic = new PictureBox();
        Bitmap bmp;
        Graphics g;
        Pen MyPen = new Pen(Color.Black);
        Point x1y1 = new Point();
        Point x2y2 = new Point(); 
        void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                g.Clear(this.BackColor);
                pic.Image = bmp;
                x = this.Width / 2 + 50;
                y = this.Height - 50;
                l = Convert.ToInt32(Textl.Text);
                s = Convert.ToInt32(Texts.Text);
                p = Convert.ToDouble(Textp.Text) * Math.PI / 180;
                FracTree(x, y, Math.PI / 2, p, l, s);
            //    Form1.BackColor = Color.Black;
                this.Controls.Add(pic); 
            }
            catch (System.StackOverflowException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
         }
        public void FracTree(int x, int y, double a, double p, int l, int s)
        {
            if (l < 10)
                return; 
            else
            {
                if (l < 25)
                    MyPen.Color = Color.Pink;
                else
                    MyPen.Color = Color.Maroon;
                
                Point XY = new Point(x, y);
                MyPen.Width = l / 8;
                l = l * s / 100; 
                int x1 =  (int)(x +l * Math.Cos(a));
                int y1 =  (int)(y -l * Math.Sin(a));
                x1y1.X = x1;
                x1y1.Y = y1;
                int x2 = x + (int)(l / 2 * Math.Cos(a));
                int y2 = y - (int)(l / 2 * Math.Sin(a));
                x2y2.X = x2;
                x2y2.Y = y2;
                
                g.DrawLine(MyPen, XY, x1y1);

                FracTree(x1, y1, a - p, p, l, s);
                FracTree(x1, y1, a + p, p, l, s);
          //      FracTree(x2, y2, a - p, p, l, s);
        //        FracTree(x2, y2, a + p, p, l, s);
            }
         }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }
      }
      
}
