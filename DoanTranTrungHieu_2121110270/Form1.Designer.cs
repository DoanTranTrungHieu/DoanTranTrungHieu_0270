namespace DoanTranTrungHieu_2121110270
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUserName = new TextBox();
            UserName = new Label();
            numericUpDown1 = new NumericUpDown();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(158, 55);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(252, 23);
            txtUserName.TabIndex = 0;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(75, 63);
            UserName.Name = "UserName";
            UserName.Size = new Size(39, 15);
            UserName.TabIndex = 3;
            UserName.Text = "Name";
            UserName.Click += label1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(493, 55);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(155, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(75, 107);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(232, 107);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(75, 150);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(335, 23);
            comboBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(75, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(335, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H" });
            listBox1.Location = new Point(75, 248);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(359, 380);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 11;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(516, 380);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 12;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(UserName);
            Controls.Add(txtUserName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Label UserName;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
    }
}