namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificationsToCustomerModel2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MemberShipTypes", "testColumn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberShipTypes", "testColumn", c => c.Byte(nullable: false));
        }
    }
}
