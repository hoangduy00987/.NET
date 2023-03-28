namespace bai_tap_7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.EDit = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1256, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbb1
            // 
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Location = new System.Drawing.Point(257, 42);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(145, 24);
            this.cbb1.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(136, 42);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 30);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(198, 330);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 29);
            this.ADD.TabIndex = 3;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // EDit
            // 
            this.EDit.Location = new System.Drawing.Point(336, 330);
            this.EDit.Name = "EDit";
            this.EDit.Size = new System.Drawing.Size(75, 29);
            this.EDit.TabIndex = 4;
            this.EDit.Text = "EDIT";
            this.EDit.UseVisualStyleBackColor = true;
            this.EDit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(459, 330);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 29);
            this.del.TabIndex = 5;
            this.del.Text = "DELETE";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "SORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sỏt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.del);
            this.Controls.Add(this.EDit);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.cbb1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button EDit;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button button1;
    }
}

