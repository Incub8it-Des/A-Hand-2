namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeTaskStartDateNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AskTasks", "TaskStartDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AskTasks", "TaskStartDate", c => c.DateTime(nullable: false));
        }
    }
}
