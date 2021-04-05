using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace practic8 //primer
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
      ///<summary>
      /// Левая граница графика
      ///</summary>
      private double XMin = -Math.PI;

      ///<summary>
      /// Правая граница графика
      ///</summary>
      private double XMax = Math.PI;

      ///<summary>
      ///Шагграфика
      ///</summary>
      private double Step = (Math.PI * 2) / 10;

      // Массив значений X - общий для обоих графиков
      private double[] x;

      // Два массива Y - по одному для каждого графика
      private double[] y1;
      private double[] y2;

      Chart chart;
      ///<summary>
      /// Расчёт значений графика
      ///</summary>
      private void CalcFunction()
      {
        // Количество точек графика
        int count = (int)Math.Ceiling((XMax - XMin) / Step)
        + 1;
        // Создаём массивы нужных размеров
        x = new double[count];
        y1 = new double[count];
        y2 = new double[count];
        // Расчитываем точки для графиков функции
        for (int i = 0; i < count; i++)
        {
          // Вычисляем значение X
          x[i] = XMin + Step * i;
          // Вычисляем значение функций в точке X
          y1[i] = Math.Sin(x[i]);
          y2[i] = Math.Cos(x[i]);
        }
      }
      ///<summary>
      /// Создаём элемент управления Chart и настраиваем его
      ///</summary>
      private void CreateChart()
      {
        // Создаёмновыйэлементуправления Chart
        chart = new Chart();
        // Помещаем его на форму
        chart.Parent = this;
        // Задаём размеры элемента
        chart.SetBounds(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);

        // Создаём новую область для построения графика
        ChartArea area = new ChartArea();
        // Даём ей имя (чтобы потом добавлять графики)
        area.Name = "myGraph";
        // Задаём левую и правую границы оси X
        area.AxisX.Minimum = XMin;
        area.AxisX.Maximum = XMax;
        // Определяемшагсетки
        area.AxisX.MajorGrid.Interval = Step;
        // Добавляем область в диаграмму
        chart.ChartAreas.Add(area);

        // Создаём объект для первого графика
        Series series1 = new Series();
        // Ссылаемся на область для построения графика
        series1.ChartArea = "myGraph";
        // Задаём тип графика - сплайны
        series1.ChartType = SeriesChartType.Spline;
        // Указываем ширину линии графика
        series1.BorderWidth = 3;
        // Название графика для отображения в легенде
        series1.LegendText = "sin(x)";
        // Добавляем в список графиков диаграммы
        chart.Series.Add(series1);
        // Аналогичные действия для второго графика
        Series series2 = new Series();
        series2.ChartArea = "myGraph";
        series2.ChartType = SeriesChartType.Spline;
        series2.BorderWidth = 3;
        series2.LegendText = "cos(x)";
        chart.Series.Add(series2);

        // Создаёмлегенду, котораябудетпоказыватьназвания
        Legend legend = new Legend();
        chart.Legends.Add(legend);
      }
      private void Form1_Load(object sender, EventArgs e)
      {
        // Создаём элемент управления
        CreateChart();

        // Расчитываем значения точек графиков функций
        CalcFunction();

        // Добавляем вычисленные значения в графики
        chart.Series[0].Points.DataBindXY(x, y1);
        chart.Series[1].Points.DataBindXY(x, y2);
      }


   
    }
}
