USE [master]
GO
/****** Object:  Database [LoginPage]    Script Date: 14.07.2022 19:33:57 ******/
CREATE DATABASE [LoginPage]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LoginPage', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\LoginPage.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LoginPage_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\LoginPage_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LoginPage] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LoginPage].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LoginPage] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LoginPage] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LoginPage] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LoginPage] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LoginPage] SET ARITHABORT OFF 
GO
ALTER DATABASE [LoginPage] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LoginPage] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LoginPage] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LoginPage] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LoginPage] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LoginPage] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LoginPage] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LoginPage] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LoginPage] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LoginPage] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LoginPage] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LoginPage] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LoginPage] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LoginPage] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LoginPage] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LoginPage] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LoginPage] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LoginPage] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LoginPage] SET  MULTI_USER 
GO
ALTER DATABASE [LoginPage] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LoginPage] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LoginPage] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LoginPage] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LoginPage] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LoginPage] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LoginPage] SET QUERY_STORE = OFF
GO
USE [LoginPage]
GO
/****** Object:  Table [dbo].[IstifadeciMelumati]    Script Date: 14.07.2022 19:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IstifadeciMelumati](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[DogumTarixi] [date] NOT NULL,
	[Telefon] [nvarchar](15) NOT NULL,
	[Cins] [nvarchar](6) NOT NULL,
	[IstifadeciAdi] [nvarchar](50) NOT NULL,
	[Sifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_IstifadeciMelumati] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profil]    Script Date: 14.07.2022 19:33:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profil](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[Telefon] [int] NOT NULL,
	[Aciqlama] [nvarchar](100) NOT NULL,
	[Qeyd] [nvarchar](500) NOT NULL,
	[QeydTarixi] [date] NOT NULL,
 CONSTRAINT [PK_Profil] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[IstifadeciMelumati] ON 

INSERT [dbo].[IstifadeciMelumati] ([Id], [Ad], [Soyad], [DogumTarixi], [Telefon], [Cins], [IstifadeciAdi], [Sifre]) VALUES (1, N'Shahali', N'Shahaliyev', CAST(N'2004-10-20' AS Date), N'774932201', N'Kişi', N'İstifadəçi Adı', N'sahali123')
INSERT [dbo].[IstifadeciMelumati] ([Id], [Ad], [Soyad], [DogumTarixi], [Telefon], [Cins], [IstifadeciAdi], [Sifre]) VALUES (2, N'', N'', CAST(N'2022-07-13' AS Date), N'23435456', N'Kişi', N'İstifadəçi Adı', N'')
INSERT [dbo].[IstifadeciMelumati] ([Id], [Ad], [Soyad], [DogumTarixi], [Telefon], [Cins], [IstifadeciAdi], [Sifre]) VALUES (3, N'rgfg', N'grhg', CAST(N'2022-07-13' AS Date), N'2356', N'Kişi', N'İstifadəçi Adı', N'')
INSERT [dbo].[IstifadeciMelumati] ([Id], [Ad], [Soyad], [DogumTarixi], [Telefon], [Cins], [IstifadeciAdi], [Sifre]) VALUES (4, N'dsgsr', N'fgdfgd', CAST(N'2022-07-13' AS Date), N'23445', N'Kişi', N'İstifadəçi Adı', N'')
INSERT [dbo].[IstifadeciMelumati] ([Id], [Ad], [Soyad], [DogumTarixi], [Telefon], [Cins], [IstifadeciAdi], [Sifre]) VALUES (5, N'hesab', N'hesab', CAST(N'2022-07-13' AS Date), N'774567233', N'Kişi', N'İstifadəçi Adı', N'1234555557678')
INSERT [dbo].[IstifadeciMelumati] ([Id], [Ad], [Soyad], [DogumTarixi], [Telefon], [Cins], [IstifadeciAdi], [Sifre]) VALUES (6, N'gregrergr', N'rgerg', CAST(N'2022-07-13' AS Date), N'3453436', N'Kişi', N'fdafs', N'123456676')
INSERT [dbo].[IstifadeciMelumati] ([Id], [Ad], [Soyad], [DogumTarixi], [Telefon], [Cins], [IstifadeciAdi], [Sifre]) VALUES (7, N'ldf;sdjfl;sd', N'ksgfhks', CAST(N'2022-07-13' AS Date), N'+994774932201', N'Kişi', N'fvbjsdkbvksb', N'djfnsjdbvks')
INSERT [dbo].[IstifadeciMelumati] ([Id], [Ad], [Soyad], [DogumTarixi], [Telefon], [Cins], [IstifadeciAdi], [Sifre]) VALUES (8, N'Shahali', N'Shahaliyev', CAST(N'2004-10-20' AS Date), N'+994774932201', N'Kişi', N'Shahali2004', N'shahali2004')
SET IDENTITY_INSERT [dbo].[IstifadeciMelumati] OFF
GO
ALTER TABLE [dbo].[Profil]  WITH CHECK ADD  CONSTRAINT [FK_Profil_IstifadeciMelumati] FOREIGN KEY([Id])
REFERENCES [dbo].[IstifadeciMelumati] ([Id])
GO
ALTER TABLE [dbo].[Profil] CHECK CONSTRAINT [FK_Profil_IstifadeciMelumati]
GO
USE [master]
GO
ALTER DATABASE [LoginPage] SET  READ_WRITE 
GO
