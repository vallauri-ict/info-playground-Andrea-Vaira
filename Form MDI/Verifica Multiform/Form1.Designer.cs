namespace Verifica_Multiform
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
            this.btn32bitz = new System.Windows.Forms.Button();
            this.btn1510rapid = new System.Windows.Forms.Button();
            this.btn105rapid = new System.Windows.Forms.Button();
            this.btn100rapid = new System.Windows.Forms.Button();
            this.btn53blitz = new System.Windows.Forms.Button();
            this.btn50blitz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn32bitz
            // 
            this.btn32bitz.BackColor = System.Drawing.Color.White;
            this.btn32bitz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn32bitz.Location = new System.Drawing.Point(37, 39);
            this.btn32bitz.Name = "btn32bitz";
            this.btn32bitz.Size = new System.Drawing.Size(92, 40);
            this.btn32bitz.TabIndex = 0;
            this.btn32bitz.Text = "3+2\r\nBlitz";
            this.btn32bitz.UseVisualStyleBackColor = false;
            this.btn32bitz.Click += new System.EventHandler(this.btn32bitz_Click);
            // 
            // btn1510rapid
            // 
            this.btn1510rapid.BackColor = System.Drawing.Color.White;
            this.btn1510rapid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1510rapid.Location = new System.Drawing.Point(233, 85);
            this.btn1510rapid.Name = "btn1510rapid";
            this.btn1510rapid.Size = new System.Drawing.Size(92, 40);
            this.btn1510rapid.TabIndex = 1;
            this.btn1510rapid.Text = "15+10\r\nRapid";
            this.btn1510rapid.UseVisualStyleBackColor = false;
            this.btn1510rapid.Click += new System.EventHandler(this.btn1510rapid_Click);
            // 
            // btn105rapid
            // 
            this.btn105rapid.BackColor = System.Drawing.Color.White;
            this.btn105rapid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn105rapid.Location = new System.Drawing.Point(135, 85);
            this.btn105rapid.Name = "btn105rapid";
            this.btn105rapid.Size = new System.Drawing.Size(92, 40);
            this.btn105rapid.TabIndex = 2;
            this.btn105rapid.Text = "10+5\r\nRapid";
            this.btn105rapid.UseVisualStyleBackColor = false;
            this.btn105rapid.Click += new System.EventHandler(this.btn105rapid_Click);
            // 
            // btn100rapid
            // 
            this.btn100rapid.BackColor = System.Drawing.Color.White;
            this.btn100rapid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100rapid.Location = new System.Drawing.Point(37, 85);
            this.btn100rapid.Name = "btn100rapid";
            this.btn100rapid.Size = new System.Drawing.Size(92, 40);
            this.btn100rapid.TabIndex = 3;
            this.btn100rapid.Text = "10+0\r\nRapid";
            this.btn100rapid.UseVisualStyleBackColor = false;
            this.btn100rapid.Click += new System.EventHandler(this.btn100rapid_Click);
            // 
            // btn53blitz
            // 
            this.btn53blitz.BackColor = System.Drawing.Color.White;
            this.btn53blitz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn53blitz.Location = new System.Drawing.Point(233, 39);
            this.btn53blitz.Name = "btn53blitz";
            this.btn53blitz.Size = new System.Drawing.Size(92, 40);
            this.btn53blitz.TabIndex = 4;
            this.btn53blitz.Text = "5+3\nBlitz";
            this.btn53blitz.UseVisualStyleBackColor = false;
            this.btn53blitz.Click += new System.EventHandler(this.btn53blitz_Click);
            // 
            // btn50blitz
            // 
            this.btn50blitz.BackColor = System.Drawing.Color.White;
            this.btn50blitz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn50blitz.Location = new System.Drawing.Point(135, 39);
            this.btn50blitz.Name = "btn50blitz";
            this.btn50blitz.Size = new System.Drawing.Size(92, 40);
            this.btn50blitz.TabIndex = 5;
            this.btn50blitz.Text = "5+0\r\nBlitz";
            this.btn50blitz.UseVisualStyleBackColor = false;
            this.btn50blitz.Click += new System.EventHandler(this.btn50blitz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 178);
            this.Controls.Add(this.btn50blitz);
            this.Controls.Add(this.btn53blitz);
            this.Controls.Add(this.btn100rapid);
            this.Controls.Add(this.btn105rapid);
            this.Controls.Add(this.btn1510rapid);
            this.Controls.Add(this.btn32bitz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn32bitz;
        private System.Windows.Forms.Button btn1510rapid;
        private System.Windows.Forms.Button btn105rapid;
        private System.Windows.Forms.Button btn100rapid;
        private System.Windows.Forms.Button btn53blitz;
        private System.Windows.Forms.Button btn50blitz;
    }
}