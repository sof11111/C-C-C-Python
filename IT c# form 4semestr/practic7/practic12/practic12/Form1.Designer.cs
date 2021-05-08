
namespace practic12
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.dataGridView3 = new System.Windows.Forms.DataGridView();
      this.dataGridView4 = new System.Windows.Forms.DataGridView();
      this.dataGridView5 = new System.Windows.Forms.DataGridView();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(240, 170);
      this.dataGridView1.TabIndex = 0;
      // 
      // dataGridView2
      // 
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Location = new System.Drawing.Point(267, 0);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.RowHeadersWidth = 51;
      this.dataGridView2.RowTemplate.Height = 24;
      this.dataGridView2.Size = new System.Drawing.Size(361, 82);
      this.dataGridView2.TabIndex = 1;
      // 
      // dataGridView3
      // 
      this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView3.Location = new System.Drawing.Point(267, 88);
      this.dataGridView3.Name = "dataGridView3";
      this.dataGridView3.RowHeadersWidth = 51;
      this.dataGridView3.RowTemplate.Height = 24;
      this.dataGridView3.Size = new System.Drawing.Size(265, 82);
      this.dataGridView3.TabIndex = 2;
      // 
      // dataGridView4
      // 
      this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView4.Location = new System.Drawing.Point(660, 0);
      this.dataGridView4.Name = "dataGridView4";
      this.dataGridView4.RowHeadersWidth = 51;
      this.dataGridView4.RowTemplate.Height = 24;
      this.dataGridView4.Size = new System.Drawing.Size(474, 135);
      this.dataGridView4.TabIndex = 3;
      // 
      // dataGridView5
      // 
      this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView5.Location = new System.Drawing.Point(660, 153);
      this.dataGridView5.Name = "dataGridView5";
      this.dataGridView5.RowHeadersWidth = 51;
      this.dataGridView5.RowTemplate.Height = 24;
      this.dataGridView5.Size = new System.Drawing.Size(292, 99);
      this.dataGridView5.TabIndex = 4;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(538, 88);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(90, 82);
      this.button1.TabIndex = 5;
      this.button1.Text = "Решить систему 1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(972, 153);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(162, 99);
      this.button2.TabIndex = 6;
      this.button2.Text = "Решить систему 2";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(660, 279);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(474, 72);
      this.button3.TabIndex = 7;
      this.button3.Text = "Отобразить начальные точки";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(660, 372);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(474, 72);
      this.button4.TabIndex = 8;
      this.button4.Text = "Построить полином 1 степени";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(660, 458);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(474, 72);
      this.button5.TabIndex = 9;
      this.button5.Text = "Построить полином второй степени 2";
      this.button5.UseVisualStyleBackColor = true;
      // 
      // chart1
      // 
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(12, 199);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(616, 380);
      this.chart1.TabIndex = 10;
      this.chart1.Text = "chart1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1146, 605);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.dataGridView5);
      this.Controls.Add(this.dataGridView4);
      this.Controls.Add(this.dataGridView3);
      this.Controls.Add(this.dataGridView2);
      this.Controls.Add(this.dataGridView1);
      this.Name = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridView dataGridView2;
    private System.Windows.Forms.DataGridView dataGridView3;
    private System.Windows.Forms.DataGridView dataGridView4;
    private System.Windows.Forms.DataGridView dataGridView5;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
  }
}

