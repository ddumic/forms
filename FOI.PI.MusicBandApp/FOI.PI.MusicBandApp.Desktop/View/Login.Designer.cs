namespace FOI.PI.MusicBandApp.Desktop
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_naziv = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.lbl_psw = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_Registracija = new System.Windows.Forms.Button();
            this.btn_Prijava = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_naziv
            // 
            this.lbl_naziv.AutoSize = true;
            this.lbl_naziv.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_naziv.Location = new System.Drawing.Point(22, 9);
            this.lbl_naziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_naziv.Name = "lbl_naziv";
            this.lbl_naziv.Size = new System.Drawing.Size(344, 59);
            this.lbl_naziv.TabIndex = 15;
            this.lbl_naziv.Text = "MusicBandApp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(124, 293);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(157, 22);
            this.password.TabIndex = 13;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(124, 240);
            this.mail.Margin = new System.Windows.Forms.Padding(4);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(157, 22);
            this.mail.TabIndex = 12;
            // 
            // lbl_psw
            // 
            this.lbl_psw.AutoSize = true;
            this.lbl_psw.Location = new System.Drawing.Point(51, 293);
            this.lbl_psw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_psw.Name = "lbl_psw";
            this.lbl_psw.Size = new System.Drawing.Size(65, 17);
            this.lbl_psw.TabIndex = 11;
            this.lbl_psw.Text = "Lozinka: ";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(75, 240);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(41, 17);
            this.lbl_user.TabIndex = 10;
            this.lbl_user.Text = "Mail: ";
            // 
            // btn_Registracija
            // 
            this.btn_Registracija.Location = new System.Drawing.Point(134, 396);
            this.btn_Registracija.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Registracija.Name = "btn_Registracija";
            this.btn_Registracija.Size = new System.Drawing.Size(131, 33);
            this.btn_Registracija.TabIndex = 9;
            this.btn_Registracija.Text = "REGISTRACIJA";
            this.btn_Registracija.UseVisualStyleBackColor = true;
            this.btn_Registracija.Click += new System.EventHandler(this.btn_Registracija_Click);
            // 
            // btn_Prijava
            // 
            this.btn_Prijava.Location = new System.Drawing.Point(143, 336);
            this.btn_Prijava.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Prijava.Name = "btn_Prijava";
            this.btn_Prijava.Size = new System.Drawing.Size(112, 32);
            this.btn_Prijava.TabIndex = 8;
            this.btn_Prijava.Text = "PRIJAVA";
            this.btn_Prijava.UseVisualStyleBackColor = true;
            this.btn_Prijava.Click += new System.EventHandler(this.btn_Prijava_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 471);
            this.Controls.Add(this.lbl_naziv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.lbl_psw);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_Registracija);
            this.Controls.Add(this.btn_Prijava);
            this.Name = "Login";
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_naziv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label lbl_psw;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btn_Registracija;
        private System.Windows.Forms.Button btn_Prijava;
    }
}

