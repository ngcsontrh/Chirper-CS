using Chirper_CS.Models;

namespace Chirper_CS.Seeders
{
    public class UserSeeder : ISeederBase<User>
    {
        public List<User> Generate()
        {
            var users = new List<User>();
            for(int i = -50; i < 0; i++)
            {
                users.Add(new User()
                {
                    UserId = i,
                    Email = $"user{i}@gmail.com",
                    FullName = $"User {i}"
                });
            }
            return users;
        }
    }
}
