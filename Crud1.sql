USE [Escuelaa]
GO
/****** Object:  Table [dbo].[administracion]    Script Date: 15/11/2019 3:05:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[administracion](
	[codigoMateria] [int] NOT NULL,
	[nombreMateria] [varchar](50) NOT NULL,
	[creditos] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[materias] [varchar](50) NOT NULL,
	[estado] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
