namespace A_Hand_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedVillages : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT [dbo].[Villages] ON");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (1,N'Alverstone')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (2,N'Arreton')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (3,N'Bembridge')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (4,N'Binstead')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (5,N'Blackgang')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (6,N'Blackwater')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (7,N'Bonchurch')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (8,N'Brighstone')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (9,N'Brook')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (10,N'Calbourne')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (11,N'Carisbrooke')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (12,N'Chale')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (13,N'Chillerton')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (14,N'Cranmore')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (15,N'Fishbourne')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (16,N'Freshwater')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (17,N'Gatcombe')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (18,N'Godshill')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (19,N'Gurnard')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (20,N'Havenstreet')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (21,N'Lake')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (22,N'Luccombe')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (23,N'Merstone')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (24,N'Nettlestone')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (25,N'Newbridge')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (26,N'Newchurch')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (27,N'Newtown')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (28,N'Ningwood')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (29,N'Niton')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (30,N'Northwood')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (31,N'Porchfield')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (32,N'Rookley')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (33,N'Seaview')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (34,N'Shalfleet')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (35,N'Shorwell')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (36,N'St Helens')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (37,N'St Lawrence')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (38,N'Totland')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (39,N'Whippingham')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (40,N'Whitwell')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (41,N'Winford')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (42,N'Wootton and Wootton Bridge')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (43,N'Wroxall')");
            Sql("INSERT INTO [dbo].[Villages] ([Id], [VillageName]) VALUES (44,N'Yaverland')");
            Sql("SET IDENTITY_INSERT [dbo].[Villages] OFF");

        }

        public override void Down()
        {
        }
    }
}
