namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemeberShipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberShipTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Customers", "MemberShipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MemberShipTypemodel_id", c => c.Int());
            CreateIndex("dbo.Customers", "MemberShipTypemodel_id");
            AddForeignKey("dbo.Customers", "MemberShipTypemodel_id", "dbo.MemberShipTypes", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipTypemodel_id", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipTypemodel_id" });
            DropColumn("dbo.Customers", "MemberShipTypemodel_id");
            DropColumn("dbo.Customers", "MemberShipTypeId");
            DropTable("dbo.MemberShipTypes");
        }
    }
}
