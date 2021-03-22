using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms3//практика3
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
      textBox_x.Text = "1";      
      textBox4.Text = "Результат работы программы";
      textBox4.Text += Environment.NewLine + "Рассчитать значение выражения";
    }


    //текст
    private void label1_Click(object sender, EventArgs e)
    {

    }
    

    public double f(double x, int choise)
    {
      if (choise == 0) //когда выбрали sh
        return Math.Sinh(x);
      else
        if (choise == 1)
        return Math.Cosh(x);
      else
        //if (choise == 2)
        return Math.Exp(x);
    }
    public double y(double x, int choise)
    {
      if (x > 10)
        return 1;
      else
        if (x >= 0 && x <= 10)
        return 2 * f(x, choise) - 1;
      else
        //if (x < 0)
        return Math.Abs(1 - 3 * f(x, choise));
    }

    //кнопка расчета вывода
    private void button1_Click(object sender, EventArgs e)
    {
      if (textBox_x.Text != "")
      {
        double x = double.Parse(textBox_x.Text);
        textBox4.Text += Environment.NewLine + "При x = " + x.ToString();        

        // Вычисляем арифметическое выражение
        if (radioButton_sh.Checked) //choise = 0 
          textBox4.Text += Environment.NewLine + "Результат Fx = sh(x) = " + f(x, 0) + ", y = " + y(x, 0).ToString();
        else
          if (radioButton_ch.Checked)
          textBox4.Text += Environment.NewLine + "Результат Fx = ch(x) = " + f(x, 1) + ", y = " + y(x, 1).ToString();
        else
          if (radioButton_exp.Checked)
          textBox4.Text += Environment.NewLine + "Результат Fx = exp(x) = " + f(x, 2) + ", y = " + y(x, 2).ToString();
        else
          MessageBox.Show("Выберите функцию");
      }
      else
        MessageBox.Show("Введите значение x");  
    }
    

    //окно для вывода текста 
    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }


    //окно для кнопок sh ch exp
    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    //кнопка выбора
    private void radioButton_sh_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void radioButton_ch_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void radioButton_exp_CheckedChanged(object sender, EventArgs e)
    {

    }

  }
}
