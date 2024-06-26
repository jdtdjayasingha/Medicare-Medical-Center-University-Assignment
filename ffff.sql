USE [Medicare-Medical-Center-DB]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 4/29/2024 1:16:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[ID] [int] IDENTITY(10,1) NOT NULL,
	[Date] [varchar](50) NULL,
	[Time ] [varchar](50) NULL,
	[Doctor_ID] [int] NULL,
	[Patient_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 4/29/2024 1:16:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[ID] [int] IDENTITY(1000,1) NOT NULL,
	[First_Name] [varchar](50) NULL,
	[Second_Name] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Phone_No] [int] NULL,
	[Hospital_Name] [varchar](50) NULL,
	[Specialization] [varchar](100) NULL,
	[Description] [varchar](200) NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 4/29/2024 1:16:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[ID] [int] IDENTITY(1000,1) NOT NULL,
	[First_Name] [varchar](50) NULL,
	[Second_Name] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Age] [int] NULL,
	[Status] [varchar](50) NULL,
	[Phone_No] [int] NULL,
	[Address] [varchar](200) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Treatment]    Script Date: 4/29/2024 1:16:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Treatment](
	[ID] [int] IDENTITY(1,100) NOT NULL,
	[Description] [varchar](50) NULL,
	[Date] [varchar](50) NULL,
	[Patient_ID] [int] NULL,
	[Doctor_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_ToDoctor] FOREIGN KEY([Doctor_ID])
REFERENCES [dbo].[Doctor] ([ID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_ToDoctor]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_ToPatient] FOREIGN KEY([Patient_ID])
REFERENCES [dbo].[Patient] ([ID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_ToPatient]
GO
ALTER TABLE [dbo].[Treatment]  WITH CHECK ADD  CONSTRAINT [FK_Treatment_ToDoctor] FOREIGN KEY([Doctor_ID])
REFERENCES [dbo].[Doctor] ([ID])
GO
ALTER TABLE [dbo].[Treatment] CHECK CONSTRAINT [FK_Treatment_ToDoctor]
GO
ALTER TABLE [dbo].[Treatment]  WITH CHECK ADD  CONSTRAINT [FK_Treatment_ToPatient] FOREIGN KEY([Patient_ID])
REFERENCES [dbo].[Patient] ([ID])
GO
ALTER TABLE [dbo].[Treatment] CHECK CONSTRAINT [FK_Treatment_ToPatient]
GO
