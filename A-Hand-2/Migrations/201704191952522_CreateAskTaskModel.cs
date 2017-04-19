namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAskTaskModel : DbMigration
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
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "AskTaskId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "AskTaskId");
            AddForeignKey("dbo.Customers", "AskTaskId", "dbo.AskTasks", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "AskTaskId", "dbo.AskTasks");
            DropIndex("dbo.Customers", new[] { "AskTaskId" });
            DropColumn("dbo.Customers", "AskTaskId");
            DropTable("dbo.AskTasks");
        }
    }
}
