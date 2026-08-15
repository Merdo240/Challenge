using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch
{
    public partial class Form1 : Form
    {
        Form2 f2;
        Form3 f3;
        Form4 f4;
        Form5 f5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {
            StuData.name = textname.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms[Application.OpenForms.Count - 1] != this)
            Application.OpenForms[Application.OpenForms.Count - 1].Close();
        }

        private void اغلاقالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count-1; i >= 0 ; i--)
            {
                if (Application.OpenForms[i] != this)
                    Application.OpenForms[i].Close();
            }
        }

        private void بياناتالطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }

        private void صورةالطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.Show();
        }

        private void عرضالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4 = new Form4();
            f4.Show();
        }

        private void تعديلالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5 = new Form5();
            f5.Show();
        }
    }
}
