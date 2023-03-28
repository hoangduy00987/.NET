using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_tap_7
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            SetCBB();
        }

        public void SetCBB()
        {
            sqlDataContext db = new sqlDataContext();
            cbb1.Items.Add(new CBBItems
            {
                value = 0,
                Text = "ALL"
            });

            foreach (LSH i in db.LSHes)
            {
                cbb1.Items.Add(new CBBItems
                {

                    value = i.ID_LOP,
                    Text = i.NameLop
                });

            }
        }

        private void Search_Click(object sender, EventArgs e)
        {


            sqlDataContext db = new sqlDataContext();

            if (cbb1.SelectedItem == null)
            {
                MessageBox.Show("Chọn lớp để tìm");
            }
            else
            {
                int ID_LOP = ((CBBItems)cbb1.SelectedItem).value;
                var l3 = db.SVs.Where(p => p.ID_LOP == ID_LOP || cbb1.SelectedIndex == 0)
                .Select(p => new{ p.MSSV,p.TENSV,p.NGAYSINH,p.GENDER,
                 p.ANH,  p.CCCD, p.HOSO, p.LSH.NameLop,p.LSH.ID_LOP
                  }); 
                   

                dataGridView1.DataSource = l3;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlDataContext db = new sqlDataContext();
            var l1 = db.SVs.Select(p => new {p.MSSV,   p.TENSV, p.NGAYSINH,
            p.GENDER, p.ANH,p.CCCD,p.HOSO,p.LSH.NameLop,p.LSH.ID_LOP });
               
            
            dataGridView1.DataSource = l1;
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.Show();
           
        }
        public string getMS()
        {
            string MSSV = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            return MSSV;
            
        }
        public void ResetData()
        {
           sqlDataContext db = new sqlDataContext();
            var query = from p in db.SVs
                        select new { p.MSSV, p.TENSV, p.NGAYSINH, p.GENDER,p.ANH,p.CCCD, p.DTB, p.LSH.NameLop,p.LSH.ID_LOP };
            dataGridView1.DataSource = query;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Form2 f2 = new Form2(this);
                f2.tbmssv.ReadOnly = true;
                f2.tbmssv.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Chọn 1 dòng để Edit thôi bro");
            }

        }

        private void del_Click(object sender, EventArgs e)
        {
            sqlDataContext db = new sqlDataContext();
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                string MSSV = item.Cells[0].Value.ToString();
                var query = db.SVs.Where(p => p.MSSV == MSSV).FirstOrDefault();
                db.SVs.DeleteOnSubmit(query);
                db.SubmitChanges();
            }
            dataGridView1.DataSource = db.SVs.ToList();
        }

        private void sỏt_Click(object sender, EventArgs e)
        {
            sqlDataContext db = new sqlDataContext();
            var query = from p in db.SVs
                        orderby p.DTB ascending
                        select p;
            dataGridView1.DataSource = query;
        }
    }
}

