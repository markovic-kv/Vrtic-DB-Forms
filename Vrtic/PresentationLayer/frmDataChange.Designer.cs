namespace PresentationLayer
{
    partial class frmDataChange
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
            this.btnChildren = new System.Windows.Forms.Button();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.btnSections = new System.Windows.Forms.Button();
            this.btnSeminars = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChildren
            // 
            this.btnChildren.Location = new System.Drawing.Point(108, 37);
            this.btnChildren.Name = "btnChildren";
            this.btnChildren.Size = new System.Drawing.Size(188, 40);
            this.btnChildren.TabIndex = 0;
            this.btnChildren.Text = "Deca";
            this.btnChildren.UseVisualStyleBackColor = true;
            this.btnChildren.Click += new System.EventHandler(this.btnChildren_Click);
            // 
            // btnAbsence
            // 
            this.btnAbsence.Location = new System.Drawing.Point(108, 97);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(188, 38);
            this.btnAbsence.TabIndex = 1;
            this.btnAbsence.Text = "Izostanci";
            this.btnAbsence.UseVisualStyleBackColor = true;
            this.btnAbsence.Click += new System.EventHandler(this.btnAbsence_Click);
            // 
            // btnSections
            // 
            this.btnSections.Location = new System.Drawing.Point(108, 157);
            this.btnSections.Name = "btnSections";
            this.btnSections.Size = new System.Drawing.Size(188, 39);
            this.btnSections.TabIndex = 2;
            this.btnSections.Text = "Oblasti";
            this.btnSections.UseVisualStyleBackColor = true;
            this.btnSections.Click += new System.EventHandler(this.btnSections_Click);
            // 
            // btnSeminars
            // 
            this.btnSeminars.Location = new System.Drawing.Point(108, 216);
            this.btnSeminars.Name = "btnSeminars";
            this.btnSeminars.Size = new System.Drawing.Size(188, 37);
            this.btnSeminars.TabIndex = 3;
            this.btnSeminars.Text = "Seminari";
            this.btnSeminars.UseVisualStyleBackColor = true;
            this.btnSeminars.Click += new System.EventHandler(this.btnSeminars_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(108, 275);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(188, 39);
            this.btnRooms.TabIndex = 4;
            this.btnRooms.Text = "Sobe";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Location = new System.Drawing.Point(108, 336);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(188, 40);
            this.btnTeachers.TabIndex = 5;
            this.btnTeachers.Text = "Vaspitaci";
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // frmDataChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 424);
            this.Controls.Add(this.btnTeachers);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnSeminars);
            this.Controls.Add(this.btnSections);
            this.Controls.Add(this.btnAbsence);
            this.Controls.Add(this.btnChildren);
            this.Name = "frmDataChange";
            this.Text = "Izmena_podataka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChildren;
        private System.Windows.Forms.Button btnAbsence;
        private System.Windows.Forms.Button btnSections;
        private System.Windows.Forms.Button btnSeminars;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnTeachers;
    }
}