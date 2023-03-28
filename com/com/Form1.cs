namespace com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         string txt = textBox1.Text;
            if (txt != "")
            {

                if (listBox1.Items.IndexOf(txt) < 0)
                {
                    listBox1.Items.Add(txt);


                }
                else
                {
                    MessageBox.Show("trung roi cu oi");
                }
            }
            else
            {
                MessageBox.Show("nhap text đi cu");
            }
            if (txt != "")
            {

                if (comboBox1.Items.IndexOf(txt) < 0)
                {
                    comboBox1.Items.Add(txt);


                }
                else
                {
                    MessageBox.Show("trung roi cu oi");
                }
            }
            else
            {
                MessageBox.Show("nhap text đi cu");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(listBox1.SelectedIndex >=0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = comboBox1.SelectedIndex;
            textBox1.Text = idx.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton1.Checked.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void keypress(object sender, KeyPressEventArgs e)
        {
            label1.Text = "key pressed: " + e.KeyChar;
        }
    }
}