namespace PresentationLayer
{
    partial class frmOneParameterView
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
            this.btnTeachersSearch = new System.Windows.Forms.Button();
            this.btnChildrenSearch = new System.Windows.Forms.Button();
            this.btnSeminarsSearch = new System.Windows.Forms.Button();
            this.btnAbsenceSearch = new System.Windows.Forms.Button();
            this.btnSectionsSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTeachersSearch
            // 
            this.btnTeachersSearch.Location = new System.Drawing.Point(128, 43);
            this.btnTeachersSearch.Name = "btnTeachersSearch";
            this.btnTeachersSearch.Size = new System.Drawing.Size(224, 44);
            this.btnTeachersSearch.TabIndex = 0;
            this.btnTeachersSearch.Text = "Vaspitaci pretraga";
            this.btnTeachersSearch.UseVisualStyleBackColor = true;
            this.btnTeachersSearch.Click += new System.EventHandler(this.btnTeachersSearch_Click);
            // 
            // btnChildrenSearch
            // 
            this.btnChildrenSearch.Location = new System.Drawing.Point(128, 106);
            this.btnChildrenSearch.Name = "btnChildrenSearch";
            this.btnChildrenSearch.Size = new System.Drawing.Size(224, 41);
            this.btnChildrenSearch.TabIndex = 1;
            this.btnChildrenSearch.Text = "Deca pretraga";
            this.btnChildrenSearch.UseVisualStyleBackColor = true;
            this.btnChildrenSearch.Click += new System.EventHandler(this.btnChildrenSearch_Click);
            // 
            // btnSeminarsSearch
            // 
            this.btnSeminarsSearch.Location = new System.Drawing.Point(128, 167);
            this.btnSeminarsSearch.Name = "btnSeminarsSearch";
            this.btnSeminarsSearch.Size = new System.Drawing.Size(224, 40);
            this.btnSeminarsSearch.TabIndex = 2;
            this.btnSeminarsSearch.Text = "Seminari pretraga";
            this.btnSeminarsSearch.UseVisualStyleBackColor = true;
            this.btnSeminarsSearch.Click += new System.EventHandler(this.btnSeminarsSearch_Click);
            // 
            // btnAbsenceSearch
            // 
            this.btnAbsenceSearch.Location = new System.Drawing.Point(128, 224);
            this.btnAbsenceSearch.Name = "btnAbsenceSearch";
            this.btnAbsenceSearch.Size = new System.Drawing.Size(224, 40);
            this.btnAbsenceSearch.TabIndex = 3;
            this.btnAbsenceSearch.Text = "Izostanci pretraga";
            this.btnAbsenceSearch.UseVisualStyleBackColor = true;
            this.btnAbsenceSearch.Click += new System.EventHandler(this.btnAbsenceSearch_Click);
            // 
            // btnSectionsSearch
            // 
            this.btnSectionsSearch.Location = new System.Drawing.Point(128, 281);
            this.btnSectionsSearch.Name = "btnSectionsSearch";
            this.btnSectionsSearch.Size = new System.Drawing.Size(224, 38);
            this.btnSectionsSearch.TabIndex = 4;
            this.btnSectionsSearch.Text = "Oblasti pretraga";
            this.btnSectionsSearch.UseVisualStyleBackColor = true;
            this.btnSectionsSearch.Click += new System.EventHandler(this.btnSectionsSearch_Click);
            // 
            // frmOneParameterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 396);
            this.Controls.Add(this.btnSectionsSearch);
            this.Controls.Add(this.btnAbsenceSearch);
            this.Controls.Add(this.btnSeminarsSearch);
            this.Controls.Add(this.btnChildrenSearch);
            this.Controls.Add(this.btnTeachersSearch);
            this.Name = "frmOneParameterView";
            this.Text = "Pregledi sa jednim parametrom";
            this.Load += new System.EventHandler(this.frmOneParameterView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTeachersSearch;
        private System.Windows.Forms.Button btnChildrenSearch;
        private System.Windows.Forms.Button btnSeminarsSearch;
        private System.Windows.Forms.Button btnAbsenceSearch;
        private System.Windows.Forms.Button btnSectionsSearch;
    }
}