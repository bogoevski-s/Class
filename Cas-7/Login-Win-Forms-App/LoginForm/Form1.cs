using LoginForm.Models;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public string errorMessage = "User not found check your email or password";

        public Form1()
        {
            InitializeComponent();

            textBox1.PlaceholderText = "Username";
            textBox2.PlaceholderText = "Password";

            label2.Text = "Name";
            label3.Text = "Email";
            label4.Text = "Position";

            groupBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;

            User user = LocalDataBase.Users.SingleOrDefault(x => x.UserName == userName && x.Password == password);

            // primer za so foreach
            //User user1 = new User();
            //foreach (var userInDB in LocalDataBase.Users)
            //{
            //    if(userInDB.UserName == userName)
            //    {
            //        user1 = userInDB;
            //    };
            //}

            if (user == null)
            {
                //prikazi error
                groupBox1.Visible = false;
                label5.Visible = true;
                label5.Text = errorMessage;
                textBox1.ResetText();
                textBox2.ResetText();
            }
            else
            {
                label5.Visible = false;
                groupBox1.Visible = true;
                groupBox1.Text = user.UserName;

                textBox3.Text = user.Name;
                textBox4.Text = user.Email;
                textBox5.Text = user.Position;

                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;

                textBox1.ResetText();
                textBox2.ResetText();
            }

        }

    }
}