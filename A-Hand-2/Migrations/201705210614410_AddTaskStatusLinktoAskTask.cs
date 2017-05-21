namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaskStatusLinktoAskTask : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.AskTasks", "TaskStatusId");
            AddForeignKey("dbo.AskTasks", "TaskStatusId", "dbo.TaskStatus", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AskTasks", "TaskStatusId", "dbo.TaskStatus");
            DropIndex("dbo.AskTasks", new[] { "TaskStatusId" });
        }
    }
}
