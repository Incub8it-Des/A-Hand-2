namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectCustomerAndAskTaskModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AskTasks", "TaskTypeId", "dbo.TaskTypes");
            DropForeignKey("dbo.Customers", "AskTaskId", "dbo.AskTasks");
            DropIndex("dbo.Customers", new[] { "AskTaskId" });
            DropIndex("dbo.AskTasks", new[] { "TaskTypeId" });
            DropColumn("dbo.Customers", "AskTaskId");
            DropTable("dbo.AskTasks");
            DropTable("dbo.TaskTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TaskTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TaskDesc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AskTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BasicDescription = c.String(),
                        FurtherDetail = c.String(),
                        MaxValue = c.Double(nullable: false),
                        TaskStartDate = c.DateTime(nullable: false),
                        TaskTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "AskTaskId", c => c.Int(nullable: false));
            CreateIndex("dbo.AskTasks", "TaskTypeId");
            CreateIndex("dbo.Customers", "AskTaskId");
            AddForeignKey("dbo.Customers", "AskTaskId", "dbo.AskTasks", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AskTasks", "TaskTypeId", "dbo.TaskTypes", "Id", cascadeDelete: true);
        }
    }
}
