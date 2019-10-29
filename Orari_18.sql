USE [master]
GO
/****** Object:  Database [Orari]    Script Date: 2016/12/18 12:20:36 PM ******/
CREATE DATABASE [Orari]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Orari_v1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.LEENDY\MSSQL\DATA\Orari_v8.mdf' , SIZE = 19456KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Orari_v1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.LEENDY\MSSQL\DATA\Orari_v8_log.ldf' , SIZE = 26816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Orari] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Orari].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Orari] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Orari] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Orari] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Orari] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Orari] SET ARITHABORT OFF 
GO
ALTER DATABASE [Orari] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Orari] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Orari] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Orari] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Orari] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Orari] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Orari] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Orari] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Orari] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Orari] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Orari] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Orari] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Orari] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Orari] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Orari] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Orari] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Orari] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Orari] SET RECOVERY FULL 
GO
ALTER DATABASE [Orari] SET  MULTI_USER 
GO
ALTER DATABASE [Orari] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Orari] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Orari] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Orari] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Orari] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Orari', N'ON'
GO
USE [Orari]
GO
USE [Orari]
GO
/****** Object:  Sequence [dbo].[seq]    Script Date: 2016/12/18 12:20:36 PM ******/
CREATE SEQUENCE [dbo].[seq] 
 AS [bigint]
 START WITH 1400
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[CPA]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CPA](
	[ID_CPA] [int] IDENTITY(1,1) NOT NULL,
	[CPA] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CPA] PRIMARY KEY CLUSTERED 
(
	[ID_CPA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CPL]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CPL](
	[ID_CPL] [int] IDENTITY(1,1) NOT NULL,
	[ID_Stafi] [int] NOT NULL,
	[ID_Lenda] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_CPL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dep_Lendet]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dep_Lendet](
	[ID_Dep] [int] NOT NULL,
	[ID_Lenda] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departamentet]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentet](
	[ID_Dep] [int] IDENTITY(1,1) NOT NULL,
	[Dep] [nvarchar](50) NOT NULL,
	[ID_Fakulteti] [int] NOT NULL,
 CONSTRAINT [PK_Departamentet] PRIMARY KEY CLUSTERED 
(
	[ID_Dep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Disponueshmeria]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Disponueshmeria](
	[Dita] [varchar](10) NOT NULL,
	[OraPrej] [time](0) NOT NULL,
	[OraDeri] [time](0) NOT NULL,
	[ID_Stafi] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fakultetet]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fakultetet](
	[ID_Fakulteti] [int] IDENTITY(1,1) NOT NULL,
	[Fakulteti] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Fakultetet] PRIMARY KEY CLUSTERED 
(
	[ID_Fakulteti] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lendet]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lendet](
	[ID_Lenda] [int] IDENTITY(1,1) NOT NULL,
	[Lenda] [nvarchar](50) NOT NULL,
	[Kredite] [int] NOT NULL,
	[Semestri] [nvarchar](50) NOT NULL,
	[ID_LlojiLendes] [int] NOT NULL,
 CONSTRAINT [PK_Lendet] PRIMARY KEY CLUSTERED 
(
	[ID_Lenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Llojet e Sallave]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Llojet e Sallave](
	[ID_LlojiSalles] [int] IDENTITY(1,1) NOT NULL,
	[LlojiS] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Llojet e Sallave] PRIMARY KEY CLUSTERED 
(
	[ID_LlojiSalles] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lloji i Lendeve]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lloji i Lendeve](
	[ID_LlojiLendes] [int] IDENTITY(1,1) NOT NULL,
	[LlojiL] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Lloji i Lendeve] PRIMARY KEY CLUSTERED 
(
	[ID_LlojiLendes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LUSH]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LUSH](
	[ID_LUSH] [int] IDENTITY(1,1) NOT NULL,
	[LUSH] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LUSH] PRIMARY KEY CLUSTERED 
(
	[ID_LUSH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Oraret]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oraret](
	[FOres] [time](0) NOT NULL,
	[MOres] [time](0) NOT NULL,
	[ID_Salla] [int] NOT NULL,
	[ID_Lush] [int] NOT NULL,
	[DataMbajtjes] [date] NOT NULL,
	[Grupi] [nvarchar](50) NULL,
	[ID_Dep] [int] NOT NULL,
	[ID_CPL] [int] NOT NULL,
 CONSTRAINT [PK_Oraret_1] PRIMARY KEY CLUSTERED 
(
	[FOres] ASC,
	[MOres] ASC,
	[ID_Salla] ASC,
	[DataMbajtjes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sallat]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sallat](
	[ID_Salla] [int] IDENTITY(1,1) NOT NULL,
	[Salla] [nvarchar](50) NOT NULL,
	[Kapaciteti] [float] NOT NULL,
	[ID_LlojiSalles] [int] NOT NULL,
 CONSTRAINT [PK_Sallat] PRIMARY KEY CLUSTERED 
(
	[ID_Salla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staf_Dep]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staf_Dep](
	[ID_Stafi] [int] NOT NULL,
	[ID_Dep] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stafi]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Stafi](
	[ID_Stafi] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [nvarchar](50) NOT NULL,
	[Mbiemri] [nvarchar](50) NOT NULL,
	[ID_Titulli] [int] NOT NULL,
	[ID_CPA] [int] NOT NULL,
	[Numri_Personal] [varchar](10) NOT NULL,
	[Foto] [image] NOT NULL CONSTRAINT [DF__Stafi__Foto__70DDC3D8]  DEFAULT ('E:\default-user.jpg'),
	[Foto_Emri] [nvarchar](50) NOT NULL,
	[Fjalekalimi] [nvarchar](30) NOT NULL,
	[ID_LOG] [varchar](10) NOT NULL CONSTRAINT [DF__Stafi__ID_LOG__06CD04F7]  DEFAULT (NEXT VALUE FOR [seq]),
	[Email] [varchar](320) NULL,
	[Roli] [nvarchar](10) NOT NULL CONSTRAINT [DEF_Perdorues]  DEFAULT ('User'),
	[passNderruar] [bit] NULL CONSTRAINT [DF_Stafi_passNderruar]  DEFAULT ((0)),
 CONSTRAINT [PK_Stafi] PRIMARY KEY CLUSTERED 
(
	[ID_Stafi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [unik_personal_number] UNIQUE NONCLUSTERED 
(
	[Numri_Personal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Stafi__2DBE379C935529FC] UNIQUE NONCLUSTERED 
(
	[ID_LOG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Titujt Shkencor]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titujt Shkencor](
	[ID_Titulli] [int] IDENTITY(1,1) NOT NULL,
	[Titulli] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Titujt Shkencor] PRIMARY KEY CLUSTERED 
(
	[ID_Titulli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CPL]  WITH CHECK ADD  CONSTRAINT [FK_CPL_Lendet] FOREIGN KEY([ID_Lenda])
REFERENCES [dbo].[Lendet] ([ID_Lenda])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CPL] CHECK CONSTRAINT [FK_CPL_Lendet]
GO
ALTER TABLE [dbo].[CPL]  WITH CHECK ADD  CONSTRAINT [FK_CPL_Stafi] FOREIGN KEY([ID_Stafi])
REFERENCES [dbo].[Stafi] ([ID_Stafi])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CPL] CHECK CONSTRAINT [FK_CPL_Stafi]
GO
ALTER TABLE [dbo].[Dep_Lendet]  WITH CHECK ADD  CONSTRAINT [FK_Dep_Lendet_Departamentet] FOREIGN KEY([ID_Dep])
REFERENCES [dbo].[Departamentet] ([ID_Dep])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Dep_Lendet] CHECK CONSTRAINT [FK_Dep_Lendet_Departamentet]
GO
ALTER TABLE [dbo].[Dep_Lendet]  WITH CHECK ADD  CONSTRAINT [FK_Dep_Lendet_Lendet] FOREIGN KEY([ID_Lenda])
REFERENCES [dbo].[Lendet] ([ID_Lenda])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Dep_Lendet] CHECK CONSTRAINT [FK_Dep_Lendet_Lendet]
GO
ALTER TABLE [dbo].[Departamentet]  WITH CHECK ADD  CONSTRAINT [FK_Departamentet_Fakultetet] FOREIGN KEY([ID_Fakulteti])
REFERENCES [dbo].[Fakultetet] ([ID_Fakulteti])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Departamentet] CHECK CONSTRAINT [FK_Departamentet_Fakultetet]
GO
ALTER TABLE [dbo].[Disponueshmeria]  WITH CHECK ADD  CONSTRAINT [FK_Disponueshmeria_Stafi] FOREIGN KEY([ID_Stafi])
REFERENCES [dbo].[Stafi] ([ID_Stafi])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Disponueshmeria] CHECK CONSTRAINT [FK_Disponueshmeria_Stafi]
GO
ALTER TABLE [dbo].[Lendet]  WITH CHECK ADD  CONSTRAINT [FK_Lendet_Lloji i Lendeve1] FOREIGN KEY([ID_LlojiLendes])
REFERENCES [dbo].[Lloji i Lendeve] ([ID_LlojiLendes])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Lendet] CHECK CONSTRAINT [FK_Lendet_Lloji i Lendeve1]
GO
ALTER TABLE [dbo].[Oraret]  WITH CHECK ADD  CONSTRAINT [FK_Oraret_CPL] FOREIGN KEY([ID_CPL])
REFERENCES [dbo].[CPL] ([ID_CPL])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Oraret] CHECK CONSTRAINT [FK_Oraret_CPL]
GO
ALTER TABLE [dbo].[Oraret]  WITH CHECK ADD  CONSTRAINT [FK_Oraret_Departamentet] FOREIGN KEY([ID_Dep])
REFERENCES [dbo].[Departamentet] ([ID_Dep])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Oraret] CHECK CONSTRAINT [FK_Oraret_Departamentet]
GO
ALTER TABLE [dbo].[Oraret]  WITH CHECK ADD  CONSTRAINT [FK_Oraret_LUSH] FOREIGN KEY([ID_Lush])
REFERENCES [dbo].[LUSH] ([ID_LUSH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Oraret] CHECK CONSTRAINT [FK_Oraret_LUSH]
GO
ALTER TABLE [dbo].[Oraret]  WITH CHECK ADD  CONSTRAINT [FK_Oraret_Sallat] FOREIGN KEY([ID_Salla])
REFERENCES [dbo].[Sallat] ([ID_Salla])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Oraret] CHECK CONSTRAINT [FK_Oraret_Sallat]
GO
ALTER TABLE [dbo].[Sallat]  WITH CHECK ADD  CONSTRAINT [FK_Sallat_Llojet e Sallave] FOREIGN KEY([ID_LlojiSalles])
REFERENCES [dbo].[Llojet e Sallave] ([ID_LlojiSalles])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sallat] CHECK CONSTRAINT [FK_Sallat_Llojet e Sallave]
GO
ALTER TABLE [dbo].[Staf_Dep]  WITH CHECK ADD  CONSTRAINT [FK_Staf_Dep_Departamentet] FOREIGN KEY([ID_Dep])
REFERENCES [dbo].[Departamentet] ([ID_Dep])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Staf_Dep] CHECK CONSTRAINT [FK_Staf_Dep_Departamentet]
GO
ALTER TABLE [dbo].[Staf_Dep]  WITH CHECK ADD  CONSTRAINT [FK_Staf_Dep_Stafi] FOREIGN KEY([ID_Stafi])
REFERENCES [dbo].[Stafi] ([ID_Stafi])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Staf_Dep] CHECK CONSTRAINT [FK_Staf_Dep_Stafi]
GO
ALTER TABLE [dbo].[Stafi]  WITH CHECK ADD  CONSTRAINT [FK_Stafi_CPA] FOREIGN KEY([ID_CPA])
REFERENCES [dbo].[CPA] ([ID_CPA])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Stafi] CHECK CONSTRAINT [FK_Stafi_CPA]
GO
ALTER TABLE [dbo].[Stafi]  WITH CHECK ADD  CONSTRAINT [FK_Stafi_Titujt Shkencor] FOREIGN KEY([ID_Titulli])
REFERENCES [dbo].[Titujt Shkencor] ([ID_Titulli])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Stafi] CHECK CONSTRAINT [FK_Stafi_Titujt Shkencor]
GO
/****** Object:  StoredProcedure [dbo].[getLendetFromSemestri]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getLendetFromSemestri](@semestri NVARCHAR(50))
AS
BEGIN
	SELECT llL.LlojiL, L.Lenda FROM [Lloji i Lendeve] AS llL 
	INNER JOIN Lendet AS L 
	ON llL.ID_LlojiLendes = L.ID_LlojiLendes
	WHERE L.Semestri = @semestri
	ORDER BY llL.LlojiL ASC
END
GO
/****** Object:  StoredProcedure [dbo].[modify_date]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[modify_date] @table_name NVARCHAR(50)
AS
BEGIN
IF GETDATE() <> (SELECT modify_date FROM sys.tables WHERE name = @table_name)
SELECT (0) AS RESULT;
ELSE
SELECT (1) AS RESULT;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_depFromSemester]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_depFromSemester](@semestri NVARCHAR(50))
AS
BEGIN
	SELECT DISTINCT D.Dep FROM Lendet AS L INNER JOIN Dep_Lendet AS Dl 
	ON L.ID_Lenda = Dl.ID_Lenda 
	INNER JOIN Departamentet AS D 
	ON Dl.ID_Dep = D.ID_Dep 
	WHERE L.Semestri = @semestri
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getAssistent]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getAssistent] (@subject NVARCHAR(150))
AS
BEGIN
SELECT CONCAT(S.Emri,' ',S.Mbiemri) AS [Emri Mbiemri], C.CPA FROM CPL INNER JOIN Stafi S ON CPL.ID_Stafi = S.ID_Stafi INNER JOIN CPA C ON S.ID_CPA=C.ID_CPA INNER JOIN Lendet L ON CPL.ID_Lenda = L.ID_Lenda WHERE L.Lenda = @subject AND C.CPA = 'Assistent';
END

GO
/****** Object:  StoredProcedure [dbo].[sp_getProfessor]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_getProfessor] (@subject NVARCHAR(150))
AS
BEGIN
SELECT CONCAT(S.Emri,' ',S.Mbiemri) AS [Emri Mbiemri], C.CPA FROM CPL INNER JOIN Stafi S ON CPL.ID_Stafi = S.ID_Stafi INNER JOIN CPA C ON S.ID_CPA=C.ID_CPA INNER JOIN Lendet L ON CPL.ID_Lenda = L.ID_Lenda WHERE L.Lenda = @subject AND C.CPA = 'Professor';
END

GO
/****** Object:  StoredProcedure [dbo].[sp_insertStaff]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insertStaff] (@dep INT)
AS 
BEGIN
	DECLARE @insertedStaff INT;
	SET @insertedStaff = (SELECT TOP 1 ID_Stafi FROM Stafi ORDER BY ID_Stafi DESC);

	INSERT INTO Staf_Dep VALUES(@insertedStaff, @dep);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertSubject]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertSubject] (@lenda VARCHAR(150), @ECTS TINYINT, @Semester TINYINT, @type INT, @dep INT)
AS
BEGIN
	DECLARE @insertedSubject INT;
	INSERT INTO Lendet VALUES(@lenda, @ECTS, @Semester, @type);

	SET @insertedSubject = (SELECT TOP 1 ID_Lenda FROM Lendet ORDER BY ID_Lenda DESC);

	INSERT INTO Dep_Lendet VALUES(@dep, @insertedSubject);
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Orari]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Orari] AS
SELECT 
	f.Fakulteti,
	o.Viti,
	l.Lenda,
	s.Emri ,
	s.Mbiemri,
	o.FOres,
	o.MOres,
	o.DataMbajtjes,
	sa.Salla,
	sa.Kapaciteti,
	lsh.LUSH as "Ligjerate/Ushtrime",
	c.CPA as "Lloji"
	
	FROM Oraret AS o
	
	INNER JOIN Lendet l
	ON o.ID_Lenda = l.ID_Lenda
	
	INNER JOIN Sallat sa
	ON o.ID_Salla = sa.ID_Salla

	INNER JOIN stafi s
	ON o.ID_Stafi = s.ID_Stafi

	INNER JOIN Fakultetet f
	ON o.ID_Fakulteti = f.ID_Fakulteti

	INNER JOIN LUSH lsh
	ON o.ID_Lush = lsh.ID_LUSH
	
	INNER JOIN CPA c
	ON s.ID_CPA = c.ID_CPA


GO
/****** Object:  StoredProcedure [dbo].[SP_searchEmployee]    Script Date: 2016/12/18 12:20:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_searchEmployee] @emri NVARCHAR(70)
AS
BEGIN
SELECT (T.Titulli + S.Emri + ' ' + S.Mbiemri) AS Employee, S.Numri_Personal AS [Personal no.], S.ID_LOG AS [User], S.Email 
FROM Stafi AS S
LEFT JOIN [dbo].[Titujt Shkencor] AS T
ON S.ID_Titulli = T.ID_Titulli
WHERE (S.Emri LIKE '%'+@emri+'%' OR (S.Emri + ' ' + S.Mbiemri) LIKE '%'+@emri+'%' OR S.Mbiemri LIKE '%'+@emri+'%' OR S.Numri_Personal LIKE '%'+@emri+'%' OR S.ID_Log LIKE '%'+@emri+'%' OR S.Email LIKE '%'+@emri+'%') AND Roli <> 'Admin';
END
GO
USE [master]
GO
ALTER DATABASE [Orari] SET  READ_WRITE 
GO
