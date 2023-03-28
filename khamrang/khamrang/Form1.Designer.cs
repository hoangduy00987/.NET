namespace khamrang
{
    partial class Dental
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cao_voi = new System.Windows.Forms.CheckBox();
            this.tay_rang = new System.Windows.Forms.CheckBox();
            this.chup_hinh = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tram_rang = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tinh_tien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hien_tien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(197, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "DENTAL PAYMENT FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 27);
            this.textBox1.TabIndex = 2;
            // 
            // cao_voi
            // 
            this.cao_voi.AutoSize = true;
            this.cao_voi.Location = new System.Drawing.Point(142, 186);
            this.cao_voi.Name = "cao_voi";
            this.cao_voi.Size = new System.Drawing.Size(81, 24);
            this.cao_voi.TabIndex = 3;
            this.cao_voi.Text = "Cạo vôi";
            this.cao_voi.UseVisualStyleBackColor = true;
            // 
            // tay_rang
            // 
            this.tay_rang.AutoSize = true;
            this.tay_rang.Location = new System.Drawing.Point(142, 216);
            this.tay_rang.Name = "tay_rang";
            this.tay_rang.Size = new System.Drawing.Size(95, 24);
            this.tay_rang.TabIndex = 4;
            this.tay_rang.Text = "Tẩy Trắng";
            this.tay_rang.UseVisualStyleBackColor = true;
            // 
            // chup_hinh
            // 
            this.chup_hinh.AutoSize = true;
            this.chup_hinh.Location = new System.Drawing.Point(142, 246);
            this.chup_hinh.Name = "chup_hinh";
            this.chup_hinh.Size = new System.Drawing.Size(138, 24);
            this.chup_hinh.TabIndex = 5;
            this.chup_hinh.Text = "Chụp Hình Răng";
            this.chup_hinh.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trám Răng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tram_rang
            // 
            this.tram_rang.FormattingEnabled = true;
            this.tram_rang.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.tram_rang.Location = new System.Drawing.Point(253, 280);
            this.tram_rang.Name = "tram_rang";
            this.tram_rang.Size = new System.Drawing.Size(98, 28);
            this.tram_rang.TabIndex = 7;
            this.tram_rang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tinh_tien
            // 
            this.tinh_tien.Location = new System.Drawing.Point(501, 367);
            this.tinh_tien.Name = "tinh_tien";
            this.tinh_tien.Size = new System.Drawing.Size(94, 29);
            this.tinh_tien.TabIndex = 9;
            this.tinh_tien.Text = "Tính tiền";
            this.tinh_tien.UseVisualStyleBackColor = true;
            this.tinh_tien.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "$100.000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "$1200.000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "$200.000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "$80.000/cái";
            // 
            // hien_tien
            // 
            this.hien_tien.Location = new System.Drawing.Point(435, 321);
            this.hien_tien.Name = "hien_tien";
            this.hien_tien.Size = new System.Drawing.Size(160, 27);
            this.hien_tien.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total";
            // 
            // Dental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hien_tien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tinh_tien);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tram_rang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chup_hinh);
            this.Controls.Add(this.tay_rang);
            this.Controls.Add(this.cao_voi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dental";
            this.Text = "Dental Payment Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private CheckBox cao_voi;
        private CheckBox tay_rang;
        private CheckBox chup_hinh;
        private Label label3;
        private ComboBox tram_rang;
        private Button button1;
        private Button tinh_tien;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox hien_tien;
        private Label label8;
    }
}