namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableFoot2AddingColumnDate2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Feet", newName: "Foods");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Foods", newName: "Feet");
        }
    }
}
