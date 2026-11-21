using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{


    public partial class Client : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True;TrustServerCertificate=True");

        public Client()
        {
            InitializeComponent();
            LoadClients(); // <<< ADD this here
        }


        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_clientid.Text) || string.IsNullOrWhiteSpace(txt_name.Text))
            {
                MessageBox.Show("Please fill required fields.");
                return;
            }

            try
            {
                con.Open();
                string query = "INSERT INTO Client (ClientID, Name, NIC, Email, Contact, Address) VALUES (@ClientID, @Name, @NIC, @Email, @Contact, @Address)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ClientID", txt_clientid.Text);
                    cmd.Parameters.AddWithValue("@Name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@NIC", txt_nic.Text);
                    cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@Contact", txt_contact.Text);
                    cmd.Parameters.AddWithValue("@Address", txt_address.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client inserted successfully!");
                    ClearFields();
                    LoadClients(); // <<< very important
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting client: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_clientid.Text) || string.IsNullOrWhiteSpace(txt_name.Text))
            {
                MessageBox.Show("Please fill required fields.");
                return;
            }

            try
            {
                con.Open();
                string query = "UPDATE Client SET Name=@Name, NIC=@NIC, Email=@Email, Contact=@Contact, Address=@Address WHERE ClientID=@ClientID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ClientID", txt_clientid.Text);
                    cmd.Parameters.AddWithValue("@Name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@NIC", txt_nic.Text);
                    cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@Contact", txt_contact.Text);
                    cmd.Parameters.AddWithValue("@Address", txt_address.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Client updated successfully!");
                    else
                        MessageBox.Show("Client not found!");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating client: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Client WHERE ClientID=@ClientID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ClientID", txt_clientid.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Client deleted successfully!");
                        ClearFields();
                        LoadClients(); // <<< 🚀 ADD THIS LINE to refresh after deleting
                    }
                    else
                    {
                        MessageBox.Show("Client not found!");
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting client: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Client WHERE ClientID=@ClientID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ClientID", txt_clientid.Text);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txt_name.Text = reader["Name"].ToString();
                        txt_nic.Text = reader["NIC"].ToString();
                        txt_email.Text = reader["Email"].ToString();
                        txt_contact.Text = reader["Contact"].ToString();
                        txt_address.Text = reader["Address"].ToString();
                        MessageBox.Show("Client found!");
                    }
                    else
                    {
                        MessageBox.Show("Client not found!");
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching client: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txt_clientid.Text = "";
            txt_name.Text = "";
            txt_nic.Text = "";
            txt_email.Text = "";
            txt_contact.Text = "";
            txt_address.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }

        private void LoadClients()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Client";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_clients.DataSource = dt;

                // Bonus for better look
                dgv_clients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_clients.AutoResizeColumns();
                dgv_clients.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dgv_clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_clients.Rows[e.RowIndex];
                txt_clientid.Text = row.Cells["ClientID"].Value.ToString();
                txt_name.Text = row.Cells["Name"].Value.ToString();
                txt_nic.Text = row.Cells["NIC"].Value.ToString();
                txt_email.Text = row.Cells["Email"].Value.ToString();
                txt_contact.Text = row.Cells["Contact"].Value.ToString();
                txt_address.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void dgv_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
