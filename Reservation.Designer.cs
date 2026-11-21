using System.Windows.Forms;

namespace HotelManagementSystem
{
    partial class Reservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            

            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gb_reseravation = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_roomno = new System.Windows.Forms.ComboBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.dtp_checkout = new System.Windows.Forms.DateTimePicker();
            this.dtp_checkin = new System.Windows.Forms.DateTimePicker();
            this.txt_reservationid = new System.Windows.Forms.TextBox();
            this.txt_clientid = new System.Windows.Forms.TextBox();
            this.txt_reservationamount = new System.Windows.Forms.TextBox();
            this.txt_days = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_reservations = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gb_reseravation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 56);
            this.panel1.TabIndex = 8;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Green;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(596, 11);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(68, 31);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(237, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 40);
            this.label7.TabIndex = 0;
            this.label7.Text = "Reservation";
            // 
            // gb_reseravation
            // 
            this.gb_reseravation.Controls.Add(this.label11);
            this.gb_reseravation.Controls.Add(this.label10);
            this.gb_reseravation.Controls.Add(this.cmb_roomno);
            this.gb_reseravation.Controls.Add(this.btn_check);
            this.gb_reseravation.Controls.Add(this.txt_price);
            this.gb_reseravation.Controls.Add(this.label9);
            this.gb_reseravation.Controls.Add(this.btn_clear);
            this.gb_reseravation.Controls.Add(this.btn_calculate);
            this.gb_reseravation.Controls.Add(this.btn_search);
            this.gb_reseravation.Controls.Add(this.btn_delete);
            this.gb_reseravation.Controls.Add(this.btn_update);
            this.gb_reseravation.Controls.Add(this.btn_insert);
            this.gb_reseravation.Controls.Add(this.dtp_checkout);
            this.gb_reseravation.Controls.Add(this.dtp_checkin);
            this.gb_reseravation.Controls.Add(this.txt_reservationid);
            this.gb_reseravation.Controls.Add(this.txt_clientid);
            this.gb_reseravation.Controls.Add(this.txt_reservationamount);
            this.gb_reseravation.Controls.Add(this.txt_days);
            this.gb_reseravation.Controls.Add(this.label6);
            this.gb_reseravation.Controls.Add(this.label5);
            this.gb_reseravation.Controls.Add(this.label8);
            this.gb_reseravation.Controls.Add(this.label4);
            this.gb_reseravation.Controls.Add(this.label3);
            this.gb_reseravation.Controls.Add(this.label2);
            this.gb_reseravation.Controls.Add(this.label1);
            this.gb_reseravation.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.gb_reseravation.Location = new System.Drawing.Point(12, 75);
            this.gb_reseravation.Name = "gb_reseravation";
            this.gb_reseravation.Size = new System.Drawing.Size(640, 533);
            this.gb_reseravation.TabIndex = 18;
            this.gb_reseravation.TabStop = false;
            this.gb_reseravation.Text = "Reservation Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(110, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(621, 22);
            this.label11.TabIndex = 42;
            this.label11.Text = "Click on \"Calculate\" button to see the no of days and the reservation amount.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(100, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(634, 22);
            this.label10.TabIndex = 42;
            this.label10.Text = "Select the room Number and click on \"Check\" button to see the price per night.";
            // 
            // cmb_roomno
            // 
            this.cmb_roomno.FormattingEnabled = true;
            this.cmb_roomno.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.cmb_roomno.Location = new System.Drawing.Point(181, 154);
            this.cmb_roomno.Name = "cmb_roomno";
            this.cmb_roomno.Size = new System.Drawing.Size(281, 37);
            this.cmb_roomno.TabIndex = 41;
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.Green;
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_check.Location = new System.Drawing.Point(489, 146);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(100, 36);
            this.btn_check.TabIndex = 40;
            this.btn_check.Text = "Check ";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(181, 208);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(281, 35);
            this.txt_price.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(9, 208);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 29);
            this.label9.TabIndex = 38;
            this.label9.Text = "Price per Night :";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Green;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clear.Location = new System.Drawing.Point(283, 461);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(128, 51);
            this.btn_clear.TabIndex = 32;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.Green;
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_calculate.Location = new System.Drawing.Point(489, 371);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(128, 38);
            this.btn_calculate.TabIndex = 34;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click_1);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Green;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(489, 44);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(128, 51);
            this.btn_search.TabIndex = 33;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Green;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(436, 461);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(128, 51);
            this.btn_delete.TabIndex = 35;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Green;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(149, 461);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(128, 51);
            this.btn_update.TabIndex = 36;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.Green;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_insert.Location = new System.Drawing.Point(9, 461);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(128, 51);
            this.btn_insert.TabIndex = 37;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // dtp_checkout
            // 
            this.dtp_checkout.Location = new System.Drawing.Point(181, 298);
            this.dtp_checkout.Name = "dtp_checkout";
            this.dtp_checkout.Size = new System.Drawing.Size(281, 35);
            this.dtp_checkout.TabIndex = 31;
            // 
            // dtp_checkin
            // 
            this.dtp_checkin.Location = new System.Drawing.Point(181, 255);
            this.dtp_checkin.Name = "dtp_checkin";
            this.dtp_checkin.Size = new System.Drawing.Size(281, 35);
            this.dtp_checkin.TabIndex = 30;
            // 
            // txt_reservationid
            // 
            this.txt_reservationid.Location = new System.Drawing.Point(181, 58);
            this.txt_reservationid.Name = "txt_reservationid";
            this.txt_reservationid.Size = new System.Drawing.Size(281, 35);
            this.txt_reservationid.TabIndex = 29;
            // 
            // txt_clientid
            // 
            this.txt_clientid.Location = new System.Drawing.Point(181, 106);
            this.txt_clientid.Name = "txt_clientid";
            this.txt_clientid.Size = new System.Drawing.Size(281, 35);
            this.txt_clientid.TabIndex = 28;
            // 
            // txt_reservationamount
            // 
            this.txt_reservationamount.Location = new System.Drawing.Point(181, 398);
            this.txt_reservationamount.Name = "txt_reservationamount";
            this.txt_reservationamount.Size = new System.Drawing.Size(281, 35);
            this.txt_reservationamount.TabIndex = 27;
            // 
            // txt_days
            // 
            this.txt_days.Location = new System.Drawing.Point(181, 350);
            this.txt_days.Name = "txt_days";
            this.txt_days.Size = new System.Drawing.Size(281, 35);
            this.txt_days.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(9, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Reservation ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(9, 401);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Reservation Amount :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(9, 353);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Days :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(9, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Check Out :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(9, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Check In :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(9, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Room Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Client ID :";
            // 



            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);

            // dgv_reservations
            // 
            this.dgv_reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservations.Location = new System.Drawing.Point(679, 181);
            this.dgv_reservations.Name = "dgv_reservations";
            this.dgv_reservations.RowHeadersWidth = 62;
            this.dgv_reservations.Size = new System.Drawing.Size(612, 270);
            this.dgv_reservations.TabIndex = 51;
            this.dgv_reservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reservations_CellClick);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 739);
            this.Controls.Add(this.gb_reseravation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_reservations);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_reseravation.ResumeLayout(false);
            this.gb_reseravation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservations)).EndInit();
            this.ResumeLayout(false);


            this.txt_price.ReadOnly = true;

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.GroupBox gb_reseravation;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DateTimePicker dtp_checkout;
        private System.Windows.Forms.DateTimePicker dtp_checkin;
        private System.Windows.Forms.TextBox txt_reservationid;
        private System.Windows.Forms.TextBox txt_clientid;
        private System.Windows.Forms.TextBox txt_reservationamount;
        private System.Windows.Forms.TextBox txt_days;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.ComboBox cmb_roomno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_reservations;


    }
}