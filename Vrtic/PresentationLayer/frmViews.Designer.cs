namespace PresentationLayer
{
    partial class frmViews
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
            this.btnVaspitaci = new System.Windows.Forms.Button();
            this.btnDeca = new System.Windows.Forms.Button();
            this.btnVaspitaciSeminari = new System.Windows.Forms.Button();
            this.btnIzostanciDece = new System.Windows.Forms.Button();
            this.btnOblastideca = new System.Windows.Forms.Button();
            this.btnSobe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVaspitaci
            // 
            this.btnVaspitaci.Location = new System.Drawing.Point(154, 57);
            this.btnVaspitaci.Name = "btnVaspitaci";
            this.btnVaspitaci.Size = new System.Drawing.Size(258, 41);
            this.btnVaspitaci.TabIndex = 0;
            this.btnVaspitaci.Text = "Svi vaspitaci";
            this.btnVaspitaci.UseVisualStyleBackColor = true;
            this.btnVaspitaci.Click += new System.EventHandler(this.btnVaspitaci_Click);
            // 
            // btnDeca
            // 
            this.btnDeca.Location = new System.Drawing.Point(154, 123);
            this.btnDeca.Name = "btnDeca";
            this.btnDeca.Size = new System.Drawing.Size(258, 42);
            this.btnDeca.TabIndex = 1;
            this.btnDeca.Text = "Sva deca";
            this.btnDeca.UseVisualStyleBackColor = true;
            this.btnDeca.Click += new System.EventHandler(this.btnDeca_Click);
            // 
            // btnVaspitaciSeminari
            // 
            this.btnVaspitaciSeminari.Location = new System.Drawing.Point(154, 187);
            this.btnVaspitaciSeminari.Name = "btnVaspitaciSeminari";
            this.btnVaspitaciSeminari.Size = new System.Drawing.Size(258, 46);
            this.btnVaspitaciSeminari.TabIndex = 2;
            this.btnVaspitaciSeminari.Text = "Vaspitaci i seminari";
            this.btnVaspitaciSeminari.UseVisualStyleBackColor = true;
            this.btnVaspitaciSeminari.Click += new System.EventHandler(this.btnVaspitaciSeminari_Click);
            // 
            // btnIzostanciDece
            // 
            this.btnIzostanciDece.Location = new System.Drawing.Point(154, 251);
            this.btnIzostanciDece.Name = "btnIzostanciDece";
            this.btnIzostanciDece.Size = new System.Drawing.Size(258, 46);
            this.btnIzostanciDece.TabIndex = 3;
            this.btnIzostanciDece.Text = "Izostanci dece";
            this.btnIzostanciDece.UseVisualStyleBackColor = true;
            this.btnIzostanciDece.Click += new System.EventHandler(this.btnIzostanciDece_Click);
            // 
            // btnOblastideca
            // 
            this.btnOblastideca.Location = new System.Drawing.Point(154, 316);
            this.btnOblastideca.Name = "btnOblastideca";
            this.btnOblastideca.Size = new System.Drawing.Size(258, 46);
            this.btnOblastideca.TabIndex = 4;
            this.btnOblastideca.Text = "Predjene oblasti";
            this.btnOblastideca.UseVisualStyleBackColor = true;
            this.btnOblastideca.Click += new System.EventHandler(this.btnOblastideca_Click);
            // 
            // btnSobe
            // 
            this.btnSobe.Location = new System.Drawing.Point(154, 382);
            this.btnSobe.Name = "btnSobe";
            this.btnSobe.Size = new System.Drawing.Size(258, 46);
            this.btnSobe.TabIndex = 5;
            this.btnSobe.Text = "Sve sobe";
            this.btnSobe.UseVisualStyleBackColor = true;
            this.btnSobe.Click += new System.EventHandler(this.btnSobe_Click);
            // 
            // Pregledi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 489);
            this.Controls.Add(this.btnSobe);
            this.Controls.Add(this.btnOblastideca);
            this.Controls.Add(this.btnIzostanciDece);
            this.Controls.Add(this.btnVaspitaciSeminari);
            this.Controls.Add(this.btnDeca);
            this.Controls.Add(this.btnVaspitaci);
            this.Name = "Pregledi";
            this.Text = "Pregledi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVaspitaci;
        private System.Windows.Forms.Button btnDeca;
        private System.Windows.Forms.Button btnVaspitaciSeminari;
        private System.Windows.Forms.Button btnIzostanciDece;
        private System.Windows.Forms.Button btnOblastideca;
        private System.Windows.Forms.Button btnSobe;
    }
}