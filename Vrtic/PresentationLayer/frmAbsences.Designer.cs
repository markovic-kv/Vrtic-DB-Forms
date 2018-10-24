namespace PresentationLayer
{
    partial class frmAbsences
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
            this.cmbAbsenceNumber = new System.Windows.Forms.ComboBox();
            this.cmbChildNumber = new System.Windows.Forms.ComboBox();
            this.txtBeginDay = new System.Windows.Forms.TextBox();
            this.txtBeginMonth = new System.Windows.Forms.TextBox();
            this.txtBeginYear = new System.Windows.Forms.TextBox();
            this.txtEndDay = new System.Windows.Forms.TextBox();
            this.txtEndMonth = new System.Windows.Forms.TextBox();
            this.txtEndYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChildSurname = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAbsenceNumber
            // 
            this.cmbAbsenceNumber.FormattingEnabled = true;
            this.cmbAbsenceNumber.Location = new System.Drawing.Point(149, 34);
            this.cmbAbsenceNumber.Name = "cmbAbsenceNumber";
            this.cmbAbsenceNumber.Size = new System.Drawing.Size(166, 21);
            this.cmbAbsenceNumber.TabIndex = 0;
            this.cmbAbsenceNumber.SelectedIndexChanged += new System.EventHandler(this.cmbAbsenceNumber_SelectedIndexChanged);
            // 
            // cmbChildNumber
            // 
            this.cmbChildNumber.FormattingEnabled = true;
            this.cmbChildNumber.Location = new System.Drawing.Point(149, 85);
            this.cmbChildNumber.Name = "cmbChildNumber";
            this.cmbChildNumber.Size = new System.Drawing.Size(166, 21);
            this.cmbChildNumber.TabIndex = 1;
            this.cmbChildNumber.SelectedIndexChanged += new System.EventHandler(this.cmbChildNumber_SelectedIndexChanged);
            // 
            // txtBeginDay
            // 
            this.txtBeginDay.Location = new System.Drawing.Point(182, 139);
            this.txtBeginDay.Name = "txtBeginDay";
            this.txtBeginDay.Size = new System.Drawing.Size(76, 20);
            this.txtBeginDay.TabIndex = 2;
            // 
            // txtBeginMonth
            // 
            this.txtBeginMonth.Location = new System.Drawing.Point(321, 139);
            this.txtBeginMonth.Name = "txtBeginMonth";
            this.txtBeginMonth.Size = new System.Drawing.Size(76, 20);
            this.txtBeginMonth.TabIndex = 3;
            // 
            // txtBeginYear
            // 
            this.txtBeginYear.Location = new System.Drawing.Point(468, 139);
            this.txtBeginYear.Name = "txtBeginYear";
            this.txtBeginYear.Size = new System.Drawing.Size(76, 20);
            this.txtBeginYear.TabIndex = 4;
            // 
            // txtEndDay
            // 
            this.txtEndDay.Location = new System.Drawing.Point(182, 185);
            this.txtEndDay.Name = "txtEndDay";
            this.txtEndDay.Size = new System.Drawing.Size(76, 20);
            this.txtEndDay.TabIndex = 5;
            // 
            // txtEndMonth
            // 
            this.txtEndMonth.Location = new System.Drawing.Point(321, 185);
            this.txtEndMonth.Name = "txtEndMonth";
            this.txtEndMonth.Size = new System.Drawing.Size(76, 20);
            this.txtEndMonth.TabIndex = 6;
            // 
            // txtEndYear
            // 
            this.txtEndYear.Location = new System.Drawing.Point(468, 185);
            this.txtEndYear.Name = "txtEndYear";
            this.txtEndYear.Size = new System.Drawing.Size(76, 20);
            this.txtEndYear.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Broj izostanaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Broj deteta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Datum pocetka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Datum zavrsetka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mesec:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Godina:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dan:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mesec:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Godina:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(101, 242);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Unos";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(259, 242);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Azuriranje";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(421, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Brisanje";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Prezime deteta";
            // 
            // txtChildSurname
            // 
            this.txtChildSurname.Location = new System.Drawing.Point(417, 90);
            this.txtChildSurname.Name = "txtChildSurname";
            this.txtChildSurname.Size = new System.Drawing.Size(127, 20);
            this.txtChildSurname.TabIndex = 22;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(345, 37);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(41, 13);
            this.lblMsg.TabIndex = 23;
            this.lblMsg.Text = "Poruka";
            // 
            // frmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 295);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtChildSurname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndYear);
            this.Controls.Add(this.txtEndMonth);
            this.Controls.Add(this.txtEndDay);
            this.Controls.Add(this.txtBeginYear);
            this.Controls.Add(this.txtBeginMonth);
            this.Controls.Add(this.txtBeginDay);
            this.Controls.Add(this.cmbChildNumber);
            this.Controls.Add(this.cmbAbsenceNumber);
            this.Name = "frmAbsences";
            this.Text = "Izostanci";
            this.Load += new System.EventHandler(this.frmAbsences_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAbsenceNumber;
        private System.Windows.Forms.ComboBox cmbChildNumber;
        private System.Windows.Forms.TextBox txtBeginDay;
        private System.Windows.Forms.TextBox txtBeginMonth;
        private System.Windows.Forms.TextBox txtBeginYear;
        private System.Windows.Forms.TextBox txtEndDay;
        private System.Windows.Forms.TextBox txtEndMonth;
        private System.Windows.Forms.TextBox txtEndYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtChildSurname;
        private System.Windows.Forms.Label lblMsg;
    }
}