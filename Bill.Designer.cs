namespace HotelManagementSystem
{
    partial class Bill
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_reservationid = new System.Windows.Forms.TextBox();
            this.btn_fetch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_reservationAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_poolAccess = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_totalAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_paymentDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_billDetails = new System.Windows.Forms.TextBox();
            this.btn_generateBill = new System.Windows.Forms.Button();
            this.btn_printBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reservation ID:";
            // 
            // txt_reservationid
            // 
            this.txt_reservationid.Location = new System.Drawing.Point(161, 19);
            this.txt_reservationid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_reservationid.Name = "txt_reservationid";
            this.txt_reservationid.Size = new System.Drawing.Size(130, 26);
            this.txt_reservationid.TabIndex = 12;
            // 
            // btn_fetch
            // 
            this.btn_fetch.BackColor = System.Drawing.Color.Green;
            this.btn_fetch.ForeColor = System.Drawing.Color.White;
            this.btn_fetch.Location = new System.Drawing.Point(302, 17);
            this.btn_fetch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fetch.Name = "btn_fetch";
            this.btn_fetch.Size = new System.Drawing.Size(77, 28);
            this.btn_fetch.TabIndex = 11;
            this.btn_fetch.Text = "Fetch Bill";
            this.btn_fetch.UseVisualStyleBackColor = false;
            this.btn_fetch.Click += new System.EventHandler(this.btn_fetch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reservation Amount:";
            // 
            // lbl_reservationAmount
            // 
            this.lbl_reservationAmount.AutoSize = true;
            this.lbl_reservationAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_reservationAmount.Location = new System.Drawing.Point(193, 69);
            this.lbl_reservationAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reservationAmount.Name = "lbl_reservationAmount";
            this.lbl_reservationAmount.Size = new System.Drawing.Size(0, 29);
            this.lbl_reservationAmount.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pool Access:";
            // 
            // lbl_poolAccess
            // 
            this.lbl_poolAccess.AutoSize = true;
            this.lbl_poolAccess.Location = new System.Drawing.Point(193, 103);
            this.lbl_poolAccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_poolAccess.Name = "lbl_poolAccess";
            this.lbl_poolAccess.Size = new System.Drawing.Size(0, 20);
            this.lbl_poolAccess.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Amount:";
            // 
            // lbl_totalAmount
            // 
            this.lbl_totalAmount.AutoSize = true;
            this.lbl_totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_totalAmount.Location = new System.Drawing.Point(193, 138);
            this.lbl_totalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_totalAmount.Name = "lbl_totalAmount";
            this.lbl_totalAmount.Size = new System.Drawing.Size(0, 29);
            this.lbl_totalAmount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Payment Date:";
            // 
            // lbl_paymentDate
            // 
            this.lbl_paymentDate.AutoSize = true;
            this.lbl_paymentDate.Location = new System.Drawing.Point(193, 172);
            this.lbl_paymentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_paymentDate.Name = "lbl_paymentDate";
            this.lbl_paymentDate.Size = new System.Drawing.Size(0, 20);
            this.lbl_paymentDate.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Status:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(193, 207);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 20);
            this.lbl_status.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Green;
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(32, 255);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(77, 31);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_billDetails
            // 
            this.txt_billDetails.Location = new System.Drawing.Point(32, 291);
            this.txt_billDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txt_billDetails.Multiline = true;
            this.txt_billDetails.Name = "txt_billDetails";
            this.txt_billDetails.Size = new System.Drawing.Size(350, 100);
            this.txt_billDetails.TabIndex = 14;
            // 
            // btn_generateBill
            // 
            this.btn_generateBill.BackColor = System.Drawing.Color.Green;
            this.btn_generateBill.ForeColor = System.Drawing.Color.White;
            this.btn_generateBill.Location = new System.Drawing.Point(302, 255);
            this.btn_generateBill.Margin = new System.Windows.Forms.Padding(2);
            this.btn_generateBill.Name = "btn_generateBill";
            this.btn_generateBill.Size = new System.Drawing.Size(77, 31);
            this.btn_generateBill.TabIndex = 15;
            this.btn_generateBill.Text = "Generate Bill";
            this.btn_generateBill.UseVisualStyleBackColor = false;
            this.btn_generateBill.Click += new System.EventHandler(this.btn_generateBill_Click);
            // 
            // btn_printBill
            // 
            this.btn_printBill.BackColor = System.Drawing.Color.Green;
            this.btn_printBill.ForeColor = System.Drawing.Color.White;
            this.btn_printBill.Location = new System.Drawing.Point(302, 401);
            this.btn_printBill.Margin = new System.Windows.Forms.Padding(2);
            this.btn_printBill.Name = "btn_printBill";
            this.btn_printBill.Size = new System.Drawing.Size(77, 31);
            this.btn_printBill.TabIndex = 16;
            this.btn_printBill.Text = "Print Bill";
            this.btn_printBill.UseVisualStyleBackColor = false;
            this.btn_printBill.Click += new System.EventHandler(this.btn_printBill_Click);
            // 
            // Bill
            // 
            this.ClientSize = new System.Drawing.Size(488, 555);
            this.Controls.Add(this.btn_printBill);
            this.Controls.Add(this.btn_generateBill);
            this.Controls.Add(this.txt_billDetails);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_paymentDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_totalAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_poolAccess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_reservationAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_fetch);
            this.Controls.Add(this.txt_reservationid);
            this.Controls.Add(this.label1);
            this.Name = "Bill";
            this.Text = "Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_reservationid;
        private System.Windows.Forms.Button btn_fetch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_reservationAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_poolAccess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_totalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_paymentDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_billDetails;
        private System.Windows.Forms.Button btn_generateBill;
        private System.Windows.Forms.Button btn_printBill;
    }
}
