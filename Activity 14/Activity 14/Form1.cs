using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class Activity14 : Form
    {
        public Activity14()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeListBox_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void AdoptButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if (AdalineRadioButton.Checked) 
            {
                Namelabel.Text = "Adaline";
            }
            if (BobRadioButton.Checked)
            {
                Namelabel.Text = "Bob";
            }
            if (KarenRadioButton.Checked)
            {
                Namelabel.Text = "Karen";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StartTimeCheckBox1.Checked ^ EndCheckBox1.Checked)
            {
                label2.Text = Namelabel.Text + "    6:00 AM TILL 10:00 PM";
            }
            if (StartTimeCheckBox1.Checked ^ EndCheckBox2.Checked)
            {
                label2.Text = Namelabel.Text + "    6:00 AM TILL 11:00 PM";
            }
            if (StartTimeCheckBox2.Checked ^ EndCheckBox1.Checked)
            {
                label2.Text = Namelabel.Text + "    7:00 AM TILL 10:00 PM";
            }
            if (StartTimeCheckBox2.Checked ^ EndCheckBox2.Checked)
            {
                label2.Text = Namelabel.Text + "    7:00 AM TILL 11:00 PM";
            }
            if (StartTimeCheckBox3.Checked ^ EndCheckBox1.Checked)
            {
                label2.Text = Namelabel.Text + "    8:00 AM TILL 10:00 PM";
            }
            if (StartTimeCheckBox3.Checked ^ EndCheckBox2.Checked)
            {
                label2.Text = Namelabel.Text + "    8:00 AM TILL 11:00 PM";
            }
            StartTimeCheckBox1.Checked = false;
            StartTimeCheckBox2.Checked = false;
            StartTimeCheckBox3.Checked = false;
            EndCheckBox1.Checked = false;
            EndCheckBox2.Checked = false;
        }

        private void WorkCheckinbutton_Click(object sender, EventArgs e)
        {
            
            CheckinLabel.Text =  "You have successfully checked in";
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            Namelabel.Text = "";
            label2.Text = "";
            CheckinLabel.Text = "";
        }
    }
}
