namespace ITI.Smart.UI.EF2.CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookCityRelation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Id", "dbo.City");
            DropIndex("dbo.Books", new[] { "Id" });
            DropTable("dbo.Books");
        }
    }
}
