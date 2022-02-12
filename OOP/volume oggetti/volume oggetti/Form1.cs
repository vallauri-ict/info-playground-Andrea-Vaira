using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volume_oggetti
{
    public partial class Form1 : Form
    {
        abstract class classeAstratta
        {
            
            public abstract void calcoloVolume();
            public abstract void stampaVolume();
            public void volume()
            {
                stampaVolume();
                calcoloVolume();
            }
        }
        class cilindro : classeAstratta
        {
            public int area=0;
            public int altezza=0;
            public int volume=0;
            public override void calcoloVolume()
            {
                volume = area * altezza;
                MessageBox.Show("Il volume del cilindro è: "+volume.ToString());
            }
            public override void stampaVolume()
            {
                MessageBox.Show("i dati del cilindro inserito sono:\nArea base: " +area.ToString() + "\nAltezza: " +altezza.ToString()+"\nVolume: "+volume.ToString());
            }

        }
        cilindro cil = new cilindro();

        class paralelepipedo : classeAstratta
        {
            public int area = 0;
            public int altezza = 0;
            public int volume = 0;
            public override void calcoloVolume()
            {
                volume = area * altezza;
                MessageBox.Show("Il volume del paralelepipedo è: " + volume.ToString());
            }
            public override void stampaVolume()
            {
                MessageBox.Show("i dati del paralelepipedo inserito sono:\nArea base: " + area.ToString() + "\nAltezza: " + altezza.ToString() + "\nVolume: " + volume.ToString());
            }

        }
        paralelepipedo par = new paralelepipedo();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            btnstampaCil.Enabled = false;
            btnStampaPar.Enabled = false;
        }

        private void btnCalcoloCil_Click_1(object sender, EventArgs e)
        {
            btnstampaCil.Enabled = true;
            cil.area = Convert.ToInt32(txtBase.Text);
            cil.altezza = Convert.ToInt32(txtAltezza.Text);
            cil.calcoloVolume();
        }

        private void btnstampaCil_Click_1(object sender, EventArgs e)
        {
            cil.stampaVolume();
        }

        private void btnCalcoloPar_Click_1(object sender, EventArgs e)
        {
            btnStampaPar.Enabled = true;
            par.area = Convert.ToInt32(txtBase.Text);
            par.altezza = Convert.ToInt32(txtAltezza.Text);
            par.calcoloVolume();

        }

        private void btnStampaPar_Click_1(object sender, EventArgs e)
        {
            par.stampaVolume();
        }
    }
}
