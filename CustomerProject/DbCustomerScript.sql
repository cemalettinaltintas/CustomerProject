USE [master]
GO
/****** Object:  Database [DbCustomer]    Script Date: 1.10.2024 09:00:00 ******/
CREATE DATABASE [DbCustomer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbCustomer', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DbCustomer.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DbCustomer_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DbCustomer_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DbCustomer] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbCustomer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbCustomer] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbCustomer] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbCustomer] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbCustomer] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbCustomer] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbCustomer] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbCustomer] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbCustomer] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbCustomer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbCustomer] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbCustomer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbCustomer] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbCustomer] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbCustomer] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbCustomer] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbCustomer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbCustomer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbCustomer] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbCustomer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbCustomer] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbCustomer] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbCustomer] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbCustomer] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DbCustomer] SET  MULTI_USER 
GO
ALTER DATABASE [DbCustomer] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbCustomer] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbCustomer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbCustomer] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DbCustomer] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DbCustomer]
GO
/****** Object:  Table [dbo].[TblCity]    Script Date: 1.10.2024 09:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCity](
	[CityId] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](50) NULL,
	[CityCountry] [nvarchar](50) NULL,
 CONSTRAINT [PK_TblCity] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblCustomer]    Script Date: 1.10.2024 09:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCustomer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](20) NULL,
	[CustomerSurname] [nvarchar](50) NULL,
	[CustomerBalance] [decimal](18, 2) NULL,
	[CustomerStatus] [bit] NULL,
	[CustomerCity] [int] NULL,
 CONSTRAINT [PK_TblCustomer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[TblCity] ON 

INSERT [dbo].[TblCity] ([CityId], [CityName], [CityCountry]) VALUES (1, N'Adana', N'Türkiye')
INSERT [dbo].[TblCity] ([CityId], [CityName], [CityCountry]) VALUES (2, N'Ankara', N'Türkiye')
INSERT [dbo].[TblCity] ([CityId], [CityName], [CityCountry]) VALUES (3, N'Berlin', N'Almanya')
INSERT [dbo].[TblCity] ([CityId], [CityName], [CityCountry]) VALUES (4, N'Milano', N'Italya')
INSERT [dbo].[TblCity] ([CityId], [CityName], [CityCountry]) VALUES (5, N'Paris', N'Fransa')
INSERT [dbo].[TblCity] ([CityId], [CityName], [CityCountry]) VALUES (6, N'Bursa', N'Türkiye')
INSERT [dbo].[TblCity] ([CityId], [CityName], [CityCountry]) VALUES (7, N'Bakü', N'Azerbaycan')
INSERT [dbo].[TblCity] ([CityId], [CityName], [CityCountry]) VALUES (8, N'Tokat', N'Türkiye')
INSERT [dbo].[TblCity] ([CityId], [CityName], [CityCountry]) VALUES (9, N'Trabzon', N'Türkiye')
INSERT [dbo].[TblCity] ([CityId], [CityName], [CityCountry]) VALUES (10, N'Manisa', N'Türkiye')
INSERT [dbo].[TblCity] ([CityId], [CityName], [CityCountry]) VALUES (11, N'Erzincan', N'Türkiye')
INSERT [dbo].[TblCity] ([CityId], [CityName], [CityCountry]) VALUES (14, N'Malatya', N'Türikye')
SET IDENTITY_INSERT [dbo].[TblCity] OFF
SET IDENTITY_INSERT [dbo].[TblCustomer] ON 

INSERT [dbo].[TblCustomer] ([CustomerId], [CustomerName], [CustomerSurname], [CustomerBalance], [CustomerStatus], [CustomerCity]) VALUES (2, N'Miraç', N'Durmaz', CAST(100000.00 AS Decimal(18, 2)), 1, 1)
INSERT [dbo].[TblCustomer] ([CustomerId], [CustomerName], [CustomerSurname], [CustomerBalance], [CustomerStatus], [CustomerCity]) VALUES (3, N'Yusuf Ali', N'Erkan', CAST(15000.00 AS Decimal(18, 2)), 1, 3)
INSERT [dbo].[TblCustomer] ([CustomerId], [CustomerName], [CustomerSurname], [CustomerBalance], [CustomerStatus], [CustomerCity]) VALUES (4, N'Mert', N'Bingöl', CAST(160000.00 AS Decimal(18, 2)), 1, 4)
INSERT [dbo].[TblCustomer] ([CustomerId], [CustomerName], [CustomerSurname], [CustomerBalance], [CustomerStatus], [CustomerCity]) VALUES (5, N'Enes', N'Lenger', CAST(165000.00 AS Decimal(18, 2)), 0, 5)
INSERT [dbo].[TblCustomer] ([CustomerId], [CustomerName], [CustomerSurname], [CustomerBalance], [CustomerStatus], [CustomerCity]) VALUES (6, N'Ahmet', N'Çelik', CAST(200000.00 AS Decimal(18, 2)), 0, 6)
SET IDENTITY_INSERT [dbo].[TblCustomer] OFF
ALTER TABLE [dbo].[TblCustomer]  WITH CHECK ADD  CONSTRAINT [FK_TblCustomer_TblCity] FOREIGN KEY([CustomerCity])
REFERENCES [dbo].[TblCity] ([CityId])
GO
ALTER TABLE [dbo].[TblCustomer] CHECK CONSTRAINT [FK_TblCustomer_TblCity]
GO
/****** Object:  StoredProcedure [dbo].[CustomerListWithCity]    Script Date: 1.10.2024 09:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CustomerListWithCity]
as
Select CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CityName from TblCustomer
Inner Join TblCity
On 
TblCustomer.CustomerCity=TblCity.CityId
GO
USE [master]
GO
ALTER DATABASE [DbCustomer] SET  READ_WRITE 
GO
