namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePostcodeFromIdentity : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Postcode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Postcode", c => c.String());
        }
    }
}
