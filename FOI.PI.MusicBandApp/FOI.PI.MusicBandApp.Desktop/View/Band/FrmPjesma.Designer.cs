namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    partial class FrmPjesma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPjesma));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_naziv = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.performer = new System.Windows.Forms.TextBox();
            this.duration = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.genreList = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izvođač:";
            // 
            // lbl_naziv
            // 
            this.lbl_naziv.AutoSize = true;
            this.lbl_naziv.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_naziv.Location = new System.Drawing.Point(63, 9);
            this.lbl_naziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_naziv.Name = "lbl_naziv";
            this.lbl_naziv.Size = new System.Drawing.Size(344, 59);
            this.lbl_naziv.TabIndex = 17;
            this.lbl_naziv.Text = "MusicBandApp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Trajanje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Godina izdanja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Žanr:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(165, 235);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(226, 22);
            this.name.TabIndex = 21;
            // 
            // performer
            // 
            this.performer.Location = new System.Drawing.Point(165, 263);
            this.performer.Name = "performer";
            this.performer.Size = new System.Drawing.Size(226, 22);
            this.performer.TabIndex = 22;
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(165, 291);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(226, 22);
            this.duration.TabIndex = 23;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(165, 319);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(226, 22);
            this.year.TabIndex = 24;
            // 
            // genreList
            // 
            this.genreList.FormattingEnabled = true;
            this.genreList.Location = new System.Drawing.Point(165, 347);
            this.genreList.Name = "genreList";
            this.genreList.Size = new System.Drawing.Size(226, 24);
            this.genreList.TabIndex = 25;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(165, 377);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(226, 23);
            this.add.TabIndex = 26;
            this.add.Text = "KREIRAJ PJESMU";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(165, 406);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(226, 23);
            this.cancel.TabIndex = 27;
            this.cancel.Text = "ODUSTANI";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // FrmPjesma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 466);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.genreList);
            this.Controls.Add(this.year);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.performer);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_naziv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPjesma";
            this.Text = "Music Band App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_naziv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox performer;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.ComboBox genreList;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancel;
    }
}