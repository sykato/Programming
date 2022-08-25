using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab_lab_9
{
    public partial class Form1 : Form
    {
        public List<ClassList> classFiles = new List<ClassList>();

        public Form1()
        {
            InitializeComponent();
        }
        string path { get; set; }

        public List<string> lines;
        private void Browse_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();


            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowser.SelectedPath;
                textBoxWay.Text = folderBrowser.SelectedPath;
                Info();
                Dell.Enabled = true;
            }
        }
        public void Info()
        {
            try
            {
                DirectoryInfo DirInfo = new DirectoryInfo($"{path}");
                classFiles.Clear();

                foreach (FileInfo file in DirInfo.GetFiles("*.*", SearchOption.AllDirectories))
                {
                    classFiles.Add(new ClassList(file.Length * 8,
                        Path.GetFileNameWithoutExtension(file.Name),
                        file.FullName,
                        file.Name
                        ));
                }
                textBoxInfo.Text = $" Количество файлов: {classFiles.Count}";
            }
            catch
            {
                MessageBox.Show("Выберите путь для исп. данной кнопки");
            }

        }
        public void DellDubl()
        {
            for (int i = 0; i < classFiles.Count; i++)
            {
                string fileName = classFiles[i].filename;
                Regex check = new Regex(@"(?<Name>.+) (?<Num>\([0-9]+\))");
                List<ClassList> serch = classFiles.FindAll(file => file.filename == fileName);
                for (int j = 0; j < serch.Count; j++)
                {
                    if (serch[j].path != classFiles[i].path)
                    {
                        if (serch[j].lenght == classFiles[i].lenght)
                        {
                            listBox1.Items.Add($"Файл с названием: {classFiles[i].filename} и размеров: {classFiles[i].lenght} был удален");
                            File.Delete(classFiles[i].path);
                            classFiles.Remove(classFiles[i]);
                            i = -1;
                        }
                    }
                }

                if (check.IsMatch(fileName))
                {
                    Match checkm = check.Match(fileName);
                    ClassList serch2 = classFiles.Find(file => file.filename == $"{checkm.Groups["Name"]}");
                    if (serch2 != null)
                    {
                        if (serch2.lenght == classFiles[i].lenght)
                        {
                            listBox1.Items.Add($"Файл с названием: {classFiles[i].filename} и размеров: {classFiles[i].lenght} был удален");
                            File.Delete(classFiles[i].path);
                            classFiles.Remove(classFiles[i]);
                            i = -1;
                        }
                    }
                }
            }
        }

        private void Dell_Click(object sender, EventArgs e)
        {
            DellDubl();
        }
    }
}