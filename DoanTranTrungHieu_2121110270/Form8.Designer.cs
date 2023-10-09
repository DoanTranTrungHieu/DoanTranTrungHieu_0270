namespace DoanTranTrungHieu_2121110270
{
    partial class Form8
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
            components = new System.ComponentModel.Container();
            tmCount = new System.Windows.Forms.Timer(components);
            lbMin = new Label();
            btStart = new Button();
            btStop = new Button();
            lbSec = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tmCount
            // 
            tmCount.Tick += tmCount_Tick;
            // 
            // lbMin
            // 
            lbMin.AutoSize = true;
            lbMin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbMin.Location = new Point(200, 95);
            lbMin.Name = "lbMin";
            lbMin.Size = new Size(84, 65);
            lbMin.TabIndex = 0;
            lbMin.Text = "00";
            lbMin.Click += lblDisplay_Click;
            // 
            // btStart
            // 
            btStart.Location = new Point(200, 256);
            btStart.Name = "btStart";
            btStart.Size = new Size(75, 23);
            btStart.TabIndex = 1;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // btStop
            // 
            btStop.Location = new Point(331, 256);
            btStop.Name = "btStop";
            btStop.Size = new Size(75, 23);
            btStop.TabIndex = 2;
            btStop.Text = "Stop";
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // lbSec
            // 
            lbSec.AutoSize = true;
            lbSec.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbSec.Location = new Point(322, 95);
            lbSec.Name = "lbSec";
            lbSec.Size = new Size(84, 65);
            lbSec.TabIndex = 3;
            lbSec.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(290, 117);
            label1.Name = "label1";
            label1.Size = new Size(16, 25);
            label1.TabIndex = 4;
            label1.Text = ":";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lbSec);
            Controls.Add(btStop);
            Controls.Add(btStart);
            Controls.Add(lbMin);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmCount;
        private Label lbMin;
        private Button btStart;
        private Button btStop;
        private Label lbSec;
        private Label label1;
    }
}