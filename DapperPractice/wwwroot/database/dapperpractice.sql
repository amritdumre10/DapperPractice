Create Database [DapperPractice]
USE [DapperPractice]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 23-Jun-22 6:46:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL
) ON [PRIMARY]
GO
