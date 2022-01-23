namespace provaVerificaOOP_Regex
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNuovoSocio = new System.Windows.Forms.Button();
            this.btnVisualizzaSoci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricola";
            // 
            // txtMatricola
            // 
            this.txtMatricola.Location = new System.Drawing.Point(80, 34);
            this.txtMatricola.Name = "txtMatricola";
            this.txtMatricola.Size = new System.Drawing.Size(153, 22);
            this.txtMatricola.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(153, 22);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(80, 90);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(153, 22);
            this.txtCognome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cognome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "INSERIMENTO NUOVO SOCIO";
            // 
            // btnNuovoSocio
            // 
            this.btnNuovoSocio.Location = new System.Drawing.Point(15, 131);
            this.btnNuovoSocio.Name = "btnNuovoSocio";
            this.btnNuovoSocio.Size = new System.Drawing.Size(119, 41);
            this.btnNuovoSocio.TabIndex = 7;
            this.btnNuovoSocio.Text = "Aggiungi";
            this.btnNuovoSocio.UseVisualStyleBackColor = true;
            this.btnNuovoSocio.Click += new System.EventHandler(this.btnNuovoSocio_Click);
            // 
            // btnVisualizzaSoci
            // 
            this.btnVisualizzaSoci.Location = new System.Drawing.Point(15, 196);
            this.btnVisualizzaSoci.Name = "btnVisualizzaSoci";
            this.btnVisualizzaSoci.Size = new System.Drawing.Size(134, 23);
            this.btnVisualizzaSoci.TabIndex = 8;
            this.btnVisualizzaSoci.Text = "Visualizza soci";
            this.btnVisualizzaSoci.UseVisualStyleBackColor = true;
            this.btnVisualizzaSoci.Click += new System.EventHandler(this.btnVisualizzaSoci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisualizzaSoci);
            this.Controls.Add(this.btnNuovoSocio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricola);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricola;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuovoSocio;
        private System.Windows.Forms.Button btnVisualizzaSoci;
    }
}

