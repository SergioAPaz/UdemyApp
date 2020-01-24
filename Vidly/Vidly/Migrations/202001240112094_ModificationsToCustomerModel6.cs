namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificationsToCustomerModel6 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "MembershipType_Id" });
            CreateIndex("dbo.Customers", "MemberShipType_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "MemberShipType_Id" });
            CreateIndex("dbo.Customers", "MembershipType_Id");
        }
    }
}
