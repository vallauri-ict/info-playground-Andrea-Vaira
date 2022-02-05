using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarioGregoriano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Data dt;
        DataOra dh;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreaData_Click(object sender, EventArgs e)
        {
            if(txtDay.Text == "" || txtMonth.Text == "" || txtYear.Text == "")
            {
                dt = new Data();
            }
            else
            {
                int day = Convert.ToInt32(txtDay.Text);
                int month = Convert.ToInt32(txtMonth.Text);
                int year = Convert.ToInt32(txtYear.Text);
                dt = new Data(day, month, year);
            }
        }

        private void btnCreaOra_Click(object sender, EventArgs e)
        {
            int year = dt.GetYear();
            int month = dt.GetMonth();
            int day = dt.GetDay();
            int hour = Convert.ToInt32(txtHour.Text);
            int minute = Convert.ToInt32(txtMinute.Text);
            int second = Convert.ToInt32(txtSecond.Text);
            dh = new DataOra(year, month, day, hour, minute, second);
        }

        private void btnIsBisestile_Click(object sender, EventArgs e)
        {
            if(dt.IsBisestile())
                MessageBox.Show("SI");
            else
                MessageBox.Show("NO");
        }

        private void btnToStringData_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dt.ToString());
        }

        private void btnIeri_Click(object sender, EventArgs e)
        {
            dt.Ieri();
        }

        private void btnDomani_Click(object sender, EventArgs e)
        {
            dt.Domani();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dt.Giorno());
        }

        private void btnDataOra_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dh.ToString());
        }

        private void BtnScriviData_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(txtDay.Text);
            int month = Convert.ToInt32(txtMonth.Text);
            int year = Convert.ToInt32(txtYear.Text);
            dt.Scrivi(year, month, day);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int hour = Convert.ToInt32(txtHour.Text);
            int minute = Convert.ToInt32(txtMinute.Text);
            int second = Convert.ToInt32(txtSecond.Text);
            dh.Scrivi(hour, minute, second);
        }
    }
}
