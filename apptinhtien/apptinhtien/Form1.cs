namespace apptinhtien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex= 0; 
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ttName.Text == "")
            {
                MessageBox.Show("nhap ten di cu");
            }else
            {
                txtTien.Text= TT().ToString();
            }
            
            txtTien.Text = TT().ToString();
          }
        private double TT()
        {
            double s = 0;
            if (ckCR.Checked)
                s += 100;
            if (ckTT.Checked )
                s += 1200;
            if (ckCCR.Checked)
                s += 800;
            string select = comboBox1.SelectedItem.ToString();
            int r = Convert.ToInt32(select);
            s += r * 80;
            return s;
        }
    }
}