using System.Data.OleDb;

namespace LoginForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = username.Text;
            string userPassword = password.Text;
            string userFullName = name.Text;
            string userMail = email.Text;
            string userPosition = position.Text;

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\slave\\OneDrive\\Documents\\Login_Users.accdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();

            OleDbCommand command = new OleDbCommand("INSERT INTO [Users] ([UserName], [FullName], [Password], [Email], [Position]) VALUES('"+userName+"', '"+userFullName+"', '"+userPassword+"', '"+userMail+"', '"+userPosition+"')", dbConnection);

            command.ExecuteNonQuery();

            MessageBox.Show("Successfully created new user");

            dbConnection.Close();

            this.Close();
        }
    }
}
