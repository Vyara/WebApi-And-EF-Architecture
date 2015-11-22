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

        //TODO add public vitual IDbSet properties

        public static ProjectDbContext Create()
        {
            return new ProjectDbContext();
        }
    }
}
