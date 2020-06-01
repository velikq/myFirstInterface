using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverCatapult
{
    public partial class Form3 : Form
    {
        public Form3(bool[] checkBoxValues)
        {
            InitializeComponent();
            label13.Hide();
            //ужасный кусок с проверкой отправленных чекбоксов
            if(checkBoxValues[0] == false)
            {
                label1.Hide();
                label2.Top -= 30;
                label3.Top -= 30;
                label4.Top -= 30;
                label5.Top -= 30;
                label8.Hide();
                label9.Top -= 30;
                label10.Top -= 30;
                label11.Top -= 30;
                label12.Top -= 30;
                label13.Top -= 30;
            }
            if(checkBoxValues[1] == false)
            {
                label2.Hide();
                label3.Top -= 30;
                label4.Top -= 30;
                label5.Top -= 30;
                label9.Hide();
                label10.Top -= 30;
                label11.Top -= 30;
                label12.Top -= 30;
            }
            if(checkBoxValues[2] == false)
            {
                label3.Hide();
                label4.Top -= 30;
                label5.Top -= 30;
                label10.Hide();
                label11.Top -= 30;
                label12.Top -= 30;
            }
            if(checkBoxValues[3] == false)
            {
                label4.Hide();
                label5.Top -= 30;
                label11.Hide();
                label12.Top -= 30;
            }
            if(checkBoxValues[4] == false)
            {
                label5.Hide();
                label12.Hide();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if(label13.Visible == true)
            {
                label13.Hide();
            } else
            {
                label13.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            f1.Left = this.Left;
            f1.Top = this.Top;
            f1.Size = this.Size;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            f4.Left = this.Left;
            f4.Top = this.Top;
            f4.Size = this.Size;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            f5.Left = this.Left;
            f5.Top = this.Top;
            f5.Size = this.Size;
            this.Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
