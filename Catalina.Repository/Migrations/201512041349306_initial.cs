namespace Catalina.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookingNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OSIs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OSICode = c.String(),
                        Remarks = c.String(),
                        Booking_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.Booking_Id)
                .Index(t => t.Booking_Id);
            
            CreateTable(
                "dbo.Segments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        From = c.String(),
                        To = c.String(),
                        DepartureDate = c.DateTime(nullable: false),
                        ArrivalDate = c.DateTime(nullable: false),
                        AdultCount = c.Int(nullable: false),
                        ChildCount = c.Int(nullable: false),
                        InfantCount = c.Int(nullable: false),
                        Booking_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.Booking_Id)
                .Index(t => t.Booking_Id);
            
            CreateTable(
                "dbo.SSRs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SSRCode = c.String(),
                        Remarks = c.String(),
                        Booking_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.Booking_Id)
                .Index(t => t.Booking_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SSRs", "Booking_Id", "dbo.Bookings");
            DropForeignKey("dbo.Segments", "Booking_Id", "dbo.Bookings");
            DropForeignKey("dbo.OSIs", "Booking_Id", "dbo.Bookings");
            DropIndex("dbo.SSRs", new[] { "Booking_Id" });
            DropIndex("dbo.Segments", new[] { "Booking_Id" });
            DropIndex("dbo.OSIs", new[] { "Booking_Id" });
            DropTable("dbo.SSRs");
            DropTable("dbo.Segments");
            DropTable("dbo.OSIs");
            DropTable("dbo.Bookings");
        }
    }
}
