USE [master]
GO
/****** Object:  Database [GamesDB]    Script Date: 22/11/2020 17:03:39 ******/
CREATE DATABASE [GamesDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GamesDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GamesDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GamesDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GamesDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GamesDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GamesDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GamesDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GamesDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GamesDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GamesDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GamesDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [GamesDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GamesDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GamesDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GamesDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GamesDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GamesDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GamesDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GamesDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GamesDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GamesDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GamesDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GamesDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GamesDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GamesDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GamesDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GamesDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GamesDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GamesDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GamesDB] SET  MULTI_USER 
GO
ALTER DATABASE [GamesDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GamesDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GamesDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GamesDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GamesDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GamesDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GamesDB] SET QUERY_STORE = OFF
GO
USE [GamesDB]
GO
/****** Object:  Table [dbo].[Consolas]    Script Date: 22/11/2020 17:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consolas](
	[precio] [int] NOT NULL,
	[almacenamiento] [int] NOT NULL,
	[modelo] [varchar](50) NOT NULL,
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[lanzamiento] [int] NOT NULL,
 CONSTRAINT [PK_Consolas] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games]    Script Date: 22/11/2020 17:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games](
	[precio] [int] NOT NULL,
	[lanzamiento] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[formato] [varchar](50) NOT NULL,
	[plataforma] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Games] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Consolas] ON 

INSERT [dbo].[Consolas] ([precio], [almacenamiento], [modelo], [codigo], [lanzamiento]) VALUES (3000, 8, N'PS1', 1, 1994)
INSERT [dbo].[Consolas] ([precio], [almacenamiento], [modelo], [codigo], [lanzamiento]) VALUES (3000, 4, N'PS2', 2, 1994)
INSERT [dbo].[Consolas] ([precio], [almacenamiento], [modelo], [codigo], [lanzamiento]) VALUES (6000, 8, N'PS2', 3, 2000)
INSERT [dbo].[Consolas] ([precio], [almacenamiento], [modelo], [codigo], [lanzamiento]) VALUES (5700, 16, N'PS2', 4, 2003)
INSERT [dbo].[Consolas] ([precio], [almacenamiento], [modelo], [codigo], [lanzamiento]) VALUES (6200, 250, N'PS3', 5, 2006)
INSERT [dbo].[Consolas] ([precio], [almacenamiento], [modelo], [codigo], [lanzamiento]) VALUES (10500, 500, N'PS3', 6, 2006)
INSERT [dbo].[Consolas] ([precio], [almacenamiento], [modelo], [codigo], [lanzamiento]) VALUES (10000, 500, N'PS4', 7, 2013)
INSERT [dbo].[Consolas] ([precio], [almacenamiento], [modelo], [codigo], [lanzamiento]) VALUES (30000, 1024, N'PS4', 8, 2016)
INSERT [dbo].[Consolas] ([precio], [almacenamiento], [modelo], [codigo], [lanzamiento]) VALUES (30600, 1024, N'PS4', 9, 2016)
SET IDENTITY_INSERT [dbo].[Consolas] OFF
GO
SET IDENTITY_INSERT [dbo].[Games] ON 

INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (200, 1998, N'Metal Gread Solid', 1, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (150, 1997, N'Symphony of the Night', 2, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (100, 1996, N'Twisted Metal', 3, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (170, 1999, N'Legacy of Kain', 4, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (200, 1998, N'The Stealth Kain', 5, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (160, 1999, N'Syphon Filter', 6, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (150, 1997, N'Final Fantasy VII', 7, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (200, 1996, N'Crash Bandicoot', 8, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (120, 1997, N'Einhander', 9, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (150, 1995, N'Tom Raider', 10, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (250, 1998, N'Medievil', 11, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (110, 1997, N'Hercules', 12, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (190, 1999, N'Wipeout', 13, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (150, 1999, N'Parasite Eve', 14, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (140, 2000, N'Tekken 3', 15, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (130, 1999, N'Gran Turismo 2', 16, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (190, 2008, N'Dino Crisis', 17, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (170, 1997, N'Vagrant Story', 18, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (200, 1997, N'Driver', 19, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (110, 1997, N'Abe Oddysey', 20, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (105, 1999, N'FIFA 98', 21, N'Fisico', N'PS1')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (310, 2005, N'Shadow of Rome', 22, N'Fisico', N'PS2')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (300, 2005, N'Mortal Kombat: Shaolin Monks', 23, N'Fisico', N'PS2')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (300, 2006, N'Hitman: blood Money', 24, N'Fisico', N'PS2')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (400, 2006, N'Black', 25, N'Fisico', N'PS2')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (320, 2008, N'PES 2009', 26, N'Fisico', N'PS2')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (390, 2005, N'Shadow of the Colossus', 27, N'Fisico', N'PS2')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (360, 2004, N'GTA San Andreas', 28, N'Fisico', N'PS2')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (290, 2005, N'God of War', 29, N'Fisico', N'PS2')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (250, 2005, N'Battefield 2', 30, N'Fisico', N'PS2')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (330, 2004, N'Silent Hill', 31, N'Fisico', N'PS2')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (370, 2008, N'Call of Duty: WW', 32, N'Fisico', N'PS2')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (260, 2006, N'Mortal Kombat: Armaggedon', 33, N'Fisico', N'PS2')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (800, 2009, N'Minecraft', 34, N'Fisico', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (700, 2011, N'Uncharted 3', 35, N'Digital', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (680, 2009, N'Uncharted 2', 36, N'Fisico', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (550, 2007, N'Uncharted: El tesoro de Drake', 37, N'Digital', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (870, 2010, N'Call of Duty: Black Ops', 38, N'Fisico', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (570, 2012, N'Call of Duty: Black Ops 2', 39, N'Fisico', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (680, 2010, N'God of War 3', 40, N'Digital', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (900, 2012, N'PES 2013', 41, N'Fisico', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (1000, 2014, N'FIFA 15', 42, N'Digital', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (950, 2011, N'Mortal Kombat 9', 43, N'Fisico', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (850, 2008, N'GTA IV', 44, N'Fisico', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (650, 2010, N'Gran Turismo 5', 45, N'Digital', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (600, 2009, N'Kill Zone', 46, N'Fisico', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (500, 2009, N'Call of Duty: MW2', 47, N'Fisico', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (520, 2007, N'Call of Duty 4: MW', 48, N'Digital', N'PS3')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (2000, 2018, N'God od War 4', 49, N'Fisico', N'PS4')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (1550, 2018, N'Spiderman: Goty', 50, N'Digital', N'PS4')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (1500, 2016, N'Watch Dogs 2', 51, N'Fisico', N'PS4')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (1980, 2019, N'Days Gone', 52, N'Digital', N'PS4')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (1600, 2016, N'Uncharted 4', 53, N'Fisico', N'PS4')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (2600, 2013, N'GTA V', 54, N'Fisico', N'PS4')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (3000, 2019, N'Mortal Kombat 11', 55, N'Digital', N'PS4')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (1970, 2015, N'Mortal Kombat X', 56, N'Fisico', N'PS4')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (3150, 2018, N'Call of Duty: Black Ops 4', 57, N'Digital', N'PS4')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (1700, 2016, N'Mafia 3', 58, N'Fisico', N'PS4')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (1650, 2013, N'Battlefield 4', 59, N'Fisico', N'PS4')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (2060, 2018, N'Far Cry 5', 60, N'Digital', N'PS4')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (1900, 2019, N'Call of Duty Modern Warfare', 61, N'Fisico', N'PS4')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (2050, 2020, N'The Last of Us Part II', 62, N'Fisico', N'PS4')
INSERT [dbo].[Games] ([precio], [lanzamiento], [nombre], [codigo], [formato], [plataforma]) VALUES (3250, 2020, N'FIFA 21', 63, N'Digital', N'PS4')
SET IDENTITY_INSERT [dbo].[Games] OFF
GO
USE [master]
GO
ALTER DATABASE [GamesDB] SET  READ_WRITE 
GO
