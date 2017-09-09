namespace FOI.PI.MusicBandApp.Desktop.View.Band
{
    partial class FrmClan
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
            this.members = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addMember = new System.Windows.Forms.Button();
            this.accountList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.members)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // members
            // 
            this.members.AllowUserToAddRows = false;
            this.members.AllowUserToDeleteRows = false;
            this.members.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.members.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.members.Location = new System.Drawing.Point(12, 12);
            this.members.MultiSelect = false;
            this.members.Name = "members";
            this.members.ReadOnly = true;
            this.members.RowTemplate.Height = 24;
            this.members.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.members.Size = new System.Drawing.Size(871, 206);
            this.members.TabIndex = 0;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(702, 224);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(181, 23);
            this.delete.TabIndex = 1;
            this.delete.Text = "OBRIŠI ČLANA";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Član:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addMember);
            this.groupBox1.Controls.Add(this.accountList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj člana";
            // 
            // addMember
            // 
            this.addMember.Location = new System.Drawing.Point(82, 76);
            this.addMember.Name = "addMember";
            this.addMember.Size = new System.Drawing.Size(309, 23);
            this.addMember.TabIndex = 5;
            this.addMember.Text = "DODAJ ČLANA";
            this.addMember.UseVisualStyleBackColor = true;
            this.addMember.Click += new System.EventHandler(this.addMember_Click);
            // 
            // accountList
            // 
            this.accountList.FormattingEnabled = true;
            this.accountList.Location = new System.Drawing.Point(82, 46);
            this.accountList.Name = "accountList";
            this.accountList.Size = new System.Drawing.Size(309, 24);
            this.accountList.TabIndex = 4;
            // 
            // FrmClan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 385);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.members);
            this.Name = "FrmClan";
            this.Text = "Music App Band";
            ((System.ComponentModel.ISupportInitialize)(this.members)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView members;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addMember;
        private System.Windows.Forms.ComboBox accountList;
    }
}