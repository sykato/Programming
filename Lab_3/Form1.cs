using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CrateBlank (2000, 1000);    
        }
        Color DefaultColor
        {
            get { return Color.White; }
        }
        void CrateBlank(int width, int height)
        {
            var oldImage = pictureBox1.Image;
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            for (int i=0; i<width; i++)
            {
                for (int j=0; j<height; j++)
                {
                    bmp.SetPixel(i,j,DefaultColor);
                }
            }
            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }
        int _x;
        int _y;
        bool _mouseClicked = false;
        Color SelectedColor
        {
            get { return button5.BackColor; }
        }
        int SelectedSize
        {
            get { return trackBar1.Value; }
        }
        Brush _selectedBrush;

        private void button1_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrash(SelectedColor, SelectedSize);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null)
            {
                MessageBox.Show("Выберите кисть");
            }
            else
            {
                _selectedBrush.BrushColor = SelectedColor;
                _selectedBrush.Size = SelectedSize;
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
                _mouseClicked = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _x=e.X > 0 ? e.X : 0;
            _y=e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                try
                {
                    _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                    pictureBox1.Refresh();
                }
                catch
                {
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close ();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            if (form.Canceled == false)
            {
                CrateBlank(form.W, form.H);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Lastic(SelectedColor, SelectedSize);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Round(SelectedColor, SelectedSize);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Spray(SelectedColor, SelectedSize);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button5.BackColor = colorDialog1.Color;
            }
        }

        private void Black_Click(object sender, EventArgs e)
        {
            button5.BackColor= Color.Black;
        }

        private void Gray_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Gray;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Green;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Blue;
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Pink;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Yellow;
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Purple;
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.OldLace;
        }

        private void MediumPurple_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.MediumPurple;
        }

        private void Brown_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Brown;
        }

        private void White_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
        }
    }
}
