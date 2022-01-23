namespace Vaira_Andrea
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricola = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAggiungiGiocatore = new System.Windows.Forms.Button();
            this.btnVisualizzaSquadra = new System.Windows.Forms.Button();
            this.lblSquadra = new System.Windows.Forms.Label();
            this.lblPunteggio = new System.Windows.Forms.Label();
            this.lblCitta = new System.Windows.Forms.Label();
            this.btnCreaSquadra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricola";
            // 
            // txtMatricola
            // 
            this.txtMatricola.Location = new System.Drawing.Point(115, 55);
            this.txtMatricola.Name = "txtMatricola";
            this.txtMatricola.Size = new System.Drawing.Size(141, 22);
            this.txtMatricola.TabIndex = 1;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(115, 139);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(141, 22);
            this.txtEta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Età";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(115, 111);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(141, 22);
            this.txtCognome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cognome";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(115, 83);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(141, 22);
            this.txtUsername.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // btnAggiungiGiocatore
            // 
            this.btnAggiungiGiocatore.Location = new System.Drawing.Point(15, 180);
            this.btnAggiungiGiocatore.Name = "btnAggiungiGiocatore";
            this.btnAggiungiGiocatore.Size = new System.Drawing.Size(136, 44);
            this.btnAggiungiGiocatore.TabIndex = 8;
            this.btnAggiungiGiocatore.Text = "Aggiungi giocatore";
            this.btnAggiungiGiocatore.UseVisualStyleBackColor = true;
            this.btnAggiungiGiocatore.Click += new System.EventHandler(this.btnAggiungiGiocatore_Click);
            // 
            // btnVisualizzaSquadra
            // 
            this.btnVisualizzaSquadra.Location = new System.Drawing.Point(15, 230);
            this.btnVisualizzaSquadra.Name = "btnVisualizzaSquadra";
            this.btnVisualizzaSquadra.Size = new System.Drawing.Size(136, 44);
            this.btnVisualizzaSquadra.TabIndex = 9;
            this.btnVisualizzaSquadra.Text = "Visualizza Squadra";
            this.btnVisualizzaSquadra.UseVisualStyleBackColor = true;
            this.btnVisualizzaSquadra.Click += new System.EventHandler(this.btnVisualizzaSquadra_Click);
            // 
            // lblSquadra
            // 
            this.lblSquadra.AutoSize = true;
            this.lblSquadra.Location = new System.Drawing.Point(17, 286);
            this.lblSquadra.Name = "lblSquadra";
            this.lblSquadra.Size = new System.Drawing.Size(65, 16);
            this.lblSquadra.TabIndex = 10;
            this.lblSquadra.Text = "Squadra: ";
            // 
            // lblPunteggio
            // 
            this.lblPunteggio.AutoSize = true;
            this.lblPunteggio.Location = new System.Drawing.Point(17, 318);
            this.lblPunteggio.Name = "lblPunteggio";
            this.lblPunteggio.Size = new System.Drawing.Size(74, 16);
            this.lblPunteggio.TabIndex = 11;
            this.lblPunteggio.Text = "Punteggio: ";
            // 
            // lblCitta
            // 
            this.lblCitta.AutoSize = true;
            this.lblCitta.Location = new System.Drawing.Point(17, 302);
            this.lblCitta.Name = "lblCitta";
            this.lblCitta.Size = new System.Drawing.Size(39, 16);
            this.lblCitta.TabIndex = 12;
            this.lblCitta.Text = "Città: ";
            // 
            // btnCreaSquadra
            // 
            this.btnCreaSquadra.Location = new System.Drawing.Point(12, 350);
            this.btnCreaSquadra.Name = "btnCreaSquadra";
            this.btnCreaSquadra.Size = new System.Drawing.Size(136, 44);
            this.btnCreaSquadra.TabIndex = 13;
            this.btnCreaSquadra.Text = "Crea squadra";
            this.btnCreaSquadra.UseVisualStyleBackColor = true;
            this.btnCreaSquadra.Click += new System.EventHandler(this.btnCreaSquadra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreaSquadra);
            this.Controls.Add(this.lblCitta);
            this.Controls.Add(this.lblPunteggio);
            this.Controls.Add(this.lblSquadra);
            this.Controls.Add(this.btnVisualizzaSquadra);
            this.Controls.Add(this.btnAggiungiGiocatore);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricola);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Vaira Andrea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricola;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAggiungiGiocatore;
        private System.Windows.Forms.Button btnVisualizzaSquadra;
        private System.Windows.Forms.Label lblSquadra;
        private System.Windows.Forms.Label lblPunteggio;
        private System.Windows.Forms.Label lblCitta;
        private System.Windows.Forms.Button btnCreaSquadra;
    }
}

