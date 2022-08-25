using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void DrawFunction(double x1, double x2, Series series, Equation equation)
        {
            if (x1 >= x2)
            {
                throw new ArgumentException("Правая граница интегирования должны быть больше левой!");
            }
            for (int i = (int)x1; i < (int)x2; i++)
            {
                double y = equation.GetValue(i);
                chart1.Series[0].Points.AddXY(i, (int)y);
            }

        }
        private void MainProgram_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(new quadraticEquation(0, 0, 0));
            comboBox1.Items.Add(new sinusoidalEquation(0));
            comboBox2.Items.Add(new MetodSimp());
            comboBox2.Items.Add(new MetodRectangle());
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            TextA.Text = "1";
            TextB.Text = "1";
            TextC.Text = "1";
            textLeft.Text = "-10";
            textRight.Text = "10";
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            Equation Equa = comboBox1.SelectedItem as Equation;
            Integrator integr = comboBox2.SelectedItem as Integrator;

            if (Equa != null)
            {
                if (Equa is quadraticEquation quad)
                {
                    quad.a = Convert.ToDouble(TextA.Text);
                    quad.b = Convert.ToDouble(TextB.Text);
                    quad.c = Convert.ToDouble(TextC.Text);
                }
                else if (Equa is sinusoidalEquation sin)
                {
                    sin.a = Convert.ToDouble(TextA.Text);
                }
                chart1.Series[0].ChartType = SeriesChartType.Spline;
                chart1.ChartAreas[0].AxisX.Minimum = Convert.ToInt32(textLeft.Text);
                chart1.ChartAreas[0].AxisX.Maximum = Convert.ToInt32(textRight.Text);

                DrawFunction(Convert.ToDouble(textLeft.Text), Convert.ToDouble(textRight.Text), chart1.Series[0], Equa);
                int N;
                if (textBoxKolvo.Text != string.Empty)
                {
                    if (Int32.TryParse(textBoxKolvo.Text, out N))
                    {
                        double summ = integr.Integrate(Convert.ToDouble(textLeft.Text), Convert.ToDouble(textRight.Text), Equa, N);
                        ComboSumm.Text = $"{summ}";
                    }
                    else { throw new ArgumentException("Неверно вписано значение разбиения"); };
                }
            }
        }
        private void TBa_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).TextLength == 0)
            {
                ((TextBox)sender).Text = "0";
            }

        }

        private void CBEqua_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label1.Enabled = true;
                    label2.Enabled = true;
                    label3.Enabled = true;
                    TextA.Enabled = true;
                    TextB.Enabled = true;
                    TextC.Enabled = true;
                    break;
                case 1:
                    label1.Enabled = true;
                    label2.Enabled = true;
                    label3.Enabled = false;
                    TextA.Enabled = true;
                    TextB.Enabled = true;
                    TextC.Enabled = false;
                    break;
                case 2:
                    label1.Enabled = true;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    TextA.Enabled = true;
                    TextB.Enabled = false;
                    TextC.Enabled = false;
                    break;
                default: break;
            }
        }

    }
}

