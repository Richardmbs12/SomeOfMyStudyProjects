USE [master]
GO
/****** Object:  Database [SHSManagementDB]    Script Date: 04 Jun 2018 12:08:29 ******/
CREATE DATABASE [SHSManagementDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SHSManagementDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SHSManagementDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SHSManagementDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SHSManagementDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SHSManagementDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SHSManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SHSManagementDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SHSManagementDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SHSManagementDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SHSManagementDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SHSManagementDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SHSManagementDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SHSManagementDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SHSManagementDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SHSManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SHSManagementDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SHSManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SHSManagementDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SHSManagementDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SHSManagementDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SHSManagementDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SHSManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SHSManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SHSManagementDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SHSManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SHSManagementDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SHSManagementDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [SHSManagementDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SHSManagementDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SHSManagementDB] SET  MULTI_USER 
GO
ALTER DATABASE [SHSManagementDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SHSManagementDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SHSManagementDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SHSManagementDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SHSManagementDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SHSManagementDB] SET QUERY_STORE = OFF
GO
USE [SHSManagementDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [SHSManagementDB]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 04 Jun 2018 12:08:29 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 04 Jun 2018 12:08:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[ID] [nvarchar](128) NOT NULL,
	[Country] [nvarchar](max) NULL,
	[Suburb] [nvarchar](max) NULL,
	[PostalCode] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[AddressLine2] [nvarchar](max) NULL,
	[AddressLine1] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Address] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillingInformation]    Script Date: 04 Jun 2018 12:08:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillingInformation](
	[ID] [nvarchar](128) NOT NULL,
	[Branch] [nvarchar](max) NULL,
	[Bank] [nvarchar](max) NULL,
	[AccountNumber] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.BillingInformation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillingInvoices]    Script Date: 04 Jun 2018 12:08:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillingInvoices](
	[OrderID] [int] NOT NULL,
	[AmountDue] [float] NOT NULL,
	[CreditAmount] [float] NOT NULL,
	[Date] [datetime] NOT NULL,
	[BillingInformation_ID] [nvarchar](128) NULL,
	[TotalPrice] [float] NOT NULL,
 CONSTRAINT [PK_dbo.BillingInvoices] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactInformation]    Script Date: 04 Jun 2018 12:08:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactInformation](
	[ID] [nvarchar](128) NOT NULL,
	[WorkNumber] [nvarchar](max) NULL,
	[MobileNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.ContactInformation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contracts]    Script Date: 04 Jun 2018 12:08:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contracts](
	[ID] [nvarchar](128) NOT NULL,
	[Type] [nvarchar](max) NULL,
	[EndDate] [datetime] NOT NULL,
	[ContractID] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.Contracts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractTypes]    Script Date: 04 Jun 2018 12:08:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractTypes](
	[ContractID] [nvarchar](128) NOT NULL,
	[IncludedCreditPercentage] [float] NOT NULL,
	[FreeTechnicalSupport] [bit] NOT NULL,
	[ContractName] [nvarchar](max) NULL,
	[ServiceLevel] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ContractTypes] PRIMARY KEY CLUSTERED 
(
	[ContractID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 04 Jun 2018 12:08:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerEnquiry]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerEnquiry](
	[TrackingNumber] [int] IDENTITY(1,1) NOT NULL,
	[EnquiryNote] [nvarchar](max) NULL,
	[EnquiryDateTime] [datetime] NOT NULL,
	[Customer_ID] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.CustomerEnquiry] PRIMARY KEY CLUSTERED 
(
	[TrackingNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerProductConfiguration]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerProductConfiguration](
	[ID] [nvarchar](128) NOT NULL,
	[ConfigurationNote] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.CustomerProductConfiguration] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [nvarchar](128) NOT NULL,
	[Discriminator] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginInformation]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginInformation](
	[ID] [nvarchar](128) NOT NULL,
	[AuthenticationLevel] [int] NOT NULL,
	[Password] [nvarchar](max) NULL,
	[UserName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.LoginInformation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[TrackingNumber] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Order] PRIMARY KEY CLUSTERED 
(
	[TrackingNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductInstallationHistory]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductInstallationHistory](
	[SerialNumber] [int] NOT NULL,
	[InstallationDate] [datetime] NOT NULL,
	[InstallationNote] [nvarchar](max) NULL,
	[Installed] [bit] NOT NULL,
	[InstallationEmployee_ID] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.ProductInstallationHistory] PRIMARY KEY CLUSTERED 
(
	[SerialNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[SerialNumber] [int] IDENTITY(1,1) NOT NULL,
	[StockOutDate] [datetime] NOT NULL,
	[StockInDate] [datetime] NOT NULL,
	[ProductID] [int] NOT NULL,
	[TrackingNumber] [int] NOT NULL,
	[ID] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED 
(
	[SerialNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTypes]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTypes](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[WarrantyDuration] [int] NOT NULL,
	[ProductName] [nvarchar](max) NULL,
	[QuantityInStock] [int] NOT NULL,
	[ProductImage] [varbinary](max) NULL,
	[ProductDescription] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_dbo.ProductTypes] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedules]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedules](
	[ScheduleID] [int] IDENTITY(1,1) NOT NULL,
	[ScheduleDate] [datetime] NOT NULL,
	[ID] [nvarchar](128) NULL,
 CONSTRAINT [PK_dbo.Schedules] PRIMARY KEY CLUSTERED 
(
	[ScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TechnicalSupportEmployee]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechnicalSupportEmployee](
	[ID] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.TechnicalSupportEmployee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TechnicalSupportEnquiry]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechnicalSupportEnquiry](
	[TrackingNumber] [int] NOT NULL,
 CONSTRAINT [PK_dbo.TechnicalSupportEnquiry] PRIMARY KEY CLUSTERED 
(
	[TrackingNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TechnicalTasks]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechnicalTasks](
	[TrackingNumber] [int] NOT NULL,
	[Completed] [bit] NULL,
	[TaskDescription] [nvarchar](max) NULL,
	[TaskTime] [datetime] NULL,
	[ScheduleID] [int] NULL,
 CONSTRAINT [PK_dbo.TechnicalTasks] PRIMARY KEY CLUSTERED 
(
	[TrackingNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [nvarchar](128) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[Gender] [nvarchar](max) NULL,
	[Surname] [nvarchar](max) NULL,
	[FullName] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_ID] ON [dbo].[Address]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_ID] ON [dbo].[BillingInformation]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_BillingInformation_ID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_BillingInformation_ID] ON [dbo].[BillingInvoices]
(
	[BillingInformation_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_OrderID] ON [dbo].[BillingInvoices]
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_ID] ON [dbo].[ContactInformation]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ContractID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_ContractID] ON [dbo].[Contracts]
(
	[ContractID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_ID] ON [dbo].[Contracts]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_ID] ON [dbo].[Customer]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Customer_ID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_Customer_ID] ON [dbo].[CustomerEnquiry]
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_ID] ON [dbo].[CustomerProductConfiguration]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_ID] ON [dbo].[Employee]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_ID] ON [dbo].[LoginInformation]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TrackingNumber]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_TrackingNumber] ON [dbo].[Order]
(
	[TrackingNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_InstallationEmployee_ID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_InstallationEmployee_ID] ON [dbo].[ProductInstallationHistory]
(
	[InstallationEmployee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SerialNumber]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_SerialNumber] ON [dbo].[ProductInstallationHistory]
(
	[SerialNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_ID] ON [dbo].[Products]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_ProductID] ON [dbo].[Products]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TrackingNumber]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_TrackingNumber] ON [dbo].[Products]
(
	[TrackingNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_ID] ON [dbo].[Schedules]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_ID] ON [dbo].[TechnicalSupportEmployee]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TrackingNumber]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_TrackingNumber] ON [dbo].[TechnicalSupportEnquiry]
(
	[TrackingNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScheduleID]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_ScheduleID] ON [dbo].[TechnicalTasks]
(
	[ScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TrackingNumber]    Script Date: 04 Jun 2018 12:08:30 ******/
CREATE NONCLUSTERED INDEX [IX_TrackingNumber] ON [dbo].[TechnicalTasks]
(
	[TrackingNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BillingInvoices] ADD  DEFAULT ((0)) FOR [TotalPrice]
GO
ALTER TABLE [dbo].[ContractTypes] ADD  DEFAULT ((0)) FOR [ServiceLevel]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Address_dbo.Users_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_dbo.Address_dbo.Users_ID]
GO
ALTER TABLE [dbo].[BillingInformation]  WITH CHECK ADD  CONSTRAINT [FK_dbo.BillingInformation_dbo.Customer_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[BillingInformation] CHECK CONSTRAINT [FK_dbo.BillingInformation_dbo.Customer_ID]
GO
ALTER TABLE [dbo].[BillingInvoices]  WITH CHECK ADD  CONSTRAINT [FK_dbo.BillingInvoices_dbo.BillingInformation_BillingInformation_ID] FOREIGN KEY([BillingInformation_ID])
REFERENCES [dbo].[BillingInformation] ([ID])
GO
ALTER TABLE [dbo].[BillingInvoices] CHECK CONSTRAINT [FK_dbo.BillingInvoices_dbo.BillingInformation_BillingInformation_ID]
GO
ALTER TABLE [dbo].[BillingInvoices]  WITH CHECK ADD  CONSTRAINT [FK_dbo.BillingInvoices_dbo.Order_OrderID] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([TrackingNumber])
GO
ALTER TABLE [dbo].[BillingInvoices] CHECK CONSTRAINT [FK_dbo.BillingInvoices_dbo.Order_OrderID]
GO
ALTER TABLE [dbo].[ContactInformation]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ContactInformation_dbo.Users_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[ContactInformation] CHECK CONSTRAINT [FK_dbo.ContactInformation_dbo.Users_ID]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Contracts_dbo.ContractTypes_ContractID] FOREIGN KEY([ContractID])
REFERENCES [dbo].[ContractTypes] ([ContractID])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_dbo.Contracts_dbo.ContractTypes_ContractID]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Contracts_dbo.Customer_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_dbo.Contracts_dbo.Customer_ID]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Customer_dbo.Users_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_dbo.Customer_dbo.Users_ID]
GO
ALTER TABLE [dbo].[CustomerEnquiry]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CustomerEnquiry_dbo.Customer_Customer_ID] FOREIGN KEY([Customer_ID])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[CustomerEnquiry] CHECK CONSTRAINT [FK_dbo.CustomerEnquiry_dbo.Customer_Customer_ID]
GO
ALTER TABLE [dbo].[CustomerProductConfiguration]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CustomerProductConfiguration_dbo.Customer_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[CustomerProductConfiguration] CHECK CONSTRAINT [FK_dbo.CustomerProductConfiguration_dbo.Customer_ID]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Employee_dbo.Users_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_dbo.Employee_dbo.Users_ID]
GO
ALTER TABLE [dbo].[LoginInformation]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LoginInformation_dbo.Employee_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[LoginInformation] CHECK CONSTRAINT [FK_dbo.LoginInformation_dbo.Employee_ID]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Order_dbo.CustomerEnquiry_TrackingNumber] FOREIGN KEY([TrackingNumber])
REFERENCES [dbo].[CustomerEnquiry] ([TrackingNumber])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_dbo.Order_dbo.CustomerEnquiry_TrackingNumber]
GO
ALTER TABLE [dbo].[ProductInstallationHistory]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ProductInstallationHistory_dbo.Products_SerialNumber] FOREIGN KEY([SerialNumber])
REFERENCES [dbo].[Products] ([SerialNumber])
GO
ALTER TABLE [dbo].[ProductInstallationHistory] CHECK CONSTRAINT [FK_dbo.ProductInstallationHistory_dbo.Products_SerialNumber]
GO
ALTER TABLE [dbo].[ProductInstallationHistory]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ProductInstallationHistory_dbo.TechnicalSupportEmployee_InstallationEmployee_ID] FOREIGN KEY([InstallationEmployee_ID])
REFERENCES [dbo].[TechnicalSupportEmployee] ([ID])
GO
ALTER TABLE [dbo].[ProductInstallationHistory] CHECK CONSTRAINT [FK_dbo.ProductInstallationHistory_dbo.TechnicalSupportEmployee_InstallationEmployee_ID]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Products_dbo.CustomerProductConfiguration_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[CustomerProductConfiguration] ([ID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_dbo.Products_dbo.CustomerProductConfiguration_ID]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Products_dbo.Order_OrderID] FOREIGN KEY([TrackingNumber])
REFERENCES [dbo].[Order] ([TrackingNumber])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_dbo.Products_dbo.Order_OrderID]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Products_dbo.ProductTypes_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[ProductTypes] ([ProductID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_dbo.Products_dbo.ProductTypes_ProductID]
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Schedules_dbo.TechnicalSupportEmployee_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[TechnicalSupportEmployee] ([ID])
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [FK_dbo.Schedules_dbo.TechnicalSupportEmployee_ID]
GO
ALTER TABLE [dbo].[TechnicalSupportEmployee]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TechnicalSupportEmployee_dbo.Employee_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[Employee] ([ID])
GO
ALTER TABLE [dbo].[TechnicalSupportEmployee] CHECK CONSTRAINT [FK_dbo.TechnicalSupportEmployee_dbo.Employee_ID]
GO
ALTER TABLE [dbo].[TechnicalSupportEnquiry]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TechnicalSupportEnquiry_dbo.CustomerEnquiry_TrackingNumber] FOREIGN KEY([TrackingNumber])
REFERENCES [dbo].[CustomerEnquiry] ([TrackingNumber])
GO
ALTER TABLE [dbo].[TechnicalSupportEnquiry] CHECK CONSTRAINT [FK_dbo.TechnicalSupportEnquiry_dbo.CustomerEnquiry_TrackingNumber]
GO
ALTER TABLE [dbo].[TechnicalTasks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TechnicalTasks_dbo.CustomerEnquiry_TrackingNumber] FOREIGN KEY([TrackingNumber])
REFERENCES [dbo].[CustomerEnquiry] ([TrackingNumber])
GO
ALTER TABLE [dbo].[TechnicalTasks] CHECK CONSTRAINT [FK_dbo.TechnicalTasks_dbo.CustomerEnquiry_TrackingNumber]
GO
ALTER TABLE [dbo].[TechnicalTasks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TechnicalTasks_dbo.Schedules_ScheduleID] FOREIGN KEY([ScheduleID])
REFERENCES [dbo].[Schedules] ([ScheduleID])
GO
ALTER TABLE [dbo].[TechnicalTasks] CHECK CONSTRAINT [FK_dbo.TechnicalTasks_dbo.Schedules_ScheduleID]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCustomer]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_InsertCustomer]
(@FirstName varchar(30), @Surname varchar(30), @Title varchar(30), @Gender Varchar(10), @DateofBirth varchar(20), @FullName varchar(50),
@ID varchar(20),@AddressLine1 varchar(30),@AddressLine2 varchar(30),@City varchar(30),@Country varchar(30),
@PostalCode varchar(30),@Suburb varchar(30), @Email varchar(30), @MobileNumber varchar(30), @WorkNumber varchar(30))

As
Begin
Insert Into Users
(Name,Title,Surname,Gender,DateOfBirth,Fullname,ID)
Values
(@FirstName,@Title,@Surname,@Gender,@DateofBirth,@FullName,@ID)

Insert Into Customer
(ID)
Values
(@ID)
End

Insert Into Address
(ID , AddressLine1 , AddressLine2 , City, Country, PostalCode, Suburb)
Values
(@ID , @AddressLine1, @AddressLine2, @City, @Country, @PostalCode, @Suburb)

Insert Into ContactInformation
(ID , Email, MobileNumber, WorkNumber)
Values
(@ID,@Email, @MobileNumber, @WorkNumber)
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCustomer]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_UpdateCustomer]
(@ID varchar(30),@Firstname varchar(30),@Title varchar(30),@Surname varchar(30),@Gender varchar(10),@DateOfBirth varchar(50),
@Fullname varchar(50),@AddressLine1 varchar(30),@AddressLine2 varchar(30),@City varchar(30),@Country varchar(30),
@PostalCode varchar(30),@Suburb varchar(30), @Email varchar(30), @MobileNumber varchar(30), @WorkNumber varchar(30))
As
Begin
Update Users
Set
	Name = @Firstname,
	Title = @Title,
    Surname = @Surname,
    Gender = @Gender,
    DateOfBirth = @DateOfBirth,
    Fullname = @Fullname
Where ID = @ID

Update Address
Set
	AddressLine1 = @AddressLine1,
	AddressLine2 = @AddressLine2,
    City = @City,
    Country = @Country,
    PostalCode = @PostalCode,
    Suburb = @Suburb
Where ID = @ID

Update ContactInformation
Set
	Email = @Email,
	MobileNumber = @MobileNumber,
    WorkNumber = @WorkNumber
Where ID = @ID
End
GO
/****** Object:  StoredProcedure [dbo].[usp_AddressDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AddressDelete] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Address]
	WHERE  [ID] = @ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AddressInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AddressInsert] 
    @ID nvarchar(128),
    @Country nvarchar(MAX) = NULL,
    @Suburb nvarchar(MAX) = NULL,
    @PostalCode nvarchar(MAX) = NULL,
    @City nvarchar(MAX) = NULL,
    @AddressLine2 nvarchar(MAX) = NULL,
    @AddressLine1 nvarchar(MAX) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Address] ([ID], [Country], [Suburb], [PostalCode], [City], [AddressLine2], [AddressLine1])
	SELECT @ID, @Country, @Suburb, @PostalCode, @City, @AddressLine2, @AddressLine1
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Country], [Suburb], [PostalCode], [City], [AddressLine2], [AddressLine1]
	FROM   [dbo].[Address]
	WHERE  [ID] = @ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AddressSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AddressSelect] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [Country], [Suburb], [PostalCode], [City], [AddressLine2], [AddressLine1] 
	FROM   [dbo].[Address] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AddressUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AddressUpdate] 
    @ID nvarchar(128),
    @Country nvarchar(MAX) = NULL,
    @Suburb nvarchar(MAX) = NULL,
    @PostalCode nvarchar(MAX) = NULL,
    @City nvarchar(MAX) = NULL,
    @AddressLine2 nvarchar(MAX) = NULL,
    @AddressLine1 nvarchar(MAX) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Address]
	SET    [Country] = @Country, [Suburb] = @Suburb, [PostalCode] = @PostalCode, [City] = @City, [AddressLine2] = @AddressLine2, [AddressLine1] = @AddressLine1
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Country], [Suburb], [PostalCode], [City], [AddressLine2], [AddressLine1]
	FROM   [dbo].[Address]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_BillingInformationDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_BillingInformationDelete] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[BillingInformation]
	WHERE  [ID] = @ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_BillingInformationInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_BillingInformationInsert] 
    @ID nvarchar(128),
    @Branch nvarchar(MAX) = NULL,
    @Bank nvarchar(MAX) = NULL,
    @AccountNumber nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[BillingInformation] ([ID], [Branch], [Bank], [AccountNumber])
	SELECT @ID, @Branch, @Bank, @AccountNumber
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Branch], [Bank], [AccountNumber]
	FROM   [dbo].[BillingInformation]
	WHERE  [ID] = @ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_BillingInformationSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_BillingInformationSelect] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [Branch], [Bank], [AccountNumber] 
	FROM   [dbo].[BillingInformation] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_BillingInformationUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_BillingInformationUpdate] 
    @ID nvarchar(128),
    @Branch nvarchar(MAX) = NULL,
    @Bank nvarchar(MAX) = NULL,
    @AccountNumber nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[BillingInformation]
	SET    [Branch] = @Branch, [Bank] = @Bank, [AccountNumber] = @AccountNumber
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Branch], [Bank], [AccountNumber]
	FROM   [dbo].[BillingInformation]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_BillingInvoicesDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_BillingInvoicesDelete] 
    @OrderID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[BillingInvoices]
	WHERE  [OrderID] = @OrderID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_BillingInvoicesInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_BillingInvoicesInsert] 
    @OrderID int,
    @AmountDue float,
    @CreditAmount float,
    @Date datetime,
    @BillingInformation_ID nvarchar(128) = NULL,
    @TotalPrice float
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[BillingInvoices] ([OrderID], [AmountDue], [CreditAmount], [Date], [BillingInformation_ID], [TotalPrice])
	SELECT @OrderID, @AmountDue, @CreditAmount, @Date, @BillingInformation_ID, @TotalPrice
	
	-- Begin Return Select <- do not remove
	SELECT [OrderID], [AmountDue], [CreditAmount], [Date], [BillingInformation_ID], [TotalPrice]
	FROM   [dbo].[BillingInvoices]
	WHERE  [OrderID] = @OrderID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_BillingInvoicesSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_BillingInvoicesSelect] 
    @OrderID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [OrderID], [AmountDue], [CreditAmount], [Date], [BillingInformation_ID], [TotalPrice] 
	FROM   [dbo].[BillingInvoices] 
	WHERE  ([OrderID] = @OrderID OR @OrderID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_BillingInvoicesUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_BillingInvoicesUpdate] 
    @OrderID int,
    @AmountDue float,
    @CreditAmount float,
    @Date datetime,
    @BillingInformation_ID nvarchar(128) = NULL,
    @TotalPrice float
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[BillingInvoices]
	SET    [AmountDue] = @AmountDue, [CreditAmount] = @CreditAmount, [Date] = @Date, [BillingInformation_ID] = @BillingInformation_ID, [TotalPrice] = @TotalPrice
	WHERE  [OrderID] = @OrderID
	
	-- Begin Return Select <- do not remove
	SELECT [OrderID], [AmountDue], [CreditAmount], [Date], [BillingInformation_ID], [TotalPrice]
	FROM   [dbo].[BillingInvoices]
	WHERE  [OrderID] = @OrderID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ContactInformationDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ContactInformationDelete] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[ContactInformation]
	WHERE  [ID] = @ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ContactInformationInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ContactInformationInsert] 
    @ID nvarchar(128),
    @WorkNumber nvarchar(MAX) = NULL,
    @MobileNumber nvarchar(MAX) = NULL,
    @Email nvarchar(MAX) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[ContactInformation] ([ID], [WorkNumber], [MobileNumber], [Email])
	SELECT @ID, @WorkNumber, @MobileNumber, @Email
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [WorkNumber], [MobileNumber], [Email]
	FROM   [dbo].[ContactInformation]
	WHERE  [ID] = @ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ContactInformationSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ContactInformationSelect] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [WorkNumber], [MobileNumber], [Email] 
	FROM   [dbo].[ContactInformation] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ContactInformationUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ContactInformationUpdate] 
    @ID nvarchar(128),
    @WorkNumber nvarchar(MAX) = NULL,
    @MobileNumber nvarchar(MAX) = NULL,
    @Email nvarchar(MAX) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[ContactInformation]
	SET    [WorkNumber] = @WorkNumber, [MobileNumber] = @MobileNumber, [Email] = @Email
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [WorkNumber], [MobileNumber], [Email]
	FROM   [dbo].[ContactInformation]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ContractsDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ContractsDelete] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Contracts]
	WHERE  [ID] = @ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ContractsInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ContractsInsert] 
    @ID nvarchar(128),
    @Type nvarchar(MAX) = NULL,
    @EndDate datetime,
    @ContractID nvarchar(128) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Contracts] ([ID], [Type], [EndDate], [ContractID])
	SELECT @ID, @Type, @EndDate, @ContractID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Type], [EndDate], [ContractID]
	FROM   [dbo].[Contracts]
	WHERE  [ID] = @ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ContractsSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ContractsSelect] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [Type], [EndDate], [ContractID] 
	FROM   [dbo].[Contracts] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ContractsUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ContractsUpdate] 
    @ID nvarchar(128),
    @Type nvarchar(MAX) = NULL,
    @EndDate datetime,
    @ContractID nvarchar(128) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Contracts]
	SET    [Type] = @Type, [EndDate] = @EndDate, [ContractID] = @ContractID
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Type], [EndDate], [ContractID]
	FROM   [dbo].[Contracts]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ContractTypesDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ContractTypesDelete] 
    @ContractID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[ContractTypes]
	WHERE  [ContractID] = @ContractID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ContractTypesInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ContractTypesInsert] 
    @ContractID nvarchar(128),
    @IncludedCreditPercentage float,
    @FreeTechnicalSupport bit,
    @ContractName nvarchar(MAX) = NULL,
    @ServiceLevel int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[ContractTypes] ([ContractID], [IncludedCreditPercentage], [FreeTechnicalSupport], [ContractName], [ServiceLevel])
	SELECT @ContractID, @IncludedCreditPercentage, @FreeTechnicalSupport, @ContractName, @ServiceLevel
	
	-- Begin Return Select <- do not remove
	SELECT [ContractID], [IncludedCreditPercentage], [FreeTechnicalSupport], [ContractName], [ServiceLevel]
	FROM   [dbo].[ContractTypes]
	WHERE  [ContractID] = @ContractID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ContractTypesSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ContractTypesSelect] 
    @ContractID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ContractID], [IncludedCreditPercentage], [FreeTechnicalSupport], [ContractName], [ServiceLevel] 
	FROM   [dbo].[ContractTypes] 
	WHERE  ([ContractID] = @ContractID OR @ContractID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ContractTypesUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ContractTypesUpdate] 
    @ContractID nvarchar(128),
    @IncludedCreditPercentage float,
    @FreeTechnicalSupport bit,
    @ContractName nvarchar(MAX) = NULL,
    @ServiceLevel int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[ContractTypes]
	SET    [IncludedCreditPercentage] = @IncludedCreditPercentage, [FreeTechnicalSupport] = @FreeTechnicalSupport, [ContractName] = @ContractName, [ServiceLevel] = @ServiceLevel
	WHERE  [ContractID] = @ContractID
	
	-- Begin Return Select <- do not remove
	SELECT [ContractID], [IncludedCreditPercentage], [FreeTechnicalSupport], [ContractName], [ServiceLevel]
	FROM   [dbo].[ContractTypes]
	WHERE  [ContractID] = @ContractID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CustomerDelete] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Customer]
	WHERE  [ID] = @ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerEnquiryDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CustomerEnquiryDelete] 
    @TrackingNumber int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[CustomerEnquiry]
	WHERE  [TrackingNumber] = @TrackingNumber

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerEnquiryInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CustomerEnquiryInsert] 
    @EnquiryNote nvarchar(MAX) = NULL,
    @EnquiryDateTime datetime,
    @Customer_ID nvarchar(128) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[CustomerEnquiry] ([EnquiryNote], [EnquiryDateTime], [Customer_ID])
	SELECT @EnquiryNote, @EnquiryDateTime, @Customer_ID
	
	-- Begin Return Select <- do not remove
	SELECT [TrackingNumber], [EnquiryNote], [EnquiryDateTime], [Customer_ID]
	FROM   [dbo].[CustomerEnquiry]
	WHERE  [TrackingNumber] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerEnquirySelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CustomerEnquirySelect] 
    @TrackingNumber int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [TrackingNumber], [EnquiryNote], [EnquiryDateTime], [Customer_ID] 
	FROM   [dbo].[CustomerEnquiry] 
	WHERE  ([TrackingNumber] = @TrackingNumber OR @TrackingNumber IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerEnquiryUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CustomerEnquiryUpdate] 
    @TrackingNumber int,
    @EnquiryNote nvarchar(MAX) = NULL,
    @EnquiryDateTime datetime,
    @Customer_ID nvarchar(128) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CustomerEnquiry]
	SET    [EnquiryNote] = @EnquiryNote, [EnquiryDateTime] = @EnquiryDateTime, [Customer_ID] = @Customer_ID
	WHERE  [TrackingNumber] = @TrackingNumber
	
	-- Begin Return Select <- do not remove
	SELECT [TrackingNumber], [EnquiryNote], [EnquiryDateTime], [Customer_ID]
	FROM   [dbo].[CustomerEnquiry]
	WHERE  [TrackingNumber] = @TrackingNumber	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CustomerInsert] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Customer] ([ID])
	SELECT @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID]
	FROM   [dbo].[Customer]
	WHERE  [ID] = @ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerProductConfigurationDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CustomerProductConfigurationDelete] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[CustomerProductConfiguration]
	WHERE  [ID] = @ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerProductConfigurationInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CustomerProductConfigurationInsert] 
    @ID nvarchar(128),
    @ConfigurationNote nvarchar(MAX) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[CustomerProductConfiguration] ([ID], [ConfigurationNote])
	SELECT @ID, @ConfigurationNote
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [ConfigurationNote]
	FROM   [dbo].[CustomerProductConfiguration]
	WHERE  [ID] = @ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerProductConfigurationSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CustomerProductConfigurationSelect] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [ConfigurationNote] 
	FROM   [dbo].[CustomerProductConfiguration] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerProductConfigurationUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CustomerProductConfigurationUpdate] 
    @ID nvarchar(128),
    @ConfigurationNote nvarchar(MAX) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[CustomerProductConfiguration]
	SET    [ConfigurationNote] = @ConfigurationNote
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [ConfigurationNote]
	FROM   [dbo].[CustomerProductConfiguration]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_CustomerSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CustomerSelect] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID] 
	FROM   [dbo].[Customer] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_EmployeeDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_EmployeeDelete] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Employee]
	WHERE  [ID] = @ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_EmployeeInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_EmployeeInsert] 
    @ID nvarchar(128),
    @Discriminator nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Employee] ([ID], [Discriminator])
	SELECT @ID, @Discriminator
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Discriminator]
	FROM   [dbo].[Employee]
	WHERE  [ID] = @ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_EmployeeSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_EmployeeSelect] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [Discriminator] 
	FROM   [dbo].[Employee] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_EmployeeUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_EmployeeUpdate] 
    @ID nvarchar(128),
    @Discriminator nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Employee]
	SET    [Discriminator] = @Discriminator
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Discriminator]
	FROM   [dbo].[Employee]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_LoginInformationDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_LoginInformationDelete] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[LoginInformation]
	WHERE  [ID] = @ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_LoginInformationInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_LoginInformationInsert] 
    @ID nvarchar(128),
    @AuthenticationLevel int,
    @Password nvarchar(MAX) = NULL,
    @UserName nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[LoginInformation] ([ID], [AuthenticationLevel], [Password], [UserName])
	SELECT @ID, @AuthenticationLevel, @Password, @UserName
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [AuthenticationLevel], [Password], [UserName]
	FROM   [dbo].[LoginInformation]
	WHERE  [ID] = @ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_LoginInformationSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_LoginInformationSelect] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [AuthenticationLevel], [Password], [UserName] 
	FROM   [dbo].[LoginInformation] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_LoginInformationUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_LoginInformationUpdate] 
    @ID nvarchar(128),
    @AuthenticationLevel int,
    @Password nvarchar(MAX) = NULL,
    @UserName nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[LoginInformation]
	SET    [AuthenticationLevel] = @AuthenticationLevel, [Password] = @Password, [UserName] = @UserName
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [AuthenticationLevel], [Password], [UserName]
	FROM   [dbo].[LoginInformation]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_OrderDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_OrderDelete] 
    @TrackingNumber int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Order]
	WHERE  [TrackingNumber] = @TrackingNumber

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_OrderInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_OrderInsert] 
    @TrackingNumber int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Order] ([TrackingNumber])
	SELECT @TrackingNumber
	
	-- Begin Return Select <- do not remove
	SELECT [TrackingNumber]
	FROM   [dbo].[Order]
	WHERE  [TrackingNumber] = @TrackingNumber
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_OrderSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_OrderSelect] 
    @TrackingNumber int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [TrackingNumber] 
	FROM   [dbo].[Order] 
	WHERE  ([TrackingNumber] = @TrackingNumber OR @TrackingNumber IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ProductInstallationHistoryDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ProductInstallationHistoryDelete] 
    @SerialNumber int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[ProductInstallationHistory]
	WHERE  [SerialNumber] = @SerialNumber

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ProductInstallationHistoryInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ProductInstallationHistoryInsert] 
    @SerialNumber int,
    @InstallationDate datetime,
    @InstallationNote nvarchar(MAX) = NULL,
    @Installed bit,
    @InstallationEmployee_ID nvarchar(128) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[ProductInstallationHistory] ([SerialNumber], [InstallationDate], [InstallationNote], [Installed], [InstallationEmployee_ID])
	SELECT @SerialNumber, @InstallationDate, @InstallationNote, @Installed, @InstallationEmployee_ID
	
	-- Begin Return Select <- do not remove
	SELECT [SerialNumber], [InstallationDate], [InstallationNote], [Installed], [InstallationEmployee_ID]
	FROM   [dbo].[ProductInstallationHistory]
	WHERE  [SerialNumber] = @SerialNumber
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ProductInstallationHistorySelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ProductInstallationHistorySelect] 
    @SerialNumber int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [SerialNumber], [InstallationDate], [InstallationNote], [Installed], [InstallationEmployee_ID] 
	FROM   [dbo].[ProductInstallationHistory] 
	WHERE  ([SerialNumber] = @SerialNumber OR @SerialNumber IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ProductInstallationHistoryUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ProductInstallationHistoryUpdate] 
    @SerialNumber int,
    @InstallationDate datetime,
    @InstallationNote nvarchar(MAX) = NULL,
    @Installed bit,
    @InstallationEmployee_ID nvarchar(128) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[ProductInstallationHistory]
	SET    [InstallationDate] = @InstallationDate, [InstallationNote] = @InstallationNote, [Installed] = @Installed, [InstallationEmployee_ID] = @InstallationEmployee_ID
	WHERE  [SerialNumber] = @SerialNumber
	
	-- Begin Return Select <- do not remove
	SELECT [SerialNumber], [InstallationDate], [InstallationNote], [Installed], [InstallationEmployee_ID]
	FROM   [dbo].[ProductInstallationHistory]
	WHERE  [SerialNumber] = @SerialNumber	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ProductsDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ProductsDelete] 
    @SerialNumber int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Products]
	WHERE  [SerialNumber] = @SerialNumber

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ProductsInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ProductsInsert] 
    @StockOutDate datetime,
    @StockInDate datetime,
    @ProductID int,
    @TrackingNumber int,
    @ID nvarchar(128) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Products] ([StockOutDate], [StockInDate], [ProductID], [TrackingNumber], [ID])
	SELECT @StockOutDate, @StockInDate, @ProductID, @TrackingNumber, @ID
	
	-- Begin Return Select <- do not remove
	SELECT [SerialNumber], [StockOutDate], [StockInDate], [ProductID], [TrackingNumber], [ID]
	FROM   [dbo].[Products]
	WHERE  [SerialNumber] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ProductsSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ProductsSelect] 
    @SerialNumber int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [SerialNumber], [StockOutDate], [StockInDate], [ProductID], [TrackingNumber], [ID] 
	FROM   [dbo].[Products] 
	WHERE  ([SerialNumber] = @SerialNumber OR @SerialNumber IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ProductsUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ProductsUpdate] 
    @SerialNumber int,
    @StockOutDate datetime,
    @StockInDate datetime,
    @ProductID int,
    @TrackingNumber int,
    @ID nvarchar(128) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Products]
	SET    [StockOutDate] = @StockOutDate, [StockInDate] = @StockInDate, [ProductID] = @ProductID, [TrackingNumber] = @TrackingNumber, [ID] = @ID
	WHERE  [SerialNumber] = @SerialNumber
	
	-- Begin Return Select <- do not remove
	SELECT [SerialNumber], [StockOutDate], [StockInDate], [ProductID], [TrackingNumber], [ID]
	FROM   [dbo].[Products]
	WHERE  [SerialNumber] = @SerialNumber	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ProductTypesDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ProductTypesDelete] 
    @ProductID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[ProductTypes]
	WHERE  [ProductID] = @ProductID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ProductTypesInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ProductTypesInsert] 
    @WarrantyDuration int,
    @ProductName nvarchar(MAX) = NULL,
    @QuantityInStock int,
    @ProductImage varbinary(MAX) = NULL,
    @ProductDescription nvarchar(MAX) = NULL,
    @Price float
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[ProductTypes] ([WarrantyDuration], [ProductName], [QuantityInStock], [ProductImage], [ProductDescription], [Price])
	SELECT @WarrantyDuration, @ProductName, @QuantityInStock, @ProductImage, @ProductDescription, @Price
	
	-- Begin Return Select <- do not remove
	SELECT [ProductID], [WarrantyDuration], [ProductName], [QuantityInStock], [ProductImage], [ProductDescription], [Price]
	FROM   [dbo].[ProductTypes]
	WHERE  [ProductID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ProductTypesSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ProductTypesSelect] 
    @ProductID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ProductID], [WarrantyDuration], [ProductName], [QuantityInStock], [ProductImage], [ProductDescription], [Price] 
	FROM   [dbo].[ProductTypes] 
	WHERE  ([ProductID] = @ProductID OR @ProductID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ProductTypesUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ProductTypesUpdate] 
    @ProductID int,
    @WarrantyDuration int,
    @ProductName nvarchar(MAX) = NULL,
    @QuantityInStock int,
    @ProductImage varbinary(MAX) = NULL,
    @ProductDescription nvarchar(MAX) = NULL,
    @Price float
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[ProductTypes]
	SET    [WarrantyDuration] = @WarrantyDuration, [ProductName] = @ProductName, [QuantityInStock] = @QuantityInStock, [ProductImage] = @ProductImage, [ProductDescription] = @ProductDescription, [Price] = @Price
	WHERE  [ProductID] = @ProductID
	
	-- Begin Return Select <- do not remove
	SELECT [ProductID], [WarrantyDuration], [ProductName], [QuantityInStock], [ProductImage], [ProductDescription], [Price]
	FROM   [dbo].[ProductTypes]
	WHERE  [ProductID] = @ProductID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_SchedulesDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_SchedulesDelete] 
    @ScheduleID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Schedules]
	WHERE  [ScheduleID] = @ScheduleID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_SchedulesInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_SchedulesInsert] 
    @ScheduleDate datetime,
    @ID nvarchar(128) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Schedules] ([ScheduleDate], [ID])
	SELECT @ScheduleDate, @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ScheduleID], [ScheduleDate], [ID]
	FROM   [dbo].[Schedules]
	WHERE  [ScheduleID] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_SchedulesSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_SchedulesSelect] 
    @ScheduleID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ScheduleID], [ScheduleDate], [ID] 
	FROM   [dbo].[Schedules] 
	WHERE  ([ScheduleID] = @ScheduleID OR @ScheduleID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_SchedulesUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_SchedulesUpdate] 
    @ScheduleID int,
    @ScheduleDate datetime,
    @ID nvarchar(128) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Schedules]
	SET    [ScheduleDate] = @ScheduleDate, [ID] = @ID
	WHERE  [ScheduleID] = @ScheduleID
	
	-- Begin Return Select <- do not remove
	SELECT [ScheduleID], [ScheduleDate], [ID]
	FROM   [dbo].[Schedules]
	WHERE  [ScheduleID] = @ScheduleID	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TechnicalSupportEmployeeDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TechnicalSupportEmployeeDelete] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[TechnicalSupportEmployee]
	WHERE  [ID] = @ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TechnicalSupportEmployeeInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TechnicalSupportEmployeeInsert] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[TechnicalSupportEmployee] ([ID])
	SELECT @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID]
	FROM   [dbo].[TechnicalSupportEmployee]
	WHERE  [ID] = @ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TechnicalSupportEmployeeSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TechnicalSupportEmployeeSelect] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID] 
	FROM   [dbo].[TechnicalSupportEmployee] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TechnicalSupportEnquiryDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TechnicalSupportEnquiryDelete] 
    @TrackingNumber int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[TechnicalSupportEnquiry]
	WHERE  [TrackingNumber] = @TrackingNumber

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TechnicalSupportEnquiryInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TechnicalSupportEnquiryInsert] 
    @TrackingNumber int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[TechnicalSupportEnquiry] ([TrackingNumber])
	SELECT @TrackingNumber
	
	-- Begin Return Select <- do not remove
	SELECT [TrackingNumber]
	FROM   [dbo].[TechnicalSupportEnquiry]
	WHERE  [TrackingNumber] = @TrackingNumber
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TechnicalSupportEnquirySelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TechnicalSupportEnquirySelect] 
    @TrackingNumber int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [TrackingNumber] 
	FROM   [dbo].[TechnicalSupportEnquiry] 
	WHERE  ([TrackingNumber] = @TrackingNumber OR @TrackingNumber IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TechnicalTasksDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TechnicalTasksDelete] 
    @TrackingNumber int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[TechnicalTasks]
	WHERE  [TrackingNumber] = @TrackingNumber

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TechnicalTasksInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TechnicalTasksInsert] 
    @TrackingNumber int,
    @Completed bit = NULL,
    @TaskDescription nvarchar(MAX) = NULL,
    @TaskTime datetime = NULL,
    @ScheduleID int = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[TechnicalTasks] ([TrackingNumber], [Completed], [TaskDescription], [TaskTime], [ScheduleID])
	SELECT @TrackingNumber, @Completed, @TaskDescription, @TaskTime, @ScheduleID
	
	-- Begin Return Select <- do not remove
	SELECT [TrackingNumber], [Completed], [TaskDescription], [TaskTime], [ScheduleID]
	FROM   [dbo].[TechnicalTasks]
	WHERE  [TrackingNumber] = @TrackingNumber
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TechnicalTasksSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TechnicalTasksSelect] 
    @TrackingNumber int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [TrackingNumber], [Completed], [TaskDescription], [TaskTime], [ScheduleID] 
	FROM   [dbo].[TechnicalTasks] 
	WHERE  ([TrackingNumber] = @TrackingNumber OR @TrackingNumber IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_TechnicalTasksUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_TechnicalTasksUpdate] 
    @TrackingNumber int,
    @Completed bit = NULL,
    @TaskDescription nvarchar(MAX) = NULL,
    @TaskTime datetime = NULL,
    @ScheduleID int = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[TechnicalTasks]
	SET    [Completed] = @Completed, [TaskDescription] = @TaskDescription, [TaskTime] = @TaskTime, [ScheduleID] = @ScheduleID
	WHERE  [TrackingNumber] = @TrackingNumber
	
	-- Begin Return Select <- do not remove
	SELECT [TrackingNumber], [Completed], [TaskDescription], [TaskTime], [ScheduleID]
	FROM   [dbo].[TechnicalTasks]
	WHERE  [TrackingNumber] = @TrackingNumber	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_UsersDelete]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UsersDelete] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Users]
	WHERE  [ID] = @ID

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_UsersInsert]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UsersInsert] 
    @ID nvarchar(128),
    @Title nvarchar(MAX) = NULL,
    @DateOfBirth datetime,
    @Gender nvarchar(MAX) = NULL,
    @Surname nvarchar(MAX) = NULL,
    @FullName nvarchar(MAX) = NULL,
    @Name nvarchar(MAX) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Users] ([ID], [Title], [DateOfBirth], [Gender], [Surname], [FullName], [Name])
	SELECT @ID, @Title, @DateOfBirth, @Gender, @Surname, @FullName, @Name
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Title], [DateOfBirth], [Gender], [Surname], [FullName], [Name]
	FROM   [dbo].[Users]
	WHERE  [ID] = @ID
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_UsersSelect]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UsersSelect] 
    @ID nvarchar(128)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ID], [Title], [DateOfBirth], [Gender], [Surname], [FullName], [Name] 
	FROM   [dbo].[Users] 
	WHERE  ([ID] = @ID OR @ID IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_UsersUpdate]    Script Date: 04 Jun 2018 12:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UsersUpdate] 
    @ID nvarchar(128),
    @Title nvarchar(MAX) = NULL,
    @DateOfBirth datetime,
    @Gender nvarchar(MAX) = NULL,
    @Surname nvarchar(MAX) = NULL,
    @FullName nvarchar(MAX) = NULL,
    @Name nvarchar(MAX) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Users]
	SET    [Title] = @Title, [DateOfBirth] = @DateOfBirth, [Gender] = @Gender, [Surname] = @Surname, [FullName] = @FullName, [Name] = @Name
	WHERE  [ID] = @ID
	
	-- Begin Return Select <- do not remove
	SELECT [ID], [Title], [DateOfBirth], [Gender], [Surname], [FullName], [Name]
	FROM   [dbo].[Users]
	WHERE  [ID] = @ID	
	-- End Return Select <- do not remove

	COMMIT
GO
USE [master]
GO
ALTER DATABASE [SHSManagementDB] SET  READ_WRITE 
GO
