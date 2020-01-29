namespace Vidly.Migrations.EntitydataModel1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiyingFKMovieGender : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Movies", new[] { "MembershipTypeId" });
            AddColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "GenreId");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            DropColumn("dbo.Movies", "Genre");
            DropColumn("dbo.Movies", "MembershipTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MembershipTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Genre", c => c.String());
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropColumn("dbo.Movies", "GenreId");
            CreateIndex("dbo.Movies", "MembershipTypeId");
            AddForeignKey("dbo.Movies", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
    }
}
