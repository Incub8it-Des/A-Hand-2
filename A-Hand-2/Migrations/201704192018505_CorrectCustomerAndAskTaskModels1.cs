namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectCustomerAndAskTaskModels1 : DbMigration
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
                        MaxValue = c.Double(nullable: false),
                        TaskStartDate = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        TaskTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.TaskTypes", t => t.TaskTypeId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.TaskTypeId);
            
            CreateTable(
                "dbo.TaskTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TaskDesc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AskTasks", "TaskTypeId", "dbo.TaskTypes");
            DropForeignKey("dbo.AskTasks", "CustomerId", "dbo.Customers");
            DropIndex("dbo.AskTasks", new[] { "TaskTypeId" });
            DropIndex("dbo.AskTasks", new[] { "CustomerId" });
            DropTable("dbo.TaskTypes");
            DropTable("dbo.AskTasks");
        }
    }
}
