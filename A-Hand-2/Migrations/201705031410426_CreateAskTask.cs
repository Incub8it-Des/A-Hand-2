namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAskTask : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AskTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BasicDescription = c.String(),
                        FurtherDetail = c.String(),
                        MaxValue = c.Double(),
                        TaskStartDate = c.DateTime(),
                        TaskTypeId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TaskTypes", t => t.TaskTypeId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.TaskTypeId)
                .Index(t => t.UserId)
                .Index(t => t.ApplicationUser_Id);
            
            AddColumn("dbo.AspNetUsers", "AskTask_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "AskTask_Id");
            AddForeignKey("dbo.AspNetUsers", "AskTask_Id", "dbo.AskTasks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AskTasks", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AskTasks", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "AskTask_Id", "dbo.AskTasks");
            DropForeignKey("dbo.AskTasks", "TaskTypeId", "dbo.TaskTypes");
            DropIndex("dbo.AspNetUsers", new[] { "AskTask_Id" });
            DropIndex("dbo.AskTasks", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.AskTasks", new[] { "UserId" });
            DropIndex("dbo.AskTasks", new[] { "TaskTypeId" });
            DropColumn("dbo.AspNetUsers", "AskTask_Id");
            DropTable("dbo.AskTasks");
        }
    }
}
