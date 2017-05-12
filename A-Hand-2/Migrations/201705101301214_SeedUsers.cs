namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'839ed9cc-c7c3-4c00-9db1-b5dafc56e097', N'admin@ahand2.help', 0, N'ACrailk5VEaFfmH3Aec+0l7wLrwgn3qLDXXEmlD9cKW0D4cZdgAfjVZL58oQvzV4jQ==', N'ef0835a4-7550-4134-9317-7a09de8bdef6', NULL, 0, 0, NULL, 1, 0, N'admin@ahand2.help')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7e9ef402-1b47-42b2-a743-dac90362d89d', N'CanManageRequests')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'839ed9cc-c7c3-4c00-9db1-b5dafc56e097', N'7e9ef402-1b47-42b2-a743-dac90362d89d')

");
        }
        
        public override void Down()
        {
        }
    }
}
