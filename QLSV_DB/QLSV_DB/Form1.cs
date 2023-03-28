using System;
using System.Data;
using System.Data.SqlClient;

namespace QLSV_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SV";
            DbHelper.Instance.ExcuteDB(query);
            dataGridView1.DataSource = DbHelper.Instance.gettable(query);
            comboBox1.Items.Add("ALL");
            comboBox1.Items.AddRange(GetClasss().ToArray());
        }
        public List<string> GetClasss()
        {
            List<string> list = new List<string>();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["TENLOP"].Value != null)
                {
                    string classname = item.Cells["TENLOP"].Value.ToString();
                    list.Add(classname);
                }
            }
            return list.Distinct().ToList();
        }

        private void add(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.infor += new Form2.del(AddSV);
            f2.Show();
        }
        public void AddSV(object sender)
        {
            SV sv = (SV)sender;
            string query = "INSERT INTO SV(MSSV,TENLOP,TENSV,GIOITINH,DTB,NGAYSINH,ANH,HOCBA,CCCD)" +
                "VALUES('" + sv.MSSV + "','" + sv.LopSH + "',N'" + sv.NameSV + "'," + Convert.ToInt16(sv.Gender) + "," + sv.DTB +
                ",'" + sv.ngaysinh.Year + "-" + sv.ngaysinh.Month + "-" + sv.ngaysinh.Day + "',"
                + Convert.ToInt16(sv.Anh) + "," + Convert.ToInt16(sv.hocba) + "," + Convert.ToInt16(sv.CCCD) + ")";

            DbHelper.Instance.ExcuteDB(query);
            ShowSV();
        }
        public void ShowSV()
        {
            string query = "SELECT * FROM SV";
            DbHelper.Instance.ExcuteDB(query);
            dataGridView1.DataSource = DbHelper.Instance.gettable(query);
        }

        private void edit(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.infor += new Form2.del(editSV);
            f2.tbms.ReadOnly = true;
            int index = dataGridView1.CurrentRow.Index;
            f2.tbms.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();

            f2.Show();
        }
        public void editSV(object sender)
        {
            SV sv = (SV)sender;
            string query = " UPDATE SV SET TENSV = N'" + sv.NameSV + "',TENLOP = '" + sv.LopSH + "',GIOITINH = " + Convert.ToInt16(sv.Gender) +
                ",DTB = " + sv.DTB + ",NGAYSINH = '" + sv.ngaysinh.Year + "-" + sv.ngaysinh.Month + "-" + sv.ngaysinh.Day + "', ANH = " + Convert.ToInt16(sv.Anh) + ",HOCBA = " + Convert.ToInt16(sv.hocba) + ", CCCD = " + Convert.ToUInt16(sv.CCCD) +
                "WHERE MSSV = '" + sv.MSSV + "'";
            DbHelper.Instance.ExcuteDB(query);
            ShowSV();



        }

        private void delete(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                string id = item.Cells["MSSV"].Value.ToString();
                string query = "DELETE FROM SV WHERE MSSV = '" + id + "'";
                DbHelper.Instance.ExcuteDB(query);
            }
            ShowSV();
        }

        private void sort(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                     string query = " SELECT * FROM SV ORDER BY DTB ASC";
                dataGridView1.DataSource = DbHelper.Instance.gettable(query);
                
            }
        
    }
    }
}