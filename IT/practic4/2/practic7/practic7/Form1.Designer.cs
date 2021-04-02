
namespace practic7
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
      this.label1 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.button2 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(22, 529);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(162, 39);
      this.button1.TabIndex = 0;
      this.button1.Text = "Заполнение массива";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(764, 549);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 17);
      this.label1.TabIndex = 2;
      this.label1.Text = "Результат:";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(866, 546);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(193, 22);
      this.textBox2.TabIndex = 3;
      this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 30;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(1070, 523);
      this.dataGridView1.TabIndex = 4;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(230, 529);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(179, 39);
      this.button2.TabIndex = 5;
      this.button2.Text = "Поменять местами";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1071, 580);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Двухмерные массивы";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button button2;
  }
}

