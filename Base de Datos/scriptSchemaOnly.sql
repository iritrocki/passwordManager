USE [PasswordManagerDB]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 17/06/2021 17:11:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Site] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
	[Modification] [datetime] NOT NULL,
	[Classification] [int] NOT NULL,
	[Category_Id] [int] NULL,
 CONSTRAINT [PK_dbo.Accounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 17/06/2021 17:11:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditCardDataBreachChecks]    Script Date: 17/06/2021 17:11:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditCardDataBreachChecks](
	[CreditCard_Id] [int] NOT NULL,
	[DataBreachCheck_Id] [int] NOT NULL,
 CONSTRAINT [PK_dbo.CreditCardDataBreachChecks] PRIMARY KEY CLUSTERED 
(
	[CreditCard_Id] ASC,
	[DataBreachCheck_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditCards]    Script Date: 17/06/2021 17:11:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditCards](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Company] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[ExpirationMonth] [int] NOT NULL,
	[ExpirationYear] [int] NOT NULL,
	[Notes] [nvarchar](max) NULL,
	[Category_Id] [int] NULL,
 CONSTRAINT [PK_dbo.CreditCards] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DataBreachCheckAccounts]    Script Date: 17/06/2021 17:11:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataBreachCheckAccounts](
	[DataBreachCheck_Id] [int] NOT NULL,
	[Account_Id] [int] NOT NULL,
 CONSTRAINT [PK_dbo.DataBreachCheckAccounts] PRIMARY KEY CLUSTERED 
(
	[DataBreachCheck_Id] ASC,
	[Account_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DataBreachChecks]    Script Date: 17/06/2021 17:11:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataBreachChecks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.DataBreachChecks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DataBreachLines]    Script Date: 17/06/2021 17:11:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataBreachLines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Line] [nvarchar](max) NULL,
	[DataBreachCheck_Id] [int] NULL,
 CONSTRAINT [PK_dbo.DataBreachLines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 17/06/2021 17:11:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [bit] NOT NULL,
	[MasterKey] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Accounts_dbo.Categories_Category_Id] FOREIGN KEY([Category_Id])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_dbo.Accounts_dbo.Categories_Category_Id]
GO
ALTER TABLE [dbo].[CreditCardDataBreachChecks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CreditCardDataBreachChecks_dbo.CreditCards_CreditCard_Id] FOREIGN KEY([CreditCard_Id])
REFERENCES [dbo].[CreditCards] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CreditCardDataBreachChecks] CHECK CONSTRAINT [FK_dbo.CreditCardDataBreachChecks_dbo.CreditCards_CreditCard_Id]
GO
ALTER TABLE [dbo].[CreditCardDataBreachChecks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CreditCardDataBreachChecks_dbo.DataBreachChecks_DataBreachCheck_Id] FOREIGN KEY([DataBreachCheck_Id])
REFERENCES [dbo].[DataBreachChecks] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CreditCardDataBreachChecks] CHECK CONSTRAINT [FK_dbo.CreditCardDataBreachChecks_dbo.DataBreachChecks_DataBreachCheck_Id]
GO
ALTER TABLE [dbo].[CreditCards]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CreditCards_dbo.Categories_Category_Id] FOREIGN KEY([Category_Id])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[CreditCards] CHECK CONSTRAINT [FK_dbo.CreditCards_dbo.Categories_Category_Id]
GO
ALTER TABLE [dbo].[DataBreachCheckAccounts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DataBreachCheckAccounts_dbo.Accounts_Account_Id] FOREIGN KEY([Account_Id])
REFERENCES [dbo].[Accounts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DataBreachCheckAccounts] CHECK CONSTRAINT [FK_dbo.DataBreachCheckAccounts_dbo.Accounts_Account_Id]
GO
ALTER TABLE [dbo].[DataBreachCheckAccounts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DataBreachCheckAccounts_dbo.DataBreachChecks_DataBreachCheck_Id] FOREIGN KEY([DataBreachCheck_Id])
REFERENCES [dbo].[DataBreachChecks] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DataBreachCheckAccounts] CHECK CONSTRAINT [FK_dbo.DataBreachCheckAccounts_dbo.DataBreachChecks_DataBreachCheck_Id]
GO
ALTER TABLE [dbo].[DataBreachLines]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DataBreachLines_dbo.DataBreachChecks_DataBreachCheck_Id] FOREIGN KEY([DataBreachCheck_Id])
REFERENCES [dbo].[DataBreachChecks] ([Id])
GO
ALTER TABLE [dbo].[DataBreachLines] CHECK CONSTRAINT [FK_dbo.DataBreachLines_dbo.DataBreachChecks_DataBreachCheck_Id]
GO
