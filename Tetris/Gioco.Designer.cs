namespace Tetris
{
    partial class Gioco
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
            this.components = new System.ComponentModel.Container();
            this.panelAnteprima = new System.Windows.Forms.Panel();
            this.panelCampoGioco = new System.Windows.Forms.Panel();
            this.timerGioco = new System.Windows.Forms.Timer(this.components);
            this.labelPunteggio = new System.Windows.Forms.Label();
            this.labelPunteggioText = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAnteprima
            // 
            this.panelAnteprima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAnteprima.Location = new System.Drawing.Point(24, 50);
            this.panelAnteprima.Margin = new System.Windows.Forms.Padding(2);
            this.panelAnteprima.Name = "panelAnteprima";
            this.panelAnteprima.Size = new System.Drawing.Size(127, 101);
            this.panelAnteprima.TabIndex = 0;
            // 
            // panelCampoGioco
            // 
            this.panelCampoGioco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCampoGioco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampoGioco.Location = new System.Drawing.Point(20, 20);
            this.panelCampoGioco.Name = "panelCampoGioco";
            this.panelCampoGioco.Size = new System.Drawing.Size(193, 342);
            this.panelCampoGioco.TabIndex = 3;
            // 
            // timerGioco
            // 
            this.timerGioco.Enabled = true;
            this.timerGioco.Interval = 500;
            this.timerGioco.Tick += new System.EventHandler(this.TimerGioco_Tick);
            // 
            // labelPunteggio
            // 
            this.labelPunteggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPunteggio.Location = new System.Drawing.Point(124, 20);
            this.labelPunteggio.Name = "labelPunteggio";
            this.labelPunteggio.Size = new System.Drawing.Size(98, 29);
            this.labelPunteggio.TabIndex = 4;
            this.labelPunteggio.Text = "0";
            // 
            // labelPunteggioText
            // 
            this.labelPunteggioText.AutoSize = true;
            this.labelPunteggioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPunteggioText.Location = new System.Drawing.Point(19, 20);
            this.labelPunteggioText.Name = "labelPunteggioText";
            this.labelPunteggioText.Size = new System.Drawing.Size(103, 29);
            this.labelPunteggioText.TabIndex = 5;
            this.labelPunteggioText.Text = "SCORE";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelCampoGioco);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(20);
            this.panelLeft.Size = new System.Drawing.Size(233, 382);
            this.panelLeft.TabIndex = 6;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.labelPunteggioText);
            this.panelRight.Controls.Add(this.labelPunteggio);
            this.panelRight.Controls.Add(this.panelAnteprima);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(233, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(234, 382);
            this.panelRight.TabIndex = 7;
            // 
            // Gioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(467, 382);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Gioco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gioco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gioco_FormClosing);
            this.Load += new System.EventHandler(this.Gioco_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gioco_KeyDown);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAnteprima;
        private System.Windows.Forms.Panel panelCampoGioco;
        private System.Windows.Forms.Timer timerGioco;
        private System.Windows.Forms.Label labelPunteggio;
        private System.Windows.Forms.Label labelPunteggioText;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
    }
}