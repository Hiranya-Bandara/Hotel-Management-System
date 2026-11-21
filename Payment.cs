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
using System.Drawing.Printing;

namespace HotelManagementSystem
{
    public partial class Payment : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-OBR8H7F\SQLEXPRESS;Database=HotelManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;");
        public Payment()
        {
            InitializeComponent();
            LoadPayments();

        }



        private void dgv_payments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_payments.Rows[e.RowIndex];

                // Populate the text box or any other controls with the selected row details
                txt_reservationid.Text = row.Cells["ReservationID"].Value.ToString();
                txt_poolaccess.Text = row.Cells["PoolAccess"].Value.ToString();
                txt_totamount.Text = row.Cells["TotalAmount"].Value.ToString();
                cmb_reservationamount.Text = row.Cells["ReservationAmount"].Value.ToString();

                // Fill in the bill details for printing
                txt_billDetails.Text = GenerateBillContent(row);
            }
        }

        // Generate the bill content from the selected row
        private string GenerateBillContent(DataGridViewRow row)
        {
            StringBuilder billContent = new StringBuilder();
            billContent.AppendLine("----- Payment Bill -----");
            billContent.AppendLine($"Reservation ID: {row.Cells["ReservationID"].Value}");
            billContent.AppendLine($"Reservation Amount: {row.Cells["ReservationAmount"].Value}");
            billContent.AppendLine($"Pool Access: {row.Cells["PoolAccess"].Value}");
            billContent.AppendLine($"Total Amount: {row.Cells["TotalAmount"].Value}");
            billContent.AppendLine($"Payment Date: {DateTime.Now.ToShortDateString()}"); // Current date
            billContent.AppendLine($"Status: {row.Cells["Status"].Value}");

            return billContent.ToString();
        }



        private void btn_back_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                // Auto calculate before insert
                btn_calculate_Click(sender, e);

                if (string.IsNullOrWhiteSpace(txt_reservationid.Text) ||
                    cmb_reservationamount.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txt_poolaccess.Text) ||
                    cmb_status.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txt_totamount.Text))
                {
                    MessageBox.Show("Please fill all fields before inserting.");
                    return;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Payment
            (ReservationID, ReservationAmount, PoolAccess, TotalAmount, PaymentDate, Status) 
            VALUES (@ReservationID, @ReservationAmount, @PoolAccess, @TotalAmount, @PaymentDate, @Status)", con);

                cmd.Parameters.AddWithValue("@ReservationID", int.Parse(txt_reservationid.Text.Trim()));
                cmd.Parameters.AddWithValue("@ReservationAmount", decimal.Parse(cmb_reservationamount.Text.Trim()));
                cmd.Parameters.AddWithValue("@PoolAccess", txt_poolaccess.Text.Trim());
                cmd.Parameters.AddWithValue("@TotalAmount", decimal.Parse(txt_totamount.Text.Trim()));
                cmd.Parameters.AddWithValue("@PaymentDate", dtp_paymentDate.Value.Date);
                cmd.Parameters.AddWithValue("@Status", cmb_status.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Payment inserted successfully!");
                ClearFields();
                LoadPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting payment: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }




        private void ClearFields()
        {
            txt_reservationid.Text = "";
            cmb_reservationamount.SelectedIndex = -1;
            txt_poolaccess.Text = "";
            txt_totamount.Text = "";
            dtp_paymentDate.Value = DateTime.Today;
            cmb_status.SelectedIndex = -1;
        }



        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Server=DESKTOP-OBR8H7F\SQLEXPRESS;Database=HotelManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    con.Open();
                    string query = @"UPDATE Payment 
                             SET ReservationAmount = @ReservationAmount, PoolAccess = @PoolAccess, TotalAmount = @TotalAmount 
                             WHERE ReservationID = @ReservationID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", txt_reservationid.Text.Trim());
                        cmd.Parameters.AddWithValue("@ReservationAmount", cmb_reservationamount.Text.Trim());
                        cmd.Parameters.AddWithValue("@PoolAccess", txt_poolaccess.Text.Trim());
                        cmd.Parameters.AddWithValue("@TotalAmount", txt_totamount.Text.Trim());

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                            MessageBox.Show("Payment updated successfully!");
                        else
                            MessageBox.Show("Payment not found!");

                        ClearFields();

                        LoadPayments();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Payment: " + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Server=DESKTOP-OBR8H7F\SQLEXPRESS;Database=HotelManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    con.Open();
                    string query = "DELETE FROM Payment WHERE ReservationID = @ReservationID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", txt_reservationid.Text.Trim());

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                            MessageBox.Show("Payment deleted successfully!");
                        else
                            MessageBox.Show("Payment not found!");

                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting Payment: " + ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Server=DESKTOP-OBR8H7F\SQLEXPRESS;Database=HotelManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    con.Open();
                    string query = "SELECT * FROM Payment WHERE ReservationID = @ReservationID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", txt_reservationid.Text.Trim());

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            cmb_reservationamount.Text = reader["ReservationAmount"].ToString();
                            txt_poolaccess.Text = reader["PoolAccess"].ToString();
                            txt_totamount.Text = reader["TotalAmount"].ToString();
                            MessageBox.Show("Payment found!");
                        }
                        else
                        {
                            MessageBox.Show("Payment not found!");
                            ClearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching Payment: " + ex.Message);
            }
        }


        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cmb_reservationamount.Text))
                {
                    MessageBox.Show("Please select or enter a Reservation Amount.");
                    return;
                }

                decimal reservationAmount;
                if (!decimal.TryParse(cmb_reservationamount.Text.Trim(), out reservationAmount))
                {
                    MessageBox.Show("Invalid Reservation Amount.");
                    return;
                }

                string poolAccess = txt_poolaccess.Text.Trim().ToLower();
                decimal additionalCharge = 0;

                if (poolAccess == "yes")
                {
                    additionalCharge = 500;
                }
                else if (poolAccess == "no")
                {
                    additionalCharge = 0;
                }
                else
                {
                    MessageBox.Show("Please enter 'yes' or 'no' for Pool Access.");
                    return;
                }

                decimal totalAmount = reservationAmount + additionalCharge;
                txt_totamount.Text = totalAmount.ToString("N2"); // 2 decimal format
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total amount: " + ex.Message);
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Server=DESKTOP-OBR8H7F\SQLEXPRESS;Database=HotelManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    con.Open();
                    string query = "SELECT DISTINCT ReservationAmount FROM Reservation";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmb_reservationamount.Items.Add(reader["ReservationAmount"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Reservation Amounts: " + ex.Message);
            }

            LoadPayments(); // <--- Important, don't forget
        }


        private void LoadPayments()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                string query = @"SELECT 
                        PaymentID,
                        ReservationID,
                        ReservationAmount,
                        PoolAccess,
                        TotalAmount,
                        PaymentDate,
                        Status
                     FROM Payment";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_payments.DataSource = dt;

                // Set nice headers
                dgv_payments.Columns["PaymentID"].HeaderText = "Payment ID";
                dgv_payments.Columns["ReservationID"].HeaderText = "Reservation ID";
                dgv_payments.Columns["ReservationAmount"].HeaderText = "Reservation Amount (Rs.)";
                dgv_payments.Columns["PoolAccess"].HeaderText = "Pool Access";
                dgv_payments.Columns["TotalAmount"].HeaderText = "Total Amount (Rs.)";
                dgv_payments.Columns["PaymentDate"].HeaderText = "Payment Date";
                dgv_payments.Columns["Status"].HeaderText = "Status";

                // Important - Auto Size
                dgv_payments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_payments.AutoResizeColumns(); // <<< Add this to resize based on contents

                // Optional: You can also set minimum width
                foreach (DataGridViewColumn column in dgv_payments.Columns)
                {
                    column.MinimumWidth = 100;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void btn_printBill_Click(object sender, EventArgs e)
        {
            // Ensure there's content to print
            if (string.IsNullOrWhiteSpace(txt_billDetails.Text))
            {
                MessageBox.Show("No bill details to print.");
                return;
            }

            // Create a PrintDialog to select a printer
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a PrintDocument object
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrinterSettings = printDialog.PrinterSettings;

                // Attach the PrintPage event to handle the actual printing
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);

                // Start printing
                printDoc.Print();
            }
        }

        

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Get the bill details from the TextBox
            string billDetails = txt_billDetails.Text;

            // Define fonts
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font contentFont = new Font("Arial", 12);
            Font valueFont = new Font("Arial", 12, FontStyle.Italic);

            // Define brushes for color
            Brush titleBrush = Brushes.Green;
            Brush contentBrush = Brushes.Black;
            Brush valueBrush = Brushes.DarkSlateGray;

            // Set the starting point for drawing text
            float xPos = 100;
            float yPos = 100;

            // Draw the title
            e.Graphics.DrawString("----- Payment Bill -----", titleFont, titleBrush, xPos, yPos);
            yPos += 30; // Adjust Y position for the next line

            // Draw the rest of the details
            e.Graphics.DrawString("Reservation ID: ", contentFont, contentBrush, xPos, yPos);
            e.Graphics.DrawString(txt_reservationid.Text, valueFont, valueBrush, xPos + 200, yPos);
            yPos += 25;

            e.Graphics.DrawString("Reservation Amount: ", contentFont, contentBrush, xPos, yPos);
            e.Graphics.DrawString(cmb_reservationamount.Text, valueFont, valueBrush, xPos + 200, yPos);
            yPos += 25;

            e.Graphics.DrawString("Pool Access: ", contentFont, contentBrush, xPos, yPos);
            e.Graphics.DrawString(txt_poolaccess.Text, valueFont, valueBrush, xPos + 200, yPos);
            yPos += 25;

            e.Graphics.DrawString("Total Amount: ", contentFont, contentBrush, xPos, yPos);
            e.Graphics.DrawString(txt_totamount.Text, valueFont, valueBrush, xPos + 200, yPos);
            yPos += 25;

            e.Graphics.DrawString("Payment Date: ", contentFont, contentBrush, xPos, yPos);
            e.Graphics.DrawString(dtp_paymentDate.Value.ToShortDateString(), valueFont, valueBrush, xPos + 200, yPos);
            yPos += 25;

            e.Graphics.DrawString("Status: ", contentFont, contentBrush, xPos, yPos);
            e.Graphics.DrawString(cmb_status.Text, valueFont, valueBrush, xPos + 200, yPos);

            // Optionally, you can add a line to separate the bill details
            e.Graphics.DrawLine(Pens.Black, xPos, yPos + 25, xPos + 400, yPos + 25);
        }

        // The PrintPage event handler




        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Get the text to be printed from the TextBox (the bill content)
            string billContent = txt_billDetails.Text;

            // Set up a font and brush to print the text
            Font printFont = new Font("Arial", 12); // You can customize the font as needed
            Brush printBrush = Brushes.Black;

            // Define a position to start printing on the page
            float yPos = 10;
            float leftMargin = 10;

            // Print the content to the page
            e.Graphics.DrawString(billContent, printFont, printBrush, leftMargin, yPos);
        }
        private void btn_generateBill_Click(object sender, EventArgs e)
        {
            // Retrieve reservation information from the database or controls
            string reservationId = txt_reservationid.Text.Trim();
            string reservationAmount = cmb_reservationamount.SelectedItem.ToString();
            string poolAccess = txt_poolaccess.Text.Trim();
            string totalAmount = txt_totamount.Text.Trim();
            string paymentDate = dtp_paymentDate.Value.ToShortDateString();
            string status = cmb_status.SelectedItem.ToString();

            // Build the bill content
            StringBuilder billContent = new StringBuilder();
            billContent.AppendLine("---- Payment Bill ----");
            billContent.AppendLine($"Reservation ID: {reservationId}");
            billContent.AppendLine($"Reservation Amount: {reservationAmount}");
            billContent.AppendLine($"Pool Access: {poolAccess}");
            billContent.AppendLine($"Total Amount: {totalAmount}");
            billContent.AppendLine($"Payment Date: {paymentDate}");
            billContent.AppendLine($"Status: {status}");

            // Display in the bill details text box or message box
            txt_billDetails.Text = billContent.ToString();
            MessageBox.Show("Bill generated successfully!");
        }



    }
}