using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.Text = Form1.UserName;
            textBox4.Text = Form1.FullName;
            textBox5.Text = Form1.Email;
            textBox1.Text = Form1.Position;

            groupBox1.Text = Form1.UserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\slave\\OneDrive\\Documents\\Login_Users.accdb";
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            oleDbConnection.Open();

            OleDbCommand command = new OleDbCommand("UPDATE [Users] SET [UserName] = '" + textBox3.Text + "', [FullName]='" + textBox4.Text+"', [Email]='"+textBox5.Text+"', [Position]='"+textBox1.Text+"' WHERE [UserName]= '"+ textBox3.Text + "'", oleDbConnection);
            
            command.ExecuteNonQuery();

            MessageBox.Show("Successfully updated user");
            groupBox1.Text = textBox3.Text;

            if (dataGridView1.Visible)
            {
                GetEmployees();
            }

            oleDbConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\slave\\OneDrive\\Documents\\Login_Users.accdb";
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            oleDbConnection.Open();

            OleDbCommand command = new OleDbCommand("DELETE FROM [Users] WHERE [UserName]= '"+ textBox3.Text + "'", oleDbConnection);

            command.ExecuteNonQuery();

            MessageBox.Show("User successfully deleted");

            if (dataGridView1.Visible)
            {
                GetEmployees();
            }

            oleDbConnection.Close();
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            this.Size = new Size(526, 450);
            this.MaximumSize = new Size(526, 450);
            this.MinimumSize = new Size(526, 450);

            GetEmployees();
        }

        public void GetEmployees()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\slave\\OneDrive\\Documents\\Login_Users.accdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();

            OleDbCommand command = new OleDbCommand("SELECT * FROM [Users]", dbConnection);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var index = dataGridView1.Rows.Add();

                dataGridView1.Rows[index].Cells[0].Value = reader.GetString(reader.GetOrdinal("UserName"));
                dataGridView1.Rows[index].Cells[1].Value = reader.GetString(reader.GetOrdinal("FullName"));
                dataGridView1.Rows[index].Cells[2].Value = reader.GetString(reader.GetOrdinal("Email"));
                dataGridView1.Rows[index].Cells[3].Value = reader.GetString(reader.GetOrdinal("Position"));
            }

            dbConnection.Close();
        }
    }
}
