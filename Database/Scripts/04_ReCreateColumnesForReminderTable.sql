USE [MysticToDo_DB]
GO

/****** Object:  Table [dbo].[Reminder]    Script Date: 3/8/2024 1:40:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reminder](
	[Reminder_Id] [int] IDENTITY(1,1) NOT NULL,
	[Reminder_Name] [nvarchar](100) NOT NULL,
	[Reminder_Description] [nvarchar](500) NULL,
	[Reminder_IsComplete] [bit] NULL,
	[Reminder_HasAlarm] [bit] NULL,
	[Reminder_Date] [date] NULL,
	[Reminder_Time] [time](7) NULL,
	[Reminder_IsPeriodic] [bit] NULL,
	[Reminder_PeriodicActive] [bit] NULL,
	[Reminder_PeriodicIntervalLabel] [int] NULL,
	[Reminder_NextPeriodicDate] [date] NULL,
	[Reminder_NextPeriodicTime] [time](7) NULL,
 CONSTRAINT [PK__Reminder__7D0D0DDB25AE1E32] PRIMARY KEY CLUSTERED 
(
	[Reminder_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Reminder]  WITH CHECK ADD  CONSTRAINT [FK__Reminder__Remind__4CA06362] FOREIGN KEY([Reminder_PeriodicIntervalLabel])
REFERENCES [dbo].[Timeframe] ([Timeframe_Key])
GO

ALTER TABLE [dbo].[Reminder] CHECK CONSTRAINT [FK__Reminder__Remind__4CA06362]
GO


