using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vaira
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            makeButtons(groupBox1);
        }

        private void makeButtons(GroupBox groupBox1)
        {
            Random rnd = new Random();
            int widthButton = 50;
            int heightButton = 30;

            
            for (int i = 0; i < 6; i++)
            {
                Button btn = new Button();

                if (i < 5)
                {
                    btn.Name = "Btn" + (i + 3).ToString();
                    btn.Text = "Parte" + (i + 3).ToString();
                }

                else
                {
                    btn.Name = "BtnFAC";
                    btn.Text = "FAC";
                }


                btn.Left = rnd.Next(0, groupBox1.Width - widthButton);
                btn.Top = rnd.Next(0, groupBox1.Height - heightButton);
                int[] pos = new int[] { btn.Left, btn.Top };
                btn.Tag = pos;

                btn.Height = heightButton;
                btn.Width = widthButton;


                btn.Click += Btn_Click;

                groupBox1.Controls.Add(btn);
                //this.Controls.Add(btn);
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = (string)btn.Name;

            switch (btnName)
            {
                case "Btn3":
                    CloseForm();
                    break;
                case "Btn4":
                    OpenFileDialogFile();
                    break;
                case "Btn5":
                    saveFile();
                    break;
                case "Btn6":
                    WriteFile();
                    break;
                case "Btn7":
                    LeggereContenutoFile();
                    break;
                case "BtnFAC":
                    ReadModal();
                    break;
            }
        }

        private void ReadModal()
        {
            Form frm = new Form();
            RichTextBox rtb = new RichTextBox();
            frm.Controls.Add(rtb);
            StreamReader sr = new StreamReader("salvataggio.txt");
            string line = sr.ReadToEnd();
            rtb.Text = line;
            frm.Show();

        }

        private void LeggereContenutoFile()
        {
            StreamReader sr = new StreamReader("salvataggio.txt");
            string line = sr.ReadToEnd();
            MessageBox.Show(line);
        }

        private void WriteFile()
        {
            try
            {
                string content = "Andrea Vaira\n"+ DateTime.Now.ToString(); 
                File.WriteAllText("salvataggio.txt", content);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Problemi durante il salvataggio del file.",
                    "ATTENZIONE!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void saveFile()
        {




            DialogResult saveResponse = saveFileDialog1.ShowDialog();
            if (saveResponse == DialogResult.Cancel) return;
            else saveDocument(saveFileDialog1.FileName);
        }

        private void saveDocument(object fileName)
        {
            try
            {
                string content = "";
                File.WriteAllText(fileName.ToString(), content);

                MessageBox.Show(fileName.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Problemi durante il salvataggio del file.",
                    "ATTENZIONE!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void OpenFileDialogFile()
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                MessageBox.Show(filename);
            }
               
        }

        private void CloseForm()
        {
            DialogResult result = checkIfUserWantToClose();
            if (result == DialogResult.Yes)
                this.Close();
        }
        private DialogResult checkIfUserWantToClose()
        {
            return MessageBox.Show(
                    "Sei sicuro di voler uscire?",
                    "ATTENZIONE!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
        }
    }
}
