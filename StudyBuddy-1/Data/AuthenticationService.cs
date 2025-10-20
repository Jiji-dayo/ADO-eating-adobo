using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyBuddy.Data
{
    public class AuthenticationService
    {
        private readonly List<User> users = new List<User>();

        public Task<bool> Login(string username, string password)
        {
            var user = users.Find(u => u.Username == username && u.Password == password);
            return Task.FromResult(user != null);
        }

        public Task<bool> Register(User newUser)
        {
            if (users.Exists(u => u.Username == newUser.Username))
            {
                return Task.FromResult(false); // User already exists
            }

            users.Add(newUser);
            return Task.FromResult(true);
        }
    }
}