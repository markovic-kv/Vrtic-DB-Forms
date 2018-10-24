namespace PresentationLayer
{
    partial class frmTeachers
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
            this.cmbTeacherNumber = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtSsn = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtQualification = new System.Windows.Forms.TextBox();
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
            this.label11 = new System.Windows.Forms.Label();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnAzur = new System.Windows.Forms.Button();
            this.btnBris = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBrVaspitac
            // 
            this.cmbTeacherNumber.FormattingEnabled = true;
            this.cmbTeacherNumber.Location = new System.Drawing.Point(139, 37);
            this.cmbTeacherNumber.Name = "cbBrVaspitac";
            this.cmbTeacherNumber.Size = new System.Drawing.Size(200, 21);
            this.cmbTeacherNumber.TabIndex = 0;
            this.cmbTeacherNumber.SelectedIndexChanged += new System.EventHandler(this.cmbTeacherNumber_SelectedIndexChanged);
            // 
            // txtIme
            // 
            this.txtName.Location = new System.Drawing.Point(139, 84);
            this.txtName.Name = "txtIme";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtSurname.Location = new System.Drawing.Point(139, 128);
            this.txtSurname.Name = "txtPrezime";
            this.txtSurname.Size = new System.Drawing.Size(200, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // cbPol
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(139, 179);
            this.cmbGender.Name = "cbPol";
            this.cmbGender.Size = new System.Drawing.Size(200, 21);
            this.cmbGender.TabIndex = 3;
            // 
            // txtJmbg
            // 
            this.txtSsn.Location = new System.Drawing.Point(139, 228);
            this.txtSsn.Name = "txtJmbg";
            this.txtSsn.Size = new System.Drawing.Size(200, 20);
            this.txtSsn.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(139, 271);
            this.txtPhoneNum.Name = "txtTel";
            this.txtPhoneNum.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneNum.TabIndex = 5;
            // 
            // txtDan
            // 
            this.txtDay.Location = new System.Drawing.Point(175, 325);
            this.txtDay.Name = "txtDan";
            this.txtDay.Size = new System.Drawing.Size(69, 20);
            this.txtDay.TabIndex = 6;
            // 
            // txtMes
            // 
            this.txtMonth.Location = new System.Drawing.Point(308, 325);
            this.txtMonth.Name = "txtMes";
            this.txtMonth.Size = new System.Drawing.Size(69, 20);
            this.txtMonth.TabIndex = 7;
            // 
            // txtGod
            // 
            this.txtYear.Location = new System.Drawing.Point(445, 326);
            this.txtYear.Name = "txtGod";
            this.txtYear.Size = new System.Drawing.Size(71, 20);
            this.txtYear.TabIndex = 8;
            // 
            // txtSsprema
            // 
            this.txtQualification.Location = new System.Drawing.Point(139, 383);
            this.txtQualification.Name = "txtSsprema";
            this.txtQualification.Size = new System.Drawing.Size(200, 20);
            this.txtQualification.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Broj vaspitaca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "JMBG:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Datum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Dan:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mesec:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Godina:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Strucna sprema:";
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(87, 435);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 21;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnAzur
            // 
            this.btnAzur.Location = new System.Drawing.Point(273, 435);
            this.btnAzur.Name = "btnAzur";
            this.btnAzur.Size = new System.Drawing.Size(75, 23);
            this.btnAzur.TabIndex = 22;
            this.btnAzur.Text = "Azuriranje";
            this.btnAzur.UseVisualStyleBackColor = true;
            this.btnAzur.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBris
            // 
            this.btnBris.Location = new System.Drawing.Point(469, 435);
            this.btnBris.Name = "btnBris";
            this.btnBris.Size = new System.Drawing.Size(75, 23);
            this.btnBris.TabIndex = 23;
            this.btnBris.Text = "Brisanje";
            this.btnBris.UseVisualStyleBackColor = true;
            this.btnBris.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPoruka
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(398, 40);
            this.lblMsg.Name = "lblPoruka";
            this.lblMsg.Size = new System.Drawing.Size(41, 13);
            this.lblMsg.TabIndex = 24;
            this.lblMsg.Text = "Poruka";
            // 
            // Vaspitac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 480);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnBris);
            this.Controls.Add(this.btnAzur);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.label11);
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
            this.Controls.Add(this.txtQualification);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtSsn);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbTeacherNumber);
            this.Name = "Vaspitac";
            this.Text = "Vaspitac";
            this.Load += new System.EventHandler(this.frmTeachers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTeacherNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtSsn;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtQualification;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnAzur;
        private System.Windows.Forms.Button btnBris;
        private System.Windows.Forms.Label lblMsg;
    }
}