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
    public partial class Form2 : Form
    {
        public Form2(string label)
        {
            InitializeComponent();
            this.lbl.Text = label;
        }

    }
}
