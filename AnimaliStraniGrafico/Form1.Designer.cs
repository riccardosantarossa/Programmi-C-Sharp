namespace AnimaliStraniGrafico
{
    partial class frmAnimali
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
            this.components = new System.ComponentModel.Container();
            this.btnGeneraAnimale = new System.Windows.Forms.Button();
            this.pctAnimaletto = new System.Windows.Forms.PictureBox();
            this.btnAddEnergia = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEnergiaMax = new System.Windows.Forms.Label();
            this.lblMostraTipo = new System.Windows.Forms.Label();
            this.lblMostraEnerMax = new System.Windows.Forms.Label();
            this.lblMostraEnergia = new System.Windows.Forms.Label();
            this.lblMostraVolo = new System.Windows.Forms.Label();
            this.lblEnergia = new System.Windows.Forms.Label();
            this.lblVolo = new System.Windows.Forms.Label();
            this.btnVeleno = new System.Windows.Forms.Button();
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimaletto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeneraAnimale
            // 
            this.btnGeneraAnimale.AutoSize = true;
            this.btnGeneraAnimale.Location = new System.Drawing.Point(148, 415);
            this.btnGeneraAnimale.Name = "btnGeneraAnimale";
            this.btnGeneraAnimale.Size = new System.Drawing.Size(118, 23);
            this.btnGeneraAnimale.TabIndex = 1;
            this.btnGeneraAnimale.Text = "Genera un animaletto";
            this.btnGeneraAnimale.UseVisualStyleBackColor = true;
            this.btnGeneraAnimale.Click += new System.EventHandler(this.btnGeneraAnimale_Click);
            // 
            // pctAnimaletto
            // 
            this.pctAnimaletto.Location = new System.Drawing.Point(37, 27);
            this.pctAnimaletto.Name = "pctAnimaletto";
            this.pctAnimaletto.Size = new System.Drawing.Size(345, 384);
            this.pctAnimaletto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAnimaletto.TabIndex = 2;
            this.pctAnimaletto.TabStop = false;
            // 
            // btnAddEnergia
            // 
            this.btnAddEnergia.AutoSize = true;
            this.btnAddEnergia.Location = new System.Drawing.Point(410, 117);
            this.btnAddEnergia.Name = "btnAddEnergia";
            this.btnAddEnergia.Size = new System.Drawing.Size(106, 38);
            this.btnAddEnergia.TabIndex = 3;
            this.btnAddEnergia.Text = "Nutri il tuo animale";
            this.btnAddEnergia.UseVisualStyleBackColor = true;
            this.btnAddEnergia.Click += new System.EventHandler(this.btnAddEnergia_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Blue;
            this.lblTipo.Location = new System.Drawing.Point(698, 76);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(51, 20);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "label1";
            this.lblTipo.Visible = false;
            // 
            // lblEnergiaMax
            // 
            this.lblEnergiaMax.AutoSize = true;
            this.lblEnergiaMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergiaMax.ForeColor = System.Drawing.Color.Blue;
            this.lblEnergiaMax.Location = new System.Drawing.Point(698, 117);
            this.lblEnergiaMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnergiaMax.Name = "lblEnergiaMax";
            this.lblEnergiaMax.Size = new System.Drawing.Size(51, 20);
            this.lblEnergiaMax.TabIndex = 5;
            this.lblEnergiaMax.Text = "label1";
            this.lblEnergiaMax.Visible = false;
            // 
            // lblMostraTipo
            // 
            this.lblMostraTipo.AutoSize = true;
            this.lblMostraTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraTipo.Location = new System.Drawing.Point(571, 76);
            this.lblMostraTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMostraTipo.Name = "lblMostraTipo";
            this.lblMostraTipo.Size = new System.Drawing.Size(39, 20);
            this.lblMostraTipo.TabIndex = 6;
            this.lblMostraTipo.Text = "Tipo";
            // 
            // lblMostraEnerMax
            // 
            this.lblMostraEnerMax.AutoSize = true;
            this.lblMostraEnerMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraEnerMax.Location = new System.Drawing.Point(571, 124);
            this.lblMostraEnerMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMostraEnerMax.Name = "lblMostraEnerMax";
            this.lblMostraEnerMax.Size = new System.Drawing.Size(93, 20);
            this.lblMostraEnerMax.TabIndex = 7;
            this.lblMostraEnerMax.Text = "EnergiaMax";
            // 
            // lblMostraEnergia
            // 
            this.lblMostraEnergia.AutoSize = true;
            this.lblMostraEnergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraEnergia.Location = new System.Drawing.Point(571, 168);
            this.lblMostraEnergia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMostraEnergia.Name = "lblMostraEnergia";
            this.lblMostraEnergia.Size = new System.Drawing.Size(115, 20);
            this.lblMostraEnergia.TabIndex = 8;
            this.lblMostraEnergia.Text = "EnergiaAttuale";
            // 
            // lblMostraVolo
            // 
            this.lblMostraVolo.AutoSize = true;
            this.lblMostraVolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraVolo.Location = new System.Drawing.Point(572, 209);
            this.lblMostraVolo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMostraVolo.Name = "lblMostraVolo";
            this.lblMostraVolo.Size = new System.Drawing.Size(50, 20);
            this.lblMostraVolo.TabIndex = 9;
            this.lblMostraVolo.Text = "Vola?";
            // 
            // lblEnergia
            // 
            this.lblEnergia.AutoSize = true;
            this.lblEnergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergia.ForeColor = System.Drawing.Color.Blue;
            this.lblEnergia.Location = new System.Drawing.Point(698, 168);
            this.lblEnergia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnergia.Name = "lblEnergia";
            this.lblEnergia.Size = new System.Drawing.Size(51, 20);
            this.lblEnergia.TabIndex = 10;
            this.lblEnergia.Text = "label1";
            this.lblEnergia.Visible = false;
            // 
            // lblVolo
            // 
            this.lblVolo.AutoSize = true;
            this.lblVolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolo.ForeColor = System.Drawing.Color.Blue;
            this.lblVolo.Location = new System.Drawing.Point(698, 209);
            this.lblVolo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolo.Name = "lblVolo";
            this.lblVolo.Size = new System.Drawing.Size(51, 20);
            this.lblVolo.TabIndex = 11;
            this.lblVolo.Text = "label2";
            this.lblVolo.Visible = false;
            // 
            // btnVeleno
            // 
            this.btnVeleno.Location = new System.Drawing.Point(410, 169);
            this.btnVeleno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVeleno.Name = "btnVeleno";
            this.btnVeleno.Size = new System.Drawing.Size(106, 34);
            this.btnVeleno.TabIndex = 12;
            this.btnVeleno.Text = "Avvelena";
            this.btnVeleno.UseVisualStyleBackColor = true;
            this.btnVeleno.Click += new System.EventHandler(this.btnVeleno_Click);
            // 
            // tmrTempo
            // 
            this.tmrTempo.Interval = 1000;
            this.tmrTempo.Tick += new System.EventHandler(this.tmrTempo_Tick);
            // 
            // frmAnimali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVeleno);
            this.Controls.Add(this.lblVolo);
            this.Controls.Add(this.lblEnergia);
            this.Controls.Add(this.lblMostraVolo);
            this.Controls.Add(this.lblMostraEnergia);
            this.Controls.Add(this.lblMostraEnerMax);
            this.Controls.Add(this.lblMostraTipo);
            this.Controls.Add(this.lblEnergiaMax);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnAddEnergia);
            this.Controls.Add(this.pctAnimaletto);
            this.Controls.Add(this.btnGeneraAnimale);
            this.Name = "frmAnimali";
            this.Text = "AnimaliStrani";
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimaletto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGeneraAnimale;
        private System.Windows.Forms.PictureBox pctAnimaletto;
        private System.Windows.Forms.Button btnAddEnergia;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEnergiaMax;
        private System.Windows.Forms.Label lblMostraTipo;
        private System.Windows.Forms.Label lblMostraEnerMax;
        private System.Windows.Forms.Label lblMostraEnergia;
        private System.Windows.Forms.Label lblMostraVolo;
        private System.Windows.Forms.Label lblEnergia;
        private System.Windows.Forms.Label lblVolo;
        private System.Windows.Forms.Button btnVeleno;
        private System.Windows.Forms.Timer tmrTempo;
    }
}

