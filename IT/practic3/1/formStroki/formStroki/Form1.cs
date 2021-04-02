using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formStroki //практика5
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }


    private void button1_Click(object sender, EventArgs e)
    {
      // Получаем номер выделенной строки
      int index = listBox1.SelectedIndex;
      // Считываем строку в перменную str
      string str = (string)listBox1.Items[index];
      // Узнаем количество символов в строке
      int len = str.Length;
      // Считаем, что количество а равно 0
      int count = 0;
      // Устанавливаем счетчик символов в 0
      int i = 0;
      //Организуем цикл перебора всех символов в строке
      while (i < len - 1)
      {
        // Если нашли букву, то увеличиваем счетчик на 1
        if (str[i] == 'а')
          count++;
        i++;
        
      }
       
      
        if(count > 0)
          label1.Text = "Количество буквы а = " + count.ToString();
        else
          label1.Text = "Строка без а";       

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

  }
}
