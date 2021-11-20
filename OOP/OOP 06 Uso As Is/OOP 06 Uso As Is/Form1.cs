using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_06_Uso_As_Is
{
    public partial class Form1 : Form
    {
        Random casuale = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneraMostro_Click(object sender, EventArgs e)
        {
            Mostro guadiano;
            if (casuale.Next(2) == 0)
                guadiano = new Mannaro();
            else
                guadiano = new Zombi();

            MessageBox.Show("Verso come Mostro: "+guadiano.Verso()); //eseguo il metodo verso di mannaro e non di mostro
            if (guadiano is Mannaro)
                MessageBox.Show("Verso come Mannaro: " + (guadiano as Mannaro).Verso()); //eseguo il metodo verso di mannaro e non di mostro
            else if(guadiano is Zombi)
                MessageBox.Show("Verso come Zombi: " + (guadiano as Zombi).Verso());
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                (sender as Button).Text = "Cliccato";
            }
            if (sender is Label)
                (sender as Label).BackColor = Color.Red;
        }
    }
}
