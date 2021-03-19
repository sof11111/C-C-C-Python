namespace Forms3
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
      this.textBox_x = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radioButton_exp = new System.Windows.Forms.RadioButton();
      this.radioButton_ch = new System.Windows.Forms.RadioButton();
      this.radioButton_sh = new System.Windows.Forms.RadioButton();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(652, 435);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(167, 54);
      this.button1.TabIndex = 0;
      this.button1.Text = "Расчет";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox_x.Location = new System.Drawing.Point(201, 76);
      this.textBox_x.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBox_x.Name = "textBox1";
      this.textBox_x.Size = new System.Drawing.Size(132, 22);
      this.textBox_x.TabIndex = 2;
      this.textBox_x.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(201, 128);
      this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(132, 22);
      this.textBox2.TabIndex = 3;
      this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(201, 188);
      this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(132, 22);
      this.textBox3.TabIndex = 4;
      this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(97, 80);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 17);
      this.label1.TabIndex = 5;
      this.label1.Text = "Введите х:";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(97, 132);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(78, 17);
      this.label2.TabIndex = 6;
      this.label2.Text = "Введите y:";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(97, 188);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(78, 17);
      this.label3.TabIndex = 7;
      this.label3.Text = "Введите z:";
      this.label3.Click += new System.EventHandler(this.label3_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radioButton_exp);
      this.groupBox1.Controls.Add(this.radioButton_ch);
      this.groupBox1.Controls.Add(this.radioButton_sh);
      this.groupBox1.Location = new System.Drawing.Point(566, 80);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Size = new System.Drawing.Size(228, 139);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "F(x)";
      this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
      // 
      // radioButton_exp
      // 
      this.radioButton_exp.AutoSize = true;
      this.radioButton_exp.Location = new System.Drawing.Point(21, 92);
      this.radioButton_exp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.radioButton_exp.Name = "radioButton_exp";
      this.radioButton_exp.Size = new System.Drawing.Size(51, 21);
      this.radioButton_exp.TabIndex = 2;
      this.radioButton_exp.TabStop = true;
      this.radioButton_exp.Text = "exp";
      this.radioButton_exp.UseVisualStyleBackColor = true;
      this.radioButton_exp.CheckedChanged += new System.EventHandler(this.radioButton_exp_CheckedChanged);
      // 
      // radioButton_ch
      // 
      this.radioButton_ch.AutoSize = true;
      this.radioButton_ch.Location = new System.Drawing.Point(21, 64);
      this.radioButton_ch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.radioButton_ch.Name = "radioButton_ch";
      this.radioButton_ch.Size = new System.Drawing.Size(44, 21);
      this.radioButton_ch.TabIndex = 1;
      this.radioButton_ch.TabStop = true;
      this.radioButton_ch.Text = "ch";
      this.radioButton_ch.UseVisualStyleBackColor = true;
      this.radioButton_ch.CheckedChanged += new System.EventHandler(this.radioButton_ch_CheckedChanged);
      // 
      // radioButton_sh
      // 
      this.radioButton_sh.AutoSize = true;
      this.radioButton_sh.Location = new System.Drawing.Point(21, 36);
      this.radioButton_sh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.radioButton_sh.Name = "radioButton_sh";
      this.radioButton_sh.Size = new System.Drawing.Size(44, 21);
      this.radioButton_sh.TabIndex = 0;
      this.radioButton_sh.TabStop = true;
      this.radioButton_sh.Text = "sh";
      this.radioButton_sh.UseVisualStyleBackColor = true;
      this.radioButton_sh.CheckedChanged += new System.EventHandler(this.radioButton_sh_CheckedChanged);
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(84, 259);
      this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBox4.Multiline = true;
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(481, 182);
      this.textBox4.TabIndex = 9;
      this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(871, 521);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox_x);
      this.Controls.Add(this.button1);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Уравнение";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_exp;
        private System.Windows.Forms.RadioButton radioButton_ch;
        private System.Windows.Forms.RadioButton radioButton_sh;
        private System.Windows.Forms.TextBox textBox4;
    }
}

