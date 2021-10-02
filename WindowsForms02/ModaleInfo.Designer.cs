namespace WindowsForms02
{
    partial class ModaleInfo
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
            this.btnModaleInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModaleInfo
            // 
            this.btnModaleInfo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModaleInfo.Location = new System.Drawing.Point(92, 161);
            this.btnModaleInfo.Name = "btnModaleInfo";
            this.btnModaleInfo.Size = new System.Drawing.Size(111, 47);
            this.btnModaleInfo.TabIndex = 0;
            this.btnModaleInfo.Text = "Esci";
            this.btnModaleInfo.UseVisualStyleBackColor = true;
            // 
            // ModaleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 226);
            this.Controls.Add(this.btnModaleInfo);
            this.Name = "ModaleInfo";
            this.Text = "ModaleInfo";
            this.Load += new System.EventHandler(this.ModaleInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModaleInfo;
    }
}