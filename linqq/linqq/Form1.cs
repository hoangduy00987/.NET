using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataClasses1DataContext db = new DataClasses1DataContext();
            int ID_LOP = ((CBBItems)cbb1.SelectedItem).value;
            var l1 = from p in db.SVs
                     where p.ID_LOP == ID_LOP
                     select new { p.MSSV, p.TENSV, p.LSH.NameLop };
            dataGridView1.DataSource = l1;

        
        }
        public void SetCBB()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            cbb1.Items.Add(new CBBItems
            {
                value = 0,
                Text = "ALL"
            });
            foreach(LSH i in db.LSHes)
            {
                cbb1.Items.Add(new CBBItems
                {
                    value = i.ID_LOP,
                    Text = i.NameLop
                });
            }
        }
    }
}
