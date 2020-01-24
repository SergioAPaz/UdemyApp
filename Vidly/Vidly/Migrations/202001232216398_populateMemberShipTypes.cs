namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShipTypes (SignUpFee,DurationInMonths,DiscountRate) values (0,0,0)");
            Sql("INSERT INTO MemberShipTypes (SignUpFee,DurationInMonths,DiscountRate) values (30,1,10)");
            Sql("INSERT INTO MemberShipTypes (SignUpFee,DurationInMonths,DiscountRate) values (90,3,15)");
            Sql("INSERT INTO MemberShipTypes (SignUpFee,DurationInMonths,DiscountRate) values (300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
