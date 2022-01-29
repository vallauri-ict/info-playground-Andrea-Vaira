namespace Es_ripasso_ereditarietà
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
            this.txtRecipiente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBicchiere = new System.Windows.Forms.TextBox();
            this.btnSettaRecipiente = new System.Windows.Forms.Button();
            this.btnSettaBicchiere = new System.Windows.Forms.Button();
            this.btnCreaBicchiere = new System.Windows.Forms.Button();
            this.btnCreaRecipiente = new System.Windows.Forms.Button();
            this.btnMettiInBicchiere = new System.Windows.Forms.Button();
            this.btnMettiInRecipiente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMettiInBicchiere = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMettiInRecipiente = new System.Windows.Forms.TextBox();
            this.btnTogliBicchiere = new System.Windows.Forms.Button();
            this.btnTogliRecipiente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTogliBicchiere = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTogliRecipiente = new System.Windows.Forms.TextBox();
            this.btnCapacitaRec = new System.Windows.Forms.Button();
            this.btnVediCapacitaBicchiere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRecipiente
            // 
            this.txtRecipiente.Location = new System.Drawing.Point(144, 128);
            this.txtRecipiente.Name = "txtRecipiente";
            this.txtRecipiente.Size = new System.Drawing.Size(100, 20);
            this.txtRecipiente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set capacità recipinete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Set capacità bicchiere";
            // 
            // txtBicchiere
            // 
            this.txtBicchiere.Location = new System.Drawing.Point(144, 166);
            this.txtBicchiere.Name = "txtBicchiere";
            this.txtBicchiere.Size = new System.Drawing.Size(100, 20);
            this.txtBicchiere.TabIndex = 2;
            // 
            // btnSettaRecipiente
            // 
            this.btnSettaRecipiente.Location = new System.Drawing.Point(260, 124);
            this.btnSettaRecipiente.Name = "btnSettaRecipiente";
            this.btnSettaRecipiente.Size = new System.Drawing.Size(118, 27);
            this.btnSettaRecipiente.TabIndex = 4;
            this.btnSettaRecipiente.Text = "Setta";
            this.btnSettaRecipiente.UseVisualStyleBackColor = true;
            this.btnSettaRecipiente.Click += new System.EventHandler(this.btnSettaRecipiente_Click);
            // 
            // btnSettaBicchiere
            // 
            this.btnSettaBicchiere.Location = new System.Drawing.Point(260, 162);
            this.btnSettaBicchiere.Name = "btnSettaBicchiere";
            this.btnSettaBicchiere.Size = new System.Drawing.Size(118, 27);
            this.btnSettaBicchiere.TabIndex = 5;
            this.btnSettaBicchiere.Text = "Setta";
            this.btnSettaBicchiere.UseVisualStyleBackColor = true;
            this.btnSettaBicchiere.Click += new System.EventHandler(this.btnSettaBicchiere_Click);
            // 
            // btnCreaBicchiere
            // 
            this.btnCreaBicchiere.Location = new System.Drawing.Point(147, 12);
            this.btnCreaBicchiere.Name = "btnCreaBicchiere";
            this.btnCreaBicchiere.Size = new System.Drawing.Size(118, 48);
            this.btnCreaBicchiere.TabIndex = 7;
            this.btnCreaBicchiere.Text = "Crea Bicchiere";
            this.btnCreaBicchiere.UseVisualStyleBackColor = true;
            this.btnCreaBicchiere.Click += new System.EventHandler(this.btnCreaBicchiere_Click);
            // 
            // btnCreaRecipiente
            // 
            this.btnCreaRecipiente.Location = new System.Drawing.Point(12, 12);
            this.btnCreaRecipiente.Name = "btnCreaRecipiente";
            this.btnCreaRecipiente.Size = new System.Drawing.Size(118, 48);
            this.btnCreaRecipiente.TabIndex = 6;
            this.btnCreaRecipiente.Text = "Crea Recipiente";
            this.btnCreaRecipiente.UseVisualStyleBackColor = true;
            this.btnCreaRecipiente.Click += new System.EventHandler(this.btnCreaRecipiente_Click);
            // 
            // btnMettiInBicchiere
            // 
            this.btnMettiInBicchiere.Location = new System.Drawing.Point(257, 256);
            this.btnMettiInBicchiere.Name = "btnMettiInBicchiere";
            this.btnMettiInBicchiere.Size = new System.Drawing.Size(118, 27);
            this.btnMettiInBicchiere.TabIndex = 13;
            this.btnMettiInBicchiere.Text = "Metti";
            this.btnMettiInBicchiere.UseVisualStyleBackColor = true;
            this.btnMettiInBicchiere.Click += new System.EventHandler(this.btnMettiInBicchiere_Click);
            // 
            // btnMettiInRecipiente
            // 
            this.btnMettiInRecipiente.Location = new System.Drawing.Point(257, 218);
            this.btnMettiInRecipiente.Name = "btnMettiInRecipiente";
            this.btnMettiInRecipiente.Size = new System.Drawing.Size(118, 27);
            this.btnMettiInRecipiente.TabIndex = 12;
            this.btnMettiInRecipiente.Text = "Metti";
            this.btnMettiInRecipiente.UseVisualStyleBackColor = true;
            this.btnMettiInRecipiente.Click += new System.EventHandler(this.btnMettiInRecipiente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Metti liquido nel bicchiere";
            // 
            // txtMettiInBicchiere
            // 
            this.txtMettiInBicchiere.Location = new System.Drawing.Point(144, 260);
            this.txtMettiInBicchiere.Name = "txtMettiInBicchiere";
            this.txtMettiInBicchiere.Size = new System.Drawing.Size(100, 20);
            this.txtMettiInBicchiere.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Metti liquido nel recipiente";
            // 
            // txtMettiInRecipiente
            // 
            this.txtMettiInRecipiente.Location = new System.Drawing.Point(147, 222);
            this.txtMettiInRecipiente.Name = "txtMettiInRecipiente";
            this.txtMettiInRecipiente.Size = new System.Drawing.Size(100, 20);
            this.txtMettiInRecipiente.TabIndex = 8;
            // 
            // btnTogliBicchiere
            // 
            this.btnTogliBicchiere.Location = new System.Drawing.Point(257, 356);
            this.btnTogliBicchiere.Name = "btnTogliBicchiere";
            this.btnTogliBicchiere.Size = new System.Drawing.Size(118, 27);
            this.btnTogliBicchiere.TabIndex = 19;
            this.btnTogliBicchiere.Text = "Togli";
            this.btnTogliBicchiere.UseVisualStyleBackColor = true;
            this.btnTogliBicchiere.Click += new System.EventHandler(this.btnTogliBicchiere_Click);
            // 
            // btnTogliRecipiente
            // 
            this.btnTogliRecipiente.Location = new System.Drawing.Point(257, 318);
            this.btnTogliRecipiente.Name = "btnTogliRecipiente";
            this.btnTogliRecipiente.Size = new System.Drawing.Size(118, 27);
            this.btnTogliRecipiente.TabIndex = 18;
            this.btnTogliRecipiente.Text = "Togli";
            this.btnTogliRecipiente.UseVisualStyleBackColor = true;
            this.btnTogliRecipiente.Click += new System.EventHandler(this.btnTogliRecipiente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Togli liquido nel bicchiere";
            // 
            // txtTogliBicchiere
            // 
            this.txtTogliBicchiere.Location = new System.Drawing.Point(144, 360);
            this.txtTogliBicchiere.Name = "txtTogliBicchiere";
            this.txtTogliBicchiere.Size = new System.Drawing.Size(100, 20);
            this.txtTogliBicchiere.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Togli liquido nel recipiente";
            // 
            // txtTogliRecipiente
            // 
            this.txtTogliRecipiente.Location = new System.Drawing.Point(144, 322);
            this.txtTogliRecipiente.Name = "txtTogliRecipiente";
            this.txtTogliRecipiente.Size = new System.Drawing.Size(100, 20);
            this.txtTogliRecipiente.TabIndex = 14;
            // 
            // btnCapacitaRec
            // 
            this.btnCapacitaRec.Location = new System.Drawing.Point(12, 79);
            this.btnCapacitaRec.Name = "btnCapacitaRec";
            this.btnCapacitaRec.Size = new System.Drawing.Size(137, 23);
            this.btnCapacitaRec.TabIndex = 20;
            this.btnCapacitaRec.Text = "Vedi capacità Recipiente";
            this.btnCapacitaRec.UseVisualStyleBackColor = true;
            this.btnCapacitaRec.Click += new System.EventHandler(this.btnCapacitaRec_Click);
            // 
            // btnVediCapacitaBicchiere
            // 
            this.btnVediCapacitaBicchiere.Location = new System.Drawing.Point(155, 79);
            this.btnVediCapacitaBicchiere.Name = "btnVediCapacitaBicchiere";
            this.btnVediCapacitaBicchiere.Size = new System.Drawing.Size(137, 23);
            this.btnVediCapacitaBicchiere.TabIndex = 22;
            this.btnVediCapacitaBicchiere.Text = "Vedi capacità Bicchiere";
            this.btnVediCapacitaBicchiere.UseVisualStyleBackColor = true;
            this.btnVediCapacitaBicchiere.Click += new System.EventHandler(this.btnVediCapacitaBicchiere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVediCapacitaBicchiere);
            this.Controls.Add(this.btnCapacitaRec);
            this.Controls.Add(this.btnTogliBicchiere);
            this.Controls.Add(this.btnTogliRecipiente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTogliBicchiere);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTogliRecipiente);
            this.Controls.Add(this.btnMettiInBicchiere);
            this.Controls.Add(this.btnMettiInRecipiente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMettiInBicchiere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMettiInRecipiente);
            this.Controls.Add(this.btnCreaBicchiere);
            this.Controls.Add(this.btnCreaRecipiente);
            this.Controls.Add(this.btnSettaBicchiere);
            this.Controls.Add(this.btnSettaRecipiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBicchiere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecipiente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecipiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBicchiere;
        private System.Windows.Forms.Button btnSettaRecipiente;
        private System.Windows.Forms.Button btnSettaBicchiere;
        private System.Windows.Forms.Button btnCreaBicchiere;
        private System.Windows.Forms.Button btnCreaRecipiente;
        private System.Windows.Forms.Button btnMettiInBicchiere;
        private System.Windows.Forms.Button btnMettiInRecipiente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMettiInBicchiere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMettiInRecipiente;
        private System.Windows.Forms.Button btnTogliBicchiere;
        private System.Windows.Forms.Button btnTogliRecipiente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTogliBicchiere;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTogliRecipiente;
        private System.Windows.Forms.Button btnCapacitaRec;
        private System.Windows.Forms.Button btnVediCapacitaBicchiere;
    }
}

