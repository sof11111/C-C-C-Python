using System;
using System.Drawing;


namespace zadanie1
{
    private void Form(object sender, EventArgs e)
    {
      Random random = new Random();
      this.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
    }
    private void Form1_Click(object sender, EventArgs e)
    {
      Random random = new Random();
      this.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
      label1.Text = "Начало работы";
      textBox1.Text = "";
    }


  }
}
