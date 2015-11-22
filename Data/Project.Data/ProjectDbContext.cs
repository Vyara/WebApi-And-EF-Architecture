namespace Project.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class ProjectDbContext : IdentityDbContext<User>
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
