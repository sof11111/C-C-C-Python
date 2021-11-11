using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      textBox1.Text = "2";
      
      textBox2.Text = "Практическая работа";
      textBox2.Text += Environment.NewLine + "Рассчитать значение выражения";
    }
    private void button1_Click(object sender, EventArgs e)
    {
      // Считывание значения X
      double x = double.Parse(textBox1.Text);

      // Вывод значения X в окно
      textBox2.Text += Environment.NewLine + "При x = " + x.ToString();

      // Вычисляем арифметическое выражение      
      double y = ((Math.Sqrt(1 + Math.Exp(Math.Sqrt(x)) + Math.Cos(Math.Pow(x, 2)))) / (Math.Abs(1 - Math.Pow(Math.Sin(x), 3)))) + Math.Log(2 * x);

      // Выводим результат в окно
      textBox2.Text += Environment.NewLine + "Результат y = " + y.ToString();
    } 
  }
}
