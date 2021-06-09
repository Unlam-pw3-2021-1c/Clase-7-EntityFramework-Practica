
CREATE DATABASE [VestimentasDB]
GO
USE [VestimentasDB]

GO
/****** Object:  Table [dbo].[Local]    Script Date: 6/9/2021 8:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Local](
	[IdLocal] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Direccion] [nvarchar](200) NULL,
 CONSTRAINT [PK_Local] PRIMARY KEY CLUSTERED 
(
	[IdLocal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LocalPrenda]    Script Date: 6/9/2021 8:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocalPrenda](
	[IdLocal] [int] NOT NULL,
	[IdPrenda] [int] NOT NULL,
 CONSTRAINT [PK_LocalPrenda] PRIMARY KEY CLUSTERED 
(
	[IdLocal] ASC,
	[IdPrenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prenda]    Script Date: 6/9/2021 8:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prenda](
	[IdPrenda] [int] IDENTITY(1,1) NOT NULL,
	[Talle] [nvarchar](10) NOT NULL,
	[Color] [nvarchar](100) NULL,
	[Modelo] [nvarchar](100) NULL,
	[Marca] [nvarchar](100) NOT NULL,
	[Tela] [nvarchar](100) NULL,
	[Temporada] [nvarchar](100) NULL,
	[IdTipoPrenda] [int] NOT NULL,
 CONSTRAINT [PK_Prenda] PRIMARY KEY CLUSTERED 
(
	[IdPrenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPrenda]    Script Date: 6/9/2021 8:21:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPrenda](
	[IdTipoPrenda] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_TipoPrenda] PRIMARY KEY CLUSTERED 
(
	[IdTipoPrenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LocalPrenda]  WITH CHECK ADD  CONSTRAINT [FK_LocalPrenda_Local] FOREIGN KEY([IdLocal])
REFERENCES [dbo].[Local] ([IdLocal])
GO
ALTER TABLE [dbo].[LocalPrenda] CHECK CONSTRAINT [FK_LocalPrenda_Local]
GO
ALTER TABLE [dbo].[LocalPrenda]  WITH CHECK ADD  CONSTRAINT [FK_LocalPrenda_Prenda] FOREIGN KEY([IdPrenda])
REFERENCES [dbo].[Prenda] ([IdPrenda])
GO
ALTER TABLE [dbo].[LocalPrenda] CHECK CONSTRAINT [FK_LocalPrenda_Prenda]
GO
ALTER TABLE [dbo].[Prenda]  WITH CHECK ADD  CONSTRAINT [FK_Prenda_TipoPrenda] FOREIGN KEY([IdTipoPrenda])
REFERENCES [dbo].[TipoPrenda] ([IdTipoPrenda])
GO
ALTER TABLE [dbo].[Prenda] CHECK CONSTRAINT [FK_Prenda_TipoPrenda]
GO
