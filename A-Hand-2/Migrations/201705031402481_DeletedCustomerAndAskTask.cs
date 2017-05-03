namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedCustomerAndAskTask : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AskTasks", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Customers", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AskTasks", "Customer_ApplicationUserId", "dbo.Customers");
            DropForeignKey("dbo.AskTasks", "TaskTypeId", "dbo.TaskTypes");
            DropIndex("dbo.AskTasks", new[] { "TaskTypeId" });
            DropIndex("dbo.AskTasks", new[] { "UserId" });
            DropIndex("dbo.AskTasks", new[] { "Customer_ApplicationUserId" });
            DropIndex("dbo.Customers", new[] { "ApplicationUserId" });
            DropTable("dbo.AskTasks");
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ApplicationUserId = c.String(nullable: false, maxLength: 128),
                        DisplayName = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        Address3 = c.String(),
                        Address4 = c.String(),
                        Postcode = c.String(),
                    })
                .PrimaryKey(t => t.ApplicationUserId);
            
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
                        Customer_ApplicationUserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Customers", "ApplicationUserId");
            CreateIndex("dbo.AskTasks", "Customer_ApplicationUserId");
            CreateIndex("dbo.AskTasks", "UserId");
            CreateIndex("dbo.AskTasks", "TaskTypeId");
            AddForeignKey("dbo.AskTasks", "TaskTypeId", "dbo.TaskTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AskTasks", "Customer_ApplicationUserId", "dbo.Customers", "ApplicationUserId");
            AddForeignKey("dbo.Customers", "ApplicationUserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AskTasks", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
