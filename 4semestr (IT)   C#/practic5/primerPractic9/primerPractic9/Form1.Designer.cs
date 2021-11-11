namespace primerPractic9
{
  partial class proramma
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
      this.SuspendLayout();
      // 
      // proramma
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(992, 569);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "proramma";
      this.Text = "График";
      this.Load += new System.EventHandler(this.Form1_Load_1);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
      this.ResumeLayout(false);

    }

    #endregion
  }
}

