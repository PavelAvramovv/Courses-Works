using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ButtonOK.Enabled = false;

            this.TextBoxAdress.Tag = false;
            this.TextBoxAge.Tag = false;
            this.TextBoxName.Tag = false;
            this.textBoxOccupation.Tag = false;
            

            this.TextBoxName.Validating += new
                CancelEventHandler(textboxEmpty_Validating);
            this.TextBoxAdress.Validating += new
                CancelEventHandler(richTextboxEmpty_Validating);                
            this.textBoxOccupation.Validating += new
               CancelEventHandler(textBoxOccupation_Validating);

        }
        private void ValidateOK()
        {
            this.ButtonOK.Enabled =
                ((bool)(this.TextBoxAdress.Tag)
                && ((bool)this.TextBoxAge.Tag)
                && ((bool)this.TextBoxName.Tag)
                && ((bool)this.textBoxOccupation.Tag)
                );

        }

        private void textBox_TextChanged ( object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if ( tb.Text.Length == 0 )
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            else if ((tb.Text.Length != 0 && tb.Text.CompareTo("Програмист") != 0))
            {
                tb.Tag = false;
            }
            else
            {
                tb.Tag = true;
                tb.BackColor = SystemColors.Window;
            }
            ValidateOK();
        }

        private void TextBoxAge_Validating (object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb.Text.Length == 0)
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;

            }
            ValidateOK();
        }
        private void textBoxAge_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb.Text.Length > 0)
            {
                if(Int16.Parse(tb.Text.ToString()) < 18)
                {
                    tb.Tag = false;
                    tb.BackColor = Color.Red;
                }
                else
                {
                    tb.Tag = true;
                    tb.BackColor = SystemColors.Window;
                }
                ValidateOK();
            }
       
        }
        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (((tb.Text.Length == 0) && (e.KeyChar == 48)) || ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxOccupation_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.CompareTo("Програмист") == 0 || tb.Text.Length == 0)
            {
                tb.Tag = true;
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }

            ValidateOK();
        }

        private void textboxEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red; tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateOK();
        }
        private void richTextboxEmpty_Validating(object sender, CancelEventArgs e)
        {
            RichTextBox tb = (RichTextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red; tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateOK();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            string output;
            output = "Име : " + this.TextBoxName.Text + "\r\n";
            output += "Aдрес : " + this.TextBoxAdress.Text + "\r\n";
            output += "Професия : " + this.textBoxOccupation.Text + "\r\n";
            output += "Възраст : " + this.TextBoxAge.Text + "\r\n";

            this.TextBoxOutput.Text = output;
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            string output;
            output = "Помощна информация : \r\n\r\n";
            output += "Име : Вашето име" + "\r\n";
            output += "Aдрес : Вашия Адрес" + "\r\n";
            output += "Професия : Единствената допустима стойност е 'Програмист' " + "\r\n";
            output += "Възраст : Вашата възраст" + "\r\n";

            this.TextBoxOutput.Text = output;
        }

        private void LabelAge_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonOK_Click_1(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string adress = TextBoxAdress.Text;
            string age = TextBoxAge.Text;
           // string res = TextBoxOutput.Text;
            string profecion = textBoxOccupation.Text;
            TextBoxOutput.Text = "Име :"+name  +"\n"+"Aдрес : " + adress +"\n"+ "Професия : "+ profecion +"\n"+ "Възраст : "+ age;

        }

        private void ButtonHelp_Click_1(object sender, EventArgs e)
        {
           // string output;
            TextBoxOutput.Text = "Помощна информация : \r\n\r\n" + "Име : Вашето име" + "\r\n"+ "Aдрес : Вашия Адрес" + "\r\n"+ "Професия : Единствената допустима стойност е 'Програмист' " + "\r\n"+ "Възраст : Вашата възраст" + "\r\n";
         
       
        }
    }
}
