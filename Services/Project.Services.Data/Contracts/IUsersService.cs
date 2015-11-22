namespace Project.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Linq;
    using Project.Data.Models;

    public interface IUsersService
    {
        IQueryable<User> ByUsername(string username);

        string UserIdByUsername(string username);
    }
}
