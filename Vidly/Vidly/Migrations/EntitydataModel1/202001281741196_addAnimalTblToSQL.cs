namespace Vidly.Migrations.EntitydataModel1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAnimalTblToSQL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Animals");
        }
    }
}
