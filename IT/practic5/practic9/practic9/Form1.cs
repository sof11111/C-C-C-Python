using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic9
{
  public partial class Form1 : Form
  {  

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;

      //линия
      Pen pen = new Pen(Color.Black, 2);
      Point[] points ={new Point(20,  10),new Point(10, 100)};
      g.DrawLines(pen, points);

      //цвет
      Pen p = new Pen(Color.Red, 5);

      //эллипс
      g.DrawEllipse(p, 50, 50, 200, 200);
      //g.Dispose();

      //квадрат
      g.DrawRectangle(p, 50, 50, 200, 200);
      //g.Dispose();

      //многоугольник
      Point point1 = new Point(50, 50);
      Point point2 = new Point(100, 25);
      Point point3 = new Point(200, 5);
      Point point4 = new Point(250, 50);
      Point point5 = new Point(300, 100);
      Point[] curvePoints = {point1,point2, point3,point4,point5};
      g.DrawPolygon(p, curvePoints);

      //закрашенный квадрат
      SolidBrush blueBrush = new SolidBrush(Color.Green);
      Rectangle rect = new Rectangle(300, 1, 100, 100);
      g.FillRectangle(blueBrush, rect);

      
    }

    


    private void Form1_Load_1(object sender, EventArgs e)
    {
      
    }


  }
}