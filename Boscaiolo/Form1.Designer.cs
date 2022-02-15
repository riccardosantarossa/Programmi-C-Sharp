namespace Boscaiolo
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
            this.pctBoscaiolo = new System.Windows.Forms.PictureBox();
            this.pctAscia = new System.Windows.Forms.PictureBox();
            this.pctAlbero = new System.Windows.Forms.PictureBox();
            this.btnTagliaAlberi = new System.Windows.Forms.Button();
            this.btnGeneraForesta = new System.Windows.Forms.Button();
            this.lblnTagli = new System.Windows.Forms.Label();
            this.lblMetri = new System.Windows.Forms.Label();
            this.lblNFaggi = new System.Windows.Forms.Label();
            this.lblNAceri = new System.Windows.Forms.Label();
            this.lblAlberiTagliati = new System.Windows.Forms.Label();
            this.lblMetriSeccati = new System.Windows.Forms.Label();
            this.lblFaggi = new System.Windows.Forms.Label();
            this.lblAceri = new System.Windows.Forms.Label();
            this.lblVita = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoscaiolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAscia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlbero)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBoscaiolo
            // 
            this.pctBoscaiolo.Location = new System.Drawing.Point(28, 35);
            this.pctBoscaiolo.Name = "pctBoscaiolo";
            this.pctBoscaiolo.Size = new System.Drawing.Size(325, 314);
            this.pctBoscaiolo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoscaiolo.TabIndex = 0;
            this.pctBoscaiolo.TabStop = false;
            // 
            // pctAscia
            // 
            this.pctAscia.Location = new System.Drawing.Point(443, 157);
            this.pctAscia.Name = "pctAscia";
            this.pctAscia.Size = new System.Drawing.Size(145, 93);
            this.pctAscia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAscia.TabIndex = 1;
            this.pctAscia.TabStop = false;
            // 
            // pctAlbero
            // 
            this.pctAlbero.Location = new System.Drawing.Point(676, 112);
            this.pctAlbero.Name = "pctAlbero";
            this.pctAlbero.Size = new System.Drawing.Size(395, 489);
            this.pctAlbero.TabIndex = 2;
            this.pctAlbero.TabStop = false;
            // 
            // btnTagliaAlberi
            // 
            this.btnTagliaAlberi.AutoSize = true;
            this.btnTagliaAlberi.Location = new System.Drawing.Point(443, 128);
            this.btnTagliaAlberi.Name = "btnTagliaAlberi";
            this.btnTagliaAlberi.Size = new System.Drawing.Size(147, 23);
            this.btnTagliaAlberi.TabIndex = 3;
            this.btnTagliaAlberi.Text = "Comincia a tagliare gli alberi";
            this.btnTagliaAlberi.UseVisualStyleBackColor = true;
            this.btnTagliaAlberi.Click += new System.EventHandler(this.btnTagliaAlberi_Click);
            // 
            // btnGeneraForesta
            // 
            this.btnGeneraForesta.AutoSize = true;
            this.btnGeneraForesta.Location = new System.Drawing.Point(794, 83);
            this.btnGeneraForesta.Name = "btnGeneraForesta";
            this.btnGeneraForesta.Size = new System.Drawing.Size(147, 23);
            this.btnGeneraForesta.TabIndex = 4;
            this.btnGeneraForesta.Text = "Crea la foresta di mille alberi";
            this.btnGeneraForesta.UseVisualStyleBackColor = true;
            this.btnGeneraForesta.Click += new System.EventHandler(this.btnGeneraForesta_Click);
            // 
            // lblnTagli
            // 
            this.lblnTagli.AutoSize = true;
            this.lblnTagli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnTagli.ForeColor = System.Drawing.Color.Red;
            this.lblnTagli.Location = new System.Drawing.Point(28, 380);
            this.lblnTagli.Name = "lblnTagli";
            this.lblnTagli.Size = new System.Drawing.Size(136, 16);
            this.lblnTagli.TabIndex = 5;
            this.lblnTagli.Text = "ALBERI TAGLIATI:";
            // 
            // lblMetri
            // 
            this.lblMetri.AutoSize = true;
            this.lblMetri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetri.ForeColor = System.Drawing.Color.Red;
            this.lblMetri.Location = new System.Drawing.Point(28, 411);
            this.lblMetri.Name = "lblMetri";
            this.lblMetri.Size = new System.Drawing.Size(127, 16);
            this.lblMetri.TabIndex = 6;
            this.lblMetri.Text = "METRI SECCATI:";
            // 
            // lblNFaggi
            // 
            this.lblNFaggi.AutoSize = true;
            this.lblNFaggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNFaggi.ForeColor = System.Drawing.Color.Red;
            this.lblNFaggi.Location = new System.Drawing.Point(28, 444);
            this.lblNFaggi.Name = "lblNFaggi";
            this.lblNFaggi.Size = new System.Drawing.Size(116, 16);
            this.lblNFaggi.TabIndex = 7;
            this.lblNFaggi.Text = "NFaggiTagliati:";
            // 
            // lblNAceri
            // 
            this.lblNAceri.AutoSize = true;
            this.lblNAceri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNAceri.ForeColor = System.Drawing.Color.Red;
            this.lblNAceri.Location = new System.Drawing.Point(31, 477);
            this.lblNAceri.Name = "lblNAceri";
            this.lblNAceri.Size = new System.Drawing.Size(112, 16);
            this.lblNAceri.TabIndex = 8;
            this.lblNAceri.Text = "NAceriTagliati:";
            // 
            // lblAlberiTagliati
            // 
            this.lblAlberiTagliati.AutoSize = true;
            this.lblAlberiTagliati.Location = new System.Drawing.Point(196, 383);
            this.lblAlberiTagliati.Name = "lblAlberiTagliati";
            this.lblAlberiTagliati.Size = new System.Drawing.Size(0, 13);
            this.lblAlberiTagliati.TabIndex = 9;
            // 
            // lblMetriSeccati
            // 
            this.lblMetriSeccati.AutoSize = true;
            this.lblMetriSeccati.Location = new System.Drawing.Point(196, 411);
            this.lblMetriSeccati.Name = "lblMetriSeccati";
            this.lblMetriSeccati.Size = new System.Drawing.Size(0, 13);
            this.lblMetriSeccati.TabIndex = 10;
            // 
            // lblFaggi
            // 
            this.lblFaggi.AutoSize = true;
            this.lblFaggi.Location = new System.Drawing.Point(196, 446);
            this.lblFaggi.Name = "lblFaggi";
            this.lblFaggi.Size = new System.Drawing.Size(0, 13);
            this.lblFaggi.TabIndex = 11;
            // 
            // lblAceri
            // 
            this.lblAceri.AutoSize = true;
            this.lblAceri.Location = new System.Drawing.Point(196, 477);
            this.lblAceri.Name = "lblAceri";
            this.lblAceri.Size = new System.Drawing.Size(0, 13);
            this.lblAceri.TabIndex = 12;
            // 
            // lblVita
            // 
            this.lblVita.AutoSize = true;
            this.lblVita.Location = new System.Drawing.Point(389, 541);
            this.lblVita.Name = "lblVita";
            this.lblVita.Size = new System.Drawing.Size(0, 13);
            this.lblVita.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 647);
            this.Controls.Add(this.lblVita);
            this.Controls.Add(this.lblAceri);
            this.Controls.Add(this.lblFaggi);
            this.Controls.Add(this.lblMetriSeccati);
            this.Controls.Add(this.lblAlberiTagliati);
            this.Controls.Add(this.lblNAceri);
            this.Controls.Add(this.lblNFaggi);
            this.Controls.Add(this.lblMetri);
            this.Controls.Add(this.lblnTagli);
            this.Controls.Add(this.btnGeneraForesta);
            this.Controls.Add(this.btnTagliaAlberi);
            this.Controls.Add(this.pctAlbero);
            this.Controls.Add(this.pctAscia);
            this.Controls.Add(this.pctBoscaiolo);
            this.Name = "Form1";
            this.Text = "BoscaioloCIeco";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoscaiolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAscia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlbero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBoscaiolo;
        private System.Windows.Forms.PictureBox pctAscia;
        private System.Windows.Forms.PictureBox pctAlbero;
        private System.Windows.Forms.Button btnTagliaAlberi;
        private System.Windows.Forms.Button btnGeneraForesta;
        private System.Windows.Forms.Label lblnTagli;
        private System.Windows.Forms.Label lblMetri;
        private System.Windows.Forms.Label lblNFaggi;
        private System.Windows.Forms.Label lblNAceri;
        private System.Windows.Forms.Label lblAlberiTagliati;
        private System.Windows.Forms.Label lblMetriSeccati;
        private System.Windows.Forms.Label lblFaggi;
        private System.Windows.Forms.Label lblAceri;
        private System.Windows.Forms.Label lblVita;
    }
}

