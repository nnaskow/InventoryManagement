USE [master]
GO
/****** Object:  Database [InventoryManagement]    Script Date: 15.5.2025 9:39:45 ******/
CREATE DATABASE [InventoryManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InventoryManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\InventoryManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InventoryManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\InventoryManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [InventoryManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InventoryManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InventoryManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InventoryManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InventoryManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InventoryManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InventoryManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [InventoryManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [InventoryManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InventoryManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InventoryManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InventoryManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InventoryManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InventoryManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InventoryManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InventoryManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InventoryManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [InventoryManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InventoryManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InventoryManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InventoryManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InventoryManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InventoryManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InventoryManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InventoryManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [InventoryManagement] SET  MULTI_USER 
GO
ALTER DATABASE [InventoryManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InventoryManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InventoryManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InventoryManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InventoryManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [InventoryManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [InventoryManagement] SET QUERY_STORE = OFF
GO
USE [InventoryManagement]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 15.5.2025 9:39:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[description] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 15.5.2025 9:39:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[category_id] [int] NULL,
	[supplier_id] [int] NULL,
	[quantity] [int] NULL,
	[last_updated] [date] NULL,
	[price] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suppliers]    Script Date: 15.5.2025 9:39:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suppliers](
	[supplier_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[contact_name] [varchar](100) NULL,
	[phone] [varchar](20) NULL,
	[email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[supplier_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transactions]    Script Date: 15.5.2025 9:39:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transactions](
	[transaction_id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
	[transaction_type] [varchar](10) NULL,
	[quantity] [int] NULL,
	[transaction_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[transaction_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[categories] ON 

INSERT [dbo].[categories] ([category_id], [name], [description]) VALUES (1, N'Electronics', N'Devices and gadgets')
INSERT [dbo].[categories] ([category_id], [name], [description]) VALUES (2, N'Furniture', N'Office and home furniture')
INSERT [dbo].[categories] ([category_id], [name], [description]) VALUES (3, N'Stationery Items', N'Office supplies and paper products')
INSERT [dbo].[categories] ([category_id], [name], [description]) VALUES (4, N'Clothing', N'Apparel and accessories')
INSERT [dbo].[categories] ([category_id], [name], [description]) VALUES (5, N'Groceries', N'Food and daily essentials')
INSERT [dbo].[categories] ([category_id], [name], [description]) VALUES (6, N'Spare Parts', NULL)
INSERT [dbo].[categories] ([category_id], [name], [description]) VALUES (7, N'Toys', NULL)
SET IDENTITY_INSERT [dbo].[categories] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([product_id], [name], [category_id], [supplier_id], [quantity], [last_updated], [price]) VALUES (1, N'Smartphone X', 1, 1, 50, CAST(N'2025-04-01' AS Date), CAST(599.99 AS Decimal(10, 2)))
INSERT [dbo].[products] ([product_id], [name], [category_id], [supplier_id], [quantity], [last_updated], [price]) VALUES (2, N'Office Chair', 2, 2, 30, CAST(N'2025-04-02' AS Date), CAST(149.99 AS Decimal(10, 2)))
INSERT [dbo].[products] ([product_id], [name], [category_id], [supplier_id], [quantity], [last_updated], [price]) VALUES (3, N'A4 Paper Pack', 3, 3, 200, CAST(N'2025-04-03' AS Date), CAST(5.99 AS Decimal(10, 2)))
INSERT [dbo].[products] ([product_id], [name], [category_id], [supplier_id], [quantity], [last_updated], [price]) VALUES (4, N'Men T-Shirt', 4, 4, 80, CAST(N'2025-04-04' AS Date), CAST(12.49 AS Decimal(10, 2)))
INSERT [dbo].[products] ([product_id], [name], [category_id], [supplier_id], [quantity], [last_updated], [price]) VALUES (5, N'Organic Milk', 5, 5, 120, CAST(N'2025-04-05' AS Date), CAST(2.99 AS Decimal(10, 2)))
INSERT [dbo].[products] ([product_id], [name], [category_id], [supplier_id], [quantity], [last_updated], [price]) VALUES (6, N'Iphone XR', 3, 3, 4, CAST(N'2020-02-04' AS Date), CAST(800.00 AS Decimal(10, 2)))
INSERT [dbo].[products] ([product_id], [name], [category_id], [supplier_id], [quantity], [last_updated], [price]) VALUES (7, N'Samsung', 1, 1, 2, CAST(N'2025-02-04' AS Date), CAST(1000.00 AS Decimal(10, 2)))
INSERT [dbo].[products] ([product_id], [name], [category_id], [supplier_id], [quantity], [last_updated], [price]) VALUES (8, N'Sofa', 2, 2, 10, NULL, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[products] ([product_id], [name], [category_id], [supplier_id], [quantity], [last_updated], [price]) VALUES (9, N'Keyboard', 1, 1, 13, CAST(N'2025-05-12' AS Date), CAST(1.99 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[suppliers] ON 

INSERT [dbo].[suppliers] ([supplier_id], [name], [contact_name], [phone], [email]) VALUES (1, N'ElectroMax', N'John Doe', N'123-456-7890', N'john@electromax.com')
INSERT [dbo].[suppliers] ([supplier_id], [name], [contact_name], [phone], [email]) VALUES (2, N'FurniCraft', N'Jane Smith', N'234-567-8901', N'jane@furnicraft.com')
INSERT [dbo].[suppliers] ([supplier_id], [name], [contact_name], [phone], [email]) VALUES (3, N'PaperHouse', N'Lisa White', N'345-678-9012', N'lisa@paperhouse.com')
INSERT [dbo].[suppliers] ([supplier_id], [name], [contact_name], [phone], [email]) VALUES (4, N'WearZone', N'Mike Brown', N'456-789-0123', N'mike@wearzone.com')
INSERT [dbo].[suppliers] ([supplier_id], [name], [contact_name], [phone], [email]) VALUES (5, N'FreshMart', N'Anna Green', N'567-890-1234', N'anna@freshmart.com')
SET IDENTITY_INSERT [dbo].[suppliers] OFF
GO
SET IDENTITY_INSERT [dbo].[transactions] ON 

INSERT [dbo].[transactions] ([transaction_id], [product_id], [transaction_type], [quantity], [transaction_date]) VALUES (1, 1, N'OUT', 5, CAST(N'2025-04-03' AS Date))
INSERT [dbo].[transactions] ([transaction_id], [product_id], [transaction_type], [quantity], [transaction_date]) VALUES (2, 2, N'IN', 10, CAST(N'2025-04-03' AS Date))
INSERT [dbo].[transactions] ([transaction_id], [product_id], [transaction_type], [quantity], [transaction_date]) VALUES (3, 3, N'OUT', 20, CAST(N'2025-04-04' AS Date))
INSERT [dbo].[transactions] ([transaction_id], [product_id], [transaction_type], [quantity], [transaction_date]) VALUES (4, 4, N'OUT', 10, CAST(N'2025-04-05' AS Date))
INSERT [dbo].[transactions] ([transaction_id], [product_id], [transaction_type], [quantity], [transaction_date]) VALUES (5, 5, N'IN', 50, CAST(N'2025-04-05' AS Date))
INSERT [dbo].[transactions] ([transaction_id], [product_id], [transaction_type], [quantity], [transaction_date]) VALUES (6, 9, N'IN', 10, CAST(N'2025-05-12' AS Date))
INSERT [dbo].[transactions] ([transaction_id], [product_id], [transaction_type], [quantity], [transaction_date]) VALUES (7, 9, N'OUT', 5, CAST(N'2025-05-12' AS Date))
INSERT [dbo].[transactions] ([transaction_id], [product_id], [transaction_type], [quantity], [transaction_date]) VALUES (8, 9, N'OUT', 2, CAST(N'2025-01-02' AS Date))
SET IDENTITY_INSERT [dbo].[transactions] OFF
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD FOREIGN KEY([category_id])
REFERENCES [dbo].[categories] ([category_id])
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD FOREIGN KEY([supplier_id])
REFERENCES [dbo].[suppliers] ([supplier_id])
GO
ALTER TABLE [dbo].[transactions]  WITH CHECK ADD  CONSTRAINT [FK_transacti_produ_6477ECF3] FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([product_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[transactions] CHECK CONSTRAINT [FK_transacti_produ_6477ECF3]
GO
USE [master]
GO
ALTER DATABASE [InventoryManagement] SET  READ_WRITE 
GO
