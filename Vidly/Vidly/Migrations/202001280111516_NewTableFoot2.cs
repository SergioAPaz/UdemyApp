namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableFoot2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Stock = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Feet");
        }
    }
}
