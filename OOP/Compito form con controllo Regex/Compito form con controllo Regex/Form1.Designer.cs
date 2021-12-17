namespace Compito_form_con_controllo_Regex
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEtà = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCAP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegistrati = new System.Windows.Forms.Button();
            this.txtCF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.epNome = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCognome = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEta = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCAP = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCitta = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCF = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCognome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCitta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form di inserimento dati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(124, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(158, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtCognome
            // 
            this.txtCognome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCognome.Location = new System.Drawing.Point(124, 71);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(158, 20);
            this.txtCognome.TabIndex = 4;
            this.txtCognome.Leave += new System.EventHandler(this.txtCognome_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cognome";
            // 
            // txtEtà
            // 
            this.txtEtà.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEtà.Location = new System.Drawing.Point(124, 97);
            this.txtEtà.Name = "txtEtà";
            this.txtEtà.Size = new System.Drawing.Size(158, 20);
            this.txtEtà.TabIndex = 6;
            this.txtEtà.Leave += new System.EventHandler(this.txtEtà_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Età";
            // 
            // txtCAP
            // 
            this.txtCAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCAP.Location = new System.Drawing.Point(124, 123);
            this.txtCAP.Name = "txtCAP";
            this.txtCAP.Size = new System.Drawing.Size(158, 20);
            this.txtCAP.TabIndex = 8;
            this.txtCAP.Leave += new System.EventHandler(this.txtCAP_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "CAP";
            // 
            // txtCitta
            // 
            this.txtCitta.BackColor = System.Drawing.SystemColors.Window;
            this.txtCitta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCitta.Location = new System.Drawing.Point(124, 149);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(158, 20);
            this.txtCitta.TabIndex = 10;
            this.txtCitta.Leave += new System.EventHandler(this.txtCitta_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Citta e provincia";
            // 
            // txtMail
            // 
            this.txtMail.AccessibleDescription = "";
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Location = new System.Drawing.Point(124, 201);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(158, 20);
            this.txtMail.TabIndex = 12;
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mail";
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleDescription = "";
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(124, 253);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(158, 20);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(124, 227);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(158, 20);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Username";
            // 
            // btnRegistrati
            // 
            this.btnRegistrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrati.Location = new System.Drawing.Point(68, 294);
            this.btnRegistrati.Name = "btnRegistrati";
            this.btnRegistrati.Size = new System.Drawing.Size(157, 47);
            this.btnRegistrati.TabIndex = 17;
            this.btnRegistrati.Text = "Registrati";
            this.btnRegistrati.UseVisualStyleBackColor = true;
            this.btnRegistrati.Click += new System.EventHandler(this.btnRegistrati_Click);
            // 
            // txtCF
            // 
            this.txtCF.BackColor = System.Drawing.SystemColors.Window;
            this.txtCF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCF.Location = new System.Drawing.Point(124, 175);
            this.txtCF.Name = "txtCF";
            this.txtCF.Size = new System.Drawing.Size(158, 20);
            this.txtCF.TabIndex = 19;
            this.txtCF.Leave += new System.EventHandler(this.txtCF_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Codice fiscale";
            // 
            // epNome
            // 
            this.epNome.ContainerControl = this;
            // 
            // epCognome
            // 
            this.epCognome.ContainerControl = this;
            // 
            // epEta
            // 
            this.epEta.ContainerControl = this;
            // 
            // epCAP
            // 
            this.epCAP.ContainerControl = this;
            // 
            // epCitta
            // 
            this.epCitta.ContainerControl = this;
            // 
            // epCF
            // 
            this.epCF.ContainerControl = this;
            // 
            // epMail
            // 
            this.epMail.ContainerControl = this;
            // 
            // epUsername
            // 
            this.epUsername.ContainerControl = this;
            // 
            // epPassword
            // 
            this.epPassword.ContainerControl = this;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 355);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 433);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtCF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRegistrati);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCAP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEtà);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Registrati";
            ((System.ComponentModel.ISupportInitialize)(this.epNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCognome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCitta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEtà;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCAP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegistrati;
        private System.Windows.Forms.TextBox txtCF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider epNome;
        private System.Windows.Forms.ErrorProvider epCognome;
        private System.Windows.Forms.ErrorProvider epEta;
        private System.Windows.Forms.ErrorProvider epCAP;
        private System.Windows.Forms.ErrorProvider epCitta;
        private System.Windows.Forms.ErrorProvider epCF;
        private System.Windows.Forms.ErrorProvider epMail;
        private System.Windows.Forms.ErrorProvider epUsername;
        private System.Windows.Forms.ErrorProvider epPassword;
        private System.Windows.Forms.Label lblResult;
    }
}

