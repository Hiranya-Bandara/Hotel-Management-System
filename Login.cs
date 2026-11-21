using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            SqlConnection con = new SqlConnection(@"Server=DESKTOP-OBR8H7F\SQLEXPRESS;Database=HotelManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;");



            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM [User] WHERE Username = @Username AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", txt_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txt_password.Text.Trim());

                    int count = (int)cmd.ExecuteScalar();

                    if (count >= 1)
                    {
                        MessageBox.Show("Login Successful!");
                        Homepage hp = new Homepage();
                        hp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed! Incorrect Username or Password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void linkLabel_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void cbx_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = cbx_showpassword.Checked ? '\0' : '*';
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
