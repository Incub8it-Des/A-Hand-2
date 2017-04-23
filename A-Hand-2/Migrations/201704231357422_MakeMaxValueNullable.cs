namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeMaxValueNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AskTasks", "MaxValue", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AskTasks", "MaxValue", c => c.Double(nullable: false));
        }
    }
}
