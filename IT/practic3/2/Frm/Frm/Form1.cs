using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    int[] Mas = new int[15];

    private void button1_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
      textBox1.Text = "";
      for (int i = 0; i < 15; i++)
      {
        Mas[i] = rand.Next(-50, 50);


        textBox1.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      textBox2.Text = "";

      int n = 0, m = 0;
      for (int i = 0; i < 15; i++)
      {
        
        if (Mas[i] == 0)        
          n++;       
          
        if (Mas[i] < 0)        
          m++;




        //textBox2.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;
        //textBox2.Text += "Mas[" + Convert.ToString(i) + "] = " + Environment.NewLine;
        textBox2.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;
      }
      

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
