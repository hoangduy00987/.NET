using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_giua_ky
{
    public partial class Form2 : Form
    {
        public delegate void del(object o);
        public del infor { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            QL ds = new QL();
            ds.TenDeTai = tbtda.Text;
            ds.SVThucHien = tbsvth.Text;
            ds.HuongNC = cbbhnc.Text;
            ds.GV = cbbgvhd.Text;
            if (radiodbv.Checked)
            {
                ds.TinhTrang = true;
            }
            else if (radiocbv.Checked)
            {
                ds.TinhTrang = false;
            }
            ds.NamBaoVe = dateTimePicker1.Value;
            infor(ds);
            Dispose();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn hủy không?");
            if (dg == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
