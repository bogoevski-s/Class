using LoginForm.Models;

namespace LoginForm
{
    public static class LocalDataBase
    {
        public static List<User> Users = new List<User>
        {
            new User
            {
                UserName = "slave",
                Password = "123456",
                Name = "Slave Bogoevski",
                Email = "slave@yahoo.com",
                Position = "Developer"
            },
            new User
            {
                UserName = "bob",
                Password = "abcd",
                Name = "Bob Bobsky",
                Email = "bob@gmail.com",
                Position = "Tester"
            },
            new User
            {
                UserName = "john",
                Password = "a1234!",
                Name = "John Williams",
                Email = "john@gmail.com",
                Position = "Manager"
            }
        };
    }
}
