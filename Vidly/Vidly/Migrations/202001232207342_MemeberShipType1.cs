namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemeberShipType1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "MemberShipTypemodel_id" });
            CreateIndex("dbo.Customers", "MemberShipTypemodel_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "MemberShipTypemodel_Id" });
            CreateIndex("dbo.Customers", "MemberShipTypemodel_id");
        }
    }
}
