namespace ITI.Smart.UI.EF2.CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserVisitsTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cities", newName: "City");
            RenameTable(name: "dbo.Countries", newName: "Country");
            RenameTable(name: "dbo.Users", newName: "User");
            CreateTable(
                "dbo.UserVisit",
                c => new
                    {
                        CityId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        when = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.CityId, t.UserId })
                .ForeignKey("dbo.City", t => t.UserId)
                .ForeignKey("dbo.User", t => t.CityId)
                .Index(t => t.CityId)
                .Index(t => t.UserId);
            
            AlterColumn("dbo.City", "Name", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Country", "Name", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.User", "Name", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserVisit", "CityId", "dbo.User");
            DropForeignKey("dbo.UserVisit", "UserId", "dbo.City");
            DropIndex("dbo.UserVisit", new[] { "UserId" });
            DropIndex("dbo.UserVisit", new[] { "CityId" });
            AlterColumn("dbo.User", "Name", c => c.String());
            AlterColumn("dbo.Country", "Name", c => c.String());
            AlterColumn("dbo.City", "Name", c => c.String());
            DropTable("dbo.UserVisit");
            RenameTable(name: "dbo.User", newName: "Users");
            RenameTable(name: "dbo.Country", newName: "Countries");
            RenameTable(name: "dbo.City", newName: "Cities");
        }
    }
}
