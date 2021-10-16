namespace Verifica_Multiform
{
    partial class FormModaleContinua
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
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vuoi proseguire?";
            // 
            // btnSi
            // 
            this.btnSi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSi.Location = new System.Drawing.Point(33, 93);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(75, 23);
            this.btnSi.TabIndex = 1;
            this.btnSi.Text = "SI";
            this.btnSi.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Location = new System.Drawing.Point(152, 93);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // FormModaleContinua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 162);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.label1);
            this.Name = "FormModaleContinua";
            this.Text = "FormModaleContinua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;
    }
}