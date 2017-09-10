namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    partial class FrmPregledOpreme
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
            this.inventoryList = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.price = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryList
            // 
            this.inventoryList.AllowUserToAddRows = false;
            this.inventoryList.AllowUserToDeleteRows = false;
            this.inventoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.inventoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryList.Location = new System.Drawing.Point(12, 12);
            this.inventoryList.MultiSelect = false;
            this.inventoryList.Name = "inventoryList";
            this.inventoryList.ReadOnly = true;
            this.inventoryList.RowTemplate.Height = 24;
            this.inventoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryList.Size = new System.Drawing.Size(559, 182);
            this.inventoryList.TabIndex = 0;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(412, 209);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(159, 23);
            this.delete.TabIndex = 1;
            this.delete.Text = "OBRIŠI";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj opremu";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(161, 49);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(227, 22);
            this.price.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(161, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(227, 22);
            this.name.TabIndex = 7;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(161, 77);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(227, 23);
            this.add.TabIndex = 6;
            this.add.Text = "DODAJ";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cijena:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv:";
            // 
            // FrmPregledOpreme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.inventoryList);
            this.Name = "FrmPregledOpreme";
            this.Text = "Music Band App";
            ((System.ComponentModel.ISupportInitialize)(this.inventoryList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView inventoryList;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox name;
    }
}