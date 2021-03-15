namespace GUI
{
    partial class FormManagerFlightSchedules
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
            this.btnImportChanges = new System.Windows.Forms.Button();
            this.btnEditFlight = new System.Windows.Forms.Button();
            this.btnCancelFlight = new System.Windows.Forms.Button();
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportChanges
            // 
            this.btnImportChanges.Location = new System.Drawing.Point(713, 441);
            this.btnImportChanges.Name = "btnImportChanges";
            this.btnImportChanges.Size = new System.Drawing.Size(117, 37);
            this.btnImportChanges.TabIndex = 15;
            this.btnImportChanges.Text = "Import  Changes";
            this.btnImportChanges.UseVisualStyleBackColor = true;
            this.btnImportChanges.Click += new System.EventHandler(this.btnImportChanges_Click);
            // 
            // btnEditFlight
            // 
            this.btnEditFlight.Location = new System.Drawing.Point(210, 441);
            this.btnEditFlight.Name = "btnEditFlight";
            this.btnEditFlight.Size = new System.Drawing.Size(98, 37);
            this.btnEditFlight.TabIndex = 14;
            this.btnEditFlight.Text = "Edit Flight";
            this.btnEditFlight.UseVisualStyleBackColor = true;
            this.btnEditFlight.Click += new System.EventHandler(this.btnEditFlight_Click);
            // 
            // btnCancelFlight
            // 
            this.btnCancelFlight.Location = new System.Drawing.Point(53, 441);
            this.btnCancelFlight.Name = "btnCancelFlight";
            this.btnCancelFlight.Size = new System.Drawing.Size(104, 37);
            this.btnCancelFlight.TabIndex = 13;
            this.btnCancelFlight.Text = "Cancel Flight";
            this.btnCancelFlight.UseVisualStyleBackColor = true;
            this.btnCancelFlight.Click += new System.EventHandler(this.btnCancelFlight_Click);
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedules.Location = new System.Drawing.Point(39, 159);
            this.dgvSchedules.Name = "dgvSchedules";
            this.dgvSchedules.Size = new System.Drawing.Size(844, 263);
            this.dgvSchedules.TabIndex = 12;
            this.dgvSchedules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedules_CellClick);
            this.dgvSchedules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedules_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.cmbSort);
            this.groupBox1.Controls.Add(this.cmbTo);
            this.groupBox1.Controls.Add(this.cmbFrom);
            this.groupBox1.Controls.Add(this.txtFlightNumber);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 110);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(114, 69);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(155, 20);
            this.txtDate.TabIndex = 15;
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Date-time",
            "EconomyPrice",
            "Confirmed"});
            this.cmbSort.Location = new System.Drawing.Point(674, 18);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(117, 21);
            this.cmbSort.TabIndex = 12;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(396, 18);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(167, 21);
            this.cmbTo.TabIndex = 10;
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(113, 18);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(156, 21);
            this.cmbFrom.TabIndex = 9;
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(396, 68);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(167, 20);
            this.txtFlightNumber.TabIndex = 8;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(674, 57);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(117, 42);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Flight Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sort by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Outbound";
            // 
            // FormManagerFlightSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 511);
            this.Controls.Add(this.btnImportChanges);
            this.Controls.Add(this.btnEditFlight);
            this.Controls.Add(this.btnCancelFlight);
            this.Controls.Add(this.dgvSchedules);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormManagerFlightSchedules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManagerFlightSchedules";
            this.Load += new System.EventHandler(this.FormManagerFlightSchedules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportChanges;
        private System.Windows.Forms.Button btnEditFlight;
        private System.Windows.Forms.Button btnCancelFlight;
        public System.Windows.Forms.DataGridView dgvSchedules;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cmbSort;
        public System.Windows.Forms.ComboBox cmbTo;
        public System.Windows.Forms.ComboBox cmbFrom;
        public System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}