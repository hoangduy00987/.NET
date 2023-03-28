namespace nhapmk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
        }

        private void clear(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void ok(object sender, EventArgs e)
        {

        }
    }
}