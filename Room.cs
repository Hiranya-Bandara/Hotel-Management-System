using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Room : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-OBR8H7F\SQLEXPRESS;Database=HotelManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;");

        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            LoadRooms();

            // Add these 2 lines
            txt_price.ReadOnly = true;
            txt_type.ReadOnly = true;



            for (int i = 1; i <= 40; i++)
            {
                cmb_roomno.Items.Add(i.ToString());
            }

        }



        private void btn_back_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // No action needed
        }
        private void LoadRooms()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();   // First close if already open

                con.Open();
                string query = "SELECT * FROM Room";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_rooms.DataSource = dt;

                // Optional: make room table also neat
                dgv_rooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_rooms.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        private void ClearFields()
        {
            cmb_roomno.Text = "";
            txt_type.Text = "";
            txt_price.Text = "";
            txt_status.Text = "";
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmb_roomno.Text))
            {
                MessageBox.Show("Please select or enter Room Number.");
                return;
            }


            try
            {
                con.Open();
                string query = "INSERT INTO Room (RoomNumber, Type, PricePerNight, Status) VALUES (@RoomNumber, @Type, @PricePerNight, @Status)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RoomNumber", int.Parse(cmb_roomno.Text));
                    cmd.Parameters.AddWithValue("@Type", txt_type.Text);
                    cmd.Parameters.AddWithValue("@PricePerNight", decimal.Parse(txt_price.Text));
                    cmd.Parameters.AddWithValue("@Status", txt_status.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room inserted successfully!");
                    ClearFields();
                    LoadRooms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting room: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmb_roomno.Text))
            {
                MessageBox.Show("Please select or enter Room Number.");
                return;
            }


            try
            {
                con.Open();
                string query = "UPDATE Room SET Type=@Type, PricePerNight=@PricePerNight, Status=@Status WHERE RoomNumber=@RoomNumber";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RoomNumber", int.Parse(cmb_roomno.Text));
                    cmd.Parameters.AddWithValue("@Type", txt_type.Text);
                    cmd.Parameters.AddWithValue("@PricePerNight", decimal.Parse(txt_price.Text));
                    cmd.Parameters.AddWithValue("@Status", txt_status.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Room updated successfully!");
                    else
                        MessageBox.Show("Room not found!");

                    ClearFields();
                    LoadRooms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating room: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmb_roomno.Text))
            {
                MessageBox.Show("Please select or enter Room Number.");
                return;
            }


            try
            {
                con.Open();
                string query = "DELETE FROM Room WHERE RoomNumber=@RoomNumber";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RoomNumber", int.Parse(cmb_roomno.Text));

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Room deleted successfully!");
                    else
                        MessageBox.Show("Room not found!");

                    ClearFields();
                    LoadRooms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting room: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmb_roomno.Text))
            {
                MessageBox.Show("Please select or enter Room Number.");
                return;
            }


            try
            {
                con.Open();
                string query = "SELECT * FROM Room WHERE RoomNumber=@RoomNumber";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RoomNumber", int.Parse(cmb_roomno.Text));

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txt_type.Text = reader["Type"].ToString();
                        txt_price.Text = reader["PricePerNight"].ToString();
                        txt_status.Text = reader["Status"].ToString();
                        MessageBox.Show("Room found!");
                    }
                    else
                    {
                        MessageBox.Show("Room not found!");
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching room: " + ex.Message);
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

        private void dgv_rooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_rooms.Rows[e.RowIndex];
                cmb_roomno.Text = row.Cells["RoomNumber"].Value.ToString();
                txt_type.Text = row.Cells["Type"].Value.ToString();
                txt_price.Text = row.Cells["PricePerNight"].Value.ToString();
                txt_status.Text = row.Cells["Status"].Value.ToString();
            }
        }

        int count;
        private void btn_check_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cmb_roomno.Text, out count))
            {
                MessageBox.Show("Invalid Room Number entered.");
                return;
            }


            else if (count <= 10)
            {
                txt_type.Text = "Single Room";
                txt_price.Text = "15000";
            }
            else if (count > 10 && count <= 20)
            {
                txt_type.Text = "Double Room";
                txt_price.Text = "30000";
            }
            else if (count > 20 && count <= 30)
            {
                txt_type.Text = "Twin Room";
                txt_price.Text = "40000";
            }
            else if (count > 30 && count <= 40)
            {
                txt_type.Text = "Family Suit";
                txt_price.Text = "80000";
            }
        }
    }
}
