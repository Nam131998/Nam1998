

USE [QuanLyTiecCuoi]
GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[TenQuyDinh] [nvarchar](100) NOT NULL,
	[GiaTri] [float] NULL,
 CONSTRAINT [PK_THAMSO] PRIMARY KEY CLUSTERED 
(
	[TenQuyDinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MaDichVu] [int] IDENTITY(1,1) NOT NULL,
	[TenDichVu] [nvarchar](100) NOT NULL,
	[DonGia] [decimal](18, 0) NOT NULL,
	[HinhAnh] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONAN]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONAN](
	[MaMonAn] [int] IDENTITY(1,1) NOT NULL,
	[TenMonAn] [nvarchar](100) NOT NULL,
	[DonGia] [decimal](18, 0) NOT NULL,
	[HinhAnh] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_MonAn] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAISANH]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISANH](
	[MaLoaiSanh] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiSanh] [nvarchar](100) NULL,
	[DonGiaBanToiThieu] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_LoaiSanh_1] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSanh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](100) NOT NULL,
	[PhanQuyen] [int] NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CA]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CA](
	[MaCa] [int] IDENTITY(1,1) NOT NULL,
	[TenCa] [nvarchar](100) NULL,
 CONSTRAINT [PK_Ca] PRIMARY KEY CLUSTERED 
(
	[MaCa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[BoDau]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[BoDau](@inputVar NVARCHAR(MAX) )
RETURNS NVARCHAR(MAX)
AS
BEGIN   
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
  
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
  
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN 
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN         
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)     
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-')
   
    RETURN @inputVar
END
GO
/****** Object:  Table [dbo].[BAOCAOTHANG]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAOTHANG](
	[MaBCT] [int] IDENTITY(1,1) NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[TongSoLuongTiecCuoi] [int] NOT NULL,
	[TongDoanhThu] [int] NOT NULL,
 CONSTRAINT [PK_BaoCaoDoanhThu] PRIMARY KEY CLUSTERED 
(
	[MaBCT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BAOCAONGAY]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAONGAY](
	[MaBCT] [int] NOT NULL,
	[Ngay] [int] NOT NULL,
	[SoLuongTiecCuoi] [int] NULL,
	[DoanhThu] [decimal](18, 0) NULL,
	[TiLe] [float] NULL,
 CONSTRAINT [PK_BAOCAONGAY] PRIMARY KEY CLUSTERED 
(
	[MaBCT] ASC,
	[Ngay] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar] (5) NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
	[DienThoai] [varchar](15) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[AnhDaiDien] [varchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANH]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANH](
	[MaSanh] [int] IDENTITY(1,1) NOT NULL,
	[TenSanh] [nvarchar](100) NOT NULL,
	[MaLoaiSanh] [int] NOT NULL,
	[SoLuongBanToiDa] [int] NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiSanh] PRIMARY KEY CLUSTERED 
(
	[MaSanh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIECCUOI]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIECCUOI](
	[MaTiecCuoi] [int] IDENTITY(1,1) NOT NULL,
	[TenChuRe] [nvarchar](100) NOT NULL,
	[TenCoDau] [nvarchar](100) NOT NULL,
	[DienThoai] [nvarchar](12) NULL,
	[NgayDatTiec] [datetime] NOT NULL,
	[NgayDaiTiec] [datetime] NOT NULL,
	[MaCa] [int] NOT NULL,
	[MaSanh] [int] NOT NULL,
	[TienCoc] [decimal](18, 0) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
	[MaNV] [int] NOT NULL,
	[TinhTrangTiec] [int] NULL,
 CONSTRAINT [PK_HoaDonTiecCuoi] PRIMARY KEY CLUSTERED 
(
	[MaTiecCuoi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUDATBAN]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUDATBAN](
	[MaPhieuDatBan] [int] IDENTITY(1,1) NOT NULL,
	[MaTiecCuoi] [int] NOT NULL,
	[SoBan] [int] NOT NULL,
	[SoBanDuTru] [int] NOT NULL,
	[DonGiaBan] [decimal](18, 0) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_PHIEUDATBAN] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDatBan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[SoHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[MaTiecCuoi] [int] NOT NULL,
	[NgayThanhToan] [datetime] NULL,
	[TongTienBan] [decimal](18, 0) NULL,
	[TongTienDichVu] [decimal](18, 0) NULL,
	[TongTienHoaDon] [decimal](18, 0) NULL,
	[ConLai] [decimal](18, 0) NULL,
	[TienDaThanhToan] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[SoHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_PHIEUDATDICHVU]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUDATDICHVU](
	[MaTiecCuoi] [int] NOT NULL,
	[MaDichVu] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_CT_PHIEUDATDICHVU] PRIMARY KEY CLUSTERED 
(
	[MaTiecCuoi] ASC,
	[MaDichVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_PHIEUDATBAN]    Script Date: 07/11/2016 21:09:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUDATBAN](
	[MaPhieuDatBan] [int] NOT NULL,
	[MaMonAn] [int] NOT NULL,
	[DonGia] [decimal](18, 0) NULL,
	[SoLuong] [int] NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChiTietThucDonTiecCuoi] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDatBan] ASC,
	[MaMonAn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_BAOCAONGAY_BAOCAOTHANG]    Script Date: 07/11/2016 21:09:43 ******/
ALTER TABLE [dbo].[BAOCAONGAY]  WITH CHECK ADD  CONSTRAINT [FK_BAOCAONGAY_BAOCAOTHANG] FOREIGN KEY([MaBCT])
REFERENCES [dbo].[BAOCAOTHANG] ([MaBCT])
GO
ALTER TABLE [dbo].[BAOCAONGAY] CHECK CONSTRAINT [FK_BAOCAONGAY_BAOCAOTHANG]
GO
/****** Object:  ForeignKey [FK_CT_PHIEUDATBAN_MonAn]    Script Date: 07/11/2016 21:09:43 ******/
ALTER TABLE [dbo].[CT_PHIEUDATBAN]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUDATBAN_MonAn] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MONAN] ([MaMonAn])
GO
ALTER TABLE [dbo].[CT_PHIEUDATBAN] CHECK CONSTRAINT [FK_CT_PHIEUDATBAN_MonAn]
GO
/****** Object:  ForeignKey [FK_CT_PHIEUDATBAN_PHIEUDATBAN]    Script Date: 07/11/2016 21:09:43 ******/
ALTER TABLE [dbo].[CT_PHIEUDATBAN]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUDATBAN_PHIEUDATBAN] FOREIGN KEY([MaPhieuDatBan])
REFERENCES [dbo].[PHIEUDATBAN] ([MaPhieuDatBan])
GO
ALTER TABLE [dbo].[CT_PHIEUDATBAN] CHECK CONSTRAINT [FK_CT_PHIEUDATBAN_PHIEUDATBAN]
GO
/****** Object:  ForeignKey [FK_CT_PHIEUDATDICHVU_DichVu]    Script Date: 07/11/2016 21:09:43 ******/
ALTER TABLE [dbo].[CT_PHIEUDATDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUDATDICHVU_DichVu] FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DICHVU] ([MaDichVu])
GO
ALTER TABLE [dbo].[CT_PHIEUDATDICHVU] CHECK CONSTRAINT [FK_CT_PHIEUDATDICHVU_DichVu]
GO
/****** Object:  ForeignKey [FK_CT_PHIEUDATDICHVU_TIECCUOI]    Script Date: 07/11/2016 21:09:43 ******/
ALTER TABLE [dbo].[CT_PHIEUDATDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUDATDICHVU_TIECCUOI] FOREIGN KEY([MaTiecCuoi])
REFERENCES [dbo].[TIECCUOI] ([MaTiecCuoi])
GO
ALTER TABLE [dbo].[CT_PHIEUDATDICHVU] CHECK CONSTRAINT [FK_CT_PHIEUDATDICHVU_TIECCUOI]
GO
/****** Object:  ForeignKey [FK_HOADON_TIECCUOI]    Script Date: 07/11/2016 21:09:43 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_TIECCUOI] FOREIGN KEY([MaTiecCuoi])
REFERENCES [dbo].[TIECCUOI] ([MaTiecCuoi])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_TIECCUOI]
GO


/****** Object:  ForeignKey [FK_PHIEUDATBAN_TIECCUOI]    Script Date: 07/11/2016 21:09:43 ******/
ALTER TABLE [dbo].[PHIEUDATBAN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUDATBAN_TIECCUOI] FOREIGN KEY([MaTiecCuoi])
REFERENCES [dbo].[TIECCUOI] ([MaTiecCuoi])
GO
ALTER TABLE [dbo].[PHIEUDATBAN] CHECK CONSTRAINT [FK_PHIEUDATBAN_TIECCUOI]
GO
/****** Object:  ForeignKey [FK_Sanh_LoaiSanh]    Script Date: 07/11/2016 21:09:43 ******/
ALTER TABLE [dbo].[SANH]  WITH CHECK ADD  CONSTRAINT [FK_Sanh_LoaiSanh] FOREIGN KEY([MaLoaiSanh])
REFERENCES [dbo].[LOAISANH] ([MaLoaiSanh])
GO
ALTER TABLE [dbo].[SANH] CHECK CONSTRAINT [FK_Sanh_LoaiSanh]
GO
/****** Object:  ForeignKey [FK_TIECCUOI_Ca]    Script Date: 07/11/2016 21:09:43 ******/
ALTER TABLE [dbo].[TIECCUOI]  WITH CHECK ADD  CONSTRAINT [FK_TIECCUOI_Ca] FOREIGN KEY([MaCa])
REFERENCES [dbo].[CA] ([MaCa])
GO
ALTER TABLE [dbo].[TIECCUOI] CHECK CONSTRAINT [FK_TIECCUOI_Ca]
GO
/****** Object:  ForeignKey [FK_TIECCUOI_NhanVien]    Script Date: 07/11/2016 21:09:43 ******/
ALTER TABLE [dbo].[TIECCUOI]  WITH CHECK ADD  CONSTRAINT [FK_TIECCUOI_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[TIECCUOI] CHECK CONSTRAINT [FK_TIECCUOI_NhanVien]
GO
/****** Object:  ForeignKey [FK_TIECCUOI_SANH]    Script Date: 07/11/2016 21:09:43 ******/
ALTER TABLE [dbo].[TIECCUOI]  WITH CHECK ADD  CONSTRAINT [FK_TIECCUOI_SANH] FOREIGN KEY([MaSanh])
REFERENCES [dbo].[SANH] ([MaSanh])
GO
ALTER TABLE [dbo].[TIECCUOI] CHECK CONSTRAINT [FK_TIECCUOI_SANH]
GO
