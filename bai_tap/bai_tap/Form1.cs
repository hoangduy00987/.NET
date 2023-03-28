using System.Data;
using System.Data.SqlClient;

namespace bai_tap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Select * from SV" + textBox1.Text + "";
            dataGridView1.DataSource = DbHelper.Instance.GetTable(query);
            
           
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=DUY;Initial Catalog=SINHVIEN;Integrated Security=True");
            SqlParameter p1 = new SqlParameter(@"TENSV", textBox1.Text);
            string query = "select * from SV where TENSV = " + @"TENSV";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.Add(p1);
            SqlDataReader r;
            cnn.Open();
            r = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            while(r.Read())
            {
                dt.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn{ColumnName ="MSSV", DataType = typeof(string)},
                     new DataColumn{ColumnName ="TENSV", DataType = typeof(string)},

                });
                dt.Rows.Add(r["MSSV"], r["TENSV"]);
            }
            dataGridView1.DataSource = dt;
            cnn.Close();
        }
    }
}