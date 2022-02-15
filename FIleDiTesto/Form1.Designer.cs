
namespace FIleDiTesto
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtScrivi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnApri = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtScrivi
            // 
            this.txtScrivi.Location = new System.Drawing.Point(280, 90);
            this.txtScrivi.Multiline = true;
            this.txtScrivi.Name = "txtScrivi";
            this.txtScrivi.Size = new System.Drawing.Size(575, 393);
            this.txtScrivi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scrivi qui il tuo testo";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(280, 516);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 2;
            this.btnSalva.Text = "SALVA FILE";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnApri
            // 
            this.btnApri.Location = new System.Drawing.Point(533, 516);
            this.btnApri.Name = "btnApri";
            this.btnApri.Size = new System.Drawing.Size(75, 23);
            this.btnApri.TabIndex = 3;
            this.btnApri.Text = "APRI FILE";
            this.btnApri.UseVisualStyleBackColor = true;
            this.btnApri.Click += new System.EventHandler(this.btnApri_Click);
            // 
            // btnChiudi
            // 
            this.btnChiudi.Location = new System.Drawing.Point(769, 515);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(85, 23);
            this.btnChiudi.TabIndex = 4;
            this.btnChiudi.Text = "CHIUDI ";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 644);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.btnApri);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScrivi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScrivi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnApri;
        private System.Windows.Forms.Button btnChiudi;
    }
}

