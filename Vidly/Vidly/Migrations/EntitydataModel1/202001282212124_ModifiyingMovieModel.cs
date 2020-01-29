namespace Vidly.Migrations.EntitydataModel1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiyingMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MembershipTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "MembershipTypeId");
            AddForeignKey("dbo.Movies", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Movies", new[] { "MembershipTypeId" });
            DropColumn("dbo.Movies", "MembershipTypeId");
        }
    }
}
