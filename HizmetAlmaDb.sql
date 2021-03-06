USE [master]
GO
/****** Object:  Database [ProcProjeDb]    Script Date: 5.06.2022 22:54:46 ******/
CREATE DATABASE [ProcProjeDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProcProjeDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProcProjeDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProcProjeDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProcProjeDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProcProjeDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProcProjeDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProcProjeDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProcProjeDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProcProjeDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProcProjeDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProcProjeDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProcProjeDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProcProjeDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProcProjeDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProcProjeDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProcProjeDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProcProjeDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProcProjeDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProcProjeDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProcProjeDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProcProjeDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProcProjeDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProcProjeDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProcProjeDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProcProjeDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProcProjeDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProcProjeDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProcProjeDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProcProjeDb] SET RECOVERY FULL 
GO
ALTER DATABASE [ProcProjeDb] SET  MULTI_USER 
GO
ALTER DATABASE [ProcProjeDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProcProjeDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProcProjeDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProcProjeDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProcProjeDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProcProjeDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProcProjeDb', N'ON'
GO
ALTER DATABASE [ProcProjeDb] SET QUERY_STORE = OFF
GO
USE [ProcProjeDb]
GO
/****** Object:  Table [dbo].[Calisans]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calisans](
	[CalisanId] [int] IDENTITY(1,1) NOT NULL,
	[KulAd] [varchar](50) NULL,
	[Sifre] [varchar](50) NULL,
 CONSTRAINT [PK_Calisans] PRIMARY KEY CLUSTERED 
(
	[CalisanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hizmetlers]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hizmetlers](
	[HizmetNo] [int] IDENTITY(1,1) NOT NULL,
	[HizmetAdi] [varchar](50) NULL,
	[HizmetTanimi] [varchar](50) NULL,
	[HizmetFiyat] [int] NULL,
 CONSTRAINT [PK_Hizmetlers] PRIMARY KEY CLUSTERED 
(
	[HizmetNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musterilers]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musterilers](
	[MusteriNo] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [varchar](50) NULL,
	[Telefon] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Adres] [varchar](50) NULL,
 CONSTRAINT [PK_Musterilers] PRIMARY KEY CLUSTERED 
(
	[MusteriNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Taleps]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taleps](
	[TalepNo] [int] IDENTITY(1,1) NOT NULL,
	[HizmetNo] [int] NULL,
	[MusteriNo] [int] NULL,
	[MusteriNot] [varchar](50) NULL,
	[TalepDurumu] [bit] NULL,
 CONSTRAINT [PK_Taleps] PRIMARY KEY CLUSTERED 
(
	[TalepNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Calisans] ON 

INSERT [dbo].[Calisans] ([CalisanId], [KulAd], [Sifre]) VALUES (1, N'm', N'm')
INSERT [dbo].[Calisans] ([CalisanId], [KulAd], [Sifre]) VALUES (2, N'as', N'as')
INSERT [dbo].[Calisans] ([CalisanId], [KulAd], [Sifre]) VALUES (9, N'ahmet12', N'as')
INSERT [dbo].[Calisans] ([CalisanId], [KulAd], [Sifre]) VALUES (10, N'ali', N'ali123')
SET IDENTITY_INSERT [dbo].[Calisans] OFF
GO
SET IDENTITY_INSERT [dbo].[Hizmetlers] ON 

INSERT [dbo].[Hizmetlers] ([HizmetNo], [HizmetAdi], [HizmetTanimi], [HizmetFiyat]) VALUES (2, N'Ofis Temizliği', N'1 saat üzerinden ücretlendirme yapılır.', 242)
INSERT [dbo].[Hizmetlers] ([HizmetNo], [HizmetAdi], [HizmetTanimi], [HizmetFiyat]) VALUES (3, N'Özel Ders', N'Matematik Dersi', 150)
INSERT [dbo].[Hizmetlers] ([HizmetNo], [HizmetAdi], [HizmetTanimi], [HizmetFiyat]) VALUES (6, N'Ev Temizliği', N'1 saat üzerinden ücretlendirme yapılır.', 400)
SET IDENTITY_INSERT [dbo].[Hizmetlers] OFF
GO
SET IDENTITY_INSERT [dbo].[Musterilers] ON 

INSERT [dbo].[Musterilers] ([MusteriNo], [AdSoyad], [Telefon], [Mail], [Adres]) VALUES (1, N'Ayşe Erkuş', N'ayse@gmail.com', N'ayse@gmail.com', N'İstanbul/ Bağcılar')
INSERT [dbo].[Musterilers] ([MusteriNo], [AdSoyad], [Telefon], [Mail], [Adres]) VALUES (2, N'Pakize Arslan', N'(002) 154-9433', N'paki@gmail.com', N'Kocaeli/ Merkez')
INSERT [dbo].[Musterilers] ([MusteriNo], [AdSoyad], [Telefon], [Mail], [Adres]) VALUES (3, N'Asya Öz', N'(054) 345-6511', N'asya01@htomail.com', N'Muş')
INSERT [dbo].[Musterilers] ([MusteriNo], [AdSoyad], [Telefon], [Mail], [Adres]) VALUES (5, N'Ali Can', N'(212) 121-2122', N'alicaan@gmail.com', N'Ankara')
SET IDENTITY_INSERT [dbo].[Musterilers] OFF
GO
SET IDENTITY_INSERT [dbo].[Taleps] ON 

INSERT [dbo].[Taleps] ([TalepNo], [HizmetNo], [MusteriNo], [MusteriNot], [TalepDurumu]) VALUES (7, 3, 3, N'Haftada 1 saat şeklinde istiyoruz.', 0)
INSERT [dbo].[Taleps] ([TalepNo], [HizmetNo], [MusteriNo], [MusteriNot], [TalepDurumu]) VALUES (15, 6, 2, N'Hergün 1 ile 5 arası gelinecek', 0)
INSERT [dbo].[Taleps] ([TalepNo], [HizmetNo], [MusteriNo], [MusteriNot], [TalepDurumu]) VALUES (16, 3, 3, N'Haftada 3 saat şeklinde istiyoruz.', 0)
INSERT [dbo].[Taleps] ([TalepNo], [HizmetNo], [MusteriNo], [MusteriNot], [TalepDurumu]) VALUES (17, 2, 2, N'Akşam biz ofiste3n çıktıktan sonra temizliğe başla', 1)
SET IDENTITY_INSERT [dbo].[Taleps] OFF
GO
/****** Object:  Index [IX_FK_Talep_Hizmetler]    Script Date: 5.06.2022 22:54:46 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Talep_Hizmetler] ON [dbo].[Taleps]
(
	[HizmetNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Talep_Musteriler]    Script Date: 5.06.2022 22:54:46 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Talep_Musteriler] ON [dbo].[Taleps]
(
	[MusteriNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Taleps]  WITH CHECK ADD  CONSTRAINT [FK_Talep_Hizmetler] FOREIGN KEY([HizmetNo])
REFERENCES [dbo].[Hizmetlers] ([HizmetNo])
GO
ALTER TABLE [dbo].[Taleps] CHECK CONSTRAINT [FK_Talep_Hizmetler]
GO
ALTER TABLE [dbo].[Taleps]  WITH CHECK ADD  CONSTRAINT [FK_Talep_Musteriler] FOREIGN KEY([MusteriNo])
REFERENCES [dbo].[Musterilers] ([MusteriNo])
GO
ALTER TABLE [dbo].[Taleps] CHECK CONSTRAINT [FK_Talep_Musteriler]
GO
/****** Object:  StoredProcedure [dbo].[Calisan_add]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Calisan_add]
@kulAd varchar(50),
@sifre varchar(50)
as begin 
insert into [dbo].[Calisans](KulAd, Sifre) values(@kulAd, @sifre)
end
GO
/****** Object:  StoredProcedure [dbo].[CalisanKulAdKONTROL]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CalisanKulAdKONTROL]
@kulAd varchar(50)
as begin 
Select * from [dbo].[Calisans] where KulAd=@kulAd
end
GO
/****** Object:  StoredProcedure [dbo].[Calisanlogin]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Calisanlogin]
@kulAd varchar(50),
@sifre varchar(50)
as begin 
Select * from [dbo].[Calisans] where KulAd=@kulAd and Sifre= @sifre
end
GO
/****** Object:  StoredProcedure [dbo].[Hizmetler_add]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Hizmetler_add]
@hizmetAdi varchar(50),
@hizmetTanimi varchar(50), 
@hizmetFiyat int
as begin 
insert into [dbo].[Hizmetlers](HizmetAdi, HizmetTanimi, HizmetFiyat) values 
(@hizmetAdi, @hizmetTanimi, @hizmetFiyat)
End
GO
/****** Object:  StoredProcedure [dbo].[Hizmetler_Del]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Hizmetler_Del]
@HizmetNo int
as begin
Delete from [dbo].[Hizmetlers] where HizmetNo=@HizmetNo
end
GO
/****** Object:  StoredProcedure [dbo].[Hizmetler_up]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Hizmetler_up]
@hizmetNo int, @hizmetAdi varchar(50), @hizmetTanimi varchar(50), @hizmetFiyat int
as begin
update [dbo].[Hizmetlers] set HizmetAdi=@hizmetAdi, HizmetTanimi=@hizmetTanimi, HizmetFiyat=@hizmetFiyat
where HizmetNo=@hizmetNo
end
GO
/****** Object:  StoredProcedure [dbo].[HizmetlerList]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HizmetlerList]
as begin
Select * from [dbo].[Hizmetlers]
end
GO
/****** Object:  StoredProcedure [dbo].[Musteri_add]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Musteri_add]
@AdSoyad varchar(50),
@Telefon varchar(50),
@Mail varchar(50),
@Adres varchar(50)

as begin 
insert into [dbo].[Musterilers] (AdSoyad,Telefon, Mail, Adres) values 
(@AdSoyad, @Telefon,  @Mail, @Adres)
End
GO
/****** Object:  StoredProcedure [dbo].[Musteriler_del]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Musteriler_del]
@musteriNo int
as begin
Delete from [dbo].[Musterilers] where MusteriNo=@musteriNo
end
GO
/****** Object:  StoredProcedure [dbo].[Musteriler_up]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Musteriler_up]
@MusteriNo int,
@AdSoyad varchar(50),
@Telefon varchar(50),
@Mail varchar(50),
@Adres varchar(50)

as begin
update [dbo].[Musterilers] set AdSoyad=@AdSoyad, Telefon=@Telefon, 
Adres=@Adres, Mail=@Mail where MusteriNo=@MusteriNo
end
GO
/****** Object:  StoredProcedure [dbo].[MusteriList]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MusteriList]
as begin 
Select * from [dbo].[Musterilers]
end
GO
/****** Object:  StoredProcedure [dbo].[TalepAdd]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TalepAdd]
@HizmetNo int,
@MusteriNo int,
@MusteriNot varchar(50),
@TalepDurumu bit
as begin
insert into [dbo].[Taleps] (HizmetNo, MusteriNo, MusteriNot, TalepDurumu) values (@HizmetNo, @MusteriNo, @MusteriNot, @TalepDurumu)
end
GO
/****** Object:  StoredProcedure [dbo].[TalepDel]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TalepDel]
@TalepNo int
as begin
delete from [dbo].[Taleps] where TalepNo=@TalepNo
end
GO
/****** Object:  StoredProcedure [dbo].[TalepList]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TalepList]
as begin 
Select * from [dbo].[Taleps]
end
GO
/****** Object:  StoredProcedure [dbo].[TalepUpdate]    Script Date: 5.06.2022 22:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TalepUpdate]
@TalepNo int,
@HizmetNo int,
@MusteriNo int,
@MusteriNot varchar(50),
@TalepDurumu bit
as begin
Update [dbo].[Taleps] set HizmetNo=@HizmetNo, MusteriNo=@MusteriNo, MusteriNot=@MusteriNot, TalepDurumu=@TalepDurumu where TalepNo=@TalepNo
end
GO
USE [master]
GO
ALTER DATABASE [ProcProjeDb] SET  READ_WRITE 
GO
