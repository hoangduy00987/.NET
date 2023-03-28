using System.Data;
using System.Windows.Forms;

namespace order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            view();
        }
        public void view()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Món ăn", typeof(string));
            dt.Columns.Add("Số lượng", typeof(string));
         dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}