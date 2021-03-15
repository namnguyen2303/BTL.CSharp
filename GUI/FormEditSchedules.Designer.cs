namespace GUI
{
    partial class FormEditSchedules
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
            this.txtDateEdit = new System.Windows.Forms.TextBox();
            this.txtTimeEdit = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEconomyEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAircraft = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDateEdit
            // 
            this.txtDateEdit.Location = new System.Drawing.Point(95, 169);
            this.txtDateEdit.Name = "txtDateEdit";
            this.txtDateEdit.Size = new System.Drawing.Size(121, 20);
            this.txtDateEdit.TabIndex = 28;
            // 
            // txtTimeEdit
            // 
            this.txtTimeEdit.Location = new System.Drawing.Point(288, 169);
            this.txtTimeEdit.Name = "txtTimeEdit";
            this.txtTimeEdit.Size = new System.Drawing.Size(100, 20);
            this.txtTimeEdit.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(522, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(407, 249);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEconomyEdit
            // 
            this.txtEconomyEdit.Location = new System.Drawing.Point(526, 169);
            this.txtEconomyEdit.Name = "txtEconomyEdit";
            this.txtEconomyEdit.Size = new System.Drawing.Size(104, 20);
            this.txtEconomyEdit.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Economy price  $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblAircraft);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 97);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight Route";
            // 
            // lblAircraft
            // 
            this.lblAircraft.AutoSize = true;
            this.lblAircraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraft.Location = new System.Drawing.Point(441, 46);
            this.lblAircraft.Name = "lblAircraft";
            this.lblAircraft.Size = new System.Drawing.Size(41, 13);
            this.lblAircraft.TabIndex = 5;
            this.lblAircraft.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aircraft : ";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(263, 46);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(41, 13);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To :";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(81, 46);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(41, 13);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(514, 46);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "label1";
            // 
            // FormEditSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 307);
            this.Controls.Add(this.txtDateEdit);
            this.Controls.Add(this.txtTimeEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtEconomyEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEditSchedules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditSchedules";
            this.Load += new System.EventHandler(this.FormEditSchedules_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDateEdit;
        internal System.Windows.Forms.TextBox txtTimeEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtEconomyEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblAircraft;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblID;
    }
}