﻿namespace InterfacciaStrumenti
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
            this.btnRumorista = new System.Windows.Forms.Button();
            this.btnTromba = new System.Windows.Forms.Button();
            this.btnChitarra = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRumorista
            // 
            this.btnRumorista.Location = new System.Drawing.Point(12, 12);
            this.btnRumorista.Name = "btnRumorista";
            this.btnRumorista.Size = new System.Drawing.Size(74, 26);
            this.btnRumorista.TabIndex = 0;
            this.btnRumorista.Text = "Rumorista";
            this.btnRumorista.UseVisualStyleBackColor = true;
            this.btnRumorista.Click += new System.EventHandler(this.btnRumorista_Click);
            // 
            // btnTromba
            // 
            this.btnTromba.Location = new System.Drawing.Point(172, 12);
            this.btnTromba.Name = "btnTromba";
            this.btnTromba.Size = new System.Drawing.Size(74, 26);
            this.btnTromba.TabIndex = 1;
            this.btnTromba.Text = "Tromba";
            this.btnTromba.UseVisualStyleBackColor = true;
            this.btnTromba.Click += new System.EventHandler(this.btnTromba_Click);
            // 
            // btnChitarra
            // 
            this.btnChitarra.Location = new System.Drawing.Point(92, 12);
            this.btnChitarra.Name = "btnChitarra";
            this.btnChitarra.Size = new System.Drawing.Size(74, 26);
            this.btnChitarra.TabIndex = 2;
            this.btnChitarra.Text = "Chitarra";
            this.btnChitarra.UseVisualStyleBackColor = true;
            this.btnChitarra.Click += new System.EventHandler(this.btnChitarra_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(92, 44);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(74, 26);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 96);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnChitarra);
            this.Controls.Add(this.btnTromba);
            this.Controls.Add(this.btnRumorista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRumorista;
        private System.Windows.Forms.Button btnTromba;
        private System.Windows.Forms.Button btnChitarra;
        private System.Windows.Forms.Button btnPlay;
    }
}

