using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic7
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    int rows = 15;
    int cols = 15;
    int[,] arr;
    int i_min = 0, i_max = 0;
    int j_max = 0, j_min = 0;
    int min = 0;
    int max = 0;
    private void Form1_Load(object sender, EventArgs e)
    {
      arr = new int[rows, cols];      
      dataGridView1.RowCount = rows;
      dataGridView1.ColumnCount = cols;
      for (int i = 0; i < cols; i++)
        dataGridView1.Columns[i].Width = 50;      
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          arr[i, j] = rand.Next(-100, 100);
          dataGridView1.Rows[i].Cells[j].Value = arr[i, j] + "";
        }
      }
      min = arr[0, 0];
      max = arr[0, 0];
      
      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          if (min > arr[i, j])
          {
            min = arr[i, j];
            i_min = i;
            j_min = j;
          }
            
          if (max < arr[i, j])
          {
            max = arr[i, j];
            i_max = i;
            j_max = j;
          }            
        }
      }

      textBox2.Text = "min = " + min + ", max = " + max; 
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      dataGridView1.Rows[i_min].Cells[j_min].Value = max + "";
      dataGridView1.Rows[i_max].Cells[j_max].Value = min + "";
      arr[i_min, j_min] = max;
      arr[i_max, j_max] = min;
    }
  }
}
