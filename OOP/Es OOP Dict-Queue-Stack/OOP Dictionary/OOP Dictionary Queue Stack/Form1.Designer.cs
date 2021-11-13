﻿namespace OOP_Dictionary_Queue_Stack
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLength = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFindArticle = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chiave";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(91, 6);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 20);
            this.txtKey.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Articolo";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(91, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Inserisci";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(216, 4);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(100, 44);
            this.btnLength.TabIndex = 5;
            this.btnLength.Text = "Visualizza numero Prodotti";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(322, 20);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(0, 13);
            this.lblLength.TabIndex = 6;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(107, 110);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 20);
            this.txtFind.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Insersci la chiave";
            // 
            // lblFindArticle
            // 
            this.lblFindArticle.AutoSize = true;
            this.lblFindArticle.Location = new System.Drawing.Point(12, 139);
            this.lblFindArticle.Name = "lblFindArticle";
            this.lblFindArticle.Size = new System.Drawing.Size(0, 13);
            this.lblFindArticle.TabIndex = 9;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(10, 165);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Cerca";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 300);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblFindArticle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.btnLength);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFindArticle;
        private System.Windows.Forms.Button btnFind;
    }
}

