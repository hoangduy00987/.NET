using System.Data;

namespace comm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createCl();
            createRow();
        }
        public void createCl()
        {
            ColumnHeader c1 = new ColumnHeader();
            c1.Text = "Mssv";
            ColumnHeader c2 = new ColumnHeader();
            c2.Text = "Name Sv";
            ColumnHeader c3 = new ColumnHeader();
            c3.Text = "Lop Sh";
            listView1.Columns.AddRange(new ColumnHeader[] { c1, c2, c3 });
        }
        public void createRow()
        {
            ListViewItem l1 = new ListViewItem();
            l1.Text = "102210204";
            ListViewItem.ListViewSubItem r1 = new ListViewItem.ListViewSubItem();
            r1.Text = "HKD";
            ListViewItem.ListViewSubItem r2 = new ListViewItem.ListViewSubItem();
            r2.Text = "21TCLC_DT3";
            l1.SubItems.AddRange(new ListViewItem.ListViewSubItem[]
            {r1,r2});
            listView1.Items.Add(l1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           ListView.SelectedListViewItemCollection r = listView1.SelectedItems;
            string re = "";
            foreach (ListViewItem i in r)
            {
                re += "MMSV=" + i.Text + "Name=" + i.SubItems[1].Text + "Ten=" + i.SubItems[2].Text;
            }
            MessageBox.Show(re);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void view()
        {
            SV[] a = new SV[] {
                new SV{MSSV = "102",Name = "Duy", Gender = true},
                new SV{MSSV = "103",Name = "Duy", Gender = true},
                new SV{MSSV = "104",Name = "Duy", Gender = true}
                };
            DataTable dt = new DataTable();
            dt.Columns.Add("MSSV", typeof(string));
            dt.Columns.Add("Ten", typeof(string));
            dt.Columns.Add("Gender", typeof(bool));
            dataGridView1.DataSource = dt;
        }
    }
}