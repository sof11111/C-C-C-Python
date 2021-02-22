using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormsApp3
{
  public partial class Form1 : Form
  {
    List<Button> buttons;
    List<Label> labels;
    public Form1()
    {
      InitializeComponent();
      labels = new List<Label>();
      buttons = new List<Button>();
      buttons.AddRange(new Button[4] { button1, button2, button3, button4 });
      labels.AddRange(new Label[4] { label1, label2, label3, label4 });
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      button1.Click += label1_Click;
      button1.Click += label1_Click;
      button1.Click += label1_Click;
      button1.Click += label1_Click;
    }

    void label1_Click(object sender, EventArgs e)
    {
      Random rnd = new Random(DateTime.Now.Millisecond);
      Button btn = buttons[rnd.Next(labels.Count)];
      btn.Visible = !btn.Visible;
    }

    
  }
}