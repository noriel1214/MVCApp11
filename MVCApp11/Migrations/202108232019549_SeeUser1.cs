namespace MVCApp11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeeUser1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bf06be85-8484-4730-89ee-c3b2c9cc0d63', N'admin1@vidly.com', 0, N'ABbZZ1r9g03mEpxVVQI6BxdLQX2C540ultU5JFpIyFZEasBdvaT+VPQGg/DwK94Hkw==', N'9bfcfefa-68de-439b-85c9-9accc9552040', NULL, 0, 0, NULL, 1, 0, N'admin1@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fdcaf05c-9d65-46e1-a7e6-3185379213fa', N'guest1@vidly.com', 0, N'AGlM5taYfdhk8quJRZLklvjezAKNShTXZMZfke3HoCDoECQ8dlpOw7BgPJ66DFjlIg==', N'2d8a6fe4-091a-4ed5-b672-28d10e7df576', NULL, 0, 0, NULL, 1, 0, N'guest1@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df696c9b-fa26-4f46-b2b1-ad753ea50361', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bf06be85-8484-4730-89ee-c3b2c9cc0d63', N'df696c9b-fa26-4f46-b2b1-ad753ea50361')
");
        }
        
        public override void Down()
        {
        }
    }
}
