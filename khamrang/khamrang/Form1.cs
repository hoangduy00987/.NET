namespace khamrang
{
    public partial class Dental : Form
    {
        public Dental()
        {
            InitializeComponent();
            tram_rang.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public double tinhtien()
        {
            double s = 0;
            if (cao_voi.Checked)
                s += 100000;
            if (tay_rang.Checked)
                s += 1200000;
            if (chup_hinh.Checked)
                s += 200000;
            int r = Convert.ToInt32(tram_rang.SelectedItem.ToString());
            s += r * 80000;

            return s;
          
           
        }
        private void button2_Click(object sender, EventArgs e)

        {
            if (textBox1.Text != "")
            {
                hien_tien.Text = tinhtien().ToString();
            }else
            {
                MessageBox.Show("nhap ten di");
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}