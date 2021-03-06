CREATE DATABASE [TP4]
GO 
SET ANSI_NULLS ON 
GO
SET QUOTED_IDENTIFIER ON
GO
USE [TP4]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 8/12/2020 19:00:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[dni] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] 
INSERT INTO Clientes VALUES ('Federico','Davila','Alvear 145','4244-1000','38123456')
INSERT INTO Clientes VALUES ('Mauricio','Cerizza','Araos 222','4255-2000','36789123')
INSERT INTO Clientes VALUES ('Daniel','Vizgarra','Saenz 313','4266-3000','33613811')

GO
/****** Object:  Table [dbo].[Productos]    Script Date: 8/12/2020 19:00:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[stock] [int] NULL,
	[precio] [float] NULL,
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[marca] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ProductosDB] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
INSERT INTO Productos VALUES (30,134.9,'Alcohol','As')
INSERT INTO Productos VALUES (20,180.25,'Detergente','Magistral')
INSERT INTO Productos VALUES (30,134.9,'Detergente','Magiplus')
INSERT INTO Productos VALUES (30,134.9,'Jabon','Ala')
INSERT INTO Productos VALUES (30,134.9,'Lavandina','Ayudin')
INSERT INTO Productos VALUES (30,134.9,'Desinfectante','Lisoform')
INSERT INTO Productos VALUES (30,134.9,'Escoba','Escobaldi')
INSERT INTO Productos VALUES (30,134.9,'Pastilla baño','Pastroni')


GO
