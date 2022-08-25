using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HaveFN = false;
        }
        public string Filename { get; set; }
        public bool HaveFN { get; set; }

        private void Refresh(bool num)
        {
            if (num == true)
            {
                OpenFileDialog op = new OpenFileDialog();

                if (op.ShowDialog() == DialogResult.OK)
                {
                    HaveFN = true;
                    Filename = op.FileName;
                    string[] lines = File.ReadAllLines(op.FileName);
                    listBox1.Items.Clear();
                    foreach (string line in lines)
                    {
                        listBox1.Items.Add(line);
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка!Файл не загружен");

                }

            }
            else
            {
                if (HaveFN == false)
                {
                    MessageBox.Show($"Выберите файл");
                }
                else
                {
                    string[] lines = File.ReadAllLines(Filename);
                    listBox1.Items.Clear();
                    foreach (string line in lines)
                    {

                        listBox1.Items.Add(line);
                    }
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Refresh(true);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Refresh(false);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string text = listBox1.Items[i].ToString();
                Regex regex = new Regex(@"(aaaaaa|a aa a|a)");
                if (regex.IsMatch(text))
                {
                    listBox1.Items[i] = $"{listBox1.Items[i]} | Соответствует";
                }
                else
                {
                    listBox1.Items[i] = $"{listBox1.Items[i]} | Не соответствует";
                }
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Refresh(false);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string text = listBox1.Items[i].ToString();
                Regex regex = new Regex(@"^.{1,5}$");
                if (regex.IsMatch(text))
                {
                    listBox1.Items[i] = $"{listBox1.Items[i]} | Соответствует";
                }
                else
                {
                    listBox1.Items[i] = $"{listBox1.Items[i]} | Не соответствует";
                }
            }
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            Refresh(false);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string text = listBox1.Items[i].ToString();
                Regex regex = new Regex(@"(.{1,}[@][a-zA-Z]+[.][a-zA-Z]+)");
                if (regex.IsMatch(text))
                {
                    listBox1.Items[i] = $"{listBox1.Items[i]} | Email введен  правильно ";
                }
                else
                {
                    listBox1.Items[i] = $"{listBox1.Items[i]} | Email введен неправильно ";
                }
            }
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            Refresh(false);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string text = listBox1.Items[i].ToString();
                Regex regex = new Regex(@"((ул\.)\ )?(?<Name>[А-Яа-я]+)\ ((д\.)\ )?(?<Dom>(\d+[\/]\d+|\d+))");

                if (regex.IsMatch(text))
                {
                    Match match = regex.Match(text);
                    listBox1.Items[i] = $"{listBox1.Items[i]}  ({match.Groups["Name"]} {match.Groups["Dom"]})";
                }
                else
                {
                    listBox1.Items[i] = $"{listBox1.Items[i]}  Не найдено";
                }
            }
        }
    }

}
