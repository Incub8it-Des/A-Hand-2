namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedRelationBetweenCustomerAndAskTask : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AskTasks", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AskTasks", "CustomerId", c => c.Int(nullable: false));
        }
    }
}
