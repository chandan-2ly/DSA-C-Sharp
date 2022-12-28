namespace Splitwise.UserDetails
{
    public class UserController
    {
        public List<User> Users { get; set; }
        public UserController()
        {
            Users = new List<User>();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public User GetUser(int id) => Users.Find(x => x.Id == id);

        public List<User> GetUsers() => Users;
    }
}
