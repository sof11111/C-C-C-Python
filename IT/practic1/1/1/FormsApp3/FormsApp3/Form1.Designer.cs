﻿namespace FormsApp3
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Aqua;
      this.button1.Location = new System.Drawing.Point(39, 298);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(253, 107);
      this.button1.TabIndex = 0;
      this.button1.Text = "ввод1";
      this.button1.UseVisualStyleBackColor = false;
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.button2.Location = new System.Drawing.Point(377, 298);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(254, 107);
      this.button2.TabIndex = 1;
      this.button2.Text = "ввод2";
      this.button2.UseVisualStyleBackColor = false;
      ///this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.Chartreuse;
      this.button3.Location = new System.Drawing.Point(39, 155);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(205, 119);
      this.button3.TabIndex = 2;
      this.button3.Text = "ввод3";
      this.button3.UseVisualStyleBackColor = false;
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.BlueViolet;
      this.button4.Location = new System.Drawing.Point(377, 155);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(254, 109);
      this.button4.TabIndex = 3;
      this.button4.Text = "ввод4";
      this.button4.UseVisualStyleBackColor = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(219, 307);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Введите1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(392, 307);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(55, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Введите2";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(174, 175);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Введите3";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(392, 175);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(55, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Введите4";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

