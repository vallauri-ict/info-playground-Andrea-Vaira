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
            this.btnNuovoIscritto = new System.Windows.Forms.Button();
            this.dgvIscritti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIscritti)).BeginInit();
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
            this.dgvEventi.Size = new System.Drawing.Size(600, 371);
            this.dgvEventi.TabIndex = 0;
            this.dgvEventi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventi_CellClick);
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
            this.lblEvento.Location = new System.Drawing.Point(869, 12);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(259, 26);
            this.lblEvento.TabIndex = 3;
            this.lblEvento.Text = "ISCRITTI ALL\'EVENTO";
            // 
            // btnNuovoIscritto
            // 
            this.btnNuovoIscritto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuovoIscritto.Location = new System.Drawing.Point(1039, 418);
            this.btnNuovoIscritto.Name = "btnNuovoIscritto";
            this.btnNuovoIscritto.Size = new System.Drawing.Size(179, 57);
            this.btnNuovoIscritto.TabIndex = 4;
            this.btnNuovoIscritto.Text = "NUOVO ISCRITTO";
            this.btnNuovoIscritto.UseVisualStyleBackColor = true;
            this.btnNuovoIscritto.Click += new System.EventHandler(this.btnNuovoIscritto_Click);
            // 
            // dgvIscritti
            // 
            this.dgvIscritti.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvIscritti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIscritti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIscritti.Location = new System.Drawing.Point(618, 41);
            this.dgvIscritti.Name = "dgvIscritti";
            this.dgvIscritti.ReadOnly = true;
            this.dgvIscritti.RowHeadersVisible = false;
            this.dgvIscritti.Size = new System.Drawing.Size(600, 371);
            this.dgvIscritti.TabIndex = 5;
            this.dgvIscritti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIscritti_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 755);
            this.Controls.Add(this.dgvIscritti);
            this.Controls.Add(this.btnNuovoIscritto);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEventi);
            this.Name = "Form1";
            this.Text = "Gestionale eventi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIscritti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.DataGridView dgvEventi;
        private System.Windows.Forms.Button btnNuovoIscritto;
        private System.Windows.Forms.DataGridView dgvIscritti;
    }
}

