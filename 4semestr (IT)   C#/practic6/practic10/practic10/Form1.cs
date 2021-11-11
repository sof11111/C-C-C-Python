using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practic10
{
  public partial class Form1 : Form
  {    
    private int changesize;    

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (changesize == 0 || changesize == -15)
      {
        changesize = 15;
      }
      else
      {
        changesize = 0;
      }
      this.Invalidate();
    }

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      
      int xc = this.Width / 2;
      int yc = this.Height / 2;
      g.TranslateTransform(xc, yc);
      
      float q = 0.5f;
      float scale_x = Width / 4 + changesize;
      float scale_y = Height / 4 + changesize;
      List<PointF> points = new List<PointF>(360);
      for (int t = 0; t < 360; t++)
      {
        double angle = Math.PI * t / 180;
        float y = (float)(Math.Sin(angle) + Math.Pow(Math.Abs(Math.Cos(angle)), q));
        float x = (float)Math.Cos(angle);
        points.Add(new PointF(x * scale_x, -y * scale_y));
      }
              
      e.Graphics.FillPolygon(new SolidBrush(Color.Red), points.ToArray());      
    }

    private void Form1_Load(object sender, EventArgs e)
    {      
      changesize = 0;
      
      timer1.Start();
    }    
  }
}

