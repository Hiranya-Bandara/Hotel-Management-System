using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            Client ct = new Client();
            ct.Show();
            this.Hide();
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            Room rm = new Room();
            rm.Show();
            this.Hide();
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            Reservation rs = new Reservation();
            rs.Show();
            this.Hide();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            Payment pt = new Payment();
            pt.Show();
            this.Hide();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            // Open the Bill form when the button is clicked
            Bill billForm = new Bill();
            billForm.Show();
            this.Hide(); // Hide the Homepage form
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
