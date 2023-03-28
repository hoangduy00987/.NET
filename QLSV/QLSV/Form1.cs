using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;

namespace QLSV
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
        
            foreach( DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["LopSH"].Value != null)
                {
                    string classname = item.Cells["LopSH"].Value.ToString();
                    list.Add(classname);
                }
            }
            return list.Distinct().ToList();
        }
       private void bt_add(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.infor += new Form2.del(AddSV);
            f2.Show();
        }
        public void AddSV(object sender)
        {
            SV sv = (SV)sender;
            string query = "INSERT INTO SV(MSSV,TENSV,LopSH,CCCD,ANH,HOCBA,GIOITINH,DTB,IDlOP)" +
               "VALUES('" + sv.MSSV + ",N" + sv.NameSV + "','" + sv.LopSH + "," + Convert.ToInt16(sv.Gender)
               + "," + sv.DTB + "," + sv.ngaysinh.Year + "-" + sv.ngaysinh.Month + "-" + sv.ngaysinh.Day + "," + Convert.ToInt16(sv.CCCD) + "," + Convert.ToInt16(sv.Anh) + "," + Convert.ToInt16(sv.hocba) + ")";
            DbHelper.Instance.ExcuteDB(query);
            ShowSV();
        }
        private void Search(object sender, EventArgs e)
        {
           
      
        }

        private void bt_edit(object sender, EventArgs e)
        {

        }

        private void bt_delete(object sender, EventArgs e)
        {

        }

        private void btsort(object sender, EventArgs e)
        {

        }

        
        public void ShowSV()
        {
         
        }
        
    }
}