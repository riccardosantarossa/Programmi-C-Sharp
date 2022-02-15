
namespace Museo
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
            this.gpbInput = new System.Windows.Forms.GroupBox();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.rdbArazzo = new System.Windows.Forms.RadioButton();
            this.rdbScultura = new System.Windows.Forms.RadioButton();
            this.rdbQuadro = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbModifica = new System.Windows.Forms.GroupBox();
            this.btnModificaOpera = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModificaCodice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.grdOpere = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ann = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbCerca = new System.Windows.Forms.GroupBox();
            this.btnCercaAutore = new System.Windows.Forms.Button();
            this.txtCercaAutore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gpbElimina = new System.Windows.Forms.GroupBox();
            this.btnElimina = new System.Windows.Forms.Button();
            this.txtCodiceElimina = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInfoFile = new System.Windows.Forms.RichTextBox();
            this.gpbInput.SuspendLayout();
            this.gpbModifica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpere)).BeginInit();
            this.gpbCerca.SuspendLayout();
            this.gpbElimina.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInput
            // 
            this.gpbInput.BackColor = System.Drawing.Color.SkyBlue;
            this.gpbInput.Controls.Add(this.txtAnno);
            this.gpbInput.Controls.Add(this.txtTitolo);
            this.gpbInput.Controls.Add(this.txtAutore);
            this.gpbInput.Controls.Add(this.rdbArazzo);
            this.gpbInput.Controls.Add(this.rdbScultura);
            this.gpbInput.Controls.Add(this.rdbQuadro);
            this.gpbInput.Controls.Add(this.label4);
            this.gpbInput.Controls.Add(this.label3);
            this.gpbInput.Controls.Add(this.label2);
            this.gpbInput.Controls.Add(this.label1);
            this.gpbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInput.ForeColor = System.Drawing.Color.White;
            this.gpbInput.Location = new System.Drawing.Point(13, 13);
            this.gpbInput.Name = "gpbInput";
            this.gpbInput.Size = new System.Drawing.Size(225, 221);
            this.gpbInput.TabIndex = 0;
            this.gpbInput.TabStop = false;
            this.gpbInput.Text = "INSERIMENTO";
            // 
            // txtAnno
            // 
            this.txtAnno.Location = new System.Drawing.Point(89, 94);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(100, 26);
            this.txtAnno.TabIndex = 9;
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(89, 59);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 26);
            this.txtTitolo.TabIndex = 8;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(89, 25);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 26);
            this.txtAutore.TabIndex = 7;
            // 
            // rdbArazzo
            // 
            this.rdbArazzo.AutoSize = true;
            this.rdbArazzo.Location = new System.Drawing.Point(89, 185);
            this.rdbArazzo.Name = "rdbArazzo";
            this.rdbArazzo.Size = new System.Drawing.Size(77, 24);
            this.rdbArazzo.TabIndex = 6;
            this.rdbArazzo.TabStop = true;
            this.rdbArazzo.Text = "Arazzo";
            this.rdbArazzo.UseVisualStyleBackColor = true;
            // 
            // rdbScultura
            // 
            this.rdbScultura.AutoSize = true;
            this.rdbScultura.Location = new System.Drawing.Point(89, 154);
            this.rdbScultura.Name = "rdbScultura";
            this.rdbScultura.Size = new System.Drawing.Size(86, 24);
            this.rdbScultura.TabIndex = 5;
            this.rdbScultura.TabStop = true;
            this.rdbScultura.Text = "Scultura";
            this.rdbScultura.UseVisualStyleBackColor = true;
            // 
            // rdbQuadro
            // 
            this.rdbQuadro.AutoSize = true;
            this.rdbQuadro.Location = new System.Drawing.Point(89, 123);
            this.rdbQuadro.Name = "rdbQuadro";
            this.rdbQuadro.Size = new System.Drawing.Size(80, 24);
            this.rdbQuadro.TabIndex = 4;
            this.rdbQuadro.TabStop = true;
            this.rdbQuadro.Text = "Quadro";
            this.rdbQuadro.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipologia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titolo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autore:";
            // 
            // gpbModifica
            // 
            this.gpbModifica.BackColor = System.Drawing.Color.SkyBlue;
            this.gpbModifica.Controls.Add(this.btnModificaOpera);
            this.gpbModifica.Controls.Add(this.label6);
            this.gpbModifica.Controls.Add(this.txtModificaCodice);
            this.gpbModifica.Controls.Add(this.label5);
            this.gpbModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbModifica.ForeColor = System.Drawing.Color.White;
            this.gpbModifica.Location = new System.Drawing.Point(244, 12);
            this.gpbModifica.Name = "gpbModifica";
            this.gpbModifica.Size = new System.Drawing.Size(401, 100);
            this.gpbModifica.TabIndex = 1;
            this.gpbModifica.TabStop = false;
            this.gpbModifica.Text = "MODIFICA";
            // 
            // btnModificaOpera
            // 
            this.btnModificaOpera.AutoSize = true;
            this.btnModificaOpera.ForeColor = System.Drawing.Color.Black;
            this.btnModificaOpera.Location = new System.Drawing.Point(304, 46);
            this.btnModificaOpera.Name = "btnModificaOpera";
            this.btnModificaOpera.Size = new System.Drawing.Size(95, 35);
            this.btnModificaOpera.TabIndex = 3;
            this.btnModificaOpera.Text = "Modifica";
            this.btnModificaOpera.UseVisualStyleBackColor = true;
            this.btnModificaOpera.Click += new System.EventHandler(this.btnModificaOpera_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(128, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 50);
            this.label6.TabIndex = 2;
            this.label6.Text = "Inserire i dati prima di confermare";
            // 
            // txtModificaCodice
            // 
            this.txtModificaCodice.Location = new System.Drawing.Point(11, 50);
            this.txtModificaCodice.Name = "txtModificaCodice";
            this.txtModificaCodice.Size = new System.Drawing.Size(100, 26);
            this.txtModificaCodice.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codice Opera";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.AutoSize = true;
            this.btnAggiungi.Location = new System.Drawing.Point(381, 138);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(90, 23);
            this.btnAggiungi.TabIndex = 2;
            this.btnAggiungi.Text = "Aggiungi Opera";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.AutoSize = true;
            this.btnVisualizza.Location = new System.Drawing.Point(381, 167);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(90, 23);
            this.btnVisualizza.TabIndex = 3;
            this.btnVisualizza.Text = "Visualizza file";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(570, 231);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Info File";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // grdOpere
            // 
            this.grdOpere.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.grdOpere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOpere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.aut,
            this.tit,
            this.ann,
            this.tip});
            this.grdOpere.Location = new System.Drawing.Point(13, 329);
            this.grdOpere.Name = "grdOpere";
            this.grdOpere.RowHeadersWidth = 51;
            this.grdOpere.Size = new System.Drawing.Size(680, 263);
            this.grdOpere.TabIndex = 6;
            // 
            // cod
            // 
            this.cod.HeaderText = "CODICE";
            this.cod.MinimumWidth = 6;
            this.cod.Name = "cod";
            this.cod.Width = 125;
            // 
            // aut
            // 
            this.aut.HeaderText = "AUTORE";
            this.aut.MinimumWidth = 6;
            this.aut.Name = "aut";
            this.aut.Width = 125;
            // 
            // tit
            // 
            this.tit.HeaderText = "TITOLO";
            this.tit.MinimumWidth = 6;
            this.tit.Name = "tit";
            this.tit.Width = 125;
            // 
            // ann
            // 
            this.ann.HeaderText = "ANNO DI REALIZZAZIONE";
            this.ann.MinimumWidth = 6;
            this.ann.Name = "ann";
            this.ann.Width = 125;
            // 
            // tip
            // 
            this.tip.HeaderText = "TIPOLOGIA";
            this.tip.MinimumWidth = 6;
            this.tip.Name = "tip";
            this.tip.Width = 125;
            // 
            // gpbCerca
            // 
            this.gpbCerca.BackColor = System.Drawing.Color.SkyBlue;
            this.gpbCerca.Controls.Add(this.btnCercaAutore);
            this.gpbCerca.Controls.Add(this.txtCercaAutore);
            this.gpbCerca.Controls.Add(this.label7);
            this.gpbCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCerca.ForeColor = System.Drawing.Color.White;
            this.gpbCerca.Location = new System.Drawing.Point(13, 240);
            this.gpbCerca.Name = "gpbCerca";
            this.gpbCerca.Size = new System.Drawing.Size(225, 83);
            this.gpbCerca.TabIndex = 7;
            this.gpbCerca.TabStop = false;
            this.gpbCerca.Text = "CERCA";
            // 
            // btnCercaAutore
            // 
            this.btnCercaAutore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCercaAutore.ForeColor = System.Drawing.Color.Black;
            this.btnCercaAutore.Location = new System.Drawing.Point(131, 38);
            this.btnCercaAutore.Name = "btnCercaAutore";
            this.btnCercaAutore.Size = new System.Drawing.Size(75, 23);
            this.btnCercaAutore.TabIndex = 2;
            this.btnCercaAutore.Text = "Cerca";
            this.btnCercaAutore.UseVisualStyleBackColor = true;
            this.btnCercaAutore.Click += new System.EventHandler(this.btnCercaAutore_Click);
            // 
            // txtCercaAutore
            // 
            this.txtCercaAutore.Location = new System.Drawing.Point(15, 50);
            this.txtCercaAutore.Name = "txtCercaAutore";
            this.txtCercaAutore.Size = new System.Drawing.Size(100, 26);
            this.txtCercaAutore.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Autore";
            // 
            // gpbElimina
            // 
            this.gpbElimina.BackColor = System.Drawing.Color.SkyBlue;
            this.gpbElimina.Controls.Add(this.btnElimina);
            this.gpbElimina.Controls.Add(this.txtCodiceElimina);
            this.gpbElimina.Controls.Add(this.label8);
            this.gpbElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbElimina.ForeColor = System.Drawing.Color.White;
            this.gpbElimina.Location = new System.Drawing.Point(244, 240);
            this.gpbElimina.Name = "gpbElimina";
            this.gpbElimina.Size = new System.Drawing.Size(227, 83);
            this.gpbElimina.TabIndex = 8;
            this.gpbElimina.TabStop = false;
            this.gpbElimina.Text = "ELIMINA";
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.ForeColor = System.Drawing.Color.Black;
            this.btnElimina.Location = new System.Drawing.Point(132, 38);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(75, 23);
            this.btnElimina.TabIndex = 2;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // txtCodiceElimina
            // 
            this.txtCodiceElimina.Location = new System.Drawing.Point(11, 50);
            this.txtCodiceElimina.Name = "txtCodiceElimina";
            this.txtCodiceElimina.Size = new System.Drawing.Size(100, 26);
            this.txtCodiceElimina.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Codice opera";
            // 
            // txtInfoFile
            // 
            this.txtInfoFile.BackColor = System.Drawing.Color.SkyBlue;
            this.txtInfoFile.Location = new System.Drawing.Point(670, 155);
            this.txtInfoFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfoFile.Name = "txtInfoFile";
            this.txtInfoFile.Size = new System.Drawing.Size(296, 160);
            this.txtInfoFile.TabIndex = 9;
            this.txtInfoFile.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 600);
            this.Controls.Add(this.txtInfoFile);
            this.Controls.Add(this.gpbElimina);
            this.Controls.Add(this.gpbCerca);
            this.Controls.Add(this.grdOpere);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.gpbModifica);
            this.Controls.Add(this.gpbInput);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "MUSEO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbInput.ResumeLayout(false);
            this.gpbInput.PerformLayout();
            this.gpbModifica.ResumeLayout(false);
            this.gpbModifica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpere)).EndInit();
            this.gpbCerca.ResumeLayout(false);
            this.gpbCerca.PerformLayout();
            this.gpbElimina.ResumeLayout(false);
            this.gpbElimina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInput;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.RadioButton rdbArazzo;
        private System.Windows.Forms.RadioButton rdbScultura;
        private System.Windows.Forms.RadioButton rdbQuadro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbModifica;
        private System.Windows.Forms.Button btnModificaOpera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModificaCodice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.DataGridView grdOpere;
        private System.Windows.Forms.GroupBox gpbCerca;
        private System.Windows.Forms.Button btnCercaAutore;
        private System.Windows.Forms.TextBox txtCercaAutore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gpbElimina;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.TextBox txtCodiceElimina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn aut;
        private System.Windows.Forms.DataGridViewTextBoxColumn tit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ann;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private System.Windows.Forms.RichTextBox txtInfoFile;
    }
}

