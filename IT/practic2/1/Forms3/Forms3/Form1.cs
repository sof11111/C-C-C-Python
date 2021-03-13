using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }


    //ввод x, y, z
    private void Form1_Load(object sender, EventArgs e)
    {
      textBox1.Text = "1";
      textBox2.Text = "2";
      textBox3.Text = "3";
      textBox4.Text = "Результат работы программы";
      textBox4.Text += Environment.NewLine + "Рассчитать значение выражения";
    }


    //текст
    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }


    //кнопка расчета вывода
    private void button1_Click(object sender, EventArgs e)
    {
            
      double x = double.Parse(textBox1.Text);
      double y = double.Parse(textBox2.Text);
      double z = double.Parse(textBox3.Text);

      
      textBox4.Text += Environment.NewLine + "При x = " + x.ToString();
      textBox4.Text += Environment.NewLine + "При y = " + y.ToString();
      textBox4.Text += Environment.NewLine + "При z = " + z.ToString();

      // Вычисляем арифметическое выражение

      //double y = Math.Pow(x, 2);
      if (x > 10) y = 1;
      if ((x >= 0) && (x <= 10)) y = 2 * z - 1;
      if (x < 0) y = Math.Abs(1 - (3*z));

      //double a = 1, b = 2, c = 3;
      
      //double D = Math.Pow(b, 2) - 4 * a * c;
      //int roots = -1;

      /*if (Math.Abs(D) < 1e-10)
      {
        roots = 1;
      }
      else
      {
        if (D > 0) roots = 2;
        if (D < 0) roots = 0;
      }*/
      
      /*switch (roots)
      {
        case 1:
          Console.WriteLine("case");
          break;
        case 2:
          Console.WriteLine("case");
          //x = -b / (2 * a);
          Console.WriteLine(x);
          break;
        default:
          Console.WriteLine("Default case");
          break;
      }*/


      //Выводимрезультатвокно
      textBox4.Text += Environment.NewLine + "Результат y = " + y.ToString();

    }
    

    //кнопки sh ch exp 
    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
      double z = double.Parse(textBox3.Text);
      double x = double.Parse(textBox1.Text);
      double y = double.Parse(textBox2.Text);
      if (radioButton1.Checked)
      {
        z = Math.Pow(x, 2);
      }
      textBox4.Text += Environment.NewLine + "Результат y = " + y.ToString();
      //z = Math.Pow(x, 2);
    }


    //окно для вывода текста 
    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }


    //окно для кнопок sh ch exp
    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

  }
}
