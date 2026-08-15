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
    public partial class Form5 : Form
    {
        Form4 f4;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = StuData.name;
            textBoxCol.Text = StuData.collage;
            textBoxdept.Text = StuData.debt;

            if (StuData.image != null)
            {
                picStudent.Image = StuData.image;
                picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (StuData.level == "الأول") radioButton1.Checked = true;
            else if (StuData.level == "الثاني") radioButton2.Checked = true;
            else if (StuData.level == "الثالث") radioButton3.Checked = true;
            else if (StuData.level == "الرابع") radioButton4.Checked = true;

            if (StuData.term == "الأول") radioButton5.Checked = true;
            else if (StuData.term == "الثاني") radioButton6.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StuData.collage = textBoxCol.Text;
            StuData.debt = textBoxdept.Text;

            if (radioButton1.Checked) StuData.level = "الاول";
            else if (radioButton2.Checked) StuData.level = "الثاني";
            else if (radioButton3.Checked) StuData.level = "الثالث";
            else if (radioButton4.Checked) StuData.level = "الرابع";

            if (radioButton5.Checked) StuData.term = "الاول";
            else if (radioButton6.Checked) StuData.term = "الثاني";

            MessageBox.Show("تم تعديل البيانات بنجاح");

            this.Close();
            f4 = new Form4();
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picStudent.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }

    }

