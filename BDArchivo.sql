USE [master]
GO
/****** Object:  Database [BDArchivos]    Script Date: 03/11/2015 16:30:33 ******/
CREATE DATABASE [BDArchivos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDArchivos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BDArchivos.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BDArchivos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BDArchivos_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BDArchivos] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDArchivos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDArchivos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDArchivos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDArchivos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDArchivos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDArchivos] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDArchivos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDArchivos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDArchivos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDArchivos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDArchivos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDArchivos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDArchivos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDArchivos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDArchivos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDArchivos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDArchivos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDArchivos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDArchivos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDArchivos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDArchivos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDArchivos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDArchivos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDArchivos] SET RECOVERY FULL 
GO
ALTER DATABASE [BDArchivos] SET  MULTI_USER 
GO
ALTER DATABASE [BDArchivos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDArchivos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDArchivos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDArchivos] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BDArchivos] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BDArchivos', N'ON'
GO
USE [BDArchivos]
GO
/****** Object:  Table [dbo].[TRegistro]    Script Date: 03/11/2015 16:30:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRegistro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FormularioNro] [nvarchar](50) NULL,
	[Boleto] [nvarchar](50) NULL,
	[NombreBeneficiario] [nvarchar](50) NULL,
	[MomentoContable] [nvarchar](50) NULL,
	[NroTomo] [nvarchar](50) NULL,
	[Gestion] [nvarchar](50) NULL,
	[PeriodoAdeudado] [varchar](50) NULL,
	[FechaPago] [date] NULL,
	[Tipo] [varchar](50) NULL,
	[ImporteAdeudado] [float] NULL,
	[DescripcionDeuda] [varchar](max) NULL,
	[CCNro] [nvarchar](50) NULL,
	[CCFechaPago] [date] NULL,
	[CCImporteAdeudado] [float] NULL,
	[CHNro] [nvarchar](50) NULL,
	[CHFechaCobro] [date] NULL,
	[CHImporteCheque] [float] NULL,
 CONSTRAINT [PK_TRegistro] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TUsuario]    Script Date: 03/11/2015 16:30:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TUsuario](
	[idusuario] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellidos] [nvarchar](50) NULL,
	[ci] [nvarchar](9) NULL,
	[direccion] [nvarchar](100) NULL,
	[telefono] [nvarchar](10) NULL,
	[login] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[acceso] [nvarchar](1) NULL,
	[rol] [nvarchar](50) NULL,
 CONSTRAINT [PK_TAcceso] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  StoredProcedure [dbo].[editar_registro]    Script Date: 03/11/2015 16:30:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_registro]

@id int,
@FormularioNro varchar(50) ,
@Boleto varchar(50) ,
@NombreBeneficiario varchar(50) ,
@MomentoContable varchar(50) ,
@NroTomo int ,
@Gestion int ,
@PeriodoAdeudado varchar(50),
@FechaPago date ,
@Tipo varchar(50),
@ImporteAdeudado float ,
@DescripcionDeuda varchar(max),
@CCNro int ,
@CCFechaPago date ,
@CCImporteAdeudado float,
@CHNro int ,
@CHFechaCobro date,
@CHImporteCheque float

as
update  TRegistro set FormularioNro =@FormularioNro,Boleto = @Boleto,  NombreBeneficiario=@NombreBeneficiario,  MomentoContable = @MomentoContable ,NroTomo=@NroTomo,Gestion=@Gestion,PeriodoAdeudado=@PeriodoAdeudado,FechaPago=@FechaPago,Tipo=@Tipo,ImporteAdeudado=@ImporteAdeudado,
DescripcionDeuda=@DescripcionDeuda,CCNro=@CCNro,CCFechaPago=@CCFechaPago,CCImporteAdeudado=@CCImporteAdeudado,CHNro=@CHNro,CHFechaCobro=@CHFechaCobro,CHImporteCheque=@CHImporteCheque 

where Id=@id
GO
/****** Object:  StoredProcedure [dbo].[editar_usuario]    Script Date: 03/11/2015 16:30:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_usuario]
@idusuario integer,
@nombre varchar (50),
@apellidos varchar(50),	
@ci varchar(9),
@direccion varchar(100),
@telefono varchar(10),
@login varchar(50),
@password varchar(50),
@acceso varchar(50),
@rol varchar(50)
as
update TUsuario set nombre=@nombre,apellidos=@apellidos,ci=@ci,direccion=@direccion,telefono=@telefono,login=@login,password=@password ,acceso=@acceso, rol=@rol
where idusuario=@idusuario

GO
/****** Object:  StoredProcedure [dbo].[insertar_registro]    Script Date: 03/11/2015 16:30:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_registro]

@FormularioNro varchar(50) ,
@Boleto varchar(50) ,
@NombreBeneficiario varchar(50) ,
@MomentoContable varchar(50) ,
@NroTomo  varchar(50) ,
@Gestion  varchar(50) ,
@PeriodoAdeudado varchar(50),
@FechaPago date ,
@Tipo varchar(50),
@ImporteAdeudado float ,
@DescripcionDeuda varchar(max),
@CCNro varchar(50) ,
@CCFechaPago date ,
@CCImporteAdeudado float,
@CHNro  varchar(50) ,
@CHFechaCobro date,
@CHImporteCheque float

as
insert into TRegistro (FormularioNro ,Boleto ,NombreBeneficiario ,MomentoContable,NroTomo,Gestion,PeriodoAdeudado,
FechaPago,Tipo,ImporteAdeudado,DescripcionDeuda ,CCNro,CCFechaPago ,CCImporteAdeudado,
CHNro,CHFechaCobro ,CHImporteCheque ) 
values(@FormularioNro , @Boleto,@NombreBeneficiario,@MomentoContable,@NroTomo,@Gestion,@PeriodoAdeudado,
@FechaPago,@Tipo,@ImporteAdeudado,@DescripcionDeuda,@CCNro,@CCFechaPago,@CCImporteAdeudado,
@CHNro ,@CHFechaCobro ,@CHImporteCheque )
GO
/****** Object:  StoredProcedure [dbo].[insertar_usuario]    Script Date: 03/11/2015 16:30:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_usuario]

@nombre varchar (50),
@apellidos varchar(50),	
@ci varchar(9),
@direccion varchar(100),
@telefono varchar(10),
@login varchar(50),
@password varchar(50),
@acceso varchar(50),
@rol varchar(50)
as
insert into TUsuario(nombre,apellidos,ci,direccion,telefono,login,password,acceso,rol)
values (@nombre,@apellidos,@ci,@direccion,@telefono,@login,@password,@acceso, @rol)


GO
/****** Object:  StoredProcedure [dbo].[mostrar_registro]    Script Date: 03/11/2015 16:30:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[mostrar_registro]
as
SELECT     id,
FormularioNro,
Boleto,
NombreBeneficiario,
MomentoContable,
NroTomo,Gestion,
PeriodoAdeudado,
FechaPago,
Tipo,
ImporteAdeudado,
DescripcionDeuda,
CCNro,CCFechaPago,
CCImporteAdeudado,
CHNro, 
CHFechaCobro, 
CHImporteCheque
FROM         dbo.TRegistro
GO
/****** Object:  StoredProcedure [dbo].[mostrar_registro_por_numero_cheque]    Script Date: 03/11/2015 16:30:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[mostrar_registro_por_numero_cheque]

@NumeroCheque as varchar(50)
as
SELECT     id,
FormularioNro,
Boleto,
NombreBeneficiario,
MomentoContable,
NroTomo,Gestion,
PeriodoAdeudado,
FechaPago,
Tipo,
ImporteAdeudado,
DescripcionDeuda,
CCNro,CCFechaPago,
CCImporteAdeudado,
CHNro, 
CHFechaCobro, 
CHImporteCheque
FROM         dbo.TRegistro
where CHNro = @NumeroCheque
GO
/****** Object:  StoredProcedure [dbo].[mostrar_usuario]    Script Date: 03/11/2015 16:30:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[mostrar_usuario]
as
SELECT     idusuario, nombre, apellidos, ci, direccion, telefono, login, password, acceso, rol
FROM         dbo.TUsuario


GO
/****** Object:  StoredProcedure [dbo].[validar_usuario]    Script Date: 03/11/2015 16:30:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[validar_usuario]
@login varchar(50),
@password varchar(50)
as
SELECT     rol
FROM         dbo.TUsuario
where login = @login and password =@password and acceso='1'


GO
/****** Object:  StoredProcedure [dbo].[validar_usuario_idusuario]    Script Date: 03/11/2015 16:30:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[validar_usuario_idusuario]
@login varchar(50),
@password varchar(50)
as
SELECT    idusuario
FROM         dbo.TUsuario
where login = @login and password =@password and acceso='1'


GO
USE [master]
GO
ALTER DATABASE [BDArchivos] SET  READ_WRITE 
GO
