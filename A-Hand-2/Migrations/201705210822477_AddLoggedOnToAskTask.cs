namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLoggedOnToAskTask : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AskTasks", "LoggedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AskTasks", "LoggedOn");
        }
    }
}
