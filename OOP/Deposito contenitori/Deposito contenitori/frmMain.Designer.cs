namespace Deposito_contenitori
{
    partial class frmMain
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
            this.btnLattina = new System.Windows.Forms.Button();
            this.btnBidone = new System.Windows.Forms.Button();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.btnConfronta = new System.Windows.Forms.Button();
            this.btnStampa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLattina
            // 
            this.btnLattina.Location = new System.Drawing.Point(12, 37);
            this.btnLattina.Name = "btnLattina";
            this.btnLattina.Size = new System.Drawing.Size(75, 23);
            this.btnLattina.TabIndex = 0;
            this.btnLattina.Text = "Crea lattina";
            this.btnLattina.UseVisualStyleBackColor = true;
            this.btnLattina.Click += new System.EventHandler(this.btnLattina_Click);
            // 
            // btnBidone
            // 
            this.btnBidone.Location = new System.Drawing.Point(145, 37);
            this.btnBidone.Name = "btnBidone";
            this.btnBidone.Size = new System.Drawing.Size(75, 23);
            this.btnBidone.TabIndex = 1;
            this.btnBidone.Text = "Crea bidone";
            this.btnBidone.UseVisualStyleBackColor = true;
            this.btnBidone.Click += new System.EventHandler(this.btnBidone_Click);
            // 
            // btnFiltra
            // 
            this.btnFiltra.Location = new System.Drawing.Point(125, 96);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(105, 45);
            this.btnFiltra.TabIndex = 2;
            this.btnFiltra.Text = "Filtra per liquido";
            this.btnFiltra.UseVisualStyleBackColor = true;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // btnConfronta
            // 
            this.btnConfronta.Location = new System.Drawing.Point(12, 96);
            this.btnConfronta.Name = "btnConfronta";
            this.btnConfronta.Size = new System.Drawing.Size(105, 45);
            this.btnConfronta.TabIndex = 3;
            this.btnConfronta.Text = "Confronta quantità";
            this.btnConfronta.UseVisualStyleBackColor = true;
            this.btnConfronta.Click += new System.EventHandler(this.btnConfronta_Click);
            // 
            // btnStampa
            // 
            this.btnStampa.Location = new System.Drawing.Point(12, 147);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(218, 39);
            this.btnStampa.TabIndex = 4;
            this.btnStampa.Text = "Stampa lista";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 198);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.btnConfronta);
            this.Controls.Add(this.btnFiltra);
            this.Controls.Add(this.btnBidone);
            this.Controls.Add(this.btnLattina);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLattina;
        private System.Windows.Forms.Button btnBidone;
        private System.Windows.Forms.Button btnFiltra;
        private System.Windows.Forms.Button btnConfronta;
        private System.Windows.Forms.Button btnStampa;
    }
}

