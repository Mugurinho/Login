using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class GenerateLogin : Form
    {
        public static string settext = "";
        private bool btnEmail = false;
        string userEmail = "";

        public GenerateLogin()
        {
            InitializeComponent();
        }

        private void GenerateLogin_Load(object sender, EventArgs e)
        {
            txtGeneratedKeyDisplay.Hide();
            lblGeneratedKeyDisplay.Hide();
            //txtGenerator.Hide();
            if (txtEmail.Text == "")
            {
                btnEmailKey.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userEmail = txtEmail.Text;
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

                else if (txtGeneratedKeyInsert.Text == "" || txtGeneratedKeyDisplay.Text == "")
                {
                    lblLogin.Text = "Unique key required";
                    lblLogin.ForeColor = System.Drawing.Color.Red;
                }


                else if(txtGeneratedKeyInsert.Text == txtGeneratedKeyDisplay.Text)
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
                lblLogin.Text = "Email and generated key required";
                lblLogin.ForeColor = System.Drawing.Color.Red;
                txtGeneratedKeyInsert.Text = "";
                Random newrnd = new Random();
                int newrndnumber = newrnd.Next(1, 500000);
                txtGeneratedKeyDisplay.Text = newrndnumber.ToString();
                txtGeneratedKeyDisplay.Hide();
            }
        }

        private void txtGenerator_TextChanged(object sender, EventArgs e)
        {
            if (txtGeneratedKeyInsert.Text == "" || txtGeneratedKeyInsert.Text != txtGeneratedKeyDisplay.Text)
            {
                lblLogin.Text = "Invalid unique key";
                lblLogin.ForeColor = System.Drawing.Color.Red;
            }
            else if (txtGeneratedKeyInsert.Text == txtGeneratedKeyDisplay.Text)
            {
                lblLogin.Text = "Unique key successfully verified";
                lblLogin.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            userEmail = txtEmail.Text;
            //select email from db is true generate key, else no key generated
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
                    btnEmailKey.Enabled = false;
                }

                else
                {
                    btnEmailKey.Enabled = true;
                    lblLogin.Text = "Email successfully verified";
                    lblLogin.ForeColor = System.Drawing.Color.Green;
                }
            }

            else
            {
                lblLogin.Text = "Invalid email";
                lblLogin.ForeColor = System.Drawing.Color.Red;
                btnEmailKey.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmailKey_Click(object sender, EventArgs e)
        {
            userEmail = txtEmail.Text;
            Random rnd = new Random();
            int rndnumber = rnd.Next(1, 500000);
            txtGeneratedKeyDisplay.Text = rndnumber.ToString();
            txtGeneratedKeyDisplay.Hide();
            btnEmail = true;
            
            if (btnEmail)
            {
                lblLogin.Text = "Unique key successfully generated";
                lblLogin.ForeColor = System.Drawing.Color.Green;
                //added last as optional > it works but there is no more need for insert unique key text if implemented.
                //btnLogin.Text = txtGeneratedKeyDisplay.Text;
                //btnLogin.ForeColor = System.Drawing.Color.Green;
            }

            // Command line argument must the the SMTP host.
            // To send and receive emails: Allow less secure apps: ONhttps://myaccount.google.com/lesssecureapps
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("mugurel.budara@gmail.com", "andrei16gle");

            MailMessage mm = new MailMessage("donotreply@domain.com", userEmail, "New key requested" , "Hi, " + userEmail.ToString() + "\nYour unique generated key is: " + rndnumber.ToString());
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void lblGeneratedKeyDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
