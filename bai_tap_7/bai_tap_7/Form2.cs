using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace bai_tap_7
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            SetCBBLSH();
        }
        public void SetCBBLSH()
        {
            sqlDataContext db = new sqlDataContext();
            foreach (LSH item in db.LSHes)
            {
                cbblsh.Items.Add(new CBBItems
                {
                    value = item.ID_LOP,
                    Text = item.NameLop
                });
                Refresh();
            }
        }
                private void Cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void OK_Click(object sender, EventArgs e)
        {

            if (tbmssv.ReadOnly)
            {
                try
                {
                    sqlDataContext s = new sqlDataContext();
                    var l1 = s.SVs.Where(p => p.MSSV == form1.getMS()).FirstOrDefault();
                    l1.MSSV = tbmssv.Text;
                    l1.TENSV = tbname.Text;
                    l1.NGAYSINH = dateTimePicker1.Value;

                    l1.GENDER = checkGENDDER(radionam.Checked, radionu.Checked);
                    l1.ANH = cbanh.Checked;
                    l1.DTB =  Convert.ToSingle(tbdtb.Text);
                    l1.CCCD = cbcccd.Checked;
                    l1.HOSO = cbhb.Checked;
                    l1.ID_LOP = getLSH(cbblsh.SelectedItem.ToString());
                    s.SubmitChanges();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            form1.ResetData();
                this.Close();
            }
            else
            {
                try
                {
                    SV sv = new SV();
                    sv.MSSV = tbmssv.Text;
                    sv.TENSV = tbname.Text; ;
                    sv.NGAYSINH = dateTimePicker1.Value;
                    sv.GENDER = checkGENDDER(radionam.Checked, radionu.Checked);
                    sv.ANH = cbanh.Checked;
                    sv.DTB = Convert.ToSingle(tbdtb.Text);
                    sv.CCCD = cbcccd.Checked;
                    sv.HOSO = cbhb.Checked;
                    sv.ID_LOP = getLSH(cbblsh.SelectedItem.ToString());


                sqlDataContext db = new sqlDataContext();
                    db.SVs.InsertOnSubmit(sv);
                    db.SubmitChanges();

                }catch(Exception ex)
               {
                MessageBox.Show(ex.Message);
            }

            form1.ResetData();
                this.Close();
            }
        }
        public bool checkGENDDER(bool a1,bool a2)
        {
            bool check = true;
            if(a1==true)
            {
                check = true;
            }
            else if(a2 == false)
            {
                check = false;
                
            }
            return check;
        }
        public int getLSH(string text)
        {

            int id = 0;
            using (sqlDataContext a = new sqlDataContext())
            {
                var r = from p in a.LSHes
                        where p.NameLop == text
                        select p.ID_LOP;
                id = r.FirstOrDefault();

            }
            return id;
        }

    }
}

