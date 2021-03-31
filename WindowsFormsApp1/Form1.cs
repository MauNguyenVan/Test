using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//#nullable enable

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool IsSelected;
      Graphics Graphic { get; set; }
        Rectangle rec;
        SolidBrush brush = new SolidBrush(Color.Red);
        // The original image.
        // private Bitmap OriginalImage;

        // True when we're selecting a rectangle.
        private bool IsSelecting = false;
        bool isIn = false;
        // The area we are selecting.
        private int X0, Y0, X1, Y1;
        public Form1()
        {
            InitializeComponent();
            
            Graphic = pictureBox1.CreateGraphics();
            Graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

      

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
             rec = new Rectangle(100, 100, 200, 300);
            Graphic.FillRectangle(brush, rec);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Invalidate();
        }
        // Start selecting the rectangle.
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsSelecting = true;

            // Save the start point.
            X0 = e.X;
            Y0 = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private static bool  PointInToRec(Point p , Rectangle rec)
        {
            bool isIn = false;

            int maxL = rec.Width > rec.Height ? rec.Width : rec.Height;
            Point minRec = new Point(rec.Left, rec.Top);
            Point maxRec = new Point(rec.Right, rec.Bottom);
            if(p.X>minRec.X && p.X < maxRec.X&& p.Y > minRec.Y && p.Y < maxRec.Y)
            {
                isIn = true;
              

            }


            return isIn;
        }
        // Continue selecting.
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            // Do nothing it we're not selecting an area.
            if (!IsSelecting  )
            {
                var b = PointInToRec(e.Location, rec);
                this.Text = b.ToString();
                if (b == isIn)
                {
                    isIn = true;
                    brush.Color = Color.Green;
                    pictureBox1.Refresh();
                }
                //else isIn = false;
               
               

            }

            // Save the new point.
            X1 = e.X;
            Y1 = e.Y;

        }
        // Finish selecting the area.
        private void picOriginal_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
