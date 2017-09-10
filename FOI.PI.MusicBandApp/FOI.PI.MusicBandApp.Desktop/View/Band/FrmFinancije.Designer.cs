namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    partial class FrmFinancije
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
            this.chargeList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.RichTextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reservtionCharge = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.diff = new System.Windows.Forms.TextBox();
            this.chargeCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chargeList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chargeList
            // 
            this.chargeList.AllowUserToAddRows = false;
            this.chargeList.AllowUserToDeleteRows = false;
            this.chargeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chargeList.Location = new System.Drawing.Point(12, 12);
            this.chargeList.MultiSelect = false;
            this.chargeList.Name = "chargeList";
            this.chargeList.ReadOnly = true;
            this.chargeList.RowTemplate.Height = 24;
            this.chargeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chargeList.Size = new System.Drawing.Size(760, 150);
            this.chargeList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.note);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj novi trošak";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(126, 107);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(606, 23);
            this.add.TabIndex = 13;
            this.add.Text = "DODAJ TROŠAK";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Opis:";
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(462, 40);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(270, 61);
            this.note.TabIndex = 6;
            this.note.Text = "";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(126, 79);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(257, 22);
            this.price.TabIndex = 5;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(126, 40);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(257, 22);
            this.name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Iznos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv:";
            // 
            // reservtionCharge
            // 
            this.reservtionCharge.Location = new System.Drawing.Point(126, 21);
            this.reservtionCharge.Name = "reservtionCharge";
            this.reservtionCharge.ReadOnly = true;
            this.reservtionCharge.Size = new System.Drawing.Size(606, 22);
            this.reservtionCharge.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.diff);
            this.groupBox2.Controls.Add(this.chargeCount);
            this.groupBox2.Controls.Add(this.reservtionCharge);
            this.groupBox2.Location = new System.Drawing.Point(12, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 113);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pregled";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ukupno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rashodi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prihodi:";
            // 
            // diff
            // 
            this.diff.Location = new System.Drawing.Point(126, 77);
            this.diff.Name = "diff";
            this.diff.ReadOnly = true;
            this.diff.Size = new System.Drawing.Size(606, 22);
            this.diff.TabIndex = 10;
            // 
            // chargeCount
            // 
            this.chargeCount.Location = new System.Drawing.Point(126, 49);
            this.chargeCount.Name = "chargeCount";
            this.chargeCount.ReadOnly = true;
            this.chargeCount.Size = new System.Drawing.Size(606, 22);
            this.chargeCount.TabIndex = 9;
            // 
            // FrmFinancije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chargeList);
            this.Name = "FrmFinancije";
            this.Text = "Music App Band";
            ((System.ComponentModel.ISupportInitialize)(this.chargeList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView chargeList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox note;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox reservtionCharge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox diff;
        private System.Windows.Forms.TextBox chargeCount;
        private System.Windows.Forms.Button add;
    }
}