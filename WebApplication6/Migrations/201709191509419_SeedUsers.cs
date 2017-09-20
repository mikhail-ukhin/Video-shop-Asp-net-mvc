namespace WebApplication6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4eb96fc9-3343-48c4-a931-0b4848d1ac2b', N'm@mail.ru', 0, N'AFnC4mxcgOdxBcxHqYvWIpIWTl7cGOVcFTD5Y+0ExXTJAJcK9W8WMOOIaCY1/xQ10g==', N'81b57659-795b-490e-ab7f-4f1089449fa8', NULL, 0, 0, NULL, 1, 0, N'm@mail.ru')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd5ae2713-a08c-48d0-8a51-c39454161176', N'manager2@mail.ru', 0, N'AIi5F5FSWgrQkfMV/n/Xsrkcy9DVvHuLz0dC7zmi5N9dlQeoZOdiOQLtUOdlDI3iQw==', N'ed034375-f50b-41ea-9e89-95014bbe40be', NULL, 0, 0, NULL, 1, 0, N'manager2@mail.ru')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a98dc135-5d88-4b22-b606-1f3a02d2113a', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd5ae2713-a08c-48d0-8a51-c39454161176', N'a98dc135-5d88-4b22-b606-1f3a02d2113a')

");
        }

        public override void Down()
        {
        }
    }
}
