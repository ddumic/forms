﻿namespace FOI.PI.MusicBandApp.Desktop.View.User
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pregledRezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bandList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.note = new System.Windows.Forms.RichTextBox();
            this.reserve = new System.Windows.Forms.Button();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.repertoireList = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.instagram = new System.Windows.Forms.TextBox();
            this.facebook = new System.Windows.Forms.TextBox();
            this.webpage = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisničkaDokumentacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repertoireList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledRezervacijaToolStripMenuItem,
            this.pomoćToolStripMenuItem,
            this.profilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pregledRezervacijaToolStripMenuItem
            // 
            this.pregledRezervacijaToolStripMenuItem.Name = "pregledRezervacijaToolStripMenuItem";
            this.pregledRezervacijaToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.pregledRezervacijaToolStripMenuItem.Text = "Pregled rezervacija";
            this.pregledRezervacijaToolStripMenuItem.Click += new System.EventHandler(this.pregledRezervacijaToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odjavaToolStripMenuItem});
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bandList
            // 
            this.bandList.AllowUserToAddRows = false;
            this.bandList.AllowUserToDeleteRows = false;
            this.bandList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bandList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bandList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bandList.Location = new System.Drawing.Point(12, 31);
            this.bandList.MultiSelect = false;
            this.bandList.Name = "bandList";
            this.bandList.ReadOnly = true;
            this.bandList.RowTemplate.Height = 24;
            this.bandList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bandList.Size = new System.Drawing.Size(927, 167);
            this.bandList.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.repertoireList);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.image);
            this.groupBox1.Controls.Add(this.mail);
            this.groupBox1.Controls.Add(this.contact);
            this.groupBox1.Controls.Add(this.instagram);
            this.groupBox1.Controls.Add(this.facebook);
            this.groupBox1.Controls.Add(this.webpage);
            this.groupBox1.Controls.Add(this.city);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 310);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.note);
            this.groupBox2.Controls.Add(this.reserve);
            this.groupBox2.Controls.Add(this.dateTo);
            this.groupBox2.Controls.Add(this.dateFrom);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(6, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(915, 87);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezerviraj bend";
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(332, 21);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(278, 53);
            this.note.TabIndex = 19;
            this.note.Text = "";
            // 
            // reserve
            // 
            this.reserve.Location = new System.Drawing.Point(616, 24);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(293, 45);
            this.reserve.TabIndex = 18;
            this.reserve.Text = "POŠALJI UPIT";
            this.reserve.UseVisualStyleBackColor = true;
            this.reserve.Click += new System.EventHandler(this.reserve_Click);
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(83, 52);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(243, 22);
            this.dateTo.TabIndex = 17;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(83, 24);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(243, 22);
            this.dateFrom.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Datum od:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Datum do:";
            // 
            // repertoireList
            // 
            this.repertoireList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repertoireList.Location = new System.Drawing.Point(622, 21);
            this.repertoireList.Name = "repertoireList";
            this.repertoireList.RowTemplate.Height = 24;
            this.repertoireList.Size = new System.Drawing.Size(299, 190);
            this.repertoireList.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kontakt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Instagram:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Facebook:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Web stranica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mjesto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naziv:";
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(6, 21);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(262, 190);
            this.image.TabIndex = 5;
            this.image.TabStop = false;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(373, 188);
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Size = new System.Drawing.Size(243, 22);
            this.mail.TabIndex = 6;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(373, 160);
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            this.contact.Size = new System.Drawing.Size(243, 22);
            this.contact.TabIndex = 5;
            // 
            // instagram
            // 
            this.instagram.Location = new System.Drawing.Point(373, 132);
            this.instagram.Name = "instagram";
            this.instagram.ReadOnly = true;
            this.instagram.Size = new System.Drawing.Size(243, 22);
            this.instagram.TabIndex = 4;
            // 
            // facebook
            // 
            this.facebook.Location = new System.Drawing.Point(373, 104);
            this.facebook.Name = "facebook";
            this.facebook.ReadOnly = true;
            this.facebook.Size = new System.Drawing.Size(243, 22);
            this.facebook.TabIndex = 3;
            // 
            // webpage
            // 
            this.webpage.Location = new System.Drawing.Point(373, 76);
            this.webpage.Name = "webpage";
            this.webpage.ReadOnly = true;
            this.webpage.Size = new System.Drawing.Size(243, 22);
            this.webpage.TabIndex = 2;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(373, 48);
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Size = new System.Drawing.Size(243, 22);
            this.city.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(373, 20);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(243, 22);
            this.name.TabIndex = 0;
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisničkaDokumentacijaToolStripMenuItem});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // korisničkaDokumentacijaToolStripMenuItem
            // 
            this.korisničkaDokumentacijaToolStripMenuItem.Name = "korisničkaDokumentacijaToolStripMenuItem";
            this.korisničkaDokumentacijaToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.korisničkaDokumentacijaToolStripMenuItem.Text = "Korisnička dokumentacija";
            this.korisničkaDokumentacijaToolStripMenuItem.Click += new System.EventHandler(this.korisničkaDokumentacijaToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bandList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Music Band App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repertoireList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView bandList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox instagram;
        private System.Windows.Forms.TextBox facebook;
        private System.Windows.Forms.TextBox webpage;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.DataGridView repertoireList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.RichTextBox note;
        private System.Windows.Forms.ToolStripMenuItem pregledRezervacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisničkaDokumentacijaToolStripMenuItem;
    }
}