namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAskTaskName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AskTaskModels", newName: "AskTasks");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AskTasks", newName: "AskTaskModels");
        }
    }
}
