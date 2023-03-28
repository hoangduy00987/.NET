using System.Collections.Generic;
using System.Data;

namespace bai_giua_ky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetAlgv(object sender)
        {
         
            string query = "Select TENGV From SV";
            List<string> LopSH = new List<string>();
            DataTable dt = DbHelper.Instance.gettable(query);
            foreach (DataRow dr in dt.Rows)
            {
                LopSH.Add(dr["TENGV"].ToString());
            }
            cbbgvcn.Items.Add("All");
            cbbgvcn.Items.AddRange(LopSH.ToArray());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT DATN.MADOAN, DATN.TENDOAN, DATN.TENSV,GVHD.HuongNC,GVHD.TENGV, DATN.TINHTRANG, DATN.NAMBAOVE FROM DATN" +
                " INNER JOIN GVHD ON DATN.MAGV = GVHD.MAGV";
            DbHelper.Instance.ExcuteDB(query);
            dataGridView1.DataSource = DbHelper.Instance.gettable(query);
            cbbhnc.Items.Add("ALL");
            cbbhnc.Items.AddRange(GetHNC().ToArray());
            cbbtt.Items.Add("da bao ve");
            cbbtt.Items.Add("chua bao ve");
            cbbtt.Items.AddRange(GetTT().ToArray());
            cbbgvcn.Items.Add("ALL");
            cbbgvcn.Items.AddRange(GetGVHD().ToArray());
        }
        public List<string> GetTT()
        {
            List<string> list = new List<string>();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["TinhTrang"].Value != null)
                {
                    string tt = item.Cells["TinhTrang"].Value.ToString();
                    list.Add(tt);
                }
            }
            return list.Distinct().ToList();
        }
        public List<string> GetHNC()
        {
            List<string> list = new List<string>();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["HuongNC"].Value != null)
                {
                    string hnc = item.Cells["HuongNC"].Value.ToString();
                    list.Add(hnc);
                }
            }
            return list.Distinct().ToList();
        }
        public List<string> GetGVHD()
        {
            List<string> list = new List<string>();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["TENGV"].Value != null)
                {
                    string nbv = item.Cells["TENGV"].Value.ToString();
                    list.Add(nbv);
                }
            }
            return list.Distinct().ToList();
        }
        public void ShowSV()
        {
            string query = "SELECT DATN.MADOAN, DATN.TENDOAN, DATN.TENSV,GVHD.HuongNC,GVHD.TENGV, DATN.TINHTRANG, DATN.NAMBAOVE FROM DATN" +
                " INNER JOIN GVHD ON DATN.MAGV = GVHD.MAGV";
            DbHelper.Instance.ExcuteDB(query);
            dataGridView1.DataSource = DbHelper.Instance.gettable(query);
        }
        public void addTT(object sender)
        {
            QL ds = (QL)sender;
            string query = "INSERT INTO DATN(MADOAN,TENDOAN,TENSV,TENGV,HuonhNC,TINHTRANG,NAMBAOVE)" +
           "VALUES('" + ds.MADOAN 
           +"','" + ds.TenDeTai 
           + "','" + ds.SVThucHien 
           + "',"  + Convert.ToInt16(ds.TinhTrang)
           + ",'" + ds.NamBaoVe.Year+"-"+ds.NamBaoVe.Month+"-"+ds.NamBaoVe.Day+"')";   
            DbHelper.Instance.ExcuteDB(query);
            ShowSV();
        }
       
        private void add_Click(object sender, EventArgs e)
        { 
            Form2 f2 = new Form2();
            f2.infor += new Form2.del(ddTT);
            f2.infor += new Form2.del(aGetAlgv);
            f2.Show();

        }

        private void del(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                string id = item.Cells["MADOAN"].Value.ToString();
                string query = "DELETE FROM DATN WHERE MADOAN = '" + id + "'";
                DbHelper.Instance.ExcuteDB(query);
            }
            ShowSV();
        }
        public void edittt(object sender)
        {
           QL sv = (QL)sender;
            string query = " UPDATE DATN SET TENDOAN = '" + sv.TenDeTai + "',TENSV = '" + sv.SVThucHien + "', HuongNC = '" + sv.HuongNC + "', TENGV = '" + sv.GV + "', TINHTRANG = " + Convert.ToInt16(sv.TinhTrang) + ", NAMBAOVE = '" + sv.NamBaoVe.Year+"-"+sv.NamBaoVe.Month+"-"+sv.NamBaoVe.Day+"'" +
            "WHERE MADOAN = '" + sv.MADOAN + "'";
            DbHelper.Instance.ExcuteDB(query);
            ShowSV();
        }

        private void edit(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.infor += new Form2.del(edittt);
            f2.tbmda.ReadOnly = true;
            int index = dataGridView1.CurrentRow.Index;
            f2.tbmda.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();

            f2.Show();
        }
    }
}