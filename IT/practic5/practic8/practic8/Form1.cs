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

    private double XMin = 0.1;
    private double XMax = Math.PI*2;
    private double Step = (Math.PI * 2) / 10;
    private double[] x;
    private double[] y1;    
    Chart chart;

    private void CalcFunction()
    {      
      int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;
      
      x = new double[count];
      y1 = new double[count];      
      
      for (int i = 0; i < count; i++)
      {        
        x[i] = XMin + Step * i;        
        y1[i] = func(x[i]);        
      }
    }
    double func(double x)
    {
      return ((Math.Sqrt(1 + Math.Exp(Math.Sqrt(x)) + Math.Cos(Math.Pow(x, 2)))) 
        / (Math.Abs(1 - Math.Pow(Math.Sin(x), 3)))) + Math.Log(2 * x);
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
      series1.LegendText = "double y = ((Math.Sqrt(1 + Math.Exp(Math.Sqrt(x)) + Math.Cos(Math.Pow(x, 2)))) / (Math.Abs(1 - Math.Pow(Math.Sin(x), 3)))) + Math.Log(2 * x);";     
      
      chart.Series.Add(series1);
      
      Legend legend = new Legend();
      chart.Legends.Add(legend);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      CreateChart();      
      CalcFunction();      

      chart.Series[0].Points.DataBindXY(x, y1);      
    }
  }
}
