using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Individual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = "Janith";
            string password = "Janith@0611";
            if (usernametxt.Text == username && passwordtxt.Text == password)
            {
                Form2 F2 = new Form2();
                F2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials, please check Username and Password and try again", "Invalid login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear1btn_Click(object sender, EventArgs e)
        {
            usernametxt.Clear();
            passwordtxt.Clear();
            usernametxt.Focus();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            { this.Close(); }
        }
    }
}
