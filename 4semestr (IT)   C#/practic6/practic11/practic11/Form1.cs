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
    private Pen curonpen;
    private Graphics g;
    public Form1()
    {
      InitializeComponent();
    }
    Color penColor;
    int penWidth;

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {      
      OpenFileDialog dialog = new OpenFileDialog();
      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

      dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";

      if (dialog.ShowDialog() == DialogResult.OK)
      {
        Image image = Image.FromFile(dialog.FileName);
        
        bmp = new Bitmap(image, pictureBox1.Width, pictureBox1.Height); 

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
          penColor = Color.FromArgb(255, Gray, Gray, Gray);
          bmp.SetPixel(i, j, penColor);
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
        if (e.Button == MouseButtons.Left)
        { 
          point.X = e.X;
          point.Y = e.Y;
          
          g.DrawLine(curonpen, PreviousPoint, point);
          
          PreviousPoint.X = point.X;
          PreviousPoint.Y = point.Y;
          pictureBox1.Invalidate();
        }     
    }

    private void button_Color_Click(object sender, EventArgs e)
    {
      if (colorDialog1.ShowDialog() == DialogResult.OK)
      {
        curonpen.Color = colorDialog1.Color;
        button_Color.BackColor = colorDialog1.Color;
      }
    }

    private void trackBar_penWidth_Scroll(object sender, EventArgs e)
    {
      penWidth = trackBar_penWidth.Value;
      curonpen.Width = penWidth;
      label_curValue.Text = trackBar_penWidth.Value + "";
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      curonpen = new Pen(Color.Black, 4);
      label_0.Text = trackBar_penWidth.Minimum + "";
      label_50.Text = trackBar_penWidth.Maximum + "";
      trackBar_penWidth.Value = 4;
      label_curValue.Text = trackBar_penWidth.Value + "";
    }
  }    
}
