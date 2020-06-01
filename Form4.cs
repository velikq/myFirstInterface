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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            checkBox1.Checked = Properties.Settings.Default.createRestorePoint;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            f1.Left = this.Left;
            f1.Top = this.Top;
            f1.Size = this.Size;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.createRestorePoint = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
