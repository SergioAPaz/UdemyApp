namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificationsToCustomerModel3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Customers", name: "MemberShipTypemodel_Id", newName: "MemberShipType_Id");
            RenameIndex(table: "dbo.Customers", name: "IX_MemberShipTypemodel_Id", newName: "IX_MemberShipType_Id");
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            DropColumn("dbo.Customers", "MemberShipTypemodelId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MemberShipTypemodelId", c => c.Byte(nullable: false));
            DropColumn("dbo.Customers", "MembershipTypeId");
            RenameIndex(table: "dbo.Customers", name: "IX_MemberShipType_Id", newName: "IX_MemberShipTypemodel_Id");
            RenameColumn(table: "dbo.Customers", name: "MemberShipType_Id", newName: "MemberShipTypemodel_Id");
        }
    }
}
