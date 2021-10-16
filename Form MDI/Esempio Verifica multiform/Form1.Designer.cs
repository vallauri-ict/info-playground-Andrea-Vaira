namespace Esempio_Verifica_multiform
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStoffa = new System.Windows.Forms.CheckBox();
            this.chkPelle = new System.Windows.Forms.CheckBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkStoffa);
            this.groupBox1.Controls.Add(this.chkPelle);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rivestimenti";
            // 
            // chkStoffa
            // 
            this.chkStoffa.AutoSize = true;
            this.chkStoffa.Location = new System.Drawing.Point(16, 42);
            this.chkStoffa.Name = "chkStoffa";
            this.chkStoffa.Size = new System.Drawing.Size(54, 17);
            this.chkStoffa.TabIndex = 1;
            this.chkStoffa.Text = "Stoffa";
            this.chkStoffa.UseVisualStyleBackColor = true;
            this.chkStoffa.CheckedChanged += new System.EventHandler(this.chkStoffa_CheckedChanged);
            // 
            // chkPelle
            // 
            this.chkPelle.AutoSize = true;
            this.chkPelle.Location = new System.Drawing.Point(16, 19);
            this.chkPelle.Name = "chkPelle";
            this.chkPelle.Size = new System.Drawing.Size(49, 17);
            this.chkPelle.TabIndex = 0;
            this.chkPelle.Text = "Pelle";
            this.chkPelle.UseVisualStyleBackColor = true;
            this.chkPelle.CheckedChanged += new System.EventHandler(this.chkPelle_CheckedChanged);
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "BMW",
            "FIAT",
            "SEAT",
            "OPEL"});
            this.cmbMarca.Location = new System.Drawing.Point(12, 120);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(105, 21);
            this.cmbMarca.TabIndex = 1;
            this.cmbMarca.SelectedValueChanged += new System.EventHandler(this.cmbMarca_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 197);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkStoffa;
        private System.Windows.Forms.CheckBox chkPelle;
        private System.Windows.Forms.ComboBox cmbMarca;
    }
}