using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp2_2 //практика4
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


    

      //факториал
      public static long Fact(long n)
      {
        if (n == 0)
          return 1;
        else
          return n * Fact(n - 1);      
      }

      public double y(long n)
      {
        return y = (n + 1) / (2 * Fact(n));
      }
    

      //сумма ряда
      public double s()
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
        if (textBox1.Text != "")
        {
          double x = double.Parse(textBox1.Text);
          textBox2.Text += Environment.NewLine + "При x = " + x.ToString();        
        }
        else
          MessageBox.Show("Введите значение x");
      }

      private void radioButton_sh(object sender, EventArgs e)
      {

      }
      private void Form1_Load_1(object sender, EventArgs e)
      {

      }
    
   }
}
