using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverCatapult
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void openMainForm()
        {
            Form1 f1 = new Form1();
            f1.Show();
            f1.Left = this.Left;
            f1.Top = this.Top;
            f1.Size = this.Size;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Properties.Settings.Default.scanDate = "сегодня";
            Properties.Settings.Default.Save();


            Console.WriteLine("успех");
            if(Properties.Settings.Default.createRestorePoint == true)
            {
                string[] mystr = { DateTime.Now.ToString() };
                Properties.Settings.Default.restorePoints.AddRange(mystr);
                Properties.Settings.Default.Save();
            }

            bool[] checkBoxValues = { checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked };
            Form3 f3 = new Form3(checkBoxValues);
            f3.Show();
            f3.Left = this.Left;
            f3.Top = this.Top;
            f3.Size = this.Size;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.openMainForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openMainForm();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox cd = (CheckBox)c;
                    cd.Checked = this.checkBox6.Checked;
                }
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            f5.Left = this.Left;
            f5.Top = this.Top;
            f5.Size = this.Size;
            this.Close();
        }
    }
}
