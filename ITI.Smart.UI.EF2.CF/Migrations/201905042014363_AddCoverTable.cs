namespace ITI.Smart.UI.EF2.CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoverTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cover", "Code", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cover", "Code", c => c.String());
        }
    }
}
