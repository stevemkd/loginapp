using System.Reflection;

namespace loginpage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "steve" && passwd.Text == "123a")
            {
                new Form2().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("the invalid details");
                username.Clear();
                passwd.Clear();
                username.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

            button1.BackColor = Color.FromArgb(0, 117, 214);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.Cursor = Cursors.Hand;
        }
    }
}