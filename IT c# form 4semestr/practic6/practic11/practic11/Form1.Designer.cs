namespace practic11
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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.button_Color = new System.Windows.Forms.Button();
      this.trackBar_penWidth = new System.Windows.Forms.TrackBar();
      this.label_0 = new System.Windows.Forms.Label();
      this.label_50 = new System.Windows.Forms.Label();
      this.label_curValue = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar_penWidth)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 415);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Открыть";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(713, 417);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Сохранить";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(532, 417);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "Серый";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(776, 377);
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
      this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
      // 
      // button_Color
      // 
      this.button_Color.Location = new System.Drawing.Point(122, 415);
      this.button_Color.Name = "button_Color";
      this.button_Color.Size = new System.Drawing.Size(75, 23);
      this.button_Color.TabIndex = 4;
      this.button_Color.Text = "Цвет";
      this.button_Color.UseVisualStyleBackColor = true;
      this.button_Color.Click += new System.EventHandler(this.button_Color_Click);
      // 
      // trackBar_penWidth
      // 
      this.trackBar_penWidth.Location = new System.Drawing.Point(246, 395);
      this.trackBar_penWidth.Maximum = 50;
      this.trackBar_penWidth.Minimum = 1;
      this.trackBar_penWidth.Name = "trackBar_penWidth";
      this.trackBar_penWidth.Size = new System.Drawing.Size(220, 45);
      this.trackBar_penWidth.TabIndex = 5;
      this.trackBar_penWidth.Value = 1;
      this.trackBar_penWidth.Scroll += new System.EventHandler(this.trackBar_penWidth_Scroll);
      // 
      // label_0
      // 
      this.label_0.AutoSize = true;
      this.label_0.Location = new System.Drawing.Point(252, 428);
      this.label_0.Name = "label_0";
      this.label_0.Size = new System.Drawing.Size(13, 13);
      this.label_0.TabIndex = 6;
      this.label_0.Text = "0";
      // 
      // label_50
      // 
      this.label_50.AutoSize = true;
      this.label_50.Location = new System.Drawing.Point(431, 428);
      this.label_50.Name = "label_50";
      this.label_50.Size = new System.Drawing.Size(19, 13);
      this.label_50.TabIndex = 7;
      this.label_50.Text = "50";
      // 
      // label_curValue
      // 
      this.label_curValue.AutoSize = true;
      this.label_curValue.Location = new System.Drawing.Point(339, 428);
      this.label_curValue.Name = "label_curValue";
      this.label_curValue.Size = new System.Drawing.Size(0, 13);
      this.label_curValue.TabIndex = 8;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label_curValue);
      this.Controls.Add(this.label_50);
      this.Controls.Add(this.label_0);
      this.Controls.Add(this.trackBar_penWidth);
      this.Controls.Add(this.button_Color);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar_penWidth)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Button button_Color;
    private System.Windows.Forms.TrackBar trackBar_penWidth;
    private System.Windows.Forms.Label label_0;
    private System.Windows.Forms.Label label_50;
    private System.Windows.Forms.Label label_curValue;
  }
}

