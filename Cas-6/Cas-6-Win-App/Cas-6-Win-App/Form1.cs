namespace Cas_6_Win_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.PlaceholderText = "Enter your name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input1.Hide();
            textBox1.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "Bob Bobsky";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.ReadOnly = true;
            textBox3.BorderStyle = BorderStyle.Fixed3D;
            textBox3.ForeColor = Color.Yellow;
            textBox3.BackColor = Color.Green;
            textBox3.Width = 600;
        }
    }
}