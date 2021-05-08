
namespace FormsApp2_2
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
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(52, 96);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Ввод числа:";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(145, 96);
      this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 22);
      this.textBox1.TabIndex = 1;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(55, 145);
      this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(345, 228);
      this.textBox2.TabIndex = 2;
      this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(358, 393);
      this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 33);
      this.button1.TabIndex = 5;
      this.button1.Text = "Расчет";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(584, 450);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "Form1";
      this.Text = "Алгоритм с использованием циклов";
      this.Load += new System.EventHandler(this.Form1_Load_1);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button1;
  }
}

