namespace Project.Services.Data
{
    using System.Linq;
    using Contracts;
    using Project.Data.Contracts;
    using Project.Data.Models;


    public class UsersService : IUsersService
    {
        private readonly IRepository<User> users;

        public UsersService(IRepository<User> users)
        {
            this.users = users;
        }

        public IQueryable<User> ByUsername(string username)
        {
            return this.users
                .All()
                .Where(u => u.UserName == username);
        }

        public string UserIdByUsername(string username)
        {
            return this.users
                 .All()
                .Where(u => u.UserName == username)
                .Select(u => u.Id)
                .FirstOrDefault();
        }
    }
}
