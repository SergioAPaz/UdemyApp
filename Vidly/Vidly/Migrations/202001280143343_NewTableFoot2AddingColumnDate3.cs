namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableFoot2AddingColumnDate3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "MembershipTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Foods", "MembershipTypeId");
            AddForeignKey("dbo.Foods", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Foods", new[] { "MembershipTypeId" });
            DropColumn("dbo.Foods", "MembershipTypeId");
        }
    }
}
