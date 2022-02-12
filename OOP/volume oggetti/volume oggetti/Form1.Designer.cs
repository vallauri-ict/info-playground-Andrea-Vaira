namespace volume_oggetti
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
            this.btnCalcoloCil = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnstampaCil = new System.Windows.Forms.Button();
            this.btnStampaPar = new System.Windows.Forms.Button();
            this.btnCalcoloPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserici area della base";
            // 
            // btnCalcoloCil
            // 
            this.btnCalcoloCil.Location = new System.Drawing.Point(31, 147);
            this.btnCalcoloCil.Name = "btnCalcoloCil";
            this.btnCalcoloCil.Size = new System.Drawing.Size(134, 47);
            this.btnCalcoloCil.TabIndex = 1;
            this.btnCalcoloCil.Text = "Calcola volume clindro";
            this.btnCalcoloCil.UseVisualStyleBackColor = true;
            this.btnCalcoloCil.Click += new System.EventHandler(this.btnCalcoloCil_Click_1);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(181, 63);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 22);
            this.txtBase.TabIndex = 2;
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(181, 100);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(100, 22);
            this.txtAltezza.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inserici l\'altezza";
            // 
            // btnstampaCil
            // 
            this.btnstampaCil.Location = new System.Drawing.Point(31, 219);
            this.btnstampaCil.Name = "btnstampaCil";
            this.btnstampaCil.Size = new System.Drawing.Size(134, 47);
            this.btnstampaCil.TabIndex = 5;
            this.btnstampaCil.Text = "Stampa Volume clicndo";
            this.btnstampaCil.UseVisualStyleBackColor = true;
            this.btnstampaCil.Click += new System.EventHandler(this.btnstampaCil_Click_1);
            // 
            // btnStampaPar
            // 
            this.btnStampaPar.Location = new System.Drawing.Point(192, 219);
            this.btnStampaPar.Name = "btnStampaPar";
            this.btnStampaPar.Size = new System.Drawing.Size(134, 47);
            this.btnStampaPar.TabIndex = 6;
            this.btnStampaPar.Text = "Stampa Volume paralelepipedo";
            this.btnStampaPar.UseVisualStyleBackColor = true;
            this.btnStampaPar.Click += new System.EventHandler(this.btnStampaPar_Click_1);
            // 
            // btnCalcoloPar
            // 
            this.btnCalcoloPar.Location = new System.Drawing.Point(192, 144);
            this.btnCalcoloPar.Name = "btnCalcoloPar";
            this.btnCalcoloPar.Size = new System.Drawing.Size(134, 47);
            this.btnCalcoloPar.TabIndex = 7;
            this.btnCalcoloPar.Text = "Calcola Volume paralelepipedo";
            this.btnCalcoloPar.UseVisualStyleBackColor = true;
            this.btnCalcoloPar.Click += new System.EventHandler(this.btnCalcoloPar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcoloPar);
            this.Controls.Add(this.btnStampaPar);
            this.Controls.Add(this.btnstampaCil);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.btnCalcoloCil);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "calcolo volume";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcoloCil;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnstampaCil;
        private System.Windows.Forms.Button btnStampaPar;
        private System.Windows.Forms.Button btnCalcoloPar;
    }
}

