namespace Project.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using Contracts;

    public class ProjectDbContext : IdentityDbContext<User>, IProjectDbContext
    {
        public ProjectDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ProjectDbContext Create()
        {
            return new ProjectDbContext();
        }
    }
}
