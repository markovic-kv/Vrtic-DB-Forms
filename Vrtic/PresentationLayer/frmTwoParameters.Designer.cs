namespace PresentationLayer
{
    partial class frmTwoParameters
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
            this.btnSemTeacherPoints = new System.Windows.Forms.Button();
            this.btnBornChildren = new System.Windows.Forms.Button();
            this.btnChildrenAbsenc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSemTeacherPoints
            // 
            this.btnSemTeacherPoints.Location = new System.Drawing.Point(105, 44);
            this.btnSemTeacherPoints.Name = "btnSemTeacherPoints";
            this.btnSemTeacherPoints.Size = new System.Drawing.Size(258, 54);
            this.btnSemTeacherPoints.TabIndex = 0;
            this.btnSemTeacherPoints.Text = "Seminari vaspitaca po bodovima";
            this.btnSemTeacherPoints.UseVisualStyleBackColor = true;
            this.btnSemTeacherPoints.Click += new System.EventHandler(this.btnSemTeacherPoints_Click);
            // 
            // btnBornChildren
            // 
            this.btnBornChildren.Location = new System.Drawing.Point(105, 120);
            this.btnBornChildren.Name = "btnBornChildren";
            this.btnBornChildren.Size = new System.Drawing.Size(258, 49);
            this.btnBornChildren.TabIndex = 1;
            this.btnBornChildren.Text = "Deca po uzrastu";
            this.btnBornChildren.UseVisualStyleBackColor = true;
            this.btnBornChildren.Click += new System.EventHandler(this.btnBornChildren_Click);
            // 
            // btnChildrenAbsenc
            // 
            this.btnChildrenAbsenc.Location = new System.Drawing.Point(105, 197);
            this.btnChildrenAbsenc.Name = "btnChildrenAbsenc";
            this.btnChildrenAbsenc.Size = new System.Drawing.Size(258, 49);
            this.btnChildrenAbsenc.TabIndex = 2;
            this.btnChildrenAbsenc.Text = "Izostanci dece";
            this.btnChildrenAbsenc.UseVisualStyleBackColor = true;
            this.btnChildrenAbsenc.Click += new System.EventHandler(this.btnChildrenAbsence_Click);
            // 
            // frmTwoParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 297);
            this.Controls.Add(this.btnChildrenAbsenc);
            this.Controls.Add(this.btnBornChildren);
            this.Controls.Add(this.btnSemTeacherPoints);
            this.Name = "frmTwoParameters";
            this.Text = "Pozivanje dva parametra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSemTeacherPoints;
        private System.Windows.Forms.Button btnBornChildren;
        private System.Windows.Forms.Button btnChildrenAbsenc;
    }
}