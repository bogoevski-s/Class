using Microsoft.Data.SqlClient;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-O7TOVAN;Initial Catalog=DemoAppDB; Integrated Security=True; TrustServerCertificate=True";
            SqlConnection dbConnection = new SqlConnection(connectionString);

            dbConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM [Persons] WHERE [PersonId]= ' " + 1 + " '", dbConnection);

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                textBox1.Text = read.GetString(read.GetOrdinal("FirstName"));
                textBox2.Text = read.GetString(read.GetOrdinal("LastName"));
            }

            dbConnection.Close();
        }
    }
}