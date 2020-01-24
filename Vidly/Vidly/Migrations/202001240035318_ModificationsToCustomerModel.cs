namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificationsToCustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MemberShipTypemodelId", c => c.Byte(nullable: false));
            DropColumn("dbo.Customers", "MemberShipTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MemberShipTypeId", c => c.Byte(nullable: false));
            DropColumn("dbo.Customers", "MemberShipTypemodelId");
        }
    }
}
