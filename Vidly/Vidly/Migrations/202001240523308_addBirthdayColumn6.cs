namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBirthdayColumn6 : DbMigration
    {
        public override void Up()
        {
            Sql("update Customers set Birthday='1991-08-03' where id='1'");
        }
        
        public override void Down()
        {
        }
    }
}
