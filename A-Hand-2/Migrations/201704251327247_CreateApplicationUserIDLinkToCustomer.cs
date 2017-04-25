namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateApplicationUserIDLinkToCustomer : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AskTasks", name: "Customer_UserId", newName: "Customer_ApplicationUserId");
            RenameColumn(table: "dbo.Customers", name: "UserId", newName: "ApplicationUserId");
            RenameIndex(table: "dbo.AskTasks", name: "IX_Customer_UserId", newName: "IX_Customer_ApplicationUserId");
            RenameIndex(table: "dbo.Customers", name: "IX_UserId", newName: "IX_ApplicationUserId");
            DropColumn("dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Id", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Customers", name: "IX_ApplicationUserId", newName: "IX_UserId");
            RenameIndex(table: "dbo.AskTasks", name: "IX_Customer_ApplicationUserId", newName: "IX_Customer_UserId");
            RenameColumn(table: "dbo.Customers", name: "ApplicationUserId", newName: "UserId");
            RenameColumn(table: "dbo.AskTasks", name: "Customer_ApplicationUserId", newName: "Customer_UserId");
        }
    }
}
