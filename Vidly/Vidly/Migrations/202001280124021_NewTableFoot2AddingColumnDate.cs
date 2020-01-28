namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableFoot2AddingColumnDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feet", "CreationDate", c => c.DateTime(nullable: false, defaultValueSql: "GetDate()"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Feet", "CreationDate");
        }
    }
}
