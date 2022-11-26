USE [master]
GO

/****** Object:  Database [LoginPage]    Script Date: 27.11.2022 00:25:39 ******/
CREATE DATABASE [LoginPage]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LoginPage', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LoginPage.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LoginPage_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LoginPage_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
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

ALTER DATABASE [LoginPage] SET  READ_WRITE 
GO

