using _3_layers.BLL;
using _3_layers.DTO;
using _3_layers.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3_LAYERS.view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCBB();
        }
       
            public void SetCBB()
            {
                QLSV_BLL bll = new QLSV_BLL();
            comboBox1.Items.AddRange(bll.GetCBBItems().ToArray());

            }
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
     
                int ID_Lop = Convert.ToInt32(((CBBItem)comboBox1.SelectedItem).Value);
                QLSV_BLL bll = new QLSV_BLL();
               dataGridView1.DataSource = bll.GetSVByIDLop(ID_Lop);


            
      }
    }
}
