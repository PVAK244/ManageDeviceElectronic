
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
/****** Object:  Table [dbo].[DeviceType]    Script Date: 3/27/2022 6:49:32 AM ******/
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
/****** Object:  Table [dbo].[ElectricBill]    Script Date: 3/27/2022 6:49:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ElectricBill](
	[electricBillId] [nvarchar](40) NOT NULL,
	[totalKWH] [float] NOT NULL,
	[bill] [money] NOT NULL,
 CONSTRAINT [PK_ElectricBill] PRIMARY KEY CLUSTERED 
(
	[electricBillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 3/27/2022 6:49:32 AM ******/
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
/****** Object:  Table [dbo].[UsageHistory]    Script Date: 3/27/2022 6:49:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsageHistory](
	[usageHistoryId] [nvarchar](40) NOT NULL,
	[deviceId] [nvarchar](40) NOT NULL,
	[lastTimeOn] [datetime] NULL,
	[totalTimeOn] [float] NOT NULL,
 CONSTRAINT [PK_UsageHistory_1] PRIMARY KEY CLUSTERED 
(
	[usageHistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Device] ([deviceId], [name], [imagePath], [deviceTypeId], [status], [power], [roomId]) VALUES (N'57a577d4-19c0-4e76-8dc6-add8de31017f', N'TV LG', N'D:\CODE\C#\Slot282930\ManageDeviceElectronic\icon\icon.png', 1, 1, 40, N'06dfa9bd-11be-47fe-ab1e-01eb60364afd')
INSERT [dbo].[Device] ([deviceId], [name], [imagePath], [deviceTypeId], [status], [power], [roomId]) VALUES (N'85201924-72e3-4f52-b73a-da1d92ab07d2', N'Fan', N'D:\CODE\C#\Slot282930\ManageDeviceElectronic\icon\room.png', 2, 1, 40, N'a624a06c-6164-4626-a4f7-ca795950d159')
INSERT [dbo].[Device] ([deviceId], [name], [imagePath], [deviceTypeId], [status], [power], [roomId]) VALUES (N'd7c4fe59-e729-4ed0-b651-5de85efa1b6a', N'Light', N'D:\CODE\C#\Slot282930\ManageDeviceElectronic\icon\device1.png', 1, 0, 20, N'a624a06c-6164-4626-a4f7-ca795950d159')
GO
SET IDENTITY_INSERT [dbo].[DeviceType] ON 

INSERT [dbo].[DeviceType] ([deviceTypeId], [nameType], [defaultImage]) VALUES (1, N'Light', N'D:\CODE\C#\Slot282930\ManageDeviceElectronic\icon\device1.png')
INSERT [dbo].[DeviceType] ([deviceTypeId], [nameType], [defaultImage]) VALUES (2, N'TV', N'D:\CODE\C#\Slot282930\ManageDeviceElectronic\icon\room.png')
INSERT [dbo].[DeviceType] ([deviceTypeId], [nameType], [defaultImage]) VALUES (3, N'Fan', N'D:\CODE\C#\Slot282930\ManageDeviceElectronic\icon\plug.png')
INSERT [dbo].[DeviceType] ([deviceTypeId], [nameType], [defaultImage]) VALUES (4, N'Air Conditioner', N'D:\CODE\C#\Slot282930\ManageDeviceElectronic\icon\device1.png')
SET IDENTITY_INSERT [dbo].[DeviceType] OFF
GO
INSERT [dbo].[ElectricBill] ([electricBillId], [totalKWH], [bill]) VALUES (N'52afff1b-69c8-444d-81c6-4546ef470940', 1.2829597638, 3848.8793)
GO
INSERT [dbo].[Room] ([roomId], [roomName]) VALUES (N'06dfa9bd-11be-47fe-ab1e-01eb60364afd', N'Living Room')
INSERT [dbo].[Room] ([roomId], [roomName]) VALUES (N'4c7d68a5-fa53-456f-b9ee-55bc77578895', N'llll')
INSERT [dbo].[Room] ([roomId], [roomName]) VALUES (N'a624a06c-6164-4626-a4f7-ca795950d159', N'Bedroom')
GO
INSERT [dbo].[UsageHistory] ([usageHistoryId], [deviceId], [lastTimeOn], [totalTimeOn]) VALUES (N'154d88c5-794e-42fe-9bc0-a62547ada957', N'57a577d4-19c0-4e76-8dc6-add8de31017f', CAST(N'2022-03-27T06:38:29.000' AS DateTime), 50.0249887746667)
INSERT [dbo].[UsageHistory] ([usageHistoryId], [deviceId], [lastTimeOn], [totalTimeOn]) VALUES (N'873e56c0-c0c2-4d8b-b9d3-865f775d9b15', N'85201924-72e3-4f52-b73a-da1d92ab07d2', CAST(N'2022-03-27T05:38:09.000' AS DateTime), 0)
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
