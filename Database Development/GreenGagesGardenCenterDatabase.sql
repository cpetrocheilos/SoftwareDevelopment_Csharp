CREATE DATABASE [GreengagesGardenCenter];
GO
USE [GreengagesGardenCenter]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 12-Jan-18 2:34:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_first_name] [char](10) NULL,
	[customer_last_name] [char](15) NULL,
	[customer_street] [varchar](50) NULL,
	[customer_city] [varchar](15) NULL,
	[customer_state] [varchar](10) NULL,
	[customer_zipcode] [char](6) NULL,
	[customer_phone] [char](12) NULL,
	[customer_email] [char](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customers_orders]    Script Date: 12-Jan-18 2:34:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers_orders](
	[customer_order_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NULL,
	[order_date] [datetime] NULL,
	[payment_method] [varchar](15) NULL,
	[discount] [char](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[customer_order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customers_orders_lines]    Script Date: 12-Jan-18 2:34:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers_orders_lines](
	[customer_order_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[product_quantity] [int] NULL,
	[cost_each] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[customer_order_id] ASC,
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[location_address]    Script Date: 12-Jan-18 2:34:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[location_address](
	[location_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[product_quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[location_id] ASC,
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[payment_types]    Script Date: 12-Jan-18 2:34:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payment_types](
	[payment_method] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[payment_method] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product_location]    Script Date: 12-Jan-18 2:34:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_location](
	[location_id] [int] IDENTITY(1,1) NOT NULL,
	[location_name] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[location_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product_season]    Script Date: 12-Jan-18 2:34:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_season](
	[season_id] [int] IDENTITY(1,1) NOT NULL,
	[season_period] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[season_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 12-Jan-18 2:34:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[stock_id]  AS (concat(upper(left([product_type],(3))),[product_id]+(100000))),
	[product_name] [char](50) NULL,
	[product_description] [varchar](100) NULL,
	[product_status] [char](10) NULL,
	[supplier_id] [int] NULL,
	[product_type] [char](20) NOT NULL,
	[season_id] [int] NULL,
	[product_cost_each] [decimal](10, 2) NULL,
	[product_manufacturer] [char](20) NULL,
	[product_expired_date] [char](5) NULL,
 CONSTRAINT [PK__products__47027DF5C744463C] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products_types]    Script Date: 12-Jan-18 2:34:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products_types](
	[product_type] [char](20) NOT NULL,
	[guarantee] [char](1) NULL,
	[guarantee_duaration] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[product_type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reservations]    Script Date: 12-Jan-18 2:34:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservations](
	[reservation_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NOT NULL,
	[reservation_date] [datetime] NULL,
	[reservation_field] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[reservation_id] ASC,
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reservations_lines]    Script Date: 12-Jan-18 2:34:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservations_lines](
	[reservation_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[product_quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[reservation_id] ASC,
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suppliers]    Script Date: 12-Jan-18 2:34:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suppliers](
	[supplier_id] [int] IDENTITY(1,1) NOT NULL,
	[supplier_name] [char](20) NULL,
	[supplier_status] [char](10) NULL,
	[supplier_street] [varchar](50) NULL,
	[supplier_city] [varchar](15) NULL,
	[supplier_state] [varchar](10) NULL,
	[supplier_zipcode] [char](6) NULL,
	[supplier_phone] [char](12) NULL,
	[supplier_email] [char](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[supplier_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customers] ON 

INSERT [dbo].[customers] ([customer_id], [customer_first_name], [customer_last_name], [customer_street], [customer_city], [customer_state], [customer_zipcode], [customer_phone], [customer_email]) VALUES (1, N'Jane      ', N'Jones          ', N'125 W. 88th Blvd.', N'Plymouth', N'Devon', N'PL01QS', N'552-555-1234', N'jane_jones@anywhere.net                 ')
INSERT [dbo].[customers] ([customer_id], [customer_first_name], [customer_last_name], [customer_street], [customer_city], [customer_state], [customer_zipcode], [customer_phone], [customer_email]) VALUES (2, N'Tom       ', N'Smith          ', N'4592 Maple Lane', N'Bristol', N'Devon', N'PL345P', N'555-555-4321', N'tom_smith@this.net                      ')
INSERT [dbo].[customers] ([customer_id], [customer_first_name], [customer_last_name], [customer_street], [customer_city], [customer_state], [customer_zipcode], [customer_phone], [customer_email]) VALUES (3, N'Mary      ', N'Johnson        ', N'98 Elm St.', N'Plymouth', N'Devon', N'PZ456X', N'551-555-4567', N'mary_johnson@somewhere.net              ')
INSERT [dbo].[customers] ([customer_id], [customer_first_name], [customer_last_name], [customer_street], [customer_city], [customer_state], [customer_zipcode], [customer_phone], [customer_email]) VALUES (4, N'John      ', N'Smith          ', N'867 Apple Tree Road', N'Plymouth', N'Devon', N'ZM11SS', N'552-555-9876', N'john_smith@somewhere.net                ')
INSERT [dbo].[customers] ([customer_id], [customer_first_name], [customer_last_name], [customer_street], [customer_city], [customer_state], [customer_zipcode], [customer_phone], [customer_email]) VALUES (5, N'Emily     ', N'Jones          ', N'7921 Fir Road', N'Bristol', N'Devon', N'ZM44XX', N'555-555-7654', N'emily_jones@somewhere.net               ')
SET IDENTITY_INSERT [dbo].[customers] OFF
SET IDENTITY_INSERT [dbo].[customers_orders] ON 

INSERT [dbo].[customers_orders] ([customer_order_id], [customer_id], [order_date], [payment_method], [discount]) VALUES (1, 2, CAST(N'2017-05-12T00:00:00.000' AS DateTime), N'Cash', N'0% ')
INSERT [dbo].[customers_orders] ([customer_order_id], [customer_id], [order_date], [payment_method], [discount]) VALUES (2, 4, CAST(N'2017-06-12T00:00:00.000' AS DateTime), N'Cash', N'0% ')
INSERT [dbo].[customers_orders] ([customer_order_id], [customer_id], [order_date], [payment_method], [discount]) VALUES (3, 4, CAST(N'2017-06-14T00:00:00.000' AS DateTime), N'Credit Card', N'0% ')
INSERT [dbo].[customers_orders] ([customer_order_id], [customer_id], [order_date], [payment_method], [discount]) VALUES (4, 5, CAST(N'2017-08-24T00:00:00.000' AS DateTime), N'Debit Card', N'0% ')
INSERT [dbo].[customers_orders] ([customer_order_id], [customer_id], [order_date], [payment_method], [discount]) VALUES (5, 2, CAST(N'2017-10-14T00:00:00.000' AS DateTime), N'Credit Card', N'0% ')
SET IDENTITY_INSERT [dbo].[customers_orders] OFF
INSERT [dbo].[customers_orders_lines] ([customer_order_id], [product_id], [product_quantity], [cost_each]) VALUES (1, 1, 3, CAST(50.00 AS Decimal(18, 2)))
INSERT [dbo].[customers_orders_lines] ([customer_order_id], [product_id], [product_quantity], [cost_each]) VALUES (1, 2, 10, CAST(0.50 AS Decimal(18, 2)))
INSERT [dbo].[customers_orders_lines] ([customer_order_id], [product_id], [product_quantity], [cost_each]) VALUES (1, 3, 1, CAST(25.20 AS Decimal(18, 2)))
INSERT [dbo].[customers_orders_lines] ([customer_order_id], [product_id], [product_quantity], [cost_each]) VALUES (2, 5, 1, CAST(1500.00 AS Decimal(18, 2)))
INSERT [dbo].[customers_orders_lines] ([customer_order_id], [product_id], [product_quantity], [cost_each]) VALUES (3, 4, 1, CAST(18.90 AS Decimal(18, 2)))
INSERT [dbo].[customers_orders_lines] ([customer_order_id], [product_id], [product_quantity], [cost_each]) VALUES (4, 4, 3, CAST(18.90 AS Decimal(18, 2)))
INSERT [dbo].[customers_orders_lines] ([customer_order_id], [product_id], [product_quantity], [cost_each]) VALUES (5, 1, 4, CAST(50.00 AS Decimal(18, 2)))
INSERT [dbo].[customers_orders_lines] ([customer_order_id], [product_id], [product_quantity], [cost_each]) VALUES (5, 2, 4, CAST(0.50 AS Decimal(18, 2)))
INSERT [dbo].[customers_orders_lines] ([customer_order_id], [product_id], [product_quantity], [cost_each]) VALUES (5, 3, 2, CAST(25.20 AS Decimal(18, 2)))
INSERT [dbo].[location_address] ([location_id], [product_id], [product_quantity]) VALUES (1, 1, 40)
INSERT [dbo].[location_address] ([location_id], [product_id], [product_quantity]) VALUES (1, 2, 76)
INSERT [dbo].[location_address] ([location_id], [product_id], [product_quantity]) VALUES (1, 3, 28)
INSERT [dbo].[location_address] ([location_id], [product_id], [product_quantity]) VALUES (1, 4, 24)
INSERT [dbo].[location_address] ([location_id], [product_id], [product_quantity]) VALUES (1, 5, 3)
INSERT [dbo].[location_address] ([location_id], [product_id], [product_quantity]) VALUES (2, 5, 6)
INSERT [dbo].[location_address] ([location_id], [product_id], [product_quantity]) VALUES (3, 2, 10)
INSERT [dbo].[location_address] ([location_id], [product_id], [product_quantity]) VALUES (6, 1, 43)
INSERT [dbo].[location_address] ([location_id], [product_id], [product_quantity]) VALUES (7, 3, 9)
INSERT [dbo].[location_address] ([location_id], [product_id], [product_quantity]) VALUES (7, 4, 12)
INSERT [dbo].[payment_types] ([payment_method]) VALUES (N'Cash')
INSERT [dbo].[payment_types] ([payment_method]) VALUES (N'Credit Card')
INSERT [dbo].[payment_types] ([payment_method]) VALUES (N'Debit Card')
SET IDENTITY_INSERT [dbo].[product_location] ON 

INSERT [dbo].[product_location] ([location_id], [location_name]) VALUES (1, N'Retail Area')
INSERT [dbo].[product_location] ([location_id], [location_name]) VALUES (2, N'Machinery Area')
INSERT [dbo].[product_location] ([location_id], [location_name]) VALUES (3, N'Sheeds Area')
INSERT [dbo].[product_location] ([location_id], [location_name]) VALUES (4, N'Trees')
INSERT [dbo].[product_location] ([location_id], [location_name]) VALUES (5, N'Garden tools Area')
INSERT [dbo].[product_location] ([location_id], [location_name]) VALUES (6, N'Medicines Area')
SET IDENTITY_INSERT [dbo].[product_location] OFF
SET IDENTITY_INSERT [dbo].[product_season] ON 

INSERT [dbo].[product_season] ([season_id], [season_period]) VALUES (1, N'All year')
INSERT [dbo].[product_season] ([season_id], [season_period]) VALUES (2, N'Summer')
INSERT [dbo].[product_season] ([season_id], [season_period]) VALUES (3, N'Winter')
INSERT [dbo].[product_season] ([season_id], [season_period]) VALUES (4, N'Autumn')
INSERT [dbo].[product_season] ([season_id], [season_period]) VALUES (5, N'Spring')
SET IDENTITY_INSERT [dbo].[product_season] OFF
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([product_id], [product_name], [product_description], [product_status], [supplier_id], [product_type], [season_id], [product_cost_each], [product_manufacturer], [product_expired_date]) VALUES (1, N'Fertilizer                                        ', N'fertilizer to keep you plants healthy 10kg', N'Unvailable', 3, N'Medicines           ', 1, CAST(50.00 AS Decimal(10, 2)), N'Bluefarm            ', N'08/20')
INSERT [dbo].[products] ([product_id], [product_name], [product_description], [product_status], [supplier_id], [product_type], [season_id], [product_cost_each], [product_manufacturer], [product_expired_date]) VALUES (2, N'Basil Sheeds                                      ', N'This is sheeds for the big leaf basil', N'Available ', 2, N'Sheeds              ', 2, CAST(0.50 AS Decimal(10, 2)), N'Sheeders            ', N'10/20')
INSERT [dbo].[products] ([product_id], [product_name], [product_description], [product_status], [supplier_id], [product_type], [season_id], [product_cost_each], [product_manufacturer], [product_expired_date]) VALUES (3, N'Olive Tree                                        ', N'2 meter olive tree', N'Available ', 2, N'Trees               ', 3, CAST(25.20 AS Decimal(10, 2)), N'Sheeders            ', NULL)
INSERT [dbo].[products] ([product_id], [product_name], [product_description], [product_status], [supplier_id], [product_type], [season_id], [product_cost_each], [product_manufacturer], [product_expired_date]) VALUES (4, N'Peach Tree                                        ', N'Young peach tree', N'Available ', 2, N'Trees               ', 2, CAST(18.90 AS Decimal(10, 2)), N'Sheeders            ', NULL)
INSERT [dbo].[products] ([product_id], [product_name], [product_description], [product_status], [supplier_id], [product_type], [season_id], [product_cost_each], [product_manufacturer], [product_expired_date]) VALUES (5, N'Lawn Mower                                        ', N'This is the bosh petrol lawn mawer', N'Avaliable ', 1, N'Machinery           ', 1, CAST(1500.00 AS Decimal(10, 2)), N'Bosh                ', NULL)
SET IDENTITY_INSERT [dbo].[products] OFF
INSERT [dbo].[products_types] ([product_type], [guarantee], [guarantee_duaration]) VALUES (N'Garden tools        ', N'Y', 2)
INSERT [dbo].[products_types] ([product_type], [guarantee], [guarantee_duaration]) VALUES (N'Machinery           ', N'Y', 2)
INSERT [dbo].[products_types] ([product_type], [guarantee], [guarantee_duaration]) VALUES (N'Medicines           ', N'N', 0)
INSERT [dbo].[products_types] ([product_type], [guarantee], [guarantee_duaration]) VALUES (N'Pots                ', N'N', 0)
INSERT [dbo].[products_types] ([product_type], [guarantee], [guarantee_duaration]) VALUES (N'Sheeds              ', N'N', 0)
INSERT [dbo].[products_types] ([product_type], [guarantee], [guarantee_duaration]) VALUES (N'Trees               ', N'N', 0)
INSERT [dbo].[products_types] ([product_type], [guarantee], [guarantee_duaration]) VALUES (N'Trimber             ', N'N', 0)
SET IDENTITY_INSERT [dbo].[reservations] ON 

INSERT [dbo].[reservations] ([reservation_id], [customer_id], [reservation_date], [reservation_field]) VALUES (1, 1, CAST(N'2017-05-12T00:00:00.000' AS DateTime), N'N')
INSERT [dbo].[reservations] ([reservation_id], [customer_id], [reservation_date], [reservation_field]) VALUES (2, 4, CAST(N'2017-06-11T00:00:00.000' AS DateTime), N'Y')
INSERT [dbo].[reservations] ([reservation_id], [customer_id], [reservation_date], [reservation_field]) VALUES (3, 3, CAST(N'2017-11-28T00:00:00.000' AS DateTime), N'N')
SET IDENTITY_INSERT [dbo].[reservations] OFF
INSERT [dbo].[reservations_lines] ([reservation_id], [product_id], [product_quantity]) VALUES (1, 3, 4)
INSERT [dbo].[reservations_lines] ([reservation_id], [product_id], [product_quantity]) VALUES (2, 5, 1)
INSERT [dbo].[reservations_lines] ([reservation_id], [product_id], [product_quantity]) VALUES (3, 5, 1)
SET IDENTITY_INSERT [dbo].[suppliers] ON 

INSERT [dbo].[suppliers] ([supplier_id], [supplier_name], [supplier_status], [supplier_street], [supplier_city], [supplier_state], [supplier_zipcode], [supplier_phone], [supplier_email]) VALUES (1, N'Gardeners           ', N'Active    ', N'29 Cobourg Street', N'Plymouth', N'Devon', N'PL11ER', N'020-345-3453', N'info@greengardens.uk                    ')
INSERT [dbo].[suppliers] ([supplier_id], [supplier_name], [supplier_status], [supplier_street], [supplier_city], [supplier_state], [supplier_zipcode], [supplier_phone], [supplier_email]) VALUES (2, N'Sheeders            ', N'Active    ', N'12 Paradice Street', N'Plymouth', N'Devon', N'PL11XZ', N'020-323-4098', N'info@sheeders.uk                        ')
INSERT [dbo].[suppliers] ([supplier_id], [supplier_name], [supplier_status], [supplier_street], [supplier_city], [supplier_state], [supplier_zipcode], [supplier_phone], [supplier_email]) VALUES (3, N'Bluefarm            ', N'Active    ', N'123 Heaven Steet', N'Bristol', N'Devon', N'PL12OO', N'098-098-0988', N'bluefarm@something.uk                   ')
SET IDENTITY_INSERT [dbo].[suppliers] OFF
ALTER TABLE [dbo].[customers_orders] ADD  DEFAULT (getdate()) FOR [order_date]
GO
ALTER TABLE [dbo].[customers_orders] ADD  DEFAULT ('0%') FOR [discount]
GO
ALTER TABLE [dbo].[reservations] ADD  DEFAULT (getdate()) FOR [reservation_date]
GO
ALTER TABLE [dbo].[customers_orders]  WITH CHECK ADD  CONSTRAINT [FK_customer_orders] FOREIGN KEY([customer_id])
REFERENCES [dbo].[customers] ([customer_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[customers_orders] CHECK CONSTRAINT [FK_customer_orders]
GO
ALTER TABLE [dbo].[customers_orders_lines]  WITH CHECK ADD  CONSTRAINT [FK_customers_orders_lines_customers_orders_lines] FOREIGN KEY([customer_order_id], [product_id])
REFERENCES [dbo].[customers_orders_lines] ([customer_order_id], [product_id])
GO
ALTER TABLE [dbo].[customers_orders_lines] CHECK CONSTRAINT [FK_customers_orders_lines_customers_orders_lines]
GO
ALTER TABLE [dbo].[reservations]  WITH CHECK ADD  CONSTRAINT [FK_reservations] FOREIGN KEY([customer_id])
REFERENCES [dbo].[customers] ([customer_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[reservations] CHECK CONSTRAINT [FK_reservations]
GO
ALTER TABLE [dbo].[reservations_lines]  WITH CHECK ADD  CONSTRAINT [FK_reservations_lines] FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([product_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[reservations_lines] CHECK CONSTRAINT [FK_reservations_lines]
GO
/****** Object:  StoredProcedure [dbo].[WarehouseCheck]    Script Date: 12-Jan-18 2:34:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Charalampos Petrocheilos
-- Create date: 12/01/18
-- Description:	This prosedure returns the weekly warehouse view
-- =============================================
CREATE PROCEDURE [dbo].[WarehouseCheck] 
	-- Add the parameters for the stored procedure here
	@location_id int = 1, 
	@quantity int = 30
AS
BEGIN
	SELECT       dbo.products.stock_id,  dbo.products.product_name, dbo.location_address.product_quantity, dbo.suppliers.supplier_name
	FROM            dbo.products
	INNER JOIN dbo.location_address ON dbo.products.product_id = dbo.location_address.product_id
	INNER JOIN dbo.suppliers ON dbo.products.supplier_id =  dbo.suppliers.supplier_id
	where  location_id = @location_id AND product_quantity < @quantity
END
GO
/****** Object:  Trigger [dbo].[ProductDelete]    Script Date: 12-Jan-18 2:34:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create TRIGGER [dbo].[ProductDelete]
ON [dbo].[products]
INSTEAD OF DELETE
AS
BEGIN
	UPDATE products 
	SET product_status = 'Unvailable'
	WHERE product_id IN (SELECT product_id FROM deleted)
END
GO
ALTER TABLE [dbo].[products] ENABLE TRIGGER [ProductDelete]
GO
/****** Object:  Trigger [dbo].[InActiveSupplier]    Script Date: 12-Jan-18 2:34:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create TRIGGER [dbo].[InActiveSupplier]
ON [dbo].[suppliers]
INSTEAD OF DELETE
AS
BEGIN
	UPDATE suppliers 
	SET supplier_status = 'In Active'
	WHERE supplier_id  IN (SELECT supplier_id FROM deleted)
END
GO
ALTER TABLE [dbo].[suppliers] ENABLE TRIGGER [InActiveSupplier]
GO
