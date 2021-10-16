namespace WindowsForms01
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnF2Leggi = new System.Windows.Forms.Button();
            this.txtF2 = new System.Windows.Forms.TextBox();
            this.btnInviaAForm1 = new System.Windows.Forms.Button();
            this.btnF2ApriFIglia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SONO LA FORM 2";
            // 
            // btnF2Leggi
            // 
            this.btnF2Leggi.Location = new System.Drawing.Point(12, 56);
            this.btnF2Leggi.Name = "btnF2Leggi";
            this.btnF2Leggi.Size = new System.Drawing.Size(105, 48);
            this.btnF2Leggi.TabIndex = 1;
            this.btnF2Leggi.Text = "Leggi valore";
            this.btnF2Leggi.UseVisualStyleBackColor = true;
            this.btnF2Leggi.Click += new System.EventHandler(this.btnF2Leggi_Click);
            // 
            // txtF2
            // 
            this.txtF2.Location = new System.Drawing.Point(12, 110);
            this.txtF2.Name = "txtF2";
            this.txtF2.Size = new System.Drawing.Size(100, 20);
            this.txtF2.TabIndex = 2;
            // 
            // btnInviaAForm1
            // 
            this.btnInviaAForm1.Location = new System.Drawing.Point(118, 110);
            this.btnInviaAForm1.Name = "btnInviaAForm1";
            this.btnInviaAForm1.Size = new System.Drawing.Size(88, 21);
            this.btnInviaAForm1.TabIndex = 3;
            this.btnInviaAForm1.Text = "Invia a form1 ";
            this.btnInviaAForm1.UseVisualStyleBackColor = true;
            this.btnInviaAForm1.Click += new System.EventHandler(this.btnInviaAForm1_Click);
            // 
            // btnF2ApriFIglia
            // 
            this.btnF2ApriFIglia.Location = new System.Drawing.Point(12, 149);
            this.btnF2ApriFIglia.Name = "btnF2ApriFIglia";
            this.btnF2ApriFIglia.Size = new System.Drawing.Size(100, 41);
            this.btnF2ApriFIglia.TabIndex = 4;
            this.btnF2ApriFIglia.Text = "Apri form figlia";
            this.btnF2ApriFIglia.UseVisualStyleBackColor = true;
            this.btnF2ApriFIglia.Click += new System.EventHandler(this.btnF2ApriFIglia_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 400);
            this.Controls.Add(this.btnF2ApriFIglia);
            this.Controls.Add(this.btnInviaAForm1);
            this.Controls.Add(this.txtF2);
            this.Controls.Add(this.btnF2Leggi);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnF2Leggi;
        private System.Windows.Forms.TextBox txtF2;
        private System.Windows.Forms.Button btnInviaAForm1;
        private System.Windows.Forms.Button btnF2ApriFIglia;
    }
}