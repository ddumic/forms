namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    partial class FrmRepertoar
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
            this.add = new System.Windows.Forms.Button();
            this.bandSongs = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.create = new System.Windows.Forms.Button();
            this.songList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bandSongs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(159, 64);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(248, 23);
            this.add.TabIndex = 0;
            this.add.Text = "DODAJ PJESMU";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // bandSongs
            // 
            this.bandSongs.AllowUserToAddRows = false;
            this.bandSongs.AllowUserToDeleteRows = false;
            this.bandSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bandSongs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.bandSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bandSongs.Location = new System.Drawing.Point(12, 12);
            this.bandSongs.MultiSelect = false;
            this.bandSongs.Name = "bandSongs";
            this.bandSongs.ReadOnly = true;
            this.bandSongs.RowTemplate.Height = 24;
            this.bandSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bandSongs.Size = new System.Drawing.Size(767, 150);
            this.bandSongs.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.create);
            this.groupBox1.Controls.Add(this.songList);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj pjesmu";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(159, 93);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(248, 23);
            this.create.TabIndex = 3;
            this.create.Text = "KREIRAJ PJESMU";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            this.songList.Location = new System.Drawing.Point(159, 34);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(248, 24);
            this.songList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pjesma:";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(578, 168);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(201, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "OBRIŠI PJESMU";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // FrmRepertoar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 315);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bandSongs);
            this.Name = "FrmRepertoar";
            this.Text = "Music Band App";
            ((System.ComponentModel.ISupportInitialize)(this.bandSongs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView bandSongs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.ComboBox songList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete;
    }
}