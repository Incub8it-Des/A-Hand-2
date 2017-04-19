namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaskType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TaskDesc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AskTasks", "TaskTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.AskTasks", "TaskTypeId");
            AddForeignKey("dbo.AskTasks", "TaskTypeId", "dbo.TaskTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AskTasks", "TaskTypeId", "dbo.TaskTypes");
            DropIndex("dbo.AskTasks", new[] { "TaskTypeId" });
            DropColumn("dbo.AskTasks", "TaskTypeId");
            DropTable("dbo.TaskTypes");
        }
    }
}
