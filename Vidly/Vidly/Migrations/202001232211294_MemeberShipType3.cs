namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemeberShipType3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "testColumn", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberShipTypes", "testColumn");
        }
    }
}
