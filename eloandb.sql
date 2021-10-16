USE [master]
GO
/****** Object:  Database [LoanEAppsdb]    Script Date: 16-10-2021 17:50:08 ******/
CREATE DATABASE [LoanEAppsdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LoanEAppsdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\LoanEAppsdb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LoanEAppsdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\LoanEAppsdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LoanEAppsdb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LoanEAppsdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LoanEAppsdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LoanEAppsdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LoanEAppsdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LoanEAppsdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LoanEAppsdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LoanEAppsdb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [LoanEAppsdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LoanEAppsdb] SET  MULTI_USER 
GO
ALTER DATABASE [LoanEAppsdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LoanEAppsdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LoanEAppsdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LoanEAppsdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LoanEAppsdb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LoanEAppsdb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LoanEAppsdb] SET QUERY_STORE = OFF
GO
USE [LoanEAppsdb]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 16-10-2021 17:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplyLoans]    Script Date: 16-10-2021 17:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplyLoans](
	[ApplyLoanId] [int] IDENTITY(1,1) NOT NULL,
	[Loanname] [nvarchar](100) NOT NULL,
	[Amount] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[BuisnessStatus] [int] NOT NULL,
	[Billingstatus] [int] NOT NULL,
	[Taxstatus] [int] NOT NULL,
	[Loanstatus] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ApplyLoans] PRIMARY KEY CLUSTERED 
(
	[ApplyLoanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerLogins]    Script Date: 16-10-2021 17:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerLogins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.CustomerLogins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 16-10-2021 17:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](100) NOT NULL,
	[Lastname] [nvarchar](100) NOT NULL,
	[Location] [nvarchar](max) NOT NULL,
	[mobile] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManagerLogins]    Script Date: 16-10-2021 17:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManagerLogins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.ManagerLogins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Managers]    Script Date: 16-10-2021 17:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Managers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](100) NOT NULL,
	[Lastname] [nvarchar](100) NOT NULL,
	[Location] [nvarchar](max) NOT NULL,
	[mobile] [nvarchar](12) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.Managers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ApplyLoans] ADD  DEFAULT ((0)) FOR [BuisnessStatus]
GO
ALTER TABLE [dbo].[ApplyLoans] ADD  DEFAULT ((0)) FOR [Billingstatus]
GO
ALTER TABLE [dbo].[ApplyLoans] ADD  DEFAULT ((0)) FOR [Taxstatus]
GO
ALTER TABLE [dbo].[ApplyLoans] ADD  DEFAULT ((0)) FOR [Loanstatus]
GO
USE [master]
GO
ALTER DATABASE [LoanEAppsdb] SET  READ_WRITE 
GO
