using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //Libreria da impementare

namespace RegEx01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //soluzione 1
            Regex rgx = new Regex(@"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$"); //metto @ perevitare di mettere tutte le volte // ma metto solo /
            string str = txtStr.Text;
            MessageBox.Show(str+"  "+rgx.IsMatch(str));

            //soluzione 2
            MessageBox.Show(str + "  " + Regex.IsMatch(str, @"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$"));
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            string str = "One car red car blue car";
            string pattern = @"(\w+)\s+(car)";
            int count = 0;

            Regex reg = new Regex(pattern);
            Match m = reg.Match(str);

            while (m.Success)
            {
                MessageBox.Show("Trovato: gruppo "+(++count)+" Valore: "+m.Value+
                                " alla posizione "+m.Index);
                m=m.NextMatch();
            }
        }
    }
}
