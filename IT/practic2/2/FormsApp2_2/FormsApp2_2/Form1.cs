using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp2_2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      textBox1.Text = "1";
      textBox2.Text = "Результат работы программы";
      textBox2.Text += Environment.NewLine + "Рассчитать значение выражения";
    }

    public double y(double n)
    {
       
    }

    public double s(double y)
    {
      double res;
      res = y;
      return res;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
  }
}
