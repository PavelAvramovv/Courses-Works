namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelAdress = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.TextBoxAdress = new System.Windows.Forms.RichTextBox();
            this.TextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxAge = new System.Windows.Forms.TextBox();
            this.LabelOccupation = new System.Windows.Forms.Label();
            this.textBoxOccupation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(151, 60);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 17);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Име";
            // 
            // LabelAdress
            // 
            this.LabelAdress.AutoSize = true;
            this.LabelAdress.Location = new System.Drawing.Point(151, 114);
            this.LabelAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAdress.Name = "LabelAdress";
            this.LabelAdress.Size = new System.Drawing.Size(48, 17);
            this.LabelAdress.TabIndex = 1;
            this.LabelAdress.Text = "Адрес";
            this.LabelAdress.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Location = new System.Drawing.Point(155, 407);
            this.LabelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(63, 17);
            this.LabelAge.TabIndex = 3;
            this.LabelAge.Text = "Възраст";
            this.LabelAge.Click += new System.EventHandler(this.LabelAge_Click);
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Location = new System.Drawing.Point(151, 452);
            this.LabelOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(77, 17);
            this.LabelOutput.TabIndex = 4;
            this.LabelOutput.Text = "Резултати";
            // 
            // TextBoxAdress
            // 
            this.TextBoxAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAdress.Location = new System.Drawing.Point(281, 114);
            this.TextBoxAdress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxAdress.Name = "TextBoxAdress";
            this.TextBoxAdress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextBoxAdress.Size = new System.Drawing.Size(665, 62);
            this.TextBoxAdress.TabIndex = 5;
            this.TextBoxAdress.Text = "";
            this.TextBoxAdress.TextChanged += new System.EventHandler(this.TextBoxAdress_TextChanged);
            // 
            // TextBoxOutput
            // 
            this.TextBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxOutput.CausesValidation = false;
            this.TextBoxOutput.Location = new System.Drawing.Point(153, 485);
            this.TextBoxOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxOutput.Name = "TextBoxOutput";
            this.TextBoxOutput.ReadOnly = true;
            this.TextBoxOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextBoxOutput.Size = new System.Drawing.Size(933, 233);
            this.TextBoxOutput.TabIndex = 6;
            this.TextBoxOutput.Text = "";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.Location = new System.Drawing.Point(1223, 54);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(100, 38);
            this.ButtonOK.TabIndex = 7;
            this.ButtonOK.Text = "ОК";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click_1);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHelp.CausesValidation = false;
            this.ButtonHelp.Location = new System.Drawing.Point(1223, 118);
            this.ButtonHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(100, 37);
            this.ButtonHelp.TabIndex = 8;
            this.ButtonHelp.Text = "Help";
            this.ButtonHelp.UseVisualStyleBackColor = true;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click_1);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxName.Location = new System.Drawing.Point(281, 54);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(753, 22);
            this.TextBoxName.TabIndex = 9;
            this.TextBoxName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // TextBoxAge
            // 
            this.TextBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAge.Location = new System.Drawing.Point(261, 399);
            this.TextBoxAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxAge.Name = "TextBoxAge";
            this.TextBoxAge.Size = new System.Drawing.Size(665, 22);
            this.TextBoxAge.TabIndex = 11;
            this.TextBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            this.TextBoxAge.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAge_KeyUp);
            this.TextBoxAge.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxAge_Validating);
            // 
            // LabelOccupation
            // 
            this.LabelOccupation.AutoSize = true;
            this.LabelOccupation.Location = new System.Drawing.Point(151, 261);
            this.LabelOccupation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOccupation.Name = "LabelOccupation";
            this.LabelOccupation.Size = new System.Drawing.Size(76, 17);
            this.LabelOccupation.TabIndex = 12;
            this.LabelOccupation.Text = "Професия";
            // 
            // textBoxOccupation
            // 
            this.textBoxOccupation.Location = new System.Drawing.Point(281, 274);
            this.textBoxOccupation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOccupation.Name = "textBoxOccupation";
            this.textBoxOccupation.Size = new System.Drawing.Size(645, 22);
            this.textBoxOccupation.TabIndex = 13;
            this.textBoxOccupation.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOccupation_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 780);
            this.Controls.Add(this.textBoxOccupation);
            this.Controls.Add(this.LabelOccupation);
            this.Controls.Add(this.TextBoxAge);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.TextBoxOutput);
            this.Controls.Add(this.TextBoxAdress);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.LabelAdress);
            this.Controls.Add(this.LabelName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelAdress;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.RichTextBox TextBoxAdress;
        private System.Windows.Forms.RichTextBox TextBoxOutput;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxAge;
        private System.Windows.Forms.Label LabelOccupation;
        private System.Windows.Forms.TextBox textBoxOccupation;
    }
}

