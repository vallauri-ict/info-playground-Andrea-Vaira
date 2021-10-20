using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica_Vaira
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

        public RichTextBox txt;

        public struct buttonStruct
        {
            public bool isNumber;
            public bool isSign;

            public buttonStruct(bool isNumber, bool isSign)
            {
                this.isNumber = isNumber;
                this.isSign = isSign;
            }
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
                    ordinaPulsanti(groupBox1);
                    break;
                case "Btn4":
                    createNumber();
                    break;
                case "Btn5":
                    removeNumber();
                    break;
                case "Btn6":
                    createRichTextBox();
                    createNumber();
                    break;
                case "Btn7":
                    cratteTextBox();
                    break;
                case "BtnFAC":
                    clearAll();
                    break;
            }

        }

        private void clearAll()
        {
            GroupBox grp = groupBox1;
            this.Controls.Clear();
            this.Controls.Add(grp);
        }

        private void cratteTextBox()
        {
            string[] text = new string[] { "Formato", "Numero", "Numero formattato" };
            for (int i = 0; i < 3; i++)
            {
                Label lbl = new Label();
                lbl.Text = text[i];
                lbl.Width = 100;
                lbl.Height = 30;
                lbl.Top = 100+(i*lbl.Height);
                lbl.Left = 350;

                this.Controls.Add(lbl);

                TextBox txt = new TextBox();
                txt.Width = 100;
                txt.Height = 30;
                txt.Top = 100 + (i * lbl.Height);
                txt.Left = 350+lbl.Width;
                txt.Name = text[i];
                if (i == 2)
                    txt.ReadOnly = true;
                if(i==1)
                    txt.TextChanged += Txt_TextChanged;

                this.Controls.Add(txt);

            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txtRis = (TextBox)this.Controls["Numero formattato"];
            TextBox txtFormato = (TextBox)this.Controls["Formato"];
            TextBox txtNum = (TextBox)sender;
            double number = Convert.ToDouble(txtNum.Text);
            txtRis.Text = number.ToString(txtFormato.Text).TrimEnd('0');
        }

        private void createRichTextBox()
        {
            if (txt == null)
            {
                txt = new RichTextBox();

                txt.Top = 0;
                txt.Left = 0;
                txt.Width = 180;
                txt.Height = 50;

                txt.RightToLeft = RightToLeft.Yes;

                //txt.TextChanged += Txt_TextChanged;

                this.Controls.Add(txt);
            }
        }

        /*private void Txt_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        private void removeNumber()
        {
            for (int i = 0; i < 12; i++)
            {
                Button btn;

                if(i<10)
                    btn = (Button)this.Controls[i.ToString()];
                else if(i==10)
                    btn = (Button)this.Controls["+"];
                else
                    btn = (Button)this.Controls["#"];
                this.Controls.Remove(btn);
            }
        }

        private void createNumber()
        {
            int buttonWidth = 60;
            int buttonHeight = 60;
            char[] num = new char[] { '7', '8', '9', '4', '5', '6', '1', '2', '3', '+', '0','#'};
            int k=0; //per scorrere num
            buttonStruct button = new buttonStruct();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();

                    btn.Width = buttonWidth;
                    btn.Height = buttonHeight;

                    btn.Top = 50 + (i * buttonHeight);
                    btn.Left = j * buttonWidth;

                    btn.Name = num[k].ToString();
                    btn.Text = num[k].ToString();
                    if (num[k] == '+' || num[k] == '#')
                    {
                        button.isSign = true;
                        button.isNumber = false;
                    }
                    else
                    {
                        button.isSign = false;
                        button.isNumber = true;
                    }
                    btn.Tag = button;

                    k++;

                    btn.Click += Number_Click;

                    this.Controls.Add(btn);
                }
            }
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            buttonStruct button = (buttonStruct)btn.Tag;
            string text;
            if(txt.Text=="")
            {
                if(button.isNumber==true || btn.Text == "+")
                {
                    text = txt.Text + btn.Text.ToString();
                    txt.Text = text;
                }
                    //txt.Text = txt.Text + btn.Text.ToString();
            }
            if (txt.Text != "")
            {
                string str = txt.Text.ToString();
                if (str.IndexOf("#") == -1)
                {
                    if (button.isNumber == true || btn.Text == "#")
                        txt.Text = txt.Text + btn.Text.ToString();
                }
                
            }
        }

        private void ordinaPulsanti(GroupBox groupBox1)
        {
            //int[,] pos = new int[2,6];
            Random rnd = new Random();

            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Button btn;
                    int pos;
                    if (j == 0)
                        pos = k;
                    else
                        pos = (k + 3);
                    if (pos < 5)
                    {
                        btn = (Button)groupBox1.Controls["Btn" + (pos + 3).ToString()];
                    }
                    else
                    {
                        btn = (Button)groupBox1.Controls["BtnFAC"];
                    }

                    if (j == 0)
                        btn.Top = rnd.Next(0, ((groupBox1.Height) / 2 - btn.Height));
                    else
                        btn.Top = rnd.Next((groupBox1.Height) / 2, ((groupBox1.Height) - btn.Height));

                    if (k == 0)
                        btn.Left = rnd.Next(0, ((groupBox1.Width) / 3 - btn.Width));
                    else if(k==1)
                        btn.Left = rnd.Next((groupBox1.Width) / 3, (((groupBox1.Width) / 3)*2 - btn.Width));
                    else
                        btn.Left = rnd.Next(((groupBox1.Width) / 3) * 2, (groupBox1.Width) - btn.Width);
                }
            }
        }
    }
}
