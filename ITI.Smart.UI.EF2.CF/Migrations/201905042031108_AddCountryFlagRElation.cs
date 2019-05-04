namespace ITI.Smart.UI.EF2.CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCountryFlagRElation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flag",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Country", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Flag", "Id", "dbo.Country");
            DropIndex("dbo.Flag", new[] { "Id" });
            DropTable("dbo.Flag");
        }
    }
}
