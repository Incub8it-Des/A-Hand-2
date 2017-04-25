namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateApplicationUserIDLinkToAskTask : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AskTasks", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.AskTasks", "UserId");
            AddForeignKey("dbo.AskTasks", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AskTasks", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AskTasks", new[] { "UserId" });
            DropColumn("dbo.AskTasks", "UserId");
        }
    }
}
