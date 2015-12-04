namespace Catalina.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class skywardsnumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "SkywardsNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bookings", "SkywardsNumber");
        }
    }
}
