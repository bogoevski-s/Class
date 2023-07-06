using LoginForm.Models;
using System.Data.OleDb;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public string errorMessage = "User not found check your email or password";

        public static string FullName { get; set; }
        public static string UserName { get; set; }
        public static string Email { get; set; }
        public static string Position { get; set; }

        public Form1()
        {
            InitializeComponent();

            textBox1.PlaceholderText = "Username";
            textBox2.PlaceholderText = "Password";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = false;

            string userName = textBox1.Text;
            string password = textBox2.Text;

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\slave\\OneDrive\\Documents\\Login_Users.accdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();

            OleDbCommand command = new OleDbCommand("SELECT * FROM [Users] WHERE Username ='" + userName + "' AND Password = '" + password + "'", dbConnection);

            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    UserName = reader.GetString(reader.GetOrdinal("UserName"));
                    FullName = reader.GetString(reader.GetOrdinal("FullName"));
                    Email = reader.GetString(reader.GetOrdinal("Email"));
                    Position = reader.GetString(reader.GetOrdinal("Position"));
                }
                textBox1.ResetText();
                textBox2.ResetText();

                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                label5.Visible = true;
                label5.Text = errorMessage;

                textBox1.ResetText();
                textBox2.ResetText();
            }

            dbConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}