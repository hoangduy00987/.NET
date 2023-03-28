namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            create_cl();
            create_r();        }
        public void create_cl()
        {
            ColumnHeader c1 = new ColumnHeader();
            c1.Text = "MSSV";
            ColumnHeader c2 = new ColumnHeader();
            c2.Text = "Ten";

            ColumnHeader c3 = new ColumnHeader();
            c3.Text = "lop";

            listView1.Columns.AddRange(new ColumnHeader[] { c1, c2, c3 });
        }
        public void create_r()
        {
            ListViewItem l1 = new ListViewItem();
            l1.Text = "1022102204";
            ListViewItem.ListViewSubItem sbl1 = new ListViewItem.ListViewSubItem();
           
            sbl1.Text = "hoang khuong duy";
            ListViewItem.ListViewSubItem sbl2 = new ListViewItem.ListViewSubItem();
            sbl2.Text = "21TCLC_DT3";
            l1.SubItems.AddRange(new ListViewItem.ListViewSubItem[] { sbl1, sbl2 });
            listView1.Items.Add(l1);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}