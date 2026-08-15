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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = StuData.name;
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

            MessageBox.Show("تم حفظ البيانات بنجاح");
        }
    }
}
