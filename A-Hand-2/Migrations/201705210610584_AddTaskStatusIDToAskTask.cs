namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaskStatusIDToAskTask : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AskTasks", "TaskStatusId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AskTasks", "TaskStatusId");
        }
    }
}
