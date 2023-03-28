using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form2 : Form
    {
        public delegate void del(object o);
        public del infor { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Cancel(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn hủy không?");
            if(dg == DialogResult.OK)
            {
                Close();
            }

        }

        private void bt_OK(object sender, EventArgs e)
        {

        }
    }
}
