namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificationsToCustomerModel4 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "MemberShipType_Id" });
            AddColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Customers", "MembershipType_Id");
            DropColumn("dbo.Customers", "IsSuscribedToNewsLetter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "IsSuscribedToNewsLetter", c => c.Boolean(nullable: false));
            DropIndex("dbo.Customers", new[] { "MembershipType_Id" });
            DropColumn("dbo.Customers", "IsSubscribedToNewsletter");
            CreateIndex("dbo.Customers", "MemberShipType_Id");
        }
    }
}
