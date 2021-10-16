using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms02
{
    public partial class ModaleInfo : Form
    {
        public ModaleInfo()
        {
            InitializeComponent();
        }

        private void ModaleInfo_Load(object sender, EventArgs e)
        {
            Label label1 = new Label()
            {
                Text = "INFO SOFTWARE:\n Autore: Vaira Andrea\n Data di creazione: 02/10/2021",
                AutoSize=true,

                Location = new Point(10, 10),
                TabIndex = 10
            };
            Controls.Add(label1);
        }
    }
}
