namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    partial class FrmRezervacija
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
            this.requestList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.dismiss = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.scheduleList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.requestList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleList)).BeginInit();
            this.SuspendLayout();
            // 
            // requestList
            // 
            this.requestList.AllowUserToAddRows = false;
            this.requestList.AllowUserToDeleteRows = false;
            this.requestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestList.Location = new System.Drawing.Point(6, 35);
            this.requestList.MultiSelect = false;
            this.requestList.Name = "requestList";
            this.requestList.ReadOnly = true;
            this.requestList.RowTemplate.Height = 24;
            this.requestList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestList.Size = new System.Drawing.Size(1243, 206);
            this.requestList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cijena:";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(60, 247);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(210, 22);
            this.price.TabIndex = 3;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(276, 247);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(210, 23);
            this.save.TabIndex = 4;
            this.save.Text = "SPREMI";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // dismiss
            // 
            this.dismiss.Location = new System.Drawing.Point(492, 247);
            this.dismiss.Name = "dismiss";
            this.dismiss.Size = new System.Drawing.Size(210, 23);
            this.dismiss.TabIndex = 5;
            this.dismiss.Text = "ODBIJ";
            this.dismiss.UseVisualStyleBackColor = true;
            this.dismiss.Click += new System.EventHandler(this.dismiss_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.requestList);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.dismiss);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Location = new System.Drawing.Point(18, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1255, 309);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zahtjevi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.scheduleList);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1267, 186);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Raspored:";
            // 
            // scheduleList
            // 
            this.scheduleList.AllowUserToAddRows = false;
            this.scheduleList.AllowUserToDeleteRows = false;
            this.scheduleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleList.Location = new System.Drawing.Point(6, 35);
            this.scheduleList.MultiSelect = false;
            this.scheduleList.Name = "scheduleList";
            this.scheduleList.ReadOnly = true;
            this.scheduleList.RowTemplate.Height = 24;
            this.scheduleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scheduleList.Size = new System.Drawing.Size(1255, 145);
            this.scheduleList.TabIndex = 6;
            // 
            // FrmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRezervacija";
            this.Text = "Music Band App";
            ((System.ComponentModel.ISupportInitialize)(this.requestList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView requestList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button dismiss;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView scheduleList;
    }
}