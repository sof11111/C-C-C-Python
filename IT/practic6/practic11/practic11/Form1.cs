using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic11
{
  public partial class Form1 : Form
  {    
    private Point PreviousPoint, point;
    private Bitmap bmp;
    private Pen blackPen;
    private Graphics g;
    public Form1()
    {
      InitializeComponent();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {      
      OpenFileDialog dialog = new OpenFileDialog(); 
                                                    
      dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";

      if (dialog.ShowDialog() == DialogResult.OK)
      {
        Image image = Image.FromFile(dialog.FileName); 
        int width = image.Width;
        int height = image.Height;
        pictureBox1.Width = width;
        pictureBox1.Height = height;


        bmp = new Bitmap(image, width, height); 

        pictureBox1.Image = bmp;
        g = Graphics.FromImage(pictureBox1.Image);

      }
    }

    private void button2_Click(object sender, EventArgs e)
    {      
      SaveFileDialog savedialog = new SaveFileDialog();
                                                       
      savedialog.Title = "Сохранить картинку как ...";
      savedialog.OverwritePrompt = true;
      savedialog.CheckPathExists = true;
      savedialog.Filter =
      "Bitmap File(*.bmp)|*.bmp|" +
      "GIF File(*.gif)|*.gif|" +
      "JPEG File(*.jpg)|*.jpg|" +
      "TIF File(*.tif)|*.tif|" +
      "PNG File(*.png)|*.png";
      savedialog.ShowHelp = true;
      
      if (savedialog.ShowDialog() == DialogResult.OK)
      {        
        string fileName = savedialog.FileName;
        
        string strFilExtn =
        fileName.Remove(0, fileName.Length - 3);
        
        switch (strFilExtn)
        {
          case "bmp":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
            break;
          case "jpg":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            break;
          case "gif":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
            break;
          case "tif":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
            break;
          case "png":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
            break;
          default:
            break;
        }
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      
      for (int i = 0; i < bmp.Width; i++)
        for (int j = 0; j < bmp.Height; j++)
        {
          int R = bmp.GetPixel(i, j).R; 
          int G = bmp.GetPixel(i, j).G;
          int B = bmp.GetPixel(i, j).B;
          int Gray = (R = G + B) / 3; 
          Color p = Color.FromArgb(255, Gray, Gray, Gray);
          bmp.SetPixel(i, j, p);
        }
      Refresh(); 
    }

    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {      
      PreviousPoint.X = e.X;
      PreviousPoint.Y = e.Y;
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      {        
        if (e.Button == MouseButtons.Left)
        { 
          point.X = e.X;
          point.Y = e.Y;
          
          g.DrawLine(blackPen, PreviousPoint, point);
          
          PreviousPoint.X = point.X;
          PreviousPoint.Y = point.Y;
          pictureBox1.Invalidate();
        }
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      blackPen = new Pen(Color.Black, 4);
    }
  }    
}
