namespace Verifica_Multiform
{
    partial class Form2
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
            this.chkBianco = new System.Windows.Forms.RadioButton();
            this.chkNero = new System.Windows.Forms.RadioButton();
            this.chkColore = new System.Windows.Forms.RadioButton();
            this.btnInizia = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkBianco
            // 
            this.chkBianco.AutoSize = true;
            this.chkBianco.Location = new System.Drawing.Point(27, 29);
            this.chkBianco.Name = "chkBianco";
            this.chkBianco.Size = new System.Drawing.Size(105, 17);
            this.chkBianco.TabIndex = 0;
            this.chkBianco.TabStop = true;
            this.chkBianco.Text = "Gioca col bianco";
            this.chkBianco.UseVisualStyleBackColor = true;
            // 
            // chkNero
            // 
            this.chkNero.AutoSize = true;
            this.chkNero.Location = new System.Drawing.Point(27, 52);
            this.chkNero.Name = "chkNero";
            this.chkNero.Size = new System.Drawing.Size(94, 17);
            this.chkNero.TabIndex = 1;
            this.chkNero.TabStop = true;
            this.chkNero.Text = "Gioca col nero";
            this.chkNero.UseVisualStyleBackColor = true;
            // 
            // chkColore
            // 
            this.chkColore.AutoSize = true;
            this.chkColore.Location = new System.Drawing.Point(27, 75);
            this.chkColore.Name = "chkColore";
            this.chkColore.Size = new System.Drawing.Size(146, 17);
            this.chkColore.TabIndex = 2;
            this.chkColore.TabStop = true;
            this.chkColore.Text = "Gioca con colore a scelta";
            this.chkColore.UseVisualStyleBackColor = true;
            // 
            // btnInizia
            // 
            this.btnInizia.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInizia.Location = new System.Drawing.Point(12, 116);
            this.btnInizia.Name = "btnInizia";
            this.btnInizia.Size = new System.Drawing.Size(75, 23);
            this.btnInizia.TabIndex = 3;
            this.btnInizia.Text = "Inizia";
            this.btnInizia.UseVisualStyleBackColor = true;
            this.btnInizia.Click += new System.EventHandler(this.btnInizia_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnulla.Location = new System.Drawing.Point(93, 116);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 4;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 173);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnInizia);
            this.Controls.Add(this.chkColore);
            this.Controls.Add(this.chkNero);
            this.Controls.Add(this.chkBianco);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton chkBianco;
        private System.Windows.Forms.RadioButton chkNero;
        private System.Windows.Forms.RadioButton chkColore;
        private System.Windows.Forms.Button btnInizia;
        private System.Windows.Forms.Button btnAnnulla;
    }
}