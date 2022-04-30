namespace Verifica_Vaira
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
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGenere = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVarietà = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnAggiungi = new System.Windows.Forms.Button();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNRose = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVisualizzaLista = new System.Windows.Forms.TextBox();
            this.btnVisualizzaPiante = new System.Windows.Forms.Button();
            this.btnVisualizzaRose = new System.Windows.Forms.Button();
            this.txtCodPianta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRimuoviDaLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "europea",
            "esotica",
            "carnivora"});
            this.cmbTipo.Location = new System.Drawing.Point(70, 80);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genere";
            // 
            // cmbGenere
            // 
            this.cmbGenere.FormattingEnabled = true;
            this.cmbGenere.Items.AddRange(new object[] {
            "colorata",
            "sempreverde"});
            this.cmbGenere.Location = new System.Drawing.Point(70, 107);
            this.cmbGenere.Name = "cmbGenere";
            this.cmbGenere.Size = new System.Drawing.Size(121, 21);
            this.cmbGenere.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Colore";
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(293, 80);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(121, 20);
            this.txtColore.TabIndex = 5;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(70, 140);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(121, 20);
            this.txtCosto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "GENERALI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "ROSA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "PIANTA";
            // 
            // txtVarietà
            // 
            this.txtVarietà.Location = new System.Drawing.Point(566, 80);
            this.txtVarietà.Name = "txtVarietà";
            this.txtVarietà.Size = new System.Drawing.Size(121, 20);
            this.txtVarietà.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Vairietà";
            // 
            // BtnAggiungi
            // 
            this.BtnAggiungi.Location = new System.Drawing.Point(354, 123);
            this.BtnAggiungi.Name = "BtnAggiungi";
            this.BtnAggiungi.Size = new System.Drawing.Size(118, 43);
            this.BtnAggiungi.TabIndex = 13;
            this.BtnAggiungi.Text = "Aggiungi";
            this.BtnAggiungi.UseVisualStyleBackColor = true;
            this.BtnAggiungi.Click += new System.EventHandler(this.BtnAggiungi_Click);
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(25, 196);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(166, 99);
            this.txtDescrizione.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Descrizione";
            // 
            // txtNRose
            // 
            this.txtNRose.Location = new System.Drawing.Point(566, 103);
            this.txtNRose.Name = "txtNRose";
            this.txtNRose.Size = new System.Drawing.Size(121, 20);
            this.txtNRose.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(496, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Numero rose";
            // 
            // txtVisualizzaLista
            // 
            this.txtVisualizzaLista.Location = new System.Drawing.Point(248, 196);
            this.txtVisualizzaLista.Multiline = true;
            this.txtVisualizzaLista.Name = "txtVisualizzaLista";
            this.txtVisualizzaLista.Size = new System.Drawing.Size(272, 161);
            this.txtVisualizzaLista.TabIndex = 18;
            // 
            // btnVisualizzaPiante
            // 
            this.btnVisualizzaPiante.Location = new System.Drawing.Point(248, 363);
            this.btnVisualizzaPiante.Name = "btnVisualizzaPiante";
            this.btnVisualizzaPiante.Size = new System.Drawing.Size(118, 43);
            this.btnVisualizzaPiante.TabIndex = 19;
            this.btnVisualizzaPiante.Text = "Visualizza Piante";
            this.btnVisualizzaPiante.UseVisualStyleBackColor = true;
            this.btnVisualizzaPiante.Click += new System.EventHandler(this.btnVisualizzaPiante_Click);
            // 
            // btnVisualizzaRose
            // 
            this.btnVisualizzaRose.Location = new System.Drawing.Point(372, 363);
            this.btnVisualizzaRose.Name = "btnVisualizzaRose";
            this.btnVisualizzaRose.Size = new System.Drawing.Size(118, 43);
            this.btnVisualizzaRose.TabIndex = 20;
            this.btnVisualizzaRose.Text = "Visualizza Rose";
            this.btnVisualizzaRose.UseVisualStyleBackColor = true;
            this.btnVisualizzaRose.Click += new System.EventHandler(this.btnVisualizzaRose_Click);
            // 
            // txtCodPianta
            // 
            this.txtCodPianta.Location = new System.Drawing.Point(556, 215);
            this.txtCodPianta.Name = "txtCodPianta";
            this.txtCodPianta.Size = new System.Drawing.Size(121, 20);
            this.txtCodPianta.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(553, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Inserisci numero pianta";
            // 
            // btnRimuoviDaLista
            // 
            this.btnRimuoviDaLista.Location = new System.Drawing.Point(556, 241);
            this.btnRimuoviDaLista.Name = "btnRimuoviDaLista";
            this.btnRimuoviDaLista.Size = new System.Drawing.Size(118, 43);
            this.btnRimuoviDaLista.TabIndex = 23;
            this.btnRimuoviDaLista.Text = "Vendi";
            this.btnRimuoviDaLista.UseVisualStyleBackColor = true;
            this.btnRimuoviDaLista.Click += new System.EventHandler(this.btnRimuoviDaLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRimuoviDaLista);
            this.Controls.Add(this.txtCodPianta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnVisualizzaRose);
            this.Controls.Add(this.btnVisualizzaPiante);
            this.Controls.Add(this.txtVisualizzaLista);
            this.Controls.Add(this.txtNRose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.BtnAggiungi);
            this.Controls.Add(this.txtVarietà);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGenere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipo);
            this.Name = "Form1";
            this.Text = "Vaira Andrea";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGenere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVarietà;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnAggiungi;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNRose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVisualizzaLista;
        private System.Windows.Forms.Button btnVisualizzaPiante;
        private System.Windows.Forms.Button btnVisualizzaRose;
        private System.Windows.Forms.TextBox txtCodPianta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRimuoviDaLista;
    }
}

