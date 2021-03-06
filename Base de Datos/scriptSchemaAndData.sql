USE [PasswordManagerDB]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 17/06/2021 17:08:39 ******/
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
/****** Object:  Table [dbo].[Categories]    Script Date: 17/06/2021 17:08:39 ******/
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
/****** Object:  Table [dbo].[CreditCardDataBreachChecks]    Script Date: 17/06/2021 17:08:39 ******/
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
/****** Object:  Table [dbo].[CreditCards]    Script Date: 17/06/2021 17:08:39 ******/
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
/****** Object:  Table [dbo].[DataBreachCheckAccounts]    Script Date: 17/06/2021 17:08:39 ******/
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
/****** Object:  Table [dbo].[DataBreachChecks]    Script Date: 17/06/2021 17:08:39 ******/
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
/****** Object:  Table [dbo].[DataBreachLines]    Script Date: 17/06/2021 17:08:39 ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 17/06/2021 17:08:39 ******/
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
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (1, N'JuanPerez', N'Juancito1234', N'Aulas', N'', CAST(N'2021-06-17T15:09:43.720' AS DateTime), 2, 1)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (2, N'JuanPerez', N'JuanPeORT..', N'Gestion', N'', CAST(N'2021-06-17T15:10:19.283' AS DateTime), 2, 1)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (3, N'CarlosLopez', N'H4rN0Hi5cggVGsxUoBdM', N'Oracle', N'', CAST(N'2021-06-17T15:11:27.123' AS DateTime), 4, 1)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (4, N'Juancito@Teams', N'#(7[";($0:!>.[-*9}52', N'Teams', N'contraseña dificil', CAST(N'2021-06-17T15:13:14.063' AS DateTime), 3, 1)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (5, N'Pepe@github.com', N'Pepe123', N'Github', N'', CAST(N'2021-06-17T15:13:57.810' AS DateTime), 1, 1)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (6, N'Matulij', N'~{-39@ckXu `}X`Me1}wd!G', N'Facebook', N'', CAST(N'2021-06-17T15:15:24.470' AS DateTime), 5, 4)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (7, N'iritrocki', N'nzGitdNBSO', N'Twitter', N'contraseña facil', CAST(N'2021-06-17T15:16:48.297' AS DateTime), 2, 4)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (8, N'LauraGomez', N'sy4L9xWm9pcP', N'Instagram', N'', CAST(N'2021-06-17T15:17:55.367' AS DateTime), 2, 4)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (9, N'JuancitoTikToker', N'Z=YL!)[MK<"LL', N'TikTok', N'', CAST(N'2021-06-17T15:19:07.713' AS DateTime), 2, 4)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (10, N'Juan@Snapchat', N'SdVjM', N'Snapchat', N'', CAST(N'2021-06-17T15:19:50.603' AS DateTime), 1, 4)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (11, N'carlos@gmail.com', N'gTqnsr?}S" ).R}z%u7Q', N'Gmail', N'', CAST(N'2021-06-17T15:20:25.683' AS DateTime), 5, 2)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (12, N'CarlosRodriguez', N'CarlosItau1.2.3.', N'Itau', N'', CAST(N'2021-06-17T15:22:26.743' AS DateTime), 5, 2)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (13, N'PedroGomez', N'O3YPNLAnjzgHSNdI', N'LinkedIn', N'Linkedin para encontrar trabajo', CAST(N'2021-06-17T15:24:35.013' AS DateTime), 4, 2)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (14, N'Pepe@slack.com', N'384PQ66C9D8WCSUF', N'Slack', N'', CAST(N'2021-06-17T15:26:38.060' AS DateTime), 3, 2)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (15, N'Cris@ClickUp.com', N'1`]%imM', N'ClickUp', N'', CAST(N'2021-06-17T15:27:34.433' AS DateTime), 1, 2)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (16, N'Jorge@outlook.com', N'O3UK5Uf8mXXqM', N'Outlook', N'mail de Jorge', CAST(N'2021-06-17T15:28:42.313' AS DateTime), 2, 3)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (17, N'Jorge@gmail.com', N'123456789', N'Directv', N'', CAST(N'2021-06-17T15:29:23.207' AS DateTime), 2, 3)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (18, N'Jorge Medina', N'FEKTHTHLPT95FMFTA', N'Spotify', N'', CAST(N'2021-06-17T15:29:58.903' AS DateTime), 3, 3)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (19, N'Jorge@gmail.com', N'9VvdrfSfoj5eit2OTA', N'Netflix', N'', CAST(N'2021-06-17T15:35:18.637' AS DateTime), 4, 3)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (20, N'pablo@canva.com', N'PABLO12', N'Canva', N'', CAST(N'2021-06-17T15:58:16.607' AS DateTime), 1, 3)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (21, N'jorge@gmail.com', N'itCEhUurfdP', N'Poipes', N'ver futbol en el exterior', CAST(N'2021-06-17T15:38:47.007' AS DateTime), 2, 5)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (22, N'pablo@auf.com', N'LuisSuarezGoleador2022', N'AufTV', N'seleccion uruguaya', CAST(N'2021-06-17T15:40:05.137' AS DateTime), 4, 5)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (23, N'pedro@nacional.com.uy', N'NacionalCampeon', N'NacionalTV', N'', CAST(N'2021-06-17T16:09:56.023' AS DateTime), 4, 5)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (24, N'pepe@gmail.com', N'`96RYK=o4+)S''naMaD-T', N'ESPN', N'', CAST(N'2021-06-17T15:42:34.023' AS DateTime), 5, 5)
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [Site], [Note], [Modification], [Classification], [Category_Id]) VALUES (25, N'marcos@fox.com.ar', N';{*<}@', N'FoxSports', N'', CAST(N'2021-06-17T15:43:36.440' AS DateTime), 1, 5)
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Facultad')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Trabajo')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Personal')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'Redes Sociales')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (5, N'Futbol')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
INSERT [dbo].[CreditCardDataBreachChecks] ([CreditCard_Id], [DataBreachCheck_Id]) VALUES (1, 1)
INSERT [dbo].[CreditCardDataBreachChecks] ([CreditCard_Id], [DataBreachCheck_Id]) VALUES (4, 2)
GO
SET IDENTITY_INSERT [dbo].[CreditCards] ON 

INSERT [dbo].[CreditCards] ([Id], [Name], [Company], [Number], [Code], [ExpirationMonth], [ExpirationYear], [Notes], [Category_Id]) VALUES (1, N'Visa Gold', N'Visa', N'1234 5678 1234 5678', N'223', 2, 2023, N'Limite 50 K', 3)
INSERT [dbo].[CreditCards] ([Id], [Name], [Company], [Number], [Code], [ExpirationMonth], [ExpirationYear], [Notes], [Category_Id]) VALUES (2, N'Visa Platinum', N'Visa', N'2098 3876 1234 2712', N'819', 3, 2024, N'Tarjeta de Debito', 2)
INSERT [dbo].[CreditCards] ([Id], [Name], [Company], [Number], [Code], [ExpirationMonth], [ExpirationYear], [Notes], [Category_Id]) VALUES (3, N'American Express Oro', N'American Express', N'4093 1234 4098 1234', N'123', 2, 2028, N'Credito - Sin limite', 2)
INSERT [dbo].[CreditCards] ([Id], [Name], [Company], [Number], [Code], [ExpirationMonth], [ExpirationYear], [Notes], [Category_Id]) VALUES (4, N'Santander Select', N'Santander', N'1023 2034 3045 4056', N'543', 3, 2025, N'Limite 10K UYU', 1)
SET IDENTITY_INSERT [dbo].[CreditCards] OFF
GO
INSERT [dbo].[DataBreachCheckAccounts] ([DataBreachCheck_Id], [Account_Id]) VALUES (1, 1)
INSERT [dbo].[DataBreachCheckAccounts] ([DataBreachCheck_Id], [Account_Id]) VALUES (2, 20)
INSERT [dbo].[DataBreachCheckAccounts] ([DataBreachCheck_Id], [Account_Id]) VALUES (3, 22)
INSERT [dbo].[DataBreachCheckAccounts] ([DataBreachCheck_Id], [Account_Id]) VALUES (3, 23)
GO
SET IDENTITY_INSERT [dbo].[DataBreachChecks] ON 

INSERT [dbo].[DataBreachChecks] ([Id], [Date]) VALUES (1, CAST(N'2021-06-17T16:04:53.280' AS DateTime))
INSERT [dbo].[DataBreachChecks] ([Id], [Date]) VALUES (2, CAST(N'2021-06-17T16:05:48.543' AS DateTime))
INSERT [dbo].[DataBreachChecks] ([Id], [Date]) VALUES (3, CAST(N'2021-06-17T16:08:07.613' AS DateTime))
INSERT [dbo].[DataBreachChecks] ([Id], [Date]) VALUES (4, CAST(N'2021-06-17T16:24:43.173' AS DateTime))
SET IDENTITY_INSERT [dbo].[DataBreachChecks] OFF
GO
SET IDENTITY_INSERT [dbo].[DataBreachLines] ON 

INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (1, N'1234 5678 1234 5678', 1)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (2, N'Juancito1234', 1)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (3, N'HolaHola', 1)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (4, N'1000 2000 3000 4000', 1)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (5, N'1023 2034 3045 4056', 2)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (6, N'PABLO12', 2)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (7, N'contraseñaDificil', 2)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (8, N'decanoFutbolUruguayo', 3)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (9, N'CavaniGoleador2022', 3)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (10, N'LuisSuarezGoleador2022', 3)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (11, N'passWord-Fugada', 3)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (12, N'holaQueTal', 4)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (13, N'LaPasswordMagica', 4)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (14, N'kjhfkjahfkjah', 4)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (15, N'contraFacil', 4)
INSERT [dbo].[DataBreachLines] ([Id], [Line], [DataBreachCheck_Id]) VALUES (16, N'pablito09', 4)
SET IDENTITY_INSERT [dbo].[DataBreachLines] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Status], [MasterKey]) VALUES (1, 1, N'masterKey123')
SET IDENTITY_INSERT [dbo].[Users] OFF
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
