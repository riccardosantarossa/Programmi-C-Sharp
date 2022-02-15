namespace AssociazioneCulturale
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
            this.grbInserimento = new System.Windows.Forms.GroupBox();
            this.lblIscrizione = new System.Windows.Forms.Label();
            this.txtIscrizione = new System.Windows.Forms.TextBox();
            this.txtCodiceFiscale = new System.Windows.Forms.TextBox();
            this.cmbCarica = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nmrNumeri = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTipoSocio = new System.Windows.Forms.GroupBox();
            this.rdbOrdinario = new System.Windows.Forms.RadioButton();
            this.rdbFondatore = new System.Windows.Forms.RadioButton();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnCalcolaQuote = new System.Windows.Forms.Button();
            this.btnCercaTessera = new System.Windows.Forms.Button();
            this.btnCercaPerCarica = new System.Windows.Forms.Button();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroSoci = new System.Windows.Forms.TextBox();
            this.grbVisualizza = new System.Windows.Forms.GroupBox();
            this.dtgSoci = new System.Windows.Forms.DataGridView();
            this.Tessera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrdinaNome = new System.Windows.Forms.Button();
            this.btnOrdinaTessera = new System.Windows.Forms.Button();
            this.nmrCercaTessera = new System.Windows.Forms.NumericUpDown();
            this.cmbCercaCarica = new System.Windows.Forms.ComboBox();
            this.grbInserimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumeri)).BeginInit();
            this.grbTipoSocio.SuspendLayout();
            this.grbVisualizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSoci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCercaTessera)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInserimento
            // 
            this.grbInserimento.AutoSize = true;
            this.grbInserimento.BackColor = System.Drawing.Color.Aqua;
            this.grbInserimento.Controls.Add(this.lblIscrizione);
            this.grbInserimento.Controls.Add(this.txtIscrizione);
            this.grbInserimento.Controls.Add(this.txtCodiceFiscale);
            this.grbInserimento.Controls.Add(this.cmbCarica);
            this.grbInserimento.Controls.Add(this.txtNome);
            this.grbInserimento.Controls.Add(this.nmrNumeri);
            this.grbInserimento.Controls.Add(this.label4);
            this.grbInserimento.Controls.Add(this.label3);
            this.grbInserimento.Controls.Add(this.label2);
            this.grbInserimento.Controls.Add(this.label1);
            this.grbInserimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInserimento.Location = new System.Drawing.Point(12, 12);
            this.grbInserimento.Name = "grbInserimento";
            this.grbInserimento.Size = new System.Drawing.Size(463, 267);
            this.grbInserimento.TabIndex = 0;
            this.grbInserimento.TabStop = false;
            this.grbInserimento.Text = "Inserimento";
            // 
            // lblIscrizione
            // 
            this.lblIscrizione.AutoSize = true;
            this.lblIscrizione.Location = new System.Drawing.Point(25, 210);
            this.lblIscrizione.Name = "lblIscrizione";
            this.lblIscrizione.Size = new System.Drawing.Size(145, 24);
            this.lblIscrizione.TabIndex = 9;
            this.lblIscrizione.Text = "Anno Iscrizione:";
            // 
            // txtIscrizione
            // 
            this.txtIscrizione.Location = new System.Drawing.Point(191, 210);
            this.txtIscrizione.Name = "txtIscrizione";
            this.txtIscrizione.Size = new System.Drawing.Size(120, 29);
            this.txtIscrizione.TabIndex = 8;
            // 
            // txtCodiceFiscale
            // 
            this.txtCodiceFiscale.Location = new System.Drawing.Point(191, 165);
            this.txtCodiceFiscale.Name = "txtCodiceFiscale";
            this.txtCodiceFiscale.Size = new System.Drawing.Size(120, 29);
            this.txtCodiceFiscale.TabIndex = 7;
            // 
            // cmbCarica
            // 
            this.cmbCarica.FormattingEnabled = true;
            this.cmbCarica.Items.AddRange(new object[] {
            "Presidente",
            "Tesoriere",
            "Segretario",
            "Nessuno"});
            this.cmbCarica.Location = new System.Drawing.Point(191, 124);
            this.cmbCarica.Name = "cmbCarica";
            this.cmbCarica.Size = new System.Drawing.Size(121, 32);
            this.cmbCarica.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(191, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(120, 29);
            this.txtNome.TabIndex = 5;
            // 
            // nmrNumeri
            // 
            this.nmrNumeri.Location = new System.Drawing.Point(191, 55);
            this.nmrNumeri.Name = "nmrNumeri";
            this.nmrNumeri.Size = new System.Drawing.Size(120, 29);
            this.nmrNumeri.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codice Fiscale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tessera:";
            // 
            // grbTipoSocio
            // 
            this.grbTipoSocio.BackColor = System.Drawing.Color.Aqua;
            this.grbTipoSocio.Controls.Add(this.rdbOrdinario);
            this.grbTipoSocio.Controls.Add(this.rdbFondatore);
            this.grbTipoSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTipoSocio.Location = new System.Drawing.Point(512, 13);
            this.grbTipoSocio.Name = "grbTipoSocio";
            this.grbTipoSocio.Size = new System.Drawing.Size(214, 130);
            this.grbTipoSocio.TabIndex = 1;
            this.grbTipoSocio.TabStop = false;
            this.grbTipoSocio.Text = "Tipo Socio:";
            // 
            // rdbOrdinario
            // 
            this.rdbOrdinario.AutoSize = true;
            this.rdbOrdinario.Location = new System.Drawing.Point(48, 77);
            this.rdbOrdinario.Name = "rdbOrdinario";
            this.rdbOrdinario.Size = new System.Drawing.Size(106, 28);
            this.rdbOrdinario.TabIndex = 1;
            this.rdbOrdinario.TabStop = true;
            this.rdbOrdinario.Text = "Ordinario";
            this.rdbOrdinario.UseVisualStyleBackColor = true;
            this.rdbOrdinario.CheckedChanged += new System.EventHandler(this.rdbOrdinario_CheckedChanged);
            // 
            // rdbFondatore
            // 
            this.rdbFondatore.AutoSize = true;
            this.rdbFondatore.Location = new System.Drawing.Point(48, 42);
            this.rdbFondatore.Name = "rdbFondatore";
            this.rdbFondatore.Size = new System.Drawing.Size(115, 28);
            this.rdbFondatore.TabIndex = 0;
            this.rdbFondatore.TabStop = true;
            this.rdbFondatore.Text = "Fondatore";
            this.rdbFondatore.UseVisualStyleBackColor = true;
            this.rdbFondatore.CheckedChanged += new System.EventHandler(this.rdbFondatore_CheckedChanged);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(828, 16);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 2;
            // 
            // btnCalcolaQuote
            // 
            this.btnCalcolaQuote.AutoSize = true;
            this.btnCalcolaQuote.Location = new System.Drawing.Point(981, 13);
            this.btnCalcolaQuote.Name = "btnCalcolaQuote";
            this.btnCalcolaQuote.Size = new System.Drawing.Size(98, 23);
            this.btnCalcolaQuote.TabIndex = 3;
            this.btnCalcolaQuote.Text = "Totale Quote";
            this.btnCalcolaQuote.UseVisualStyleBackColor = true;
            this.btnCalcolaQuote.Click += new System.EventHandler(this.btnCalcolaQuote_Click);
            // 
            // btnCercaTessera
            // 
            this.btnCercaTessera.AutoSize = true;
            this.btnCercaTessera.Location = new System.Drawing.Point(981, 55);
            this.btnCercaTessera.Name = "btnCercaTessera";
            this.btnCercaTessera.Size = new System.Drawing.Size(98, 23);
            this.btnCercaTessera.TabIndex = 4;
            this.btnCercaTessera.Text = "Cerca Tessera";
            this.btnCercaTessera.UseVisualStyleBackColor = true;
            this.btnCercaTessera.Click += new System.EventHandler(this.btnCercaTessera_Click);
            // 
            // btnCercaPerCarica
            // 
            this.btnCercaPerCarica.AutoSize = true;
            this.btnCercaPerCarica.Location = new System.Drawing.Point(981, 95);
            this.btnCercaPerCarica.Name = "btnCercaPerCarica";
            this.btnCercaPerCarica.Size = new System.Drawing.Size(98, 35);
            this.btnCercaPerCarica.TabIndex = 5;
            this.btnCercaPerCarica.Text = "Cerca per Carica";
            this.btnCercaPerCarica.UseVisualStyleBackColor = true;
            this.btnCercaPerCarica.Click += new System.EventHandler(this.btnCercaPerCarica_Click);
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(512, 164);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(79, 23);
            this.btnInserisci.TabIndex = 6;
            this.btnInserisci.Text = "INSERISCI";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.AutoSize = true;
            this.btnVisualizza.Location = new System.Drawing.Point(512, 194);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(79, 23);
            this.btnVisualizza.TabIndex = 7;
            this.btnVisualizza.Text = "VISUALIZZA";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(958, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "<--Numero di Soci";
            // 
            // txtNumeroSoci
            // 
            this.txtNumeroSoci.Location = new System.Drawing.Point(828, 148);
            this.txtNumeroSoci.Name = "txtNumeroSoci";
            this.txtNumeroSoci.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroSoci.TabIndex = 9;
            // 
            // grbVisualizza
            // 
            this.grbVisualizza.BackColor = System.Drawing.Color.Aqua;
            this.grbVisualizza.Controls.Add(this.dtgSoci);
            this.grbVisualizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVisualizza.Location = new System.Drawing.Point(12, 296);
            this.grbVisualizza.Name = "grbVisualizza";
            this.grbVisualizza.Size = new System.Drawing.Size(1109, 226);
            this.grbVisualizza.TabIndex = 10;
            this.grbVisualizza.TabStop = false;
            this.grbVisualizza.Text = "Dati";
            // 
            // dtgSoci
            // 
            this.dtgSoci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgSoci.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgSoci.BackgroundColor = System.Drawing.Color.White;
            this.dtgSoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSoci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tessera,
            this.Nome,
            this.Carica,
            this.anno,
            this.codf,
            this.quota});
            this.dtgSoci.GridColor = System.Drawing.Color.White;
            this.dtgSoci.Location = new System.Drawing.Point(6, 41);
            this.dtgSoci.Name = "dtgSoci";
            this.dtgSoci.RowHeadersWidth = 51;
            this.dtgSoci.Size = new System.Drawing.Size(1097, 150);
            this.dtgSoci.TabIndex = 0;
            // 
            // Tessera
            // 
            this.Tessera.HeaderText = "NUMERO TESSERA";
            this.Tessera.MinimumWidth = 6;
            this.Tessera.Name = "Tessera";
            this.Tessera.Width = 181;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "NOME SOCIO";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.Width = 133;
            // 
            // Carica
            // 
            this.Carica.HeaderText = "RUOLO";
            this.Carica.MinimumWidth = 6;
            this.Carica.Name = "Carica";
            this.Carica.Width = 96;
            // 
            // anno
            // 
            this.anno.HeaderText = "ANNO ISCRIZIONE";
            this.anno.MinimumWidth = 6;
            this.anno.Name = "anno";
            this.anno.Width = 174;
            // 
            // codf
            // 
            this.codf.HeaderText = "QUOTA";
            this.codf.MinimumWidth = 6;
            this.codf.Name = "codf";
            this.codf.Width = 95;
            // 
            // quota
            // 
            this.quota.HeaderText = "CODICE FISCALE";
            this.quota.MinimumWidth = 6;
            this.quota.Name = "quota";
            this.quota.Width = 166;
            // 
            // btnOrdinaNome
            // 
            this.btnOrdinaNome.Location = new System.Drawing.Point(981, 185);
            this.btnOrdinaNome.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdinaNome.Name = "btnOrdinaNome";
            this.btnOrdinaNome.Size = new System.Drawing.Size(98, 32);
            this.btnOrdinaNome.TabIndex = 12;
            this.btnOrdinaNome.Text = "Ordina per nome";
            this.btnOrdinaNome.UseVisualStyleBackColor = true;
            this.btnOrdinaNome.Click += new System.EventHandler(this.btnOrdinaNome_Click);
            // 
            // btnOrdinaTessera
            // 
            this.btnOrdinaTessera.Location = new System.Drawing.Point(981, 227);
            this.btnOrdinaTessera.Name = "btnOrdinaTessera";
            this.btnOrdinaTessera.Size = new System.Drawing.Size(98, 39);
            this.btnOrdinaTessera.TabIndex = 13;
            this.btnOrdinaTessera.Text = "Ordina per tessera";
            this.btnOrdinaTessera.UseVisualStyleBackColor = true;
            this.btnOrdinaTessera.Click += new System.EventHandler(this.btnOrdinaTessera_Click);
            // 
            // nmrCercaTessera
            // 
            this.nmrCercaTessera.Location = new System.Drawing.Point(828, 57);
            this.nmrCercaTessera.Name = "nmrCercaTessera";
            this.nmrCercaTessera.Size = new System.Drawing.Size(120, 20);
            this.nmrCercaTessera.TabIndex = 15;
            // 
            // cmbCercaCarica
            // 
            this.cmbCercaCarica.FormattingEnabled = true;
            this.cmbCercaCarica.Items.AddRange(new object[] {
            "Presidente",
            "Tesoriere",
            "Segretario ",
            "Nessuno"});
            this.cmbCercaCarica.Location = new System.Drawing.Point(828, 106);
            this.cmbCercaCarica.Name = "cmbCercaCarica";
            this.cmbCercaCarica.Size = new System.Drawing.Size(121, 21);
            this.cmbCercaCarica.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 556);
            this.Controls.Add(this.cmbCercaCarica);
            this.Controls.Add(this.nmrCercaTessera);
            this.Controls.Add(this.btnOrdinaTessera);
            this.Controls.Add(this.btnOrdinaNome);
            this.Controls.Add(this.grbVisualizza);
            this.Controls.Add(this.txtNumeroSoci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.btnCercaPerCarica);
            this.Controls.Add(this.btnCercaTessera);
            this.Controls.Add(this.btnCalcolaQuote);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.grbTipoSocio);
            this.Controls.Add(this.grbInserimento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbInserimento.ResumeLayout(false);
            this.grbInserimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumeri)).EndInit();
            this.grbTipoSocio.ResumeLayout(false);
            this.grbTipoSocio.PerformLayout();
            this.grbVisualizza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSoci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCercaTessera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbInserimento;
        private System.Windows.Forms.ComboBox cmbCarica;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown nmrNumeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodiceFiscale;
        private System.Windows.Forms.GroupBox grbTipoSocio;
        private System.Windows.Forms.RadioButton rdbOrdinario;
        private System.Windows.Forms.RadioButton rdbFondatore;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnCalcolaQuote;
        private System.Windows.Forms.Button btnCercaTessera;
        private System.Windows.Forms.Button btnCercaPerCarica;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroSoci;
        private System.Windows.Forms.GroupBox grbVisualizza;
        private System.Windows.Forms.Label lblIscrizione;
        private System.Windows.Forms.TextBox txtIscrizione;
        private System.Windows.Forms.DataGridView dtgSoci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tessera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carica;
        private System.Windows.Forms.DataGridViewTextBoxColumn anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codf;
        private System.Windows.Forms.DataGridViewTextBoxColumn quota;
        private System.Windows.Forms.Button btnOrdinaNome;
        private System.Windows.Forms.Button btnOrdinaTessera;
        private System.Windows.Forms.NumericUpDown nmrCercaTessera;
        private System.Windows.Forms.ComboBox cmbCercaCarica;
    }
}

