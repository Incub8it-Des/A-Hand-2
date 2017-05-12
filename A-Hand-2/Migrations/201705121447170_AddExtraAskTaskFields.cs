namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExtraAskTaskFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AskTasks", "TaskTown", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AskTasks", "TaskTown");
        }
    }
}
