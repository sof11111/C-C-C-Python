namespace FormsApp1
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
      this.components = new System.ComponentModel.Container();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Crimson;
      this.button1.ForeColor = System.Drawing.Color.Black;
      this.button1.Location = new System.Drawing.Point(132, 94);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(312, 178);
      this.button1.TabIndex = 1;
      this.button1.Text = "Красный";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.ForestGreen;
      this.button2.ForeColor = System.Drawing.Color.Black;
      this.button2.Location = new System.Drawing.Point(645, 94);
      this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(312, 178);
      this.button2.TabIndex = 2;
      this.button2.Text = "Зеленый";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.DarkBlue;
      this.button3.ForeColor = System.Drawing.Color.Black;
      this.button3.Location = new System.Drawing.Point(132, 318);
      this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(312, 178);
      this.button3.TabIndex = 3;
      this.button3.Text = "Синий";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.Yellow;
      this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.button4.ForeColor = System.Drawing.Color.Black;
      this.button4.Location = new System.Drawing.Point(645, 326);
      this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(312, 170);
      this.button4.TabIndex = 4;
      this.button4.Text = "Желтый";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1119, 596);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.ForeColor = System.Drawing.Color.MediumVioletRed;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Practic№1";
      this.Click += new System.EventHandler(this.Form1_Click);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

