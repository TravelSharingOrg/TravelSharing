namespace TravelSharing.Data.Migrations
{
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<TravelSharing.Data.TravelSharingDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
 
        }
        //protected override void Seed(TravelSharing.Data.TravelSharingDbContext context)
        //{
       
        //}
    }
}
