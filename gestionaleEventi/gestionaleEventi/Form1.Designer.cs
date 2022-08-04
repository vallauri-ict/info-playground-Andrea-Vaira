namespace gestionaleEventi
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
            this.dgvEventi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.dgvIscrittiEvento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIscrittiEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventi
            // 
            this.dgvEventi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEventi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEventi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventi.Location = new System.Drawing.Point(12, 41);
            this.dgvEventi.Name = "dgvEventi";
            this.dgvEventi.ReadOnly = true;
            this.dgvEventi.RowHeadersVisible = false;
            this.dgvEventi.Size = new System.Drawing.Size(600, 181);
            this.dgvEventi.TabIndex = 0;
            this.dgvEventi.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvEventi_RowStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "EVENTI";
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.Location = new System.Drawing.Point(888, 12);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(108, 26);
            this.lblEvento.TabIndex = 3;
            this.lblEvento.Text = "EVENTO";
            // 
            // dgvIscrittiEvento
            // 
            this.dgvIscrittiEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIscrittiEvento.Location = new System.Drawing.Point(618, 41);
            this.dgvIscrittiEvento.Name = "dgvIscrittiEvento";
            this.dgvIscrittiEvento.Size = new System.Drawing.Size(600, 181);
            this.dgvIscrittiEvento.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 755);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.dgvIscrittiEvento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEventi);
            this.Name = "Form1";
            this.Text = "Gestionale eventi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIscrittiEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.DataGridView dgvIscrittiEvento;
    }
}

