using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica_Multiform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string scelta = "";
        FormModaleContinua formModale;
        public Form2 form2;

        public string passaScelta()
        {
            return scelta;
        }
        private void btn32bitz_Click(object sender, EventArgs e)
        {
            pulisci();
            btn32bitz.BackColor = Color.Yellow;
            formModale = new FormModaleContinua();
            formModale.ShowDialog();
            if (formModale.DialogResult == DialogResult.OK)
            {
                scelta = "3+2 Blitz";
                this.Enabled = false;
                if (form2 == null)
                    form2 = new Form2();
                form2.MdiParent = this.MdiParent;
                form2.Show();
            }

            
        }


        private void btn50blitz_Click(object sender, EventArgs e)
        {
            pulisci();
            btn50blitz.BackColor = Color.Yellow;
            formModale = new FormModaleContinua();
            formModale.ShowDialog();
            if (formModale.DialogResult == DialogResult.OK)
            {
                scelta = "5+0 Blitz";
                this.Enabled = false;
                if (form2 == null)
                    form2 = new Form2();
                form2.MdiParent = this.MdiParent;
                form2.Show();
            }
                
        }

        private void btn53blitz_Click(object sender, EventArgs e)
        {
            pulisci();
            btn53blitz.BackColor = Color.Yellow;
            formModale = new FormModaleContinua();
            formModale.ShowDialog();
            if (formModale.DialogResult == DialogResult.OK) { this.Enabled = false; 
            scelta = "5+3 Blitz";
                if (form2 == null)
                    form2 = new Form2();
                form2.MdiParent = this.MdiParent;
                form2.Show();
            }
                
        }

        private void btn100rapid_Click(object sender, EventArgs e)
        {
            pulisci();
            btn100rapid.BackColor = Color.Yellow;
            formModale = new FormModaleContinua();
            formModale.ShowDialog();
            if (formModale.DialogResult == DialogResult.OK)
            {
                this.Enabled = false;scelta = "10+0 Rapid";
                if (form2 == null)
                    form2 = new Form2();
                form2.MdiParent = this.MdiParent;
                form2.Show();
            }
        }

        private void btn105rapid_Click(object sender, EventArgs e)
        {
            pulisci();
            btn105rapid.BackColor = Color.Yellow;
            formModale = new FormModaleContinua();
            formModale.ShowDialog();
            if (formModale.DialogResult == DialogResult.OK)
            {
                this.Enabled = false;scelta = "10+5 Rapid";
                if (form2 == null)
                    form2 = new Form2();
                form2.MdiParent = this.MdiParent;
                form2.Show();
            }
                
        }

        private void btn1510rapid_Click(object sender, EventArgs e)
        {
            pulisci();
            
            btn1510rapid.BackColor = Color.Yellow;
            formModale = new FormModaleContinua();
            formModale.ShowDialog();
            if (formModale.DialogResult == DialogResult.OK)
            {scelta = "15+10 Rapid";
                this.Enabled = false;
                if (form2 == null)
                    form2 = new Form2();
                form2.MdiParent = this.MdiParent;
                form2.Show();
            }
                
        }

        private void pulisci()
        {
            scelta = "";
            btn32bitz.BackColor = Color.White;
            btn50blitz.BackColor = Color.White;
            btn53blitz.BackColor = Color.White;
            btn100rapid.BackColor = Color.White;
            btn105rapid.BackColor = Color.White;
            btn1510rapid.BackColor = Color.White;
        }
    }
}
