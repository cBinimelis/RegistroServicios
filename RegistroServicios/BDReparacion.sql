USE [master]
GO
/****** Object:  Database [bd_reparacion]    Script Date: 24/07/2017 15:28:53 ******/
CREATE DATABASE [bd_reparacion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bd_reparacion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\bd_reparacion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bd_reparacion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\bd_reparacion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [bd_reparacion] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bd_reparacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bd_reparacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bd_reparacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bd_reparacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bd_reparacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bd_reparacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [bd_reparacion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bd_reparacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bd_reparacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bd_reparacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bd_reparacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bd_reparacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bd_reparacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bd_reparacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bd_reparacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bd_reparacion] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bd_reparacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bd_reparacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bd_reparacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bd_reparacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bd_reparacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bd_reparacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bd_reparacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bd_reparacion] SET RECOVERY FULL 
GO
ALTER DATABASE [bd_reparacion] SET  MULTI_USER 
GO
ALTER DATABASE [bd_reparacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bd_reparacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bd_reparacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bd_reparacion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bd_reparacion] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'bd_reparacion', N'ON'
GO
ALTER DATABASE [bd_reparacion] SET QUERY_STORE = OFF
GO
USE [bd_reparacion]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [bd_reparacion]
GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 24/07/2017 15:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudad](
	[idCiudad] [int] IDENTITY(1,1) NOT NULL,
	[nombreCiudad] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Ciudad_1] PRIMARY KEY CLUSTERED 
(
	[idCiudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/07/2017 15:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](150) NOT NULL,
	[Apellidos] [varchar](150) NOT NULL,
	[Telefono] [varchar](12) NOT NULL,
	[idCiudad] [int] NOT NULL,
 CONSTRAINT [PK_Usuario_1] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vUsers]    Script Date: 24/07/2017 15:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vUsers] as
select u.idUsuario, u.Nombres +' '+ u.Apellidos as 'Nombre', u.Telefono, c.idCiudad, c.nombreCiudad
from Usuario u 
inner join Ciudad c on c.idCiudad = u.idCiudad
GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 24/07/2017 15:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[idServicio] [int] IDENTITY(1,1) NOT NULL,
	[idTipoServicio] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[PrecioServicio] [int] NOT NULL,
 CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED 
(
	[idServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoServicio]    Script Date: 24/07/2017 15:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoServicio](
	[idTipoServicio] [int] IDENTITY(1,1) NOT NULL,
	[nombreTipoServicio] [varchar](250) NOT NULL,
 CONSTRAINT [PK_TipoServicio] PRIMARY KEY CLUSTERED 
(
	[idTipoServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ciudad] ON 

INSERT [dbo].[Ciudad] ([idCiudad], [nombreCiudad]) VALUES (1, N'Los Angeles')
INSERT [dbo].[Ciudad] ([idCiudad], [nombreCiudad]) VALUES (2, N'Concepcion')
INSERT [dbo].[Ciudad] ([idCiudad], [nombreCiudad]) VALUES (3, N'Chillan')
INSERT [dbo].[Ciudad] ([idCiudad], [nombreCiudad]) VALUES (4, N'Lebu')
SET IDENTITY_INSERT [dbo].[Ciudad] OFF
SET IDENTITY_INSERT [dbo].[Servicio] ON 

INSERT [dbo].[Servicio] ([idServicio], [idTipoServicio], [idUsuario], [PrecioServicio]) VALUES (5, 2, 1, 1100)
SET IDENTITY_INSERT [dbo].[Servicio] OFF
SET IDENTITY_INSERT [dbo].[TipoServicio] ON 

INSERT [dbo].[TipoServicio] ([idTipoServicio], [nombreTipoServicio]) VALUES (1, N'Formateo')
INSERT [dbo].[TipoServicio] ([idTipoServicio], [nombreTipoServicio]) VALUES (2, N'Limpieza')
INSERT [dbo].[TipoServicio] ([idTipoServicio], [nombreTipoServicio]) VALUES (3, N'Respaldo de Datos')
INSERT [dbo].[TipoServicio] ([idTipoServicio], [nombreTipoServicio]) VALUES (4, N'Jaquear Feisbu')
SET IDENTITY_INSERT [dbo].[TipoServicio] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([idUsuario], [Nombres], [Apellidos], [Telefono], [idCiudad]) VALUES (1, N'Joselito', N'Barrendero', N'+56988888888', 1)
INSERT [dbo].[Usuario] ([idUsuario], [Nombres], [Apellidos], [Telefono], [idCiudad]) VALUES (2, N'Pepe ', N'Polainas', N'+56977777777', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Servicio_TipoServicio] FOREIGN KEY([idTipoServicio])
REFERENCES [dbo].[TipoServicio] ([idTipoServicio])
GO
ALTER TABLE [dbo].[Servicio] CHECK CONSTRAINT [FK_Servicio_TipoServicio]
GO
ALTER TABLE [dbo].[Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Servicio_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Servicio] CHECK CONSTRAINT [FK_Servicio_Usuario]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Ciudad] FOREIGN KEY([idCiudad])
REFERENCES [dbo].[Ciudad] ([idCiudad])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Ciudad]
GO
USE [master]
GO
ALTER DATABASE [bd_reparacion] SET  READ_WRITE 
GO
