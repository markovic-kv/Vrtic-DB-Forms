namespace PresentationLayer
{
    partial class frmTwoParametresQuestion
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
            this.lblManja = new System.Windows.Forms.Label();
            this.lblVeca = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblManja
            // 
            this.lblManja.AutoSize = true;
            this.lblManja.Location = new System.Drawing.Point(24, 25);
            this.lblManja.Name = "lblManja";
            this.lblManja.Size = new System.Drawing.Size(21, 13);
            this.lblManja.TabIndex = 0;
            this.lblManja.Text = "Od";
            // 
            // lblVeca
            // 
            this.lblVeca.AutoSize = true;
            this.lblVeca.Location = new System.Drawing.Point(24, 65);
            this.lblVeca.Name = "lblVeca";
            this.lblVeca.Size = new System.Drawing.Size(21, 13);
            this.lblVeca.TabIndex = 1;
            this.lblVeca.Text = "Do";
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(78, 22);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(201, 20);
            this.txtLow.TabIndex = 2;
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(78, 58);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(201, 20);
            this.txtHigh.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(116, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Pretrazi";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TwoParametresQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 153);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.lblVeca);
            this.Controls.Add(this.lblManja);
            this.Name = "TwoParametresQuestion";
            this.Text = "Pitalica za dva parametra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManja;
        private System.Windows.Forms.Label lblVeca;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.Button btnSearch;
    }
}