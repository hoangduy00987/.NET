using System.Data;
using System.Windows.Forms;

namespace bando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            view();
        }
        public void  view()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên Món", typeof(string));
            dt.Columns.Add("Số Lượng", typeof(string));
            dataGridView1.DataSource = dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBNull.Value;
        }
    }
}