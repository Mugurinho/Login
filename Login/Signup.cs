using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Mail;

namespace Login
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.Enabled = false;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=Mugurel;Initial Catalog=Details;Integrated Security=True");
            conn.Open();

            if (txtEmail.Text == "")
            {
                lblSignup.Text = "Email required";
                lblSignup.ForeColor = System.Drawing.Color.Red;
            }

            else
            {
                string sql = "insert into Signup(Email, Password) VALUES ('" + txtEmail.Text + "' , '" + txtPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                lblSignup.Visible = true;
                lblSignup.Text = "User registered successfully";
                lblSignup.ForeColor = System.Drawing.Color.Green;
            }
        }


        //duplicated email entries validation
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=Mugurel;Initial Catalog=Details;Integrated Security=True");
            conn.Open();
            string query = "select Email from Signup";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lblSignup.Text = "";

                if (rd["Email"].ToString() == txtEmail.Text.ToString())
                {
                    lblSignup.Visible = true;
                    lblSignup.Text = "User/email already registered, try again";
                    lblSignup.ForeColor = System.Drawing.Color.Red;
                    btnSignup.Enabled = false;
                    break;
                }

                else
                {
                    btnSignup.Enabled = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = (checkBox1.CheckState == CheckState.Checked);
        }
    }
}
