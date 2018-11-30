using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void linear_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.abcd1 = "tuantu";
            f1.ShowDialog();
        }

        private void binary_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.abcd1 = "nhiphan";
            f1.ShowDialog();
        }

        private void select_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.abcd2 = "select";
            f2.ShowDialog();
        }

        private void shell_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.abcd2 = "shell";
            f2.ShowDialog();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.abcd2 = "insert";
            f2.ShowDialog();
        }

        private void heap_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.abcd2 = "heap";
            f2.ShowDialog();
        }

        private void interchange_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.abcd2 = "interchange";
            f2.ShowDialog();
        }

        private void quick_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.abcd2 = "quick";
            f2.ShowDialog();
        }

        private void bubble_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.abcd2 = "bubble";
            f2.ShowDialog();
        }

        private void merge_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
