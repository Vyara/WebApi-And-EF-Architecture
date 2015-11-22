namespace Project.Web.Api
{
    using System.Data.Entity;
    using Project.Data;
    //using Project.Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            //TODO: Configure DB after Migration
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProjectDbContext, Configuration>());
            //ProjectDbContext.Create().Database.Initialize(true);
        }
    }
}