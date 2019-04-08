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

namespace Login
{
    public partial class Login : Form
    {
        public static string settext = "";
        string userEmail = "";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userEmail = txtEmail.Text;
            //userEmail = LoginInfo.Email;
            SqlConnection conn = new SqlConnection("Data Source=Mugurel;Initial Catalog=Details;Integrated Security=True");
            conn.Open();
            string sql = "select Email from Signup where Email = '" + userEmail + "' and Password = '" + txtPassword.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >=1)
            {
                if (txtEmail.Text == "" || txtPassword.Text == "")
                {
                    lblLogin.Text = "Email and password required";
                    lblLogin.ForeColor = System.Drawing.Color.Red;
                }
                
                else
                {
                    settext = txtEmail.Text;
                    Welcome wc = new Welcome();
                    wc.Show();
                    this.Hide();
                    lblLogin.Visible = true;
                    lblLogin.Text = "User logged in successfully";
                    lblLogin.ForeColor = System.Drawing.Color.Green;
                }
            }

            else
            {
                lblLogin.Text = "Invalid email/password";
                lblLogin.ForeColor = System.Drawing.Color.Red;
                txtPassword.Text = "";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            userEmail = txtEmail.Text;
           //verify email
            SqlConnection conn = new SqlConnection("Data Source=Mugurel;Initial Catalog=Details;Integrated Security=True");
            conn.Open();
            string sql = "select Email from Signup where Email = '" + userEmail + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >= 1)
            {
                if (txtEmail.Text == "")
                {
                    lblLogin.Text = "Email required";
                    lblLogin.ForeColor = System.Drawing.Color.Red;
                }

                else
                {
                    lblLogin.Text = "Email successfully verified";
                    lblLogin.ForeColor = System.Drawing.Color.Green;
                }
            }

            else
            {
                lblLogin.Text = "Invalid email";
                lblLogin.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
