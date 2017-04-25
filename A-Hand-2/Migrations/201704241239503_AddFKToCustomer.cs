namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKToCustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AskTasks", "CustomerId", "dbo.Customers");
            DropIndex("dbo.AskTasks", new[] { "CustomerId" });
            DropPrimaryKey("dbo.Customers");
            AddColumn("dbo.AskTasks", "Customer_UserId", c => c.String(maxLength: 128));
            AddColumn("dbo.Customers", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Customers", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Customers", "UserId");
            CreateIndex("dbo.AskTasks", "Customer_UserId");
            CreateIndex("dbo.Customers", "UserId");
            AddForeignKey("dbo.Customers", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AskTasks", "Customer_UserId", "dbo.Customers", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AskTasks", "Customer_UserId", "dbo.Customers");
            DropForeignKey("dbo.Customers", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Customers", new[] { "UserId" });
            DropIndex("dbo.AskTasks", new[] { "Customer_UserId" });
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Customers", "UserId");
            DropColumn("dbo.AskTasks", "Customer_UserId");
            AddPrimaryKey("dbo.Customers", "Id");
            CreateIndex("dbo.AskTasks", "CustomerId");
            AddForeignKey("dbo.AskTasks", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
