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
    public partial class Welcome : Form
    {
        string userEmail = "";
        public Welcome()
        {
            InitializeComponent();     
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            lblLogin.Text = "" + Login.settext;
            txtEmail.Text = Login.settext;
            //userEmail = Login.settext;
            //userEmail = txtEmail.Text;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            userEmail = txtEmail.Text;
            SqlConnection conn = new SqlConnection("Data Source=Mugurel;Initial Catalog=Details;Integrated Security=True");
            conn.Open();
            string query = "select Email from Signup where Email = '" + txtEmail.Text + "' and Password = '" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            userEmail = Login.settext;

            if (txtPassword.Text != "")
            {
                cmd.CommandText = "Update Signup set Password='" + txtPassword.Text + "' where Email='" + userEmail + "'";
                cmd.ExecuteNonQuery();
                lblAlert.Text = "Password has been set/updated";
                lblAlert.ForeColor = System.Drawing.Color.Green;
            }

            else
            {
                lblAlert.Text = "Password not set, try again!";
                lblAlert.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
