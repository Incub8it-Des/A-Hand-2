namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAskTaskPage : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AskTasks", newName: "AskTaskModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AskTaskModels", newName: "AskTasks");
        }
    }
}
