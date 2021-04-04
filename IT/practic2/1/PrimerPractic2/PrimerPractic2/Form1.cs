using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerPractic2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load_1(object sender, EventArgs e)
    {
      textBox1.Text = "2";
      // Вывод строки в многострочный редактор
      textBox2.Text = "Практическая работа №1 Иванов И.И.";
      textBox2.Text += Environment.NewLine + "Рассчитать значение выражения y=x^2";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // Считывание значения X
      double x = double.Parse(textBox1.Text);

      // Вывод значения X в окно
      textBox2.Text += Environment.NewLine + "При x = " + x.ToString();

      // Вычисляем арифметическое выражение
      double y = Math.Pow(x, 2);

      // Выводим результат в окно
      textBox2.Text += Environment.NewLine + "Результат y = " + y.ToString();
    }    
  }
}
