namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaskTownIdToAskTask : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AskTasks", "TaskTownId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AskTasks", "TaskTownId");
        }
    }
}
