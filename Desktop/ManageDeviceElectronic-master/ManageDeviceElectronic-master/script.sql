
CREATE DATABASE [ManageDeviceElectronic]
 
CREATE TABLE [dbo].[Device](
	[deviceId] [nvarchar](40) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[imagePath] [nvarchar](255) NULL,
	[deviceTypeId] [int] NOT NULL,
	[status] [bit] NOT NULL,
	[power] [int] NOT NULL,
	[roomId] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_Device] PRIMARY KEY CLUSTERED 
(
	[deviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeviceType]    Script Date: 3/26/2022 2:39:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeviceType](
	[deviceTypeId] [int] IDENTITY(1,1) NOT NULL,
	[nameType] [nvarchar](50) NOT NULL,
	[defaultImage] [nvarchar](255) NULL,
 CONSTRAINT [PK_DeviceType] PRIMARY KEY CLUSTERED 
(
	[deviceTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ElectricBill]    Script Date: 3/26/2022 2:39:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ElectricBill](
	[electricBillId] [nvarchar](40) NOT NULL,
	[totalKWH] [int] NOT NULL,
	[month] [date] NOT NULL,
	[bill] [money] NOT NULL,
 CONSTRAINT [PK_ElectricBill] PRIMARY KEY CLUSTERED 
(
	[electricBillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 3/26/2022 2:39:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[roomId] [nvarchar](40) NOT NULL,
	[roomName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[roomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsageHistory]    Script Date: 3/26/2022 2:39:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsageHistory](
	[usageHistoryId] [nvarchar](40) NOT NULL,
	[deviceId] [nvarchar](40) NOT NULL,
	[lastTimeOn] [date] NOT NULL,
	[totalTimeOn] [int] NOT NULL,
 CONSTRAINT [PK_UsageHistory_1] PRIMARY KEY CLUSTERED 
(
	[usageHistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Device] ([deviceId], [name], [imagePath], [deviceTypeId], [status], [power], [roomId]) VALUES (N'57a577d4-19c0-4e76-8dc6-add8de31017f', N'TV LG', N'D:\CODE\C#\Slot282930\ManageDeviceElectronic\icon\icon.png', 2, 0, 40, N'a624a06c-6164-4626-a4f7-ca795950d159')
GO
SET IDENTITY_INSERT [dbo].[DeviceType] ON 

INSERT [dbo].[DeviceType] ([deviceTypeId], [nameType], [defaultImage]) VALUES (1, N'Light', N'D:\CODE\C#\Slot282930\ManageDeviceElectronic\icon\device1.png')
INSERT [dbo].[DeviceType] ([deviceTypeId], [nameType], [defaultImage]) VALUES (2, N'TV', N'D:\CODE\C#\Slot282930\ManageDeviceElectronic\icon\icon.png')
INSERT [dbo].[DeviceType] ([deviceTypeId], [nameType], [defaultImage]) VALUES (3, N'Fan', N'D:\CODE\C#\Slot282930\ManageDeviceElectronic\icon\plug.png')
INSERT [dbo].[DeviceType] ([deviceTypeId], [nameType], [defaultImage]) VALUES (4, N'Air Conditioner', N'D:\CODE\C#\Slot282930\ManageDeviceElectronic\icon\device1.png')
SET IDENTITY_INSERT [dbo].[DeviceType] OFF
GO
INSERT [dbo].[Room] ([roomId], [roomName]) VALUES (N'06dfa9bd-11be-47fe-ab1e-01eb60364afd', N'Living Room')
INSERT [dbo].[Room] ([roomId], [roomName]) VALUES (N'a624a06c-6164-4626-a4f7-ca795950d159', N'Bedroom')
GO
ALTER TABLE [dbo].[Device]  WITH CHECK ADD  CONSTRAINT [fk_device_devicetype] FOREIGN KEY([deviceTypeId])
REFERENCES [dbo].[DeviceType] ([deviceTypeId])
GO
ALTER TABLE [dbo].[Device] CHECK CONSTRAINT [fk_device_devicetype]
GO
ALTER TABLE [dbo].[Device]  WITH CHECK ADD  CONSTRAINT [fk_device_room] FOREIGN KEY([roomId])
REFERENCES [dbo].[Room] ([roomId])
GO
ALTER TABLE [dbo].[Device] CHECK CONSTRAINT [fk_device_room]
GO
ALTER TABLE [dbo].[UsageHistory]  WITH CHECK ADD  CONSTRAINT [fk_usageHistory_device] FOREIGN KEY([deviceId])
REFERENCES [dbo].[Device] ([deviceId])
GO
ALTER TABLE [dbo].[UsageHistory] CHECK CONSTRAINT [fk_usageHistory_device]
GO
