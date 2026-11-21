using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Bill : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-OBR8H7F\SQLEXPRESS;Database=HotelManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;");

        public Bill()
        {
            InitializeComponent();
        }

        // Event handler for the back button click
        private void btn_back_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }

        // Event handler for fetching the bill details based on the Reservation ID
        private void btn_fetch_Click(object sender, EventArgs e)
        {
            // Ensure Reservation ID is entered
            if (string.IsNullOrWhiteSpace(txt_reservationid.Text))
            {
                MessageBox.Show("Please enter Reservation ID.");
                return;
            }

            int reservationId;
            if (!int.TryParse(txt_reservationid.Text.Trim(), out reservationId))
            {
                MessageBox.Show("Please enter a valid number for Reservation ID.");
                return;
            }

            try
            {
                con.Open();
                string query = "SELECT ReservationAmount, PoolAccess, TotalAmount, PaymentDate, Status FROM Payment WHERE ReservationID = @ReservationID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lbl_reservationAmount.Text = string.Format("{0:C}", Convert.ToDecimal(reader["ReservationAmount"])); // Format as currency
                    lbl_poolAccess.Text = reader["PoolAccess"].ToString();
                    lbl_totalAmount.Text = string.Format("{0:C}", Convert.ToDecimal(reader["TotalAmount"])); // Format as currency
                    lbl_paymentDate.Text = Convert.ToDateTime(reader["PaymentDate"]).ToShortDateString();
                    lbl_status.Text = reader["Status"].ToString();
                }
                else
                {
                    MessageBox.Show("No payment found for this Reservation ID!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching payment: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // Event handler for generating the bill content
        private void btn_generateBill_Click(object sender, EventArgs e)
        {
            string billContent = GenerateBillContent();

            // Display the bill content in the textbox
            txt_billDetails.Text = billContent;
            MessageBox.Show("Bill generated successfully!");
        }

        // Generate the bill content based on the selected reservation
        private string GenerateBillContent()
        {
            StringBuilder billContent = new StringBuilder();
            billContent.AppendLine("----- Payment Bill -----");
            billContent.AppendLine($"Reservation ID: {txt_reservationid.Text}");
            billContent.AppendLine($"Reservation Amount: {lbl_reservationAmount.Text}");
            billContent.AppendLine($"Pool Access: {lbl_poolAccess.Text}");
            billContent.AppendLine($"Total Amount: {lbl_totalAmount.Text}");
            billContent.AppendLine($"Payment Date: {lbl_paymentDate.Text}");
            billContent.AppendLine($"Status: {lbl_status.Text}");

            return billContent.ToString();
        }

        // Event handler for printing the bill
        private void btn_printBill_Click(object sender, EventArgs e)
        {
            // Ensure there's content to print
            if (string.IsNullOrWhiteSpace(txt_billDetails.Text))
            {
                MessageBox.Show("No bill details to print.");
                return;
            }

            // Create a PrintDialog to select the printer
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrinterSettings = printDialog.PrinterSettings;

                // Print the bill content
                printDoc.PrintPage += new PrintPageEventHandler((sender2, e2) =>
                {
                    e2.Graphics.DrawString(txt_billDetails.Text, new Font("Arial", 12), Brushes.Black, 10, 10);
                });

                printDoc.Print();
            }
        }
    }
}
