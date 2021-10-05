using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esempio_Verifica_multiform
{
    
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        Form1 form1;
        Form2 form2;
        

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1.MdiParent = this;
            form1.Show();
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if((!form1.pelle && !form1.stoffa) || form1.marca=="")
            {
                FormControllo frm = new FormControllo();
                frm.ShowDialog();
            }
            else
            {
                string label = "La tua macchina e': ";
                label += form1.marca + "\n" + "Rivestimento: ";
                if (form1.pelle)
                    label += "pelle ";
                if (form1.stoffa)
                    label += "stoffa ";

                form2 = new Form2(label);
                form2.MdiParent = this;
                form2.Show();

                lblStatusStrip.Text = "La tua auto e'una ";
                lblStatusStrip.Text += form1.marca;
            }

            

        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModale frm = new FormModale();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
                this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            form1 = new Form1();
            
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo frm = new FormInfo();
            frm.ShowDialog();
        }
    }
}
