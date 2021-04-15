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

namespace practic8
{
  public partial class График : Form
  {
    public График()
    {
      InitializeComponent();
    }

    private double XMin = -Math.PI;
    private double XMax = Math.PI;
    private double Step = (Math.PI * 2) / 10;
    private double[] x;
    private double[] y1;
    private double[] y2;
    Chart chart;

    private void CalcFunction()
    {      
      int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;
      
      x = new double[count];
      y1 = new double[count];
      y2 = new double[count];
      
      for (int i = 0; i < count; i++)
      {        
        x[i] = XMin + Step * i;        
        y1[i] = Math.Sin(x[i]);
        y2[i] = Math.Cos(x[i]);
      }
    }

    private void CreateChart()
    {
      
      chart = new Chart();      
      chart.Parent = this;      
      chart.SetBounds(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);

      
      ChartArea area = new ChartArea();      
      area.Name = "myGraph";     
      area.AxisX.Minimum = XMin;
      area.AxisX.Maximum = XMax;      
      area.AxisX.MajorGrid.Interval = Step;      
      chart.ChartAreas.Add(area);

     
      Series series1 = new Series();      
      series1.ChartArea = "myGraph";      
      series1.ChartType = SeriesChartType.Spline;      
      series1.BorderWidth = 3;      
      series1.LegendText = "sin(x)";      
      chart.Series.Add(series1);      
      Series series2 = new Series();
      series2.ChartArea = "myGraph";
      series2.ChartType = SeriesChartType.Spline;
      series2.BorderWidth = 3;
      series2.LegendText = "cos(x)";
      chart.Series.Add(series2);
      
      Legend legend = new Legend();
      chart.Legends.Add(legend);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      CreateChart();      
      CalcFunction();
      
      chart.Series[0].Points.DataBindXY(x, y1);
      chart.Series[1].Points.DataBindXY(x, y2);
    }
  }
}
