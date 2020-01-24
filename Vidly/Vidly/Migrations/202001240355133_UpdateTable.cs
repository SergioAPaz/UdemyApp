namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MemberShipTypes SET Name='Al305' WHERE ID='4'");
        }

        public override void Down()
        {
        }
    }
}
