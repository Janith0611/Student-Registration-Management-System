using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_Project_Individual
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Final_AssignmentSI;Integrated Security=True");
        SqlCommand com;
        public Form2()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                String gen = "";
                if (radiobtn1.Checked) { gen = "Male"; }
                if (radiobtn2.Checked) { gen = "Female"; }
                con.Open();
                String query1 = "INSERT INTO S_Registration (RegNo,FirstName,LastName,DateOfBirth,Gender,Address,Email,MobilePhone,Homephone,ParentName,NIC,ContactNo) VALUES ('" + reg_no_cmbox.Text + "','" + firstnametxt.Text + "','" + lastnametxt.Text + "','" + DateTimePicker.Text + "','" + gen + "','" + addresstxt.Text + "','" + emailtxt.Text + "','" + mobiletxt.Text + "','" + hometxt.Text + "','" + parentnametxt.Text + "','" + nictxt.Text + "','" + contactnumbertxt.Text + "' )";
                com = new SqlCommand(query1, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Record Added Succesfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            String gen = "";
            if (radiobtn1.Checked) { gen = "Male"; }
            if (radiobtn2.Checked) { gen = "Female"; }
            con.Open();
            String query2 = "UPDATE S_Registration SET FirstName = '" + firstnametxt.Text + "',LastName = '" + lastnametxt.Text + "',DateOfBirth = '" + DateTimePicker.Text + "',Gender = '" + gen + "',Address = '" + addresstxt.Text + "',Email = '" + emailtxt.Text + "',MobilePhone = '" + mobiletxt.Text + "',HomePhone = '" + hometxt.Text + "',ParentName = '" + parentnametxt.Text + "',NIC = '" + nictxt.Text + "',ContactNo = '" + contactnumbertxt.Text + "' WHERE RegNo = '" + reg_no_cmbox.Text + "' ";
            com = new SqlCommand(query2, con);
            com.ExecuteNonQuery();
            MessageBox.Show("Record Updated Succesfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            String gen = "";
            if (radiobtn1.Checked) { gen = "Male"; }
            if (radiobtn2.Checked) { gen = "Female"; }
            con.Open();
            String query3 = "DELETE FROM S_Registration WHERE RegNo = '" + reg_no_cmbox.Text + "' ";
            com = new SqlCommand(query3, con);
            com.ExecuteNonQuery();
            DialogResult ans = MessageBox.Show("Are you sure, Do you really want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                Form2 F2 = new Form2();
                F2.Show();
                this.Hide();
            }
            con.Close();
        }

        private void clear2btn_Click(object sender, EventArgs e)
        {
            firstnametxt.Clear();
            lastnametxt.Clear();
            addresstxt.Clear();
            emailtxt.Clear();
            mobiletxt.Clear();
            hometxt.Clear();
            parentnametxt.Clear();
            nictxt.Clear();
            contactnumbertxt.Clear();
            radiobtn1.Checked = false;
            radiobtn2.Checked = false;
            reg_no_cmbox.Text = string.Empty;
        }

        private void exitlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            { this.Close(); }
        }

        private void logoutlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            String date = null;
            String part1 = null;
            String part2 = null;
            String part3 = null;
            String part4 = null;
            String date1 = null;

            try
            {
                con.Open();
                String query = "select * from  S_Registration WHERE RegNo = '" + reg_no_cmbox.Text + "' ";
                com = new SqlCommand(query, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    firstnametxt.Text = dr[1].ToString();
                    lastnametxt.Text = dr[2].ToString();
                    addresstxt.Text = dr[5].ToString();
                    emailtxt.Text = dr[6].ToString();
                    mobiletxt.Text = dr[7].ToString();
                    hometxt.Text = dr[8].ToString();
                    parentnametxt.Text = dr[9].ToString();
                    nictxt.Text = dr[10].ToString();
                    contactnumbertxt.Text = dr[11].ToString();

                    if (radiobtn1.Checked) { radiobtn1.Checked = true; }
                    if (radiobtn2.Checked) { radiobtn2.Checked = true; }

                    date = dr[3].ToString();
                }
                con.Close();

                part1 = date.Substring(0, 1);
                part2 = date.Substring(2, 2);
                part3 = date.Substring(3, 6);
                date1 = part3;
                part4 = date1.Substring(2, 4);
                DateTimePicker.Value = new DateTime(int.Parse(part4), int.Parse(part1), int.Parse(part2));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
