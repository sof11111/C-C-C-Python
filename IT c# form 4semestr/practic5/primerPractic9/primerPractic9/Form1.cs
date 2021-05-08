using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerPractic9
{  
  public partial class proramma :Form
  {
        Point[] points = new Point[50];
        Pen pen = new Pen(Color.Black, 2);

        public proramma()
        {
          InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          Graphics g = e.Graphics;
          g.DrawLines(pen, points);
        }    

        private void Form1_Load_1(object sender, EventArgs e)
        {
          for (int i = 0; i < 20; i++)
          {
            int xPos;
            if (i % 2 == 0)
            {
              xPos = 10;
            }
            else
            {
              xPos = 400;
            }
            points[i] = new Point(xPos, 10 * i);
          }
        }
  }


}
