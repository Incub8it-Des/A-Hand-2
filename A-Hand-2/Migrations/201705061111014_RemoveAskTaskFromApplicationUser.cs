namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveAskTaskFromApplicationUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "AskTask_Id", "dbo.AskTasks");
            DropForeignKey("dbo.AskTasks", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AskTasks", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AskTasks", new[] { "UserId" });
            DropIndex("dbo.AskTasks", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "AskTask_Id" });
            DropColumn("dbo.AskTasks", "UserId");
            DropColumn("dbo.AskTasks", "ApplicationUser_Id");
            DropColumn("dbo.AspNetUsers", "AskTask_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "AskTask_Id", c => c.Int());
            AddColumn("dbo.AskTasks", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AskTasks", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.AspNetUsers", "AskTask_Id");
            CreateIndex("dbo.AskTasks", "ApplicationUser_Id");
            CreateIndex("dbo.AskTasks", "UserId");
            AddForeignKey("dbo.AskTasks", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AskTasks", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUsers", "AskTask_Id", "dbo.AskTasks", "Id");
        }
    }
}
