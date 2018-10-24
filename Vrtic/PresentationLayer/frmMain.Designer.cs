namespace PresentationLayer
{
    partial class frmMain
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
            this.btnViews = new System.Windows.Forms.Button();
            this.btnSearchText = new System.Windows.Forms.Button();
            this.btnPrecisionSearch = new System.Windows.Forms.Button();
            this.btnDataChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViews
            // 
            this.btnViews.Location = new System.Drawing.Point(161, 53);
            this.btnViews.Name = "btnViews";
            this.btnViews.Size = new System.Drawing.Size(270, 49);
            this.btnViews.TabIndex = 0;
            this.btnViews.Text = "Pregledi";
            this.btnViews.UseVisualStyleBackColor = true;
            this.btnViews.Click += new System.EventHandler(this.btnViews_Click);
            // 
            // btnSearchText
            // 
            this.btnSearchText.Location = new System.Drawing.Point(161, 122);
            this.btnSearchText.Name = "btnSearchText";
            this.btnSearchText.Size = new System.Drawing.Size(270, 47);
            this.btnSearchText.TabIndex = 1;
            this.btnSearchText.Text = "Pretraga po tekstu";
            this.btnSearchText.UseVisualStyleBackColor = true;
            this.btnSearchText.Click += new System.EventHandler(this.btnTextSearch_Click);
            // 
            // btnPrecisionSearch
            // 
            this.btnPrecisionSearch.Location = new System.Drawing.Point(161, 187);
            this.btnPrecisionSearch.Name = "btnPrecisionSearch";
            this.btnPrecisionSearch.Size = new System.Drawing.Size(270, 49);
            this.btnPrecisionSearch.TabIndex = 2;
            this.btnPrecisionSearch.Text = "Precizne pretrage";
            this.btnPrecisionSearch.UseVisualStyleBackColor = true;
            this.btnPrecisionSearch.Click += new System.EventHandler(this.btnPrecisionSearch_Click);
            // 
            // btnDataChange
            // 
            this.btnDataChange.Location = new System.Drawing.Point(161, 255);
            this.btnDataChange.Name = "btnDataChange";
            this.btnDataChange.Size = new System.Drawing.Size(270, 47);
            this.btnDataChange.TabIndex = 3;
            this.btnDataChange.Text = "Izmena podataka";
            this.btnDataChange.UseVisualStyleBackColor = true;
            this.btnDataChange.Click += new System.EventHandler(this.btnDataChange_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 395);
            this.Controls.Add(this.btnDataChange);
            this.Controls.Add(this.btnPrecisionSearch);
            this.Controls.Add(this.btnSearchText);
            this.Controls.Add(this.btnViews);
            this.Name = "frmMain";
            this.Text = "Glavna forma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViews;
        private System.Windows.Forms.Button btnSearchText;
        private System.Windows.Forms.Button btnPrecisionSearch;
        private System.Windows.Forms.Button btnDataChange;
    }
}

