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
            this.panelloNuovoIscritto = new System.Windows.Forms.Panel();
            this.lblGestisciIscritto = new System.Windows.Forms.Label();
            this.btnGestisciIscritto = new System.Windows.Forms.Button();
            this.dtpDataNascita = new System.Windows.Forms.DateTimePicker();
            this.cmbGenere = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelloNuovoEvento = new System.Windows.Forms.Panel();
            this.lblGestioneEvento = new System.Windows.Forms.Label();
            this.btnGestioneEvento = new System.Windows.Forms.Button();
            this.dtpDataEvento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCostoEvento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescrizioneEvento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDenominazioneEvento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTipologiaEvento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnNuovoEvento = new System.Windows.Forms.Button();
            this.btnCancellaEvento = new System.Windows.Forms.Button();
            this.btnCancellaIscritto = new System.Windows.Forms.Button();
            this.rbtM = new System.Windows.Forms.RadioButton();
            this.rbtF = new System.Windows.Forms.RadioButton();
            this.rbtTutti = new System.Windows.Forms.RadioButton();
            this.grbFiltri = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chkFiltraPerAnno = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIscritti)).BeginInit();
            this.panelloNuovoIscritto.SuspendLayout();
            this.panelloNuovoEvento.SuspendLayout();
            this.grbFiltri.SuspendLayout();
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
            // panelloNuovoIscritto
            // 
            this.panelloNuovoIscritto.Controls.Add(this.btnCancellaIscritto);
            this.panelloNuovoIscritto.Controls.Add(this.lblGestisciIscritto);
            this.panelloNuovoIscritto.Controls.Add(this.btnGestisciIscritto);
            this.panelloNuovoIscritto.Controls.Add(this.dtpDataNascita);
            this.panelloNuovoIscritto.Controls.Add(this.cmbGenere);
            this.panelloNuovoIscritto.Controls.Add(this.label5);
            this.panelloNuovoIscritto.Controls.Add(this.label4);
            this.panelloNuovoIscritto.Controls.Add(this.txtCognome);
            this.panelloNuovoIscritto.Controls.Add(this.label3);
            this.panelloNuovoIscritto.Controls.Add(this.txtNome);
            this.panelloNuovoIscritto.Controls.Add(this.label2);
            this.panelloNuovoIscritto.Controls.Add(this.txtTelefono);
            this.panelloNuovoIscritto.Controls.Add(this.label6);
            this.panelloNuovoIscritto.Controls.Add(this.txtEmail);
            this.panelloNuovoIscritto.Controls.Add(this.label7);
            this.panelloNuovoIscritto.Location = new System.Drawing.Point(679, 472);
            this.panelloNuovoIscritto.Name = "panelloNuovoIscritto";
            this.panelloNuovoIscritto.Size = new System.Drawing.Size(539, 280);
            this.panelloNuovoIscritto.TabIndex = 6;
            // 
            // lblGestisciIscritto
            // 
            this.lblGestisciIscritto.AutoSize = true;
            this.lblGestisciIscritto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestisciIscritto.Location = new System.Drawing.Point(135, 8);
            this.lblGestisciIscritto.Name = "lblGestisciIscritto";
            this.lblGestisciIscritto.Size = new System.Drawing.Size(160, 24);
            this.lblGestisciIscritto.TabIndex = 36;
            this.lblGestisciIscritto.Text = "Aggiungi Iscritto";
            // 
            // btnGestisciIscritto
            // 
            this.btnGestisciIscritto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestisciIscritto.Location = new System.Drawing.Point(30, 219);
            this.btnGestisciIscritto.Name = "btnGestisciIscritto";
            this.btnGestisciIscritto.Size = new System.Drawing.Size(208, 52);
            this.btnGestisciIscritto.TabIndex = 35;
            this.btnGestisciIscritto.Text = "Aggiungi";
            this.btnGestisciIscritto.UseVisualStyleBackColor = true;
            this.btnGestisciIscritto.Click += new System.EventHandler(this.btnGestisciIscritto_Click);
            // 
            // dtpDataNascita
            // 
            this.dtpDataNascita.Location = new System.Drawing.Point(179, 193);
            this.dtpDataNascita.Name = "dtpDataNascita";
            this.dtpDataNascita.Size = new System.Drawing.Size(200, 20);
            this.dtpDataNascita.TabIndex = 34;
            // 
            // cmbGenere
            // 
            this.cmbGenere.FormattingEnabled = true;
            this.cmbGenere.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbGenere.Location = new System.Drawing.Point(199, 166);
            this.cmbGenere.Name = "cmbGenere";
            this.cmbGenere.Size = new System.Drawing.Size(180, 21);
            this.cmbGenere.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Data di nascita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Genere";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(120, 140);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(259, 20);
            this.txtCognome.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cognome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(120, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(259, 20);
            this.txtNome.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(120, 88);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(259, 20);
            this.txtTelefono.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Email";
            // 
            // panelloNuovoEvento
            // 
            this.panelloNuovoEvento.Controls.Add(this.btnCancellaEvento);
            this.panelloNuovoEvento.Controls.Add(this.lblGestioneEvento);
            this.panelloNuovoEvento.Controls.Add(this.btnGestioneEvento);
            this.panelloNuovoEvento.Controls.Add(this.dtpDataEvento);
            this.panelloNuovoEvento.Controls.Add(this.label9);
            this.panelloNuovoEvento.Controls.Add(this.txtCostoEvento);
            this.panelloNuovoEvento.Controls.Add(this.label11);
            this.panelloNuovoEvento.Controls.Add(this.txtDescrizioneEvento);
            this.panelloNuovoEvento.Controls.Add(this.label12);
            this.panelloNuovoEvento.Controls.Add(this.txtDenominazioneEvento);
            this.panelloNuovoEvento.Controls.Add(this.label13);
            this.panelloNuovoEvento.Controls.Add(this.txtTipologiaEvento);
            this.panelloNuovoEvento.Controls.Add(this.label14);
            this.panelloNuovoEvento.Location = new System.Drawing.Point(12, 472);
            this.panelloNuovoEvento.Name = "panelloNuovoEvento";
            this.panelloNuovoEvento.Size = new System.Drawing.Size(539, 280);
            this.panelloNuovoEvento.TabIndex = 8;
            // 
            // lblGestioneEvento
            // 
            this.lblGestioneEvento.AutoSize = true;
            this.lblGestioneEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestioneEvento.Location = new System.Drawing.Point(135, 8);
            this.lblGestioneEvento.Name = "lblGestioneEvento";
            this.lblGestioneEvento.Size = new System.Drawing.Size(160, 24);
            this.lblGestioneEvento.TabIndex = 36;
            this.lblGestioneEvento.Text = "Aggiungi Iscritto";
            // 
            // btnGestioneEvento
            // 
            this.btnGestioneEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestioneEvento.Location = new System.Drawing.Point(30, 219);
            this.btnGestioneEvento.Name = "btnGestioneEvento";
            this.btnGestioneEvento.Size = new System.Drawing.Size(208, 52);
            this.btnGestioneEvento.TabIndex = 35;
            this.btnGestioneEvento.Text = "Aggiungi";
            this.btnGestioneEvento.UseVisualStyleBackColor = true;
            this.btnGestioneEvento.Click += new System.EventHandler(this.btnGestioneEvento_Click);
            // 
            // dtpDataEvento
            // 
            this.dtpDataEvento.Location = new System.Drawing.Point(209, 139);
            this.dtpDataEvento.Name = "dtpDataEvento";
            this.dtpDataEvento.Size = new System.Drawing.Size(200, 20);
            this.dtpDataEvento.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Data";
            // 
            // txtCostoEvento
            // 
            this.txtCostoEvento.Location = new System.Drawing.Point(150, 165);
            this.txtCostoEvento.Name = "txtCostoEvento";
            this.txtCostoEvento.Size = new System.Drawing.Size(259, 20);
            this.txtCostoEvento.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Costo";
            // 
            // txtDescrizioneEvento
            // 
            this.txtDescrizioneEvento.Location = new System.Drawing.Point(150, 114);
            this.txtDescrizioneEvento.Name = "txtDescrizioneEvento";
            this.txtDescrizioneEvento.Size = new System.Drawing.Size(259, 20);
            this.txtDescrizioneEvento.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Descrizione";
            // 
            // txtDenominazioneEvento
            // 
            this.txtDenominazioneEvento.Location = new System.Drawing.Point(150, 88);
            this.txtDenominazioneEvento.Name = "txtDenominazioneEvento";
            this.txtDenominazioneEvento.Size = new System.Drawing.Size(259, 20);
            this.txtDenominazioneEvento.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Denominazione";
            // 
            // txtTipologiaEvento
            // 
            this.txtTipologiaEvento.Location = new System.Drawing.Point(150, 62);
            this.txtTipologiaEvento.Name = "txtTipologiaEvento";
            this.txtTipologiaEvento.Size = new System.Drawing.Size(259, 20);
            this.txtTipologiaEvento.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Tipologia";
            // 
            // btnNuovoEvento
            // 
            this.btnNuovoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuovoEvento.Location = new System.Drawing.Point(433, 418);
            this.btnNuovoEvento.Name = "btnNuovoEvento";
            this.btnNuovoEvento.Size = new System.Drawing.Size(179, 57);
            this.btnNuovoEvento.TabIndex = 7;
            this.btnNuovoEvento.Text = "NUOVO EVENTO";
            this.btnNuovoEvento.UseVisualStyleBackColor = true;
            this.btnNuovoEvento.Click += new System.EventHandler(this.btnNuovoEvento_Click);
            // 
            // btnCancellaEvento
            // 
            this.btnCancellaEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancellaEvento.Location = new System.Drawing.Point(244, 219);
            this.btnCancellaEvento.Name = "btnCancellaEvento";
            this.btnCancellaEvento.Size = new System.Drawing.Size(208, 52);
            this.btnCancellaEvento.TabIndex = 37;
            this.btnCancellaEvento.Text = "Elimina";
            this.btnCancellaEvento.UseVisualStyleBackColor = true;
            this.btnCancellaEvento.Click += new System.EventHandler(this.btnCancellaEvento_Click);
            // 
            // btnCancellaIscritto
            // 
            this.btnCancellaIscritto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancellaIscritto.Location = new System.Drawing.Point(244, 219);
            this.btnCancellaIscritto.Name = "btnCancellaIscritto";
            this.btnCancellaIscritto.Size = new System.Drawing.Size(208, 52);
            this.btnCancellaIscritto.TabIndex = 38;
            this.btnCancellaIscritto.Text = "Elimina";
            this.btnCancellaIscritto.UseVisualStyleBackColor = true;
            this.btnCancellaIscritto.Click += new System.EventHandler(this.btnCancellaIscritto_Click);
            // 
            // rbtM
            // 
            this.rbtM.AutoSize = true;
            this.rbtM.Location = new System.Drawing.Point(6, 19);
            this.rbtM.Name = "rbtM";
            this.rbtM.Size = new System.Drawing.Size(34, 17);
            this.rbtM.TabIndex = 9;
            this.rbtM.Text = "M";
            this.rbtM.UseVisualStyleBackColor = true;
            this.rbtM.CheckedChanged += new System.EventHandler(this.rbtM_CheckedChanged);
            // 
            // rbtF
            // 
            this.rbtF.AutoSize = true;
            this.rbtF.Location = new System.Drawing.Point(45, 19);
            this.rbtF.Name = "rbtF";
            this.rbtF.Size = new System.Drawing.Size(31, 17);
            this.rbtF.TabIndex = 10;
            this.rbtF.Text = "F";
            this.rbtF.UseVisualStyleBackColor = true;
            this.rbtF.CheckedChanged += new System.EventHandler(this.rbtF_CheckedChanged);
            // 
            // rbtTutti
            // 
            this.rbtTutti.AutoSize = true;
            this.rbtTutti.Checked = true;
            this.rbtTutti.Location = new System.Drawing.Point(82, 19);
            this.rbtTutti.Name = "rbtTutti";
            this.rbtTutti.Size = new System.Drawing.Size(46, 17);
            this.rbtTutti.TabIndex = 11;
            this.rbtTutti.TabStop = true;
            this.rbtTutti.Text = "Tutti";
            this.rbtTutti.UseVisualStyleBackColor = true;
            this.rbtTutti.CheckedChanged += new System.EventHandler(this.rbtTutti_CheckedChanged);
            // 
            // grbFiltri
            // 
            this.grbFiltri.Controls.Add(this.chkFiltraPerAnno);
            this.grbFiltri.Controls.Add(this.dateTimePicker1);
            this.grbFiltri.Controls.Add(this.rbtM);
            this.grbFiltri.Controls.Add(this.rbtTutti);
            this.grbFiltri.Controls.Add(this.rbtF);
            this.grbFiltri.Location = new System.Drawing.Point(682, 428);
            this.grbFiltri.Name = "grbFiltri";
            this.grbFiltri.Size = new System.Drawing.Size(315, 38);
            this.grbFiltri.TabIndex = 12;
            this.grbFiltri.TabStop = false;
            this.grbFiltri.Text = "Filtri";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(241, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(68, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // chkFiltraPerAnno
            // 
            this.chkFiltraPerAnno.AutoSize = true;
            this.chkFiltraPerAnno.Location = new System.Drawing.Point(142, 15);
            this.chkFiltraPerAnno.Name = "chkFiltraPerAnno";
            this.chkFiltraPerAnno.Size = new System.Drawing.Size(93, 17);
            this.chkFiltraPerAnno.TabIndex = 13;
            this.chkFiltraPerAnno.Text = "Filtra per anno";
            this.chkFiltraPerAnno.UseVisualStyleBackColor = true;
            this.chkFiltraPerAnno.CheckedChanged += new System.EventHandler(this.chkFiltraPerAnno_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 755);
            this.Controls.Add(this.grbFiltri);
            this.Controls.Add(this.panelloNuovoEvento);
            this.Controls.Add(this.btnNuovoEvento);
            this.Controls.Add(this.panelloNuovoIscritto);
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
            this.panelloNuovoIscritto.ResumeLayout(false);
            this.panelloNuovoIscritto.PerformLayout();
            this.panelloNuovoEvento.ResumeLayout(false);
            this.panelloNuovoEvento.PerformLayout();
            this.grbFiltri.ResumeLayout(false);
            this.grbFiltri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.DataGridView dgvEventi;
        private System.Windows.Forms.Button btnNuovoIscritto;
        private System.Windows.Forms.DataGridView dgvIscritti;
        private System.Windows.Forms.Panel panelloNuovoIscritto;
        private System.Windows.Forms.Label lblGestisciIscritto;
        private System.Windows.Forms.Button btnGestisciIscritto;
        private System.Windows.Forms.DateTimePicker dtpDataNascita;
        private System.Windows.Forms.ComboBox cmbGenere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelloNuovoEvento;
        private System.Windows.Forms.Label lblGestioneEvento;
        private System.Windows.Forms.Button btnGestioneEvento;
        private System.Windows.Forms.DateTimePicker dtpDataEvento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCostoEvento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescrizioneEvento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDenominazioneEvento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTipologiaEvento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnNuovoEvento;
        private System.Windows.Forms.Button btnCancellaIscritto;
        private System.Windows.Forms.Button btnCancellaEvento;
        private System.Windows.Forms.RadioButton rbtM;
        private System.Windows.Forms.RadioButton rbtF;
        private System.Windows.Forms.RadioButton rbtTutti;
        private System.Windows.Forms.GroupBox grbFiltri;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chkFiltraPerAnno;
    }
}

