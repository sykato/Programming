namespace lab_6
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Draw = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextA = new System.Windows.Forms.TextBox();
            this.TextB = new System.Windows.Forms.TextBox();
            this.TextC = new System.Windows.Forms.TextBox();
            this.textBoxKolvo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboSumm = new System.Windows.Forms.TextBox();
            this.textLeft = new System.Windows.Forms.TextBox();
            this.textRight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(706, 588);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(712, 553);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 1;
            this.Draw.Text = "начать";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(712, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(712, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Left";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Right";
            // 
            // TextA
            // 
            this.TextA.Location = new System.Drawing.Point(741, 74);
            this.TextA.Name = "TextA";
            this.TextA.Size = new System.Drawing.Size(59, 20);
            this.TextA.TabIndex = 4;
            // 
            // TextB
            // 
            this.TextB.Location = new System.Drawing.Point(741, 96);
            this.TextB.Name = "TextB";
            this.TextB.Size = new System.Drawing.Size(59, 20);
            this.TextB.TabIndex = 4;
            // 
            // TextC
            // 
            this.TextC.Location = new System.Drawing.Point(741, 118);
            this.TextC.Name = "TextC";
            this.TextC.Size = new System.Drawing.Size(59, 20);
            this.TextC.TabIndex = 4;
            // 
            // textBoxKolvo
            // 
            this.textBoxKolvo.Location = new System.Drawing.Point(802, 191);
            this.textBoxKolvo.Name = "textBoxKolvo";
            this.textBoxKolvo.Size = new System.Drawing.Size(59, 20);
            this.textBoxKolvo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(709, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Кол. Разбиения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Площадь";
            // 
            // ComboSumm
            // 
            this.ComboSumm.Location = new System.Drawing.Point(770, 217);
            this.ComboSumm.Name = "ComboSumm";
            this.ComboSumm.ReadOnly = true;
            this.ComboSumm.Size = new System.Drawing.Size(119, 20);
            this.ComboSumm.TabIndex = 20;
            // 
            // textLeft
            // 
            this.textLeft.Location = new System.Drawing.Point(741, 141);
            this.textLeft.Name = "textLeft";
            this.textLeft.Size = new System.Drawing.Size(59, 20);
            this.textLeft.TabIndex = 4;
            // 
            // textRight
            // 
            this.textRight.Location = new System.Drawing.Point(741, 165);
            this.textRight.Name = "textRight";
            this.textRight.Size = new System.Drawing.Size(59, 20);
            this.textRight.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 588);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboSumm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKolvo);
            this.Controls.Add(this.textRight);
            this.Controls.Add(this.textLeft);
            this.Controls.Add(this.TextC);
            this.Controls.Add(this.TextB);
            this.Controls.Add(this.TextA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextA;
        private System.Windows.Forms.TextBox TextB;
        private System.Windows.Forms.TextBox TextC;
        private System.Windows.Forms.TextBox textBoxKolvo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ComboSumm;
        private System.Windows.Forms.TextBox textLeft;
        private System.Windows.Forms.TextBox textRight;
    }
}

