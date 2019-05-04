namespace ITI.Smart.UI.EF2.CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserVisitsTableFix : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UserVisit", name: "UserId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.UserVisit", name: "CityId", newName: "UserId");
            RenameColumn(table: "dbo.UserVisit", name: "__mig_tmp__0", newName: "CityId");
            RenameIndex(table: "dbo.UserVisit", name: "IX_UserId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.UserVisit", name: "IX_CityId", newName: "IX_UserId");
            RenameIndex(table: "dbo.UserVisit", name: "__mig_tmp__0", newName: "IX_CityId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UserVisit", name: "IX_CityId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.UserVisit", name: "IX_UserId", newName: "IX_CityId");
            RenameIndex(table: "dbo.UserVisit", name: "__mig_tmp__0", newName: "IX_UserId");
            RenameColumn(table: "dbo.UserVisit", name: "CityId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.UserVisit", name: "UserId", newName: "CityId");
            RenameColumn(table: "dbo.UserVisit", name: "__mig_tmp__0", newName: "UserId");
        }
    }
}
