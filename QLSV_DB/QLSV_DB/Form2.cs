using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_DB
{
    public partial class Form2 : Form
    {
        public delegate void del(object o);
        public del infor { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void cancel(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn hủy không?");
            if (dg == DialogResult.OK)
            {
                Close();
            }
        }

        private void ok(object sender, EventArgs e)
        {
            SV sv = new SV();
         
                sv.NameSV = tbname.Text;
                sv.MSSV = tbms.Text;
                sv.LopSH = tblsh.Text;
                sv.ngaysinh = dateTimePicker1.Value;
                sv.DTB = Convert.ToDouble(tbdtb.Text);
                if (radio.Checked)
                {
                    sv.Gender = true;

                }
                else if (radiofm.Checked)
                {
                    sv.Gender = false;
                }
                sv.Anh = checkanh.Checked;
                sv.CCCD = checkcccd.Checked;
                sv.hocba = checkbhb.Checked;
                infor(sv);
                Dispose();
            }
            

        }
    }

