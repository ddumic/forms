namespace FOI.PI.MusicBandApp.Desktop.View.User
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
            this.reservationList = new System.Windows.Forms.DataGridView();
            this.submit = new System.Windows.Forms.Button();
            this.dismiss = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reservationList)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationList
            // 
            this.reservationList.AllowUserToAddRows = false;
            this.reservationList.AllowUserToDeleteRows = false;
            this.reservationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.reservationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationList.Location = new System.Drawing.Point(12, 12);
            this.reservationList.MultiSelect = false;
            this.reservationList.Name = "reservationList";
            this.reservationList.ReadOnly = true;
            this.reservationList.RowTemplate.Height = 24;
            this.reservationList.Size = new System.Drawing.Size(911, 194);
            this.reservationList.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(12, 221);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(197, 41);
            this.submit.TabIndex = 1;
            this.submit.Text = "POTVRDI ZAHTJEV";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // dismiss
            // 
            this.dismiss.Location = new System.Drawing.Point(215, 221);
            this.dismiss.Name = "dismiss";
            this.dismiss.Size = new System.Drawing.Size(197, 41);
            this.dismiss.TabIndex = 2;
            this.dismiss.Text = "ODBACI ZAHTJEV";
            this.dismiss.UseVisualStyleBackColor = true;
            this.dismiss.Click += new System.EventHandler(this.dismiss_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(418, 221);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(197, 41);
            this.close.TabIndex = 3;
            this.close.Text = "ZATVORI";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 283);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dismiss);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.reservationList);
            this.Name = "Reservation";
            this.Text = "Music App Band";
            ((System.ComponentModel.ISupportInitialize)(this.reservationList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reservationList;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button dismiss;
        private System.Windows.Forms.Button close;
    }
}