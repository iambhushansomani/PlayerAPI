USE [master]
GO
/****** Object:  Database [PlayerDB]    Script Date: 11-06-2021 08:52:59 ******/
CREATE DATABASE [PlayerDB]
 GO
USE [PlayerDB]
GO
/****** Object:  Table [dbo].[CountryMaster]    Script Date: 11-06-2021 08:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CountryMaster](
	[countryId] [int] NOT NULL,
	[country] [varchar](15) NULL,
 CONSTRAINT [PK_CountryMaster] PRIMARY KEY CLUSTERED 
(
	[countryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlayerMaster]    Script Date: 11-06-2021 08:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayerMaster](
	[playerId] [int] IDENTITY(1,1) NOT NULL,
	[playerName] [varchar](35) NOT NULL,
	[playerCountry] [int] NOT NULL,
	[playerType] [int] NOT NULL,
	[playerHeight] [decimal](3, 2) NOT NULL,
	[playerBMI] [int] NOT NULL,
	[playerRuns] [int] NOT NULL,
	[playerWickets] [int] NOT NULL,
	[playerStumpings] [int] NOT NULL,
 CONSTRAINT [PK_PlayerMaster] PRIMARY KEY CLUSTERED 
(
	[playerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlayerTypeMaster]    Script Date: 11-06-2021 08:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayerTypeMaster](
	[playerTypeId] [int] NOT NULL,
	[type] [varchar](15) NOT NULL,
 CONSTRAINT [PK_PlayerTypeMaster] PRIMARY KEY CLUSTERED 
(
	[playerTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CountryMaster] ([countryId], [country]) VALUES (1, N'India')
GO
INSERT [dbo].[CountryMaster] ([countryId], [country]) VALUES (2, N'Australia')
GO
SET IDENTITY_INSERT [dbo].[PlayerMaster] ON 
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (1, N'Rishabh Pant', 1, 1, CAST(6.00 AS Decimal(3, 2)), 23, 10000, 20, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (2, N'Rahul Dravid', 1, 1, CAST(5.70 AS Decimal(3, 2)), 21, 12500, 89, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (3, N'Jasprit Bumrah', 1, 2, CAST(5.70 AS Decimal(3, 2)), 21, 300, 260, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (4, N'Anil Kumble', 1, 2, CAST(6.00 AS Decimal(3, 2)), 21, 800, 500, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (5, N'Harbhajan Singh', 1, 2, CAST(6.00 AS Decimal(3, 2)), 21, 1800, 405, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (6, N'Manish Pande', 1, 1, CAST(5.80 AS Decimal(3, 2)), 21, 4600, 0, 87)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (7, N'Ravindra Jadeja', 1, 1, CAST(5.80 AS Decimal(3, 2)), 21, 4900, 0, 89)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (8, N'Virat Kohali', 1, 1, CAST(6.00 AS Decimal(3, 2)), 23, 13500, 24, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (9, N'Sachin Tendulkar', 1, 1, CAST(5.70 AS Decimal(3, 2)), 21, 14000, 92, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (10, N'Agit Agarkar', 1, 2, CAST(5.70 AS Decimal(3, 2)), 21, 300, 260, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (11, N'Zaheer Khan', 1, 2, CAST(6.00 AS Decimal(3, 2)), 21, 800, 290, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (12, N'Laxmipati Balaji', 1, 2, CAST(6.00 AS Decimal(3, 2)), 21, 2150, 330, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (13, N'K L Rahul', 1, 1, CAST(5.80 AS Decimal(3, 2)), 21, 8790, 0, 34)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (14, N'Nayan Mongia', 1, 3, CAST(5.80 AS Decimal(3, 2)), 21, 4900, 0, 102)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (15, N'Mahendra Singh Dhoni', 1, 3, CAST(5.90 AS Decimal(3, 2)), 22, 6500, 1, 270)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (16, N'Saourav Ganguly', 1, 1, CAST(6.00 AS Decimal(3, 2)), 23, 9750, 49, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (17, N'Virender Sehwag', 1, 1, CAST(5.70 AS Decimal(3, 2)), 21, 9800, 89, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (18, N'Rmesh Powar', 1, 2, CAST(5.70 AS Decimal(3, 2)), 21, 300, 60, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (19, N'Sunil Joshi', 1, 2, CAST(6.00 AS Decimal(3, 2)), 21, 800, 140, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (20, N'VVS Laxman', 1, 1, CAST(6.00 AS Decimal(3, 2)), 21, 13000, 0, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (21, N'M Manish', 1, 1, CAST(5.80 AS Decimal(3, 2)), 21, 4600, 0, 187)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (22, N' RJ Krishna', 1, 1, CAST(5.80 AS Decimal(3, 2)), 21, 4900, 0, 102)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (23, N'Sadgopan Ramesh', 1, 1, CAST(6.00 AS Decimal(3, 2)), 23, 11000, 34, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (24, N'Robin Uttapa', 1, 1, CAST(5.70 AS Decimal(3, 2)), 21, 9000, 89, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (25, N'Shane Wrne', 1, 2, CAST(5.70 AS Decimal(3, 2)), 21, 300, 200, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (26, N'P Krishna', 1, 2, CAST(6.00 AS Decimal(3, 2)), 21, 800, 201, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (27, N'K Balaji', 1, 2, CAST(6.00 AS Decimal(3, 2)), 21, 1800, 400, 0)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (28, N'Denial Mishra', 1, 1, CAST(5.80 AS Decimal(3, 2)), 21, 7600, 0, 187)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (29, N'Rakesh K', 1, 3, CAST(5.80 AS Decimal(3, 2)), 21, 5100, 0, 123)
GO
INSERT [dbo].[PlayerMaster] ([playerId], [playerName], [playerCountry], [playerType], [playerHeight], [playerBMI], [playerRuns], [playerWickets], [playerStumpings]) VALUES (30, N'Swarup Jadhav', 1, 3, CAST(5.90 AS Decimal(3, 2)), 22, 6500, 1, 78)
GO
SET IDENTITY_INSERT [dbo].[PlayerMaster] OFF
GO
INSERT [dbo].[PlayerTypeMaster] ([playerTypeId], [type]) VALUES (1, N'Batsman')
GO
INSERT [dbo].[PlayerTypeMaster] ([playerTypeId], [type]) VALUES (2, N'Bowler')
GO
INSERT [dbo].[PlayerTypeMaster] ([playerTypeId], [type]) VALUES (3, N'WicketKeeper')
GO
ALTER TABLE [dbo].[PlayerMaster]  WITH CHECK ADD FOREIGN KEY([playerType])
REFERENCES [dbo].[PlayerTypeMaster] ([playerTypeId])
GO
ALTER TABLE [dbo].[PlayerMaster]  WITH CHECK ADD FOREIGN KEY([playerCountry])
REFERENCES [dbo].[CountryMaster] ([countryId])
GO
USE [master]
GO
ALTER DATABASE [PlayerDB] SET  READ_WRITE 
GO
