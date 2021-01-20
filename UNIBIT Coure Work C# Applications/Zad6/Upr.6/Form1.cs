using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBald_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = this.richTextBox1.SelectionFont;

            if ( oldFont.Bold)
            {
                newFont =
                    new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            }
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus();
        }

        private void buttonUnder_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = this.richTextBox1.SelectionFont;

            if (oldFont.Underline)
            {
                newFont =
                    new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            }
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus();
        }

        private void buttonItalic_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = this.richTextBox1.SelectionFont;

            if (oldFont.Italic)
            {
                newFont =
                    new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            }
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus();
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.SelectionAlignment == HorizontalAlignment.Center)
            {
                this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                this.richTextBox1.Focus();
            }
        }

        private void ApplyTextSize (string TextSize)
        {
            float newSize = Convert.ToSingle(TextSize);
            FontFamily currentFontFamily;
            Font newFont;

            currentFontFamily = this.richTextBox1.SelectionFont.FontFamily;
            newFont = new Font(currentFontFamily, newSize);
            this.richTextBox1.SelectionFont = newFont;
        }

        private void textBoxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int MinSize = 8;
            if ((e.KeyChar < 48 || e.KeyChar > 57) &&
                e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
                else if (e.KeyChar == 13)
                    {
                        TextBox txt = (TextBox)sender;
                        if (Convert.ToInt16(txt.Text) < MinSize)
                        {
                            txt.Text = Convert.ToString(MinSize);
                        }
                ApplyTextSize(txt.Text);
                e.Handled = true;
                this.richTextBox1.Focus();
                    }
            
        }

        private void RichTextBoxText_LinkClicked (object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile(MyFile);
                MessageBox.Show("Файлът" + MyFile + "Е успешно зареден");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Файлът не е намерен" + MyFile);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SaveFile(MyFile);
                MessageBox.Show("Файлът" + MyFile + "e успешно запазен.");
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
