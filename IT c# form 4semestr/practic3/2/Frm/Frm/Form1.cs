using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//практика6
namespace Frm
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    //static int n = 15;
    int[] Mas = new int[15];

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
      textBox1.Text = "";
      for (int i = 0; i < Mas.Length; i++)
      {
        Mas[i] = rand.Next(-50, 50);

        textBox1.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;
      }
    }

    
    private void button2_Click_1(object sender, EventArgs e)
    {
      textBox2.Text = "";

      long counter = 1;
      for (int i = 0; i < Mas.Length; i++)
      {
        if (i % 2 == 0) //0 считается четным 
          counter *= Mas[i];
      }
      textBox2.Text = counter + "";
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

   
  }
}
