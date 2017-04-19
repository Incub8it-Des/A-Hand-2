namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReSeedTaskType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TaskTypes (TaskDesc) VALUES('Lifting Task')");
            Sql("INSERT INTO TaskTypes (TaskDesc) VALUES('Put together flat pack furniture')");
            Sql("INSERT INTO TaskTypes (TaskDesc) VALUES('Mow the grass')");
            Sql("INSERT INTO TaskTypes (TaskDesc) VALUES('Paint a wall')");
        }
        
        public override void Down()
        {
        }
    }
}
