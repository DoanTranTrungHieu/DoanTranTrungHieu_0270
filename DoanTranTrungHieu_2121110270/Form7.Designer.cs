namespace DoanTranTrungHieu_2121110270
{
    partial class Form7
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbId = new TextBox();
            tbName = new TextBox();
            tbAge = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btAddNew = new Button();
            button2 = new Button();
            button3 = new Button();
            ckGender = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 294);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 331);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 364);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Tuổi";
            // 
            // tbId
            // 
            tbId.Location = new Point(97, 286);
            tbId.Name = "tbId";
            tbId.Size = new Size(156, 23);
            tbId.TabIndex = 3;
            tbId.TextChanged += textBox1_TextChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(97, 323);
            tbName.Name = "tbName";
            tbName.Size = new Size(336, 23);
            tbName.TabIndex = 4;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(97, 356);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(156, 23);
            tbAge.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(39, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(674, 235);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Mã nhân viên";
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "Tên nhân viên";
            Column2.Name = "Column2";
            Column2.Width = 180;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Age";
            Column3.HeaderText = "Tuổi";
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giới tính (Nam)";
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(408, 399);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(84, 23);
            btAddNew.TabIndex = 7;
            btAddNew.Text = "Thêm";
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(519, 399);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 8;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(667, 432);
            button3.Name = "button3";
            button3.Size = new Size(84, 23);
            button3.TabIndex = 9;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Location = new Point(97, 402);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(52, 19);
            ckGender.TabIndex = 10;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(638, 399);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Sửa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 467);
            Controls.Add(button1);
            Controls.Add(ckGender);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btAddNew);
            Controls.Add(dataGridView1);
            Controls.Add(tbAge);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbId;
        private TextBox tbName;
        private TextBox tbAge;
        private DataGridView dataGridView1;
        private Button btAddNew;
        private Button button2;
        private Button button3;
        private CheckBox ckGender;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
    }
}