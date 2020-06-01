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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label2.Text = Properties.Settings.Default.scanDate;
            if(this.label2.Text == "никогда")
            {
                this.label2.ForeColor = Color.FromName("Red");
            }
            else
            {
                this.label2.ForeColor = Color.FromName("Green");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.Left = this.Left;
            f2.Top = this.Top;
            f2.Size = this.Size;
            this.Hide();
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
            this.Hide();
        }
    }
}
