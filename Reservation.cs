using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Reservation : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-OBR8H7F\SQLEXPRESS;Database=HotelManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;");

        public Reservation()
        {
            InitializeComponent();
            LoadReservations(); // <<< Add this like Client.cs
        }


        private void Reservation_Load(object sender, EventArgs e)
        {
            try
            {
                LoadReservations(); // Load all reservations when form open
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservations at form load: " + ex.Message);
            }
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cmb_roomno.Text, out int roomNo))
            {
                if (roomNo <= 10)
                    txt_price.Text = "15000";
                else if (roomNo <= 20)
                    txt_price.Text = "30000";
                else if (roomNo <= 30)
                    txt_price.Text = "40000";
                else if (roomNo <= 40)
                    txt_price.Text = "80000";
            }
            else
            {
                MessageBox.Show("Please select a valid Room Number!");
            }
        }

        private void btn_calculate_Click_1(object sender, EventArgs e)
        {
            DateTime checkIn = dtp_checkin.Value;
            DateTime checkOut = dtp_checkout.Value;

            if (checkOut <= checkIn)
            {
                MessageBox.Show("Check-out date must be after check-in date.");
                txt_days.Text = "";
                txt_reservationamount.Text = "";
                return;
            }

            int no_of_days = (checkOut - checkIn).Days;
            txt_days.Text = no_of_days.ToString();

            string rawPrice = txt_price.Text.Replace(",", "").Trim();

            if (int.TryParse(rawPrice, out int pricePerNight))
            {
                int totalAmount = pricePerNight * no_of_days;
                txt_reservationamount.Text = totalAmount.ToString("N0"); // nicely formatted
            }
            else
            {
                MessageBox.Show("Please enter a valid price.");
                txt_reservationamount.Text = "";
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_reservationid.Text) ||
                string.IsNullOrWhiteSpace(txt_clientid.Text) ||
                string.IsNullOrWhiteSpace(cmb_roomno.Text))
            {
                MessageBox.Show("Please fill Reservation ID, Client ID, and Room Number.");
                return;
            }


            try
            {
                con.Open();
                string query = @"INSERT INTO Reservation (ReservationID, ClientID, RoomNumber, PricePerNight, CheckInDate, CheckOutDate, NumberOfDays, ReservationAmount)
                         VALUES (@ReservationID, @ClientID, @RoomNumber, @PricePerNight, @CheckInDate, @CheckOutDate, @NumberOfDays, @ReservationAmount)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", txt_reservationid.Text);
                    cmd.Parameters.AddWithValue("@ClientID", txt_clientid.Text);
                    cmd.Parameters.AddWithValue("@RoomNumber", cmb_roomno.Text);
                    cmd.Parameters.AddWithValue("@PricePerNight", decimal.Parse(txt_price.Text));
                    cmd.Parameters.AddWithValue("@CheckInDate", dtp_checkin.Value);
                    cmd.Parameters.AddWithValue("@CheckOutDate", dtp_checkout.Value);
                    cmd.Parameters.AddWithValue("@NumberOfDays", int.Parse(txt_days.Text.Trim()));
                    cmd.Parameters.AddWithValue("@ReservationAmount", decimal.Parse(txt_reservationamount.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation inserted successfully!");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting reservation: " + ex.Message);
            }
            finally
            {
                con.Close();  // Close first
            }

            LoadReservations();  // Then load table
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_reservationid.Text))
            {
                MessageBox.Show("Please enter Reservation ID to update.");
                return;
            }

            try
            {
                con.Open();
                string query = @"UPDATE Reservation 
                         SET ClientID = @ClientID, 
                             RoomNumber = @RoomNumber, 
                             PricePerNight = @PricePerNight, 
                             CheckInDate = @CheckInDate, 
                             CheckOutDate = @CheckOutDate, 
                             NumberOfDays = @NumberOfDays, 
                             ReservationAmount = @ReservationAmount 
                         WHERE ReservationID = @ReservationID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", txt_reservationid.Text.Trim());
                    cmd.Parameters.AddWithValue("@ClientID", txt_clientid.Text.Trim());
                    cmd.Parameters.AddWithValue("@RoomNumber", cmb_roomno.Text.Trim());
                    cmd.Parameters.AddWithValue("@PricePerNight", decimal.Parse(txt_price.Text.Trim()));
                    cmd.Parameters.AddWithValue("@CheckInDate", dtp_checkin.Value);
                    cmd.Parameters.AddWithValue("@CheckOutDate", dtp_checkout.Value);
                    cmd.Parameters.AddWithValue("@NumberOfDays", int.Parse(txt_days.Text.Trim()));
                    cmd.Parameters.AddWithValue("@ReservationAmount", decimal.Parse(txt_reservationamount.Text.Trim()));

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Reservation updated successfully!");
                    else
                        MessageBox.Show("Reservation not found!");

                    LoadReservations();  // Refresh DataGrid
                    ClearFields();       // Clear form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating reservation: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }




        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_reservationid.Text))
            {
                MessageBox.Show("Please enter Reservation ID to delete.");
                return;
            }

            try
            {
                con.Open();
                string query = "DELETE FROM Reservation WHERE ReservationID = @ReservationID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", txt_reservationid.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservation deleted successfully!");
                        ClearFields();
                        LoadReservations(); // Refresh the datagrid after delete
                    }
                    else
                    {
                        MessageBox.Show("Reservation not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting reservation: " + ex.Message);
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
                string query = "SELECT * FROM Reservation WHERE ReservationID = @ReservationID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", txt_reservationid.Text);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txt_clientid.Text = reader["ClientID"].ToString();
                        cmb_roomno.Text = reader["RoomNumber"].ToString();
                        txt_price.Text = reader["PricePerNight"].ToString();
                        dtp_checkin.Value = Convert.ToDateTime(reader["CheckInDate"]);
                        dtp_checkout.Value = Convert.ToDateTime(reader["CheckOutDate"]);
                        txt_days.Text = reader["NumberOfDays"].ToString();
                        txt_reservationamount.Text = reader["ReservationAmount"].ToString();

                        MessageBox.Show("Reservation found!");
                    }
                    else
                    {
                        MessageBox.Show("Reservation not found!");
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching reservation: " + ex.Message);
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


        private void LoadReservations()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); // If already open, close first
                }

                con.Open(); // Now open fresh
                string query = "SELECT * FROM Reservation";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_reservations.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservations: " + ex.Message);
            }
            finally
            {
                con.Close(); // Always close after
            }
        }




        private void ClearFields()
        {
            txt_reservationid.Text = "";
            txt_clientid.Text = "";
            cmb_roomno.Text = "";
            txt_price.Text = "";
            dtp_checkin.Value = DateTime.Today;
            dtp_checkout.Value = DateTime.Today;
            txt_days.Text = "";
            txt_reservationamount.Text = "";

            // New line to clear DataGridView selection
            dgv_reservations.ClearSelection();
        }


        private void dgv_reservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_reservations.Rows[e.RowIndex];
                txt_reservationid.Text = row.Cells["ReservationID"].Value.ToString();
                txt_clientid.Text = row.Cells["ClientID"].Value.ToString();
                cmb_roomno.Text = row.Cells["RoomNumber"].Value.ToString();
                txt_price.Text = row.Cells["PricePerNight"].Value.ToString();
                dtp_checkin.Value = Convert.ToDateTime(row.Cells["CheckInDate"].Value);
                dtp_checkout.Value = Convert.ToDateTime(row.Cells["CheckOutDate"].Value);
                txt_days.Text = row.Cells["NumberOfDays"].Value.ToString();
                txt_reservationamount.Text = row.Cells["ReservationAmount"].Value.ToString();
            }
        }

        private void LoadCurrentReservation(string reservationId)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                string query = "SELECT * FROM Reservation WHERE ReservationID = @ReservationID";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@ReservationID", reservationId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_reservations.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading current reservation: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
