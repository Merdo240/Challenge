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
    public partial class Form4 : Form
    {
        bool isExpanded = false;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (StuData.image != null)
            {
                pictureBox1.Image = StuData.image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            this.Width = 497;
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            if (!isExpanded)
            {
                this.Width = 813;
                label1.Text = StuData.name;
                label2.Text = "كلية " + StuData.collage;
                label3.Text = "قسم " + StuData.debt;
                label4.Text = "المستوى " + StuData.level;
                label5.Text = StuData.term;

                button1.Text = "<<";
                isExpanded = true;
            }
            else if(isExpanded)
            {
                this.Width = 497;
                button1.Text = ">>";
                isExpanded = false;
            }

        }
    }
}
