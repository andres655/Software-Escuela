USE [master]
GO
/****** Object:  Database [Estudiante]    Script Date: 18/07/2020 9:22:40 ******/
CREATE DATABASE [Estudiante]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Estudiante', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Estudiante.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Estudiante_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Estudiante_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Estudiante] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Estudiante].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Estudiante] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Estudiante] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Estudiante] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Estudiante] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Estudiante] SET ARITHABORT OFF 
GO
ALTER DATABASE [Estudiante] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Estudiante] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Estudiante] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Estudiante] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Estudiante] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Estudiante] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Estudiante] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Estudiante] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Estudiante] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Estudiante] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Estudiante] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Estudiante] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Estudiante] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Estudiante] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Estudiante] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Estudiante] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Estudiante] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Estudiante] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Estudiante] SET  MULTI_USER 
GO
ALTER DATABASE [Estudiante] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Estudiante] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Estudiante] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Estudiante] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Estudiante] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Estudiante]
GO
/****** Object:  Table [dbo].[Asistencia]    Script Date: 18/07/2020 9:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asistencia](
	[Codigo_Estudiante] [int] NOT NULL,
	[Asistencia] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 18/07/2020 9:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Categoria](
	[ID_Categoria] [int] NOT NULL,
	[Nombre_Categoria] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 18/07/2020 9:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Estudiante](
	[Codigo_Estudiante] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Estudiante] [varchar](max) NULL,
	[Estado] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
SET ANSI_PADDING ON
ALTER TABLE [dbo].[Estudiante] ADD [Numero] [varchar](10) NULL
SET ANSI_PADDING OFF
ALTER TABLE [dbo].[Estudiante] ADD [direccion] [varchar](max) NULL
ALTER TABLE [dbo].[Estudiante] ADD [ID_Categoria] [int] NULL
ALTER TABLE [dbo].[Estudiante] ADD [EstadoPrueba] [bit] NULL
SET ANSI_PADDING ON
ALTER TABLE [dbo].[Estudiante] ADD [Cedula] [varchar](20) NULL
SET ANSI_PADDING OFF
ALTER TABLE [dbo].[Estudiante] ADD [correo] [varchar](max) NULL
ALTER TABLE [dbo].[Estudiante] ADD [Asistencia] [int] NULL
ALTER TABLE [dbo].[Estudiante] ADD [Terminado] [bit] NULL
ALTER TABLE [dbo].[Estudiante] ADD [FechaInscripcion] [date] NULL
ALTER TABLE [dbo].[Estudiante] ADD [Fecha_Asistencia] [date] NULL
PRIMARY KEY CLUSTERED 
(
	[Codigo_Estudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_EstadoPorAusencia]    Script Date: 18/07/2020 9:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Actualizar_EstadoPorAusencia]
@Terminado bit ,@Estado bit

as 

UPDATE Estudiante
  SET Terminado=@Terminado, Estado=@Estado
  WHERE 2< (select DATEDIFF (MONTH, FechaInscripcion, GETDATE()) as Month From Estudiante)
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_Estudiante]    Script Date: 18/07/2020 9:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Actualizar_Estudiante]
 @Nombre_Estudiante varchar(max),@Numero varchar(10),@direccion varchar(max),@ID_Categoria int,@Cedula varchar(20),@correo varchar (max), @FechaInscripcion date 

as

INSERT INTO Estudiante( Nombre_Estudiante,Numero,direccion,ID_Categoria,Cedula,correo,Estado,FechaInscripcion,Asistencia) values (@Nombre_Estudiante,@Numero,@direccion,@ID_Categoria,@Cedula,@correo,1,@FechaInscripcion,0)
GO
/****** Object:  StoredProcedure [dbo].[ActualizarAsistencia]    Script Date: 18/07/2020 9:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ActualizarAsistencia]

@Asistencia int , @Codigo_Estudiante int,@Fecha_Asistencia date

as 

UPDATE Estudiante
  SET Asistencia=@Asistencia, Fecha_Asistencia=@Fecha_Asistencia
  WHERE Codigo_Estudiante=@Codigo_Estudiante
GO
/****** Object:  StoredProcedure [dbo].[ActualizarEstado]    Script Date: 18/07/2020 9:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ActualizarEstado]

@Terminado bit , @Codigo_Estudiante int,@Estado bit

as 

UPDATE Estudiante
  SET Terminado=@Terminado, Estado=@Estado
  WHERE Codigo_Estudiante=@Codigo_Estudiante
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Estudiante]    Script Date: 18/07/2020 9:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Eliminar_Estudiante]

@Codigo_Estudiante int

as

delete from Estudiante where Codigo_Estudiante=@Codigo_Estudiante

GO
/****** Object:  StoredProcedure [dbo].[Examen]    Script Date: 18/07/2020 9:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Examen] 

@EstadoPrueba bit, @Codigo_Estudiante int 

as

UPDATE Estudiante
  SET EstadoPrueba=@EstadoPrueba
  WHERE Codigo_Estudiante=@Codigo_Estudiante 

GO
USE [master]
GO
ALTER DATABASE [Estudiante] SET  READ_WRITE 
GO
