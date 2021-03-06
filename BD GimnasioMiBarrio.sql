USE [master]
GO
/****** Object:  Database [GimMiBarrioData]    Script Date: 19/10/2021 7:49:08 a. m. ******/
CREATE DATABASE [GimMiBarrioData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GimMiBarrioData', FILENAME = N'C:\Users\kelly\GimMiBarrioData.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GimMiBarrioData_log', FILENAME = N'C:\Users\kelly\GimMiBarrioData_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GimMiBarrioData] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GimMiBarrioData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GimMiBarrioData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET ARITHABORT OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GimMiBarrioData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GimMiBarrioData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GimMiBarrioData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GimMiBarrioData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GimMiBarrioData] SET  MULTI_USER 
GO
ALTER DATABASE [GimMiBarrioData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GimMiBarrioData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GimMiBarrioData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GimMiBarrioData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GimMiBarrioData] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GimMiBarrioData] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GimMiBarrioData] SET QUERY_STORE = OFF
GO
USE [GimMiBarrioData]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 19/10/2021 7:49:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 19/10/2021 7:49:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Identificacion] [nvarchar](max) NULL,
	[Nombres] [nvarchar](max) NULL,
	[Apellidos] [nvarchar](max) NULL,
	[Contrasena] [nvarchar](max) NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrenadores]    Script Date: 19/10/2021 7:49:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrenadores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Identificacion] [nvarchar](max) NULL,
	[Nombres] [nvarchar](max) NULL,
	[Apellidos] [nvarchar](max) NULL,
	[FechaIngreso] [datetime2](7) NOT NULL,
	[SalarioMensual] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Entrenadores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gimnasios]    Script Date: 19/10/2021 7:49:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gimnasios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
	[Direccion] [nvarchar](max) NULL,
	[Telefono] [nvarchar](max) NULL,
	[ArriendoMensual] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Gimnasios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logins]    Script Date: 19/10/2021 7:49:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](max) NULL,
	[Contrasena] [nvarchar](max) NULL,
 CONSTRAINT [PK_Logins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Maquinas]    Script Date: 19/10/2021 7:49:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maquinas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](max) NULL,
	[EstadoActual] [nvarchar](max) NULL,
	[CostoRevision] [decimal](18, 2) NOT NULL,
	[FechaRevision] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Maquinas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanDias]    Script Date: 19/10/2021 7:49:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanDias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DiasSeleccionados] [nvarchar](max) NULL,
	[Horario] [datetime2](7) NOT NULL,
	[PlanId] [int] NULL,
 CONSTRAINT [PK_PlanDias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Planes]    Script Date: 19/10/2021 7:49:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
	[CostoMensual] [decimal](18, 2) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
 CONSTRAINT [PK_Planes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transacciones]    Script Date: 19/10/2021 7:49:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transacciones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](max) NULL,
	[Estado] [nvarchar](max) NULL,
	[Tipo] [nvarchar](max) NULL,
	[FechaLimite] [datetime2](7) NOT NULL,
	[FechaPago] [datetime2](7) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
 CONSTRAINT [PK_Transacciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioRecurrentes]    Script Date: 19/10/2021 7:49:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioRecurrentes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Identificacion] [nvarchar](max) NULL,
	[Nombres] [nvarchar](max) NULL,
	[Apellidos] [nvarchar](max) NULL,
	[Estado] [nvarchar](max) NULL,
	[FechaIngreso] [datetime2](7) NOT NULL,
	[PesoInicial] [nvarchar](max) NULL,
	[PesoActual] [nvarchar](max) NULL,
	[PlanId] [int] NULL,
 CONSTRAINT [PK_UsuarioRecurrentes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211018164017_Inicial12', N'5.0.0')
GO
SET IDENTITY_INSERT [dbo].[Planes] ON 

INSERT [dbo].[Planes] ([Id], [Codigo], [Nombre], [CostoMensual], [Descripcion]) VALUES (2, N'10', N'Plna', CAST(0.00 AS Decimal(18, 2)), N'pLna')
INSERT [dbo].[Planes] ([Id], [Codigo], [Nombre], [CostoMensual], [Descripcion]) VALUES (3, N'01', N'Ju', CAST(0.00 AS Decimal(18, 2)), N'Asd')
SET IDENTITY_INSERT [dbo].[Planes] OFF
GO
SET IDENTITY_INSERT [dbo].[UsuarioRecurrentes] ON 

INSERT [dbo].[UsuarioRecurrentes] ([Id], [Identificacion], [Nombres], [Apellidos], [Estado], [FechaIngreso], [PesoInicial], [PesoActual], [PlanId]) VALUES (4, N'72450890', N'Kevin', N'Santiago', N'Activo', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'75', N'65', NULL)
SET IDENTITY_INSERT [dbo].[UsuarioRecurrentes] OFF
GO
/****** Object:  Index [IX_PlanDias_PlanId]    Script Date: 19/10/2021 7:49:08 a. m. ******/
CREATE NONCLUSTERED INDEX [IX_PlanDias_PlanId] ON [dbo].[PlanDias]
(
	[PlanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UsuarioRecurrentes_PlanId]    Script Date: 19/10/2021 7:49:08 a. m. ******/
CREATE NONCLUSTERED INDEX [IX_UsuarioRecurrentes_PlanId] ON [dbo].[UsuarioRecurrentes]
(
	[PlanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PlanDias]  WITH CHECK ADD  CONSTRAINT [FK_PlanDias_Planes_PlanId] FOREIGN KEY([PlanId])
REFERENCES [dbo].[Planes] ([Id])
GO
ALTER TABLE [dbo].[PlanDias] CHECK CONSTRAINT [FK_PlanDias_Planes_PlanId]
GO
ALTER TABLE [dbo].[UsuarioRecurrentes]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioRecurrentes_Planes_PlanId] FOREIGN KEY([PlanId])
REFERENCES [dbo].[Planes] ([Id])
GO
ALTER TABLE [dbo].[UsuarioRecurrentes] CHECK CONSTRAINT [FK_UsuarioRecurrentes_Planes_PlanId]
GO
USE [master]
GO
ALTER DATABASE [GimMiBarrioData] SET  READ_WRITE 
GO
