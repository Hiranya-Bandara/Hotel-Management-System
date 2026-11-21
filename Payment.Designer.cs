using System.Windows.Forms;

namespace HotelManagementSystem
{
    partial class Payment
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_reservationid = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_poolaccess = new System.Windows.Forms.TextBox();
            this.txt_totamount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_reservationamount = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dtp_paymentDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.dgv_payments = new System.Windows.Forms.DataGridView();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_billDetails = new System.Windows.Forms.Label();
            this.txt_billDetails = new System.Windows.Forms.TextBox();
            this.btn_generateBill = new System.Windows.Forms.Button();
            this.btn_printBill = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payments)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reservation ID :";
            // 
            // txt_reservationid
            // 
            this.txt_reservationid.Location = new System.Drawing.Point(214, 70);
            this.txt_reservationid.Name = "txt_reservationid";
            this.txt_reservationid.Size = new System.Drawing.Size(281, 35);
            this.txt_reservationid.TabIndex = 12;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Green;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clear.Location = new System.Drawing.Point(287, 446);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(128, 51);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Green;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(517, 380);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(128, 51);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Green;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(357, 380);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(128, 51);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Green;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(197, 380);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(128, 51);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.Green;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_insert.Location = new System.Drawing.Point(37, 380);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(128, 51);
            this.btn_insert.TabIndex = 17;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
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
            this.panel1.Size = new System.Drawing.Size(1437, 64);
            this.panel1.TabIndex = 19;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Green;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(602, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 41);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(269, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 40);
            this.label7.TabIndex = 0;
            this.label7.Text = "Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pool Access :";
            // 
            // txt_poolaccess
            // 
            this.txt_poolaccess.Location = new System.Drawing.Point(176, 189);
            this.txt_poolaccess.Name = "txt_poolaccess";
            this.txt_poolaccess.Size = new System.Drawing.Size(281, 35);
            this.txt_poolaccess.TabIndex = 12;
            // 
            // txt_totamount
            // 
            this.txt_totamount.Location = new System.Drawing.Point(197, 248);
            this.txt_totamount.Name = "txt_totamount";
            this.txt_totamount.Size = new System.Drawing.Size(281, 35);
            this.txt_totamount.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SeaGreen;
            this.label10.Location = new System.Drawing.Point(98, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(594, 22);
            this.label10.TabIndex = 43;
            this.label10.Text = "If the client has accessed the pool there will be additional 500rs/- charged";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(25, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "Reservation Amount :";
            // 
            // cmb_reservationamount
            // 
            this.cmb_reservationamount.FormattingEnabled = true;
            this.cmb_reservationamount.Location = new System.Drawing.Point(272, 120);
            this.cmb_reservationamount.Name = "cmb_reservationamount";
            this.cmb_reservationamount.Size = new System.Drawing.Size(260, 37);
            this.cmb_reservationamount.TabIndex = 46;
            // 
            // dtp_paymentDate
            // 
            this.dtp_paymentDate.Location = new System.Drawing.Point(197, 298);
            this.dtp_paymentDate.Name = "dtp_paymentDate";
            this.dtp_paymentDate.Size = new System.Drawing.Size(281, 35);
            this.dtp_paymentDate.TabIndex = 47;
            // 
            // cmb_status
            // 
            this.cmb_status.Items.AddRange(new object[] {
            "Paid",
            "Pending",
            "Cancelled"});
            this.cmb_status.Location = new System.Drawing.Point(197, 338);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(281, 37);
            this.cmb_status.TabIndex = 48;
            // 
            // dgv_payments
            // 
            this.dgv_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payments.Location = new System.Drawing.Point(764, 133);
            this.dgv_payments.Name = "dgv_payments";
            this.dgv_payments.RowHeadersWidth = 62;
            this.dgv_payments.Size = new System.Drawing.Size(574, 242);
            this.dgv_payments.TabIndex = 48;
            this.dgv_payments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_payments_CellClick);
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.Green;
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_calculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_calculate.Location = new System.Drawing.Point(517, 245);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(188, 68);
            this.btn_calculate.TabIndex = 44;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_billDetails
            // 
            this.lbl_billDetails.Location = new System.Drawing.Point(0, 0);
            this.lbl_billDetails.Name = "lbl_billDetails";
            this.lbl_billDetails.Size = new System.Drawing.Size(100, 23);
            this.lbl_billDetails.TabIndex = 0;
            // 
            // txt_billDetails
            // 
            this.txt_billDetails.Location = new System.Drawing.Point(0, 0);
            this.txt_billDetails.Name = "txt_billDetails";
            this.txt_billDetails.Size = new System.Drawing.Size(100, 26);
            this.txt_billDetails.TabIndex = 0;
            // 
            // btn_generateBill
            // 
            this.btn_generateBill.Location = new System.Drawing.Point(0, 0);
            this.btn_generateBill.Name = "btn_generateBill";
            this.btn_generateBill.Size = new System.Drawing.Size(75, 23);
            this.btn_generateBill.TabIndex = 0;
            // 
            // btn_printBill
            // 
            this.btn_printBill.BackColor = System.Drawing.Color.Green;
            this.btn_printBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_printBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_printBill.Location = new System.Drawing.Point(764, 414);
            this.btn_printBill.Name = "btn_printBill";
            this.btn_printBill.Size = new System.Drawing.Size(128, 51);
            this.btn_printBill.TabIndex = 13;
            this.btn_printBill.Text = "Print Bill";
            this.btn_printBill.UseVisualStyleBackColor = false;
            this.btn_printBill.Click += new System.EventHandler(this.btn_printBill_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 552);
            this.Controls.Add(this.btn_printBill);
            this.Controls.Add(this.cmb_reservationamount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_totamount);
            this.Controls.Add(this.txt_poolaccess);
            this.Controls.Add(this.txt_reservationid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_paymentDate);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.dgv_payments);
            this.Controls.Add(this.btn_calculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_reservationid;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_poolaccess;
        private System.Windows.Forms.TextBox txt_totamount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_reservationamount;
        private System.Windows.Forms.ColorDialog colorDialog1;
        // Inside your class Payment
        private System.Windows.Forms.DateTimePicker dtp_paymentDate;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.DataGridView dgv_payments;

        private System.Windows.Forms.Label lbl_billDetails;
        private System.Windows.Forms.TextBox txt_billDetails;
        private System.Windows.Forms.Button btn_generateBill;
        private System.Windows.Forms.Button btn_printBill;






    }

}
