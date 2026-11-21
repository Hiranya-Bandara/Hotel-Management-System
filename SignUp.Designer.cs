namespace HotelManagementSystem
{
    partial class SignUp
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
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.linkLabel_login = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_showpassword = new System.Windows.Forms.CheckBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_close = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_password.Location = new System.Drawing.Point(20, 339);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(102, 24);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password :";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_username.Location = new System.Drawing.Point(20, 271);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(115, 24);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "User Name :";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_password.Location = new System.Drawing.Point(70, 368);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(329, 29);
            this.txt_password.TabIndex = 2;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_username.Location = new System.Drawing.Point(70, 299);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(329, 29);
            this.txt_username.TabIndex = 3;
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_signup.Location = new System.Drawing.Point(134, 446);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(161, 59);
            this.btn_signup.TabIndex = 6;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // linkLabel_login
            // 
            this.linkLabel_login.AutoSize = true;
            this.linkLabel_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_login.Location = new System.Drawing.Point(364, 521);
            this.linkLabel_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_login.Name = "linkLabel_login";
            this.linkLabel_login.Size = new System.Drawing.Size(51, 18);
            this.linkLabel_login.TabIndex = 8;
            this.linkLabel_login.TabStop = true;
            this.linkLabel_login.Text = "Log In!";
            this.linkLabel_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_login_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 520);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Already have an account?";
            // 
            // cbx_showpassword
            // 
            this.cbx_showpassword.AutoSize = true;
            this.cbx_showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_showpassword.Location = new System.Drawing.Point(287, 405);
            this.cbx_showpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_showpassword.Name = "cbx_showpassword";
            this.cbx_showpassword.Size = new System.Drawing.Size(136, 22);
            this.cbx_showpassword.TabIndex = 9;
            this.cbx_showpassword.Text = "Show Password";
            this.cbx_showpassword.UseVisualStyleBackColor = true;
            this.cbx_showpassword.CheckedChanged += new System.EventHandler(this.cbx_showpassword_CheckedChanged);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_email.Location = new System.Drawing.Point(70, 231);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(329, 29);
            this.txt_email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(20, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email :";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.SeaGreen;
            this.panel_top.Controls.Add(this.label_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(427, 39);
            this.panel_top.TabIndex = 21;
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.White;
            this.label_close.Location = new System.Drawing.Point(430, 9);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(21, 20);
            this.label_close.TabIndex = 0;
            this.label_close.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sign Up Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.outdoor_stay;
            this.pictureBox1.Location = new System.Drawing.Point(146, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.cbx_showpassword);
            this.Controls.Add(this.linkLabel_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.LinkLabel linkLabel_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbx_showpassword;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}