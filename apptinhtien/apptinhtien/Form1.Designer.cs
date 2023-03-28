namespace apptinhtien
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
            this.ttName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckCR = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckTT = new System.Windows.Forms.CheckBox();
            this.ckCCR = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ttName
            // 
            this.ttName.Location = new System.Drawing.Point(262, 76);
            this.ttName.Name = "ttName";
            this.ttName.Size = new System.Drawing.Size(192, 27);
            this.ttName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "payment";
            // 
            // ckCR
            // 
            this.ckCR.AutoSize = true;
            this.ckCR.Location = new System.Drawing.Point(123, 128);
            this.ckCR.Name = "ckCR";
            this.ckCR.Size = new System.Drawing.Size(89, 24);
            this.ckCR.TabIndex = 2;
            this.ckCR.Text = "cao rang";
            this.ckCR.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "thoat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "100";
            // 
            // ckTT
            // 
            this.ckTT.AutoSize = true;
            this.ckTT.Location = new System.Drawing.Point(123, 158);
            this.ckTT.Name = "ckTT";
            this.ckTT.Size = new System.Drawing.Size(88, 24);
            this.ckTT.TabIndex = 7;
            this.ckTT.Text = "tay râng\'";
            this.ckTT.UseVisualStyleBackColor = true;
            this.ckTT.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ckCCR
            // 
            this.ckCCR.AutoSize = true;
            this.ckCCR.Location = new System.Drawing.Point(123, 188);
            this.ckCCR.Name = "ckCCR";
            this.ckCCR.Size = new System.Drawing.Size(132, 24);
            this.ckCCR.TabIndex = 8;
            this.ckCCR.Text = "chup chan rang";
            this.ckCCR.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(298, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "1200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "80000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "tram rang";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "tinh tien";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTien
            // 
            this.txtTien.Enabled = false;
            this.txtTien.Location = new System.Drawing.Point(353, 324);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(192, 27);
            this.txtTien.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "80/1c";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ckCCR);
            this.Controls.Add(this.ckTT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ckCR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ttName);
            this.Name = "Form1";
            this.Text = "cao rang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ttName;
        private Label label1;
        private CheckBox ckCR;
        private Button button1;
        private Label label2;
        private Label label3;
        private CheckBox ckTT;
        private CheckBox ckCCR;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private TextBox txtTien;
        private Label label7;
        private Label label8;
    }
}