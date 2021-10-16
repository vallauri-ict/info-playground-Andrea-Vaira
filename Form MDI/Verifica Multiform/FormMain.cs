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
            if (form1 == null)
                form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
            
        }

        
        /*public void passaStatus(string parametro)
        {
            statusStrip1.Text = parametro;
        }*/

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form1.form2 == null)
            {
                if (form2 == null)
                    form2 = new Form2();
                form2.MdiParent = this;
                form2.Show();
            }
            else
                form1.form2.Show();
        }
    }
}
