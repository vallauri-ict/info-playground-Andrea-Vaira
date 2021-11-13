using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Dictionary_Queue_Stack
{
    public partial class Form1 : Form
    {
        public string key;
        public string name;

        Dictionary<string, string> dict = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                key = txtKey.Text;
                name = txtName.Text;

                dict.Add(key, name);
            }
            catch (Exception)
            {

                MessageBox.Show("Inserire una chiave corretta");
            }
            

            txtKey.Text = "";
            txtName.Text = "";

            
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            int len = 0;
            foreach  (string key in dict.Keys)
            {
                len++;
            }
            lblLength.Text = len.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lblFindArticle.Text = dict[txtFind.Text];
        }

    }
}
