namespace ITI.Smart.UI.EF2.CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookCityRelation1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Books", newName: "Book");
            CreateTable(
                "dbo.Cover",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cover");
            RenameTable(name: "dbo.Book", newName: "Books");
        }
    }
}
