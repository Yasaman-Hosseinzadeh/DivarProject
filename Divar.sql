USE [master]
GO
/****** Object:  Database [DivarProjectDB]    Script Date: 10/25/2023 4:08:21 PM ******/
CREATE DATABASE [DivarProjectDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DivarProjectDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DivarProjectDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DivarProjectDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DivarProjectDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DivarProjectDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DivarProjectDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DivarProjectDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DivarProjectDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DivarProjectDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DivarProjectDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DivarProjectDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [DivarProjectDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DivarProjectDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DivarProjectDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DivarProjectDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DivarProjectDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DivarProjectDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DivarProjectDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DivarProjectDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DivarProjectDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DivarProjectDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DivarProjectDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DivarProjectDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DivarProjectDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DivarProjectDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DivarProjectDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DivarProjectDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DivarProjectDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DivarProjectDB] SET RECOVERY FULL 
GO
ALTER DATABASE [DivarProjectDB] SET  MULTI_USER 
GO
ALTER DATABASE [DivarProjectDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DivarProjectDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DivarProjectDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DivarProjectDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DivarProjectDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DivarProjectDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DivarProjectDB', N'ON'
GO
ALTER DATABASE [DivarProjectDB] SET QUERY_STORE = OFF
GO
USE [DivarProjectDB]
GO
/****** Object:  Table [dbo].[Advertisement]    Script Date: 10/25/2023 4:08:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advertisement](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[CreatorUserId] [int] NOT NULL,
	[IntactStatus] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[IsFixedPrice] [bit] NOT NULL,
	[LikeToExchange] [bit] NOT NULL,
	[Price] [int] NOT NULL,
	[Title] [nvarchar](300) NOT NULL,
	[Address] [nvarchar](400) NOT NULL,
	[Description] [nvarchar](500) NULL,
 CONSTRAINT [PK_advertisement] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 10/25/2023 4:08:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 10/25/2023 4:08:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[NationalCode] [char](10) NOT NULL,
	[CellNumber] [varchar](13) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Advertisement] ON 

INSERT [dbo].[Advertisement] ([Id], [CreatedDate], [ModifiedDate], [CategoryId], [CreatorUserId], [IntactStatus], [Status], [IsFixedPrice], [LikeToExchange], [Price], [Title], [Address], [Description]) VALUES (2, CAST(N'2023-10-24T18:03:55.000' AS DateTime), CAST(N'2023-10-24T18:03:55.000' AS DateTime), 1, 2, 1, 1, 1, 0, 100, N'sfnsfnsfnsfn', N'sfnsfnsfnsfnsfnsfn', N'sfnsfnsfnsfn')
INSERT [dbo].[Advertisement] ([Id], [CreatedDate], [ModifiedDate], [CategoryId], [CreatorUserId], [IntactStatus], [Status], [IsFixedPrice], [LikeToExchange], [Price], [Title], [Address], [Description]) VALUES (3, CAST(N'2023-10-24T18:05:54.000' AS DateTime), CAST(N'2023-10-24T18:05:54.000' AS DateTime), 1, 2, 2, 1, 1, 1, 100, N'خونه خاله غزی', N'تهران، اونور تر', N'ویو ابدی')
INSERT [dbo].[Advertisement] ([Id], [CreatedDate], [ModifiedDate], [CategoryId], [CreatorUserId], [IntactStatus], [Status], [IsFixedPrice], [LikeToExchange], [Price], [Title], [Address], [Description]) VALUES (4, CAST(N'2023-10-24T18:07:48.000' AS DateTime), CAST(N'2023-10-24T18:07:48.000' AS DateTime), 1, 2, 3, 1, 0, 1, 100, N'خونه عمه غزی', N'تهران پلاک 1', N'خونه عمه غزی')
INSERT [dbo].[Advertisement] ([Id], [CreatedDate], [ModifiedDate], [CategoryId], [CreatorUserId], [IntactStatus], [Status], [IsFixedPrice], [LikeToExchange], [Price], [Title], [Address], [Description]) VALUES (5, CAST(N'2023-10-24T18:17:48.447' AS DateTime), CAST(N'2023-10-24T18:17:48.450' AS DateTime), 1, 2, 4, 1, 0, 0, 100, N'sfbsfbsfbsfb', N'sfbsfbsfbsfbsf', N'sfbsfbsfbsfb')
INSERT [dbo].[Advertisement] ([Id], [CreatedDate], [ModifiedDate], [CategoryId], [CreatorUserId], [IntactStatus], [Status], [IsFixedPrice], [LikeToExchange], [Price], [Title], [Address], [Description]) VALUES (6, CAST(N'2023-10-24T18:19:28.510' AS DateTime), CAST(N'2023-10-24T18:19:28.510' AS DateTime), 1, 2, 1, 1, 0, 0, 100, N'wrnwrnwr', N'nnwrnwrnwrnwrnwrn', N'wrnwrnwrnwrn')
INSERT [dbo].[Advertisement] ([Id], [CreatedDate], [ModifiedDate], [CategoryId], [CreatorUserId], [IntactStatus], [Status], [IsFixedPrice], [LikeToExchange], [Price], [Title], [Address], [Description]) VALUES (7, CAST(N'2023-10-24T18:21:09.760' AS DateTime), CAST(N'2023-10-24T18:21:09.760' AS DateTime), 1, 2, 2, 1, 0, 0, 100, N'afnafnafna', N'sfnfasnafanbfn', N'nafnafnafn')
INSERT [dbo].[Advertisement] ([Id], [CreatedDate], [ModifiedDate], [CategoryId], [CreatorUserId], [IntactStatus], [Status], [IsFixedPrice], [LikeToExchange], [Price], [Title], [Address], [Description]) VALUES (8, CAST(N'2023-10-24T18:30:27.883' AS DateTime), CAST(N'2023-10-24T18:30:27.883' AS DateTime), 1, 2, 1, 1, 1, 0, 100, N'خونه نوتر', N'خونه نو', N'خونه نوتر')
INSERT [dbo].[Advertisement] ([Id], [CreatedDate], [ModifiedDate], [CategoryId], [CreatorUserId], [IntactStatus], [Status], [IsFixedPrice], [LikeToExchange], [Price], [Title], [Address], [Description]) VALUES (9, CAST(N'2023-10-25T14:24:01.277' AS DateTime), CAST(N'2023-10-25T14:24:01.277' AS DateTime), 2, 2, 1, 1, 1, 0, 100, N'لاماری', N'تهران - سهروردی شمالی', N'فروش ماشین ')
INSERT [dbo].[Advertisement] ([Id], [CreatedDate], [ModifiedDate], [CategoryId], [CreatorUserId], [IntactStatus], [Status], [IsFixedPrice], [LikeToExchange], [Price], [Title], [Address], [Description]) VALUES (10, CAST(N'2023-10-25T14:25:50.040' AS DateTime), CAST(N'2023-10-25T14:25:50.040' AS DateTime), 1, 2, 1, 1, 1, 0, 100, N'لاماری ', N'تهران - ونک', N'فروش ماشین ')
INSERT [dbo].[Advertisement] ([Id], [CreatedDate], [ModifiedDate], [CategoryId], [CreatorUserId], [IntactStatus], [Status], [IsFixedPrice], [LikeToExchange], [Price], [Title], [Address], [Description]) VALUES (11, CAST(N'2023-10-25T15:00:10.790' AS DateTime), CAST(N'2023-10-25T15:00:10.790' AS DateTime), 3, 2, 2, 1, 1, 1, 100, N'گوشی s23 ultra', N'گیلان - رشت', N'فروش گوشی ')
INSERT [dbo].[Advertisement] ([Id], [CreatedDate], [ModifiedDate], [CategoryId], [CreatorUserId], [IntactStatus], [Status], [IsFixedPrice], [LikeToExchange], [Price], [Title], [Address], [Description]) VALUES (12, CAST(N'2023-10-25T15:18:50.410' AS DateTime), CAST(N'2023-10-25T15:18:50.410' AS DateTime), 7, 2, 1, 1, 1, 1, 100, N'بازی و سرگرمی', N'اصفهان', N'تست تست ت سس')
INSERT [dbo].[Advertisement] ([Id], [CreatedDate], [ModifiedDate], [CategoryId], [CreatorUserId], [IntactStatus], [Status], [IsFixedPrice], [LikeToExchange], [Price], [Title], [Address], [Description]) VALUES (13, CAST(N'2023-10-25T15:23:44.387' AS DateTime), CAST(N'2023-10-25T15:23:44.457' AS DateTime), 9, 2, 4, 1, 1, 1, 100, N'تتسستت', N'تتتتت', N'تتتتتتتتتتتتتتتتتتتتت')
INSERT [dbo].[Advertisement] ([Id], [CreatedDate], [ModifiedDate], [CategoryId], [CreatorUserId], [IntactStatus], [Status], [IsFixedPrice], [LikeToExchange], [Price], [Title], [Address], [Description]) VALUES (14, CAST(N'2023-10-25T16:01:07.237' AS DateTime), CAST(N'2023-10-25T16:01:07.237' AS DateTime), 1, 2, 1, 1, 1, 1, 200000, N'fffff', N'fffff', N'ffff')
INSERT [dbo].[Advertisement] ([Id], [CreatedDate], [ModifiedDate], [CategoryId], [CreatorUserId], [IntactStatus], [Status], [IsFixedPrice], [LikeToExchange], [Price], [Title], [Address], [Description]) VALUES (15, CAST(N'2023-10-25T16:03:18.353' AS DateTime), CAST(N'2023-10-25T16:03:18.353' AS DateTime), 1, 2, 1, 1, 0, 0, 80000, N'gggggggg', N'ssssssssss', N'uuuuuuuuuuuuuu')
SET IDENTITY_INSERT [dbo].[Advertisement] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [CreatedDate], [ModifiedDate], [Title]) VALUES (1, CAST(N'2023-10-18T09:47:04.773' AS DateTime), CAST(N'2023-10-18T09:47:04.773' AS DateTime), N'املاک')
INSERT [dbo].[Category] ([Id], [CreatedDate], [ModifiedDate], [Title]) VALUES (2, CAST(N'2023-10-18T09:47:59.947' AS DateTime), CAST(N'2023-10-18T09:47:59.947' AS DateTime), N'وسایل نقلیه')
INSERT [dbo].[Category] ([Id], [CreatedDate], [ModifiedDate], [Title]) VALUES (3, CAST(N'2023-10-18T09:48:08.857' AS DateTime), CAST(N'2023-10-18T09:48:08.857' AS DateTime), N'کالای دیجیتال')
INSERT [dbo].[Category] ([Id], [CreatedDate], [ModifiedDate], [Title]) VALUES (4, CAST(N'2023-10-18T09:48:17.850' AS DateTime), CAST(N'2023-10-18T09:48:17.850' AS DateTime), N'خانه و آشپژخانه')
INSERT [dbo].[Category] ([Id], [CreatedDate], [ModifiedDate], [Title]) VALUES (5, CAST(N'2023-10-18T09:48:21.050' AS DateTime), CAST(N'2023-10-18T09:48:21.050' AS DateTime), N'خدمات')
INSERT [dbo].[Category] ([Id], [CreatedDate], [ModifiedDate], [Title]) VALUES (6, CAST(N'2023-10-18T09:48:28.150' AS DateTime), CAST(N'2023-10-18T09:48:28.150' AS DateTime), N'وسایل شخصی')
INSERT [dbo].[Category] ([Id], [CreatedDate], [ModifiedDate], [Title]) VALUES (7, CAST(N'2023-10-18T09:48:35.857' AS DateTime), CAST(N'2023-10-18T09:48:35.857' AS DateTime), N'سرگرمی و فراغت')
INSERT [dbo].[Category] ([Id], [CreatedDate], [ModifiedDate], [Title]) VALUES (8, CAST(N'2023-10-18T09:48:40.410' AS DateTime), CAST(N'2023-10-18T09:48:40.410' AS DateTime), N'اجتماعی')
INSERT [dbo].[Category] ([Id], [CreatedDate], [ModifiedDate], [Title]) VALUES (9, CAST(N'2023-10-18T09:48:49.667' AS DateTime), CAST(N'2023-10-18T09:48:49.667' AS DateTime), N'تجهیزات و صنعتی')
INSERT [dbo].[Category] ([Id], [CreatedDate], [ModifiedDate], [Title]) VALUES (10, CAST(N'2023-10-18T09:48:55.900' AS DateTime), CAST(N'2023-10-18T09:48:55.900' AS DateTime), N'استخدام و کاریابی')
INSERT [dbo].[Category] ([Id], [CreatedDate], [ModifiedDate], [Title]) VALUES (11, CAST(N'2023-10-18T09:49:18.807' AS DateTime), CAST(N'2023-10-18T09:49:18.807' AS DateTime), N'رزومه کارجویان(جدید)')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [CreatedDate], [ModifiedDate], [FirstName], [LastName], [NationalCode], [CellNumber]) VALUES (2, CAST(N'2023-10-24T17:57:39.570' AS DateTime), CAST(N'2023-10-24T17:57:39.570' AS DateTime), N'یاسمن', N'حسین زاده', N'1234567890', N'09125896524')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Advertisement] ADD  CONSTRAINT [DF_advertisement_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Advertisement] ADD  CONSTRAINT [DF_advertisement_ModifiedDate]  DEFAULT (getdate()) FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[Advertisement] ADD  CONSTRAINT [DF_advertisement_IntactStatus]  DEFAULT ((0)) FOR [IntactStatus]
GO
ALTER TABLE [dbo].[Advertisement] ADD  CONSTRAINT [DF_advertisement_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_ModifiedDate]  DEFAULT (getdate()) FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_ModifiedDate]  DEFAULT (getdate()) FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[Advertisement]  WITH CHECK ADD  CONSTRAINT [FK_Advertisement_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Advertisement] CHECK CONSTRAINT [FK_Advertisement_Category]
GO
ALTER TABLE [dbo].[Advertisement]  WITH CHECK ADD  CONSTRAINT [FK_Advertisement_User] FOREIGN KEY([CreatorUserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Advertisement] CHECK CONSTRAINT [FK_Advertisement_User]
GO
USE [master]
GO
ALTER DATABASE [DivarProjectDB] SET  READ_WRITE 
GO
