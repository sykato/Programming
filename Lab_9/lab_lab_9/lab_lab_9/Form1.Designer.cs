namespace lab_lab_9
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
            this.textBoxWay = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.Dell = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь";
            // 
            // textBoxWay
            // 
            this.textBoxWay.Location = new System.Drawing.Point(49, 6);
            this.textBoxWay.Name = "textBoxWay";
            this.textBoxWay.Size = new System.Drawing.Size(416, 20);
            this.textBoxWay.TabIndex = 1;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(471, 6);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 21);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click_1);
            // 
            // Dell
            // 
            this.Dell.Location = new System.Drawing.Point(186, 276);
            this.Dell.Name = "Dell";
            this.Dell.Size = new System.Drawing.Size(122, 31);
            this.Dell.TabIndex = 3;
            this.Dell.Text = "Удалить дубликаты";
            this.Dell.UseVisualStyleBackColor = true;
            this.Dell.Click += new System.EventHandler(this.Dell_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(531, 212);
            this.listBox1.TabIndex = 4;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(49, 32);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(126, 20);
            this.textBoxInfo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 315);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Dell);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.textBoxWay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWay;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Dell;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxInfo;
    }
}

