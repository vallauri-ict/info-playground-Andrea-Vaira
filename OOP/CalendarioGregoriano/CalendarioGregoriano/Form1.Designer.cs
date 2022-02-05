namespace CalendarioGregoriano
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
            this.btnCreaData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreaOra = new System.Windows.Forms.Button();
            this.btnIsBisestile = new System.Windows.Forms.Button();
            this.btnToStringData = new System.Windows.Forms.Button();
            this.btnDomani = new System.Windows.Forms.Button();
            this.btnIeri = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnDataOra = new System.Windows.Forms.Button();
            this.BtnScriviData = new System.Windows.Forms.Button();
            this.BtnScriviOra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreaData
            // 
            this.btnCreaData.Location = new System.Drawing.Point(12, 12);
            this.btnCreaData.Name = "btnCreaData";
            this.btnCreaData.Size = new System.Drawing.Size(155, 69);
            this.btnCreaData.TabIndex = 0;
            this.btnCreaData.Text = "Crea Data";
            this.btnCreaData.UseVisualStyleBackColor = true;
            this.btnCreaData.Click += new System.EventHandler(this.btnCreaData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(86, 112);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 2;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(86, 138);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 20);
            this.txtMonth.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Month";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(86, 164);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 20);
            this.txtDay.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Day";
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(365, 164);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 20);
            this.txtSecond.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Second";
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(365, 138);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(100, 20);
            this.txtMinute.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Minute";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(365, 112);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(100, 20);
            this.txtHour.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hour";
            // 
            // btnCreaOra
            // 
            this.btnCreaOra.Location = new System.Drawing.Point(291, 12);
            this.btnCreaOra.Name = "btnCreaOra";
            this.btnCreaOra.Size = new System.Drawing.Size(155, 69);
            this.btnCreaOra.TabIndex = 7;
            this.btnCreaOra.Text = "Crea Ora";
            this.btnCreaOra.UseVisualStyleBackColor = true;
            this.btnCreaOra.Click += new System.EventHandler(this.btnCreaOra_Click);
            // 
            // btnIsBisestile
            // 
            this.btnIsBisestile.Location = new System.Drawing.Point(12, 219);
            this.btnIsBisestile.Name = "btnIsBisestile";
            this.btnIsBisestile.Size = new System.Drawing.Size(131, 46);
            this.btnIsBisestile.TabIndex = 14;
            this.btnIsBisestile.Text = "E\' bisestile";
            this.btnIsBisestile.UseVisualStyleBackColor = true;
            this.btnIsBisestile.Click += new System.EventHandler(this.btnIsBisestile_Click);
            // 
            // btnToStringData
            // 
            this.btnToStringData.Location = new System.Drawing.Point(12, 271);
            this.btnToStringData.Name = "btnToStringData";
            this.btnToStringData.Size = new System.Drawing.Size(131, 46);
            this.btnToStringData.TabIndex = 15;
            this.btnToStringData.Text = "Ritorna Stringa data";
            this.btnToStringData.UseVisualStyleBackColor = true;
            this.btnToStringData.Click += new System.EventHandler(this.btnToStringData_Click);
            // 
            // btnDomani
            // 
            this.btnDomani.Location = new System.Drawing.Point(149, 271);
            this.btnDomani.Name = "btnDomani";
            this.btnDomani.Size = new System.Drawing.Size(98, 46);
            this.btnDomani.TabIndex = 17;
            this.btnDomani.Text = "Domani";
            this.btnDomani.UseVisualStyleBackColor = true;
            this.btnDomani.Click += new System.EventHandler(this.btnDomani_Click);
            // 
            // btnIeri
            // 
            this.btnIeri.Location = new System.Drawing.Point(149, 219);
            this.btnIeri.Name = "btnIeri";
            this.btnIeri.Size = new System.Drawing.Size(98, 46);
            this.btnIeri.TabIndex = 16;
            this.btnIeri.Text = "Ieri";
            this.btnIeri.UseVisualStyleBackColor = true;
            this.btnIeri.Click += new System.EventHandler(this.btnIeri_Click);
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(12, 323);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(131, 46);
            this.btnDay.TabIndex = 18;
            this.btnDay.Text = "Ritorna giorno settimana";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnDataOra
            // 
            this.btnDataOra.Location = new System.Drawing.Point(291, 219);
            this.btnDataOra.Name = "btnDataOra";
            this.btnDataOra.Size = new System.Drawing.Size(131, 46);
            this.btnDataOra.TabIndex = 19;
            this.btnDataOra.Text = "Ritorna Stringa dataOra";
            this.btnDataOra.UseVisualStyleBackColor = true;
            this.btnDataOra.Click += new System.EventHandler(this.btnDataOra_Click);
            // 
            // BtnScriviData
            // 
            this.BtnScriviData.Location = new System.Drawing.Point(149, 323);
            this.BtnScriviData.Name = "BtnScriviData";
            this.BtnScriviData.Size = new System.Drawing.Size(98, 46);
            this.BtnScriviData.TabIndex = 20;
            this.BtnScriviData.Text = "Modifica";
            this.BtnScriviData.UseVisualStyleBackColor = true;
            this.BtnScriviData.Click += new System.EventHandler(this.BtnScriviData_Click);
            // 
            // BtnScriviOra
            // 
            this.BtnScriviOra.Location = new System.Drawing.Point(428, 219);
            this.BtnScriviOra.Name = "BtnScriviOra";
            this.BtnScriviOra.Size = new System.Drawing.Size(98, 46);
            this.BtnScriviOra.TabIndex = 21;
            this.BtnScriviOra.Text = "Modifica";
            this.BtnScriviOra.UseVisualStyleBackColor = true;
            this.BtnScriviOra.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 530);
            this.Controls.Add(this.BtnScriviOra);
            this.Controls.Add(this.BtnScriviData);
            this.Controls.Add(this.btnDataOra);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.btnDomani);
            this.Controls.Add(this.btnIeri);
            this.Controls.Add(this.btnToStringData);
            this.Controls.Add(this.btnIsBisestile);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreaOra);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreaData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreaData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreaOra;
        private System.Windows.Forms.Button btnIsBisestile;
        private System.Windows.Forms.Button btnToStringData;
        private System.Windows.Forms.Button btnDomani;
        private System.Windows.Forms.Button btnIeri;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnDataOra;
        private System.Windows.Forms.Button BtnScriviData;
        private System.Windows.Forms.Button BtnScriviOra;
    }
}

