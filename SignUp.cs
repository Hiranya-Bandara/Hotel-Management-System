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

namespace HotelManagementSystem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            SqlConnection con = new SqlConnection(@"Server=DESKTOP-OBR8H7F\SQLEXPRESS;Database=HotelManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;");




            try
            {
                con.Open();

                string insertUser = "INSERT INTO [User] (Email, Username, Password) VALUES (@Email, @Username, @Password)";

                using (SqlCommand cmd = new SqlCommand(insertUser, con))
                {
                    cmd.Parameters.AddWithValue("@Email", txt_email.Text.Trim());
                    cmd.Parameters.AddWithValue("@Username", txt_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txt_password.Text.Trim());

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sign Up Successful! Now you can login.");
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sign Up Failed!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void linkLabel_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void cbx_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = cbx_showpassword.Checked ? '\0' : '*';
        }
    }
}
