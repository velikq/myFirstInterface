using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DriverCatapult
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex > -1)
            {
                this.label2.Text = "Успех";
                this.label2.Show();
            } else
            {
                this.label2.Text = "Выберите точку восстановления";
                this.label2.Show();
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
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string[] restPoints = new string[Properties.Settings.Default.restorePoints.Count];
            Properties.Settings.Default.restorePoints.CopyTo(restPoints, 0);
            foreach (string restPoint in restPoints)
            {
                this.comboBox1.Items.Add(restPoint);
            }
            this.label2.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            Properties.Settings.Default.restorePoints.Clear();
            Properties.Settings.Default.Save();
        }
    }
}
