﻿
namespace practic2
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
      this.label2 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(37, 48);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(113, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Введите значение х: ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(37, 124);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(186, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Результат выполнения программы";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(163, 48);
      this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 2;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(39, 156);
      this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox2.Size = new System.Drawing.Size(255, 192);
      this.textBox2.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(202, 386);
      this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(81, 27);
      this.button1.TabIndex = 4;
      this.button1.Text = "Выполнить";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(360, 444);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "Form1";
      this.Text = "Линейный алгоритм";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button1;
  }
}
