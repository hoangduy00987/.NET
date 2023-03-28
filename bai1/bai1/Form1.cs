using System.Data;

namespace bai1
{
    public partial class Form1 : Form
    {
        public DataTable DB { get; set; }   
        public Form1()
        {
            InitializeComponent();
        createDB();
        }
        public void createDB()
        {
            // tao columns cho DB
            DB= new DataTable();
            DB.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MMSV", typeof(string)),
                new DataColumn("Ho va Ten", typeof(string)),
                new DataColumn("Gioi Tinh", typeof(bool)),
                new DataColumn("Ngayn sinh", typeof(DateTime)),
                new DataColumn("Dia chi", typeof(string)),
                new DataColumn("Phone", typeof(string)),
                new DataColumn("Lop hoc phan", typeof(string)),

            });

            //tao row (tao 3 row)
            DB.Rows.Add(new object[] { 
            "10222210204","Hoang Khuong Duy",true,DateTime.Now,
            "Quang Binh","0889159648","21TCLC_DT3"
            });
            DB.Rows.Add(new object[] {
            "10222210204","Hoang Khuong Duy",true,DateTime.Now,
            "Quang Binh","0889159648","21TCLC_DT3"
            });
            DB.Rows.Add(new object[] {
            "10222210204","Hoang Khuong Duy",true,DateTime.Now,
            "Quang Binh","0889159648","21TCLC_DT3"
            });
        }
        
        
    }
}