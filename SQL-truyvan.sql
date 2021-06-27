use [Quản lý trung tâm học thêm]

-- Search LH

-- Ma lop --
create procedure searchMaLop @malop char(10)
as 
begin
	select MaLH, TenLH, MaMH, MaGV, MaMHP
	from LOPHOC
	where MaLH = @malop
end
go

-- Ten lop --
create procedure searchTenLop @tenlop char(10)
as 
begin
	select MaLH, TenLH, MaMH, MaGV, MaMHP
	from LOPHOC
	where TenLH = @tenlop
end
go

-- -----------------
create sequence LHSeq
	start with 1000 --bat dau tu 1000
	increment by 1; --moi lan tang 1 don vi
	select next value for LHSeq
go

create procedure ThemMoiLH	
	@TenLH nvarchar(20),
	@MaMH char(6),
	@MaGV char(6),
	@MaMHP char(6)
as 
begin
	insert into LOPHOC
	(
		MaLH, TenLH, MaMH, MaGV, MaMHP
	)values(
		'LH' + cast(next value for LHSeq as char(10)),
		@TenLH,
		@MaMH,
		@MaGV,
		@MaMHP
	);
		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end

go

create procedure UpdateLH
	@TenLH nvarchar(20),
	@MaMH char(6),
	@MaGV char(6),
	@MaMHP char(6)
as 
begin
	update LOPHOC
	set 		
		TenLH = @TenLH,
		MaMH = @MaMH,
		MaGV = @MaGV,
		MaMHP = @MaMHP
	where MaLH = @MaLH;

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end
go
create sequence BuoiHocSeq
	start with 1000 --bat dau tu 1000
	increment by 1; --moi lan tang 1 don vi
	select next value for BuoiHocSeq
go

create procedure ThemMoiBH
	@thoiGian datetime,
	@MaLH char(6)
as 
begin
	insert into BUOIHOC
	(
		MaBH, ThoiGian, MaLH
	)values(
		'BH' + cast(next value for BuoiHocSeq as char(6)),
		@thoiGian,
		@MaLH
	);
		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end

go
create procedure ThemMoiDD	
	@MaBH char(6),
	@MaHV char(6),
	@CoTrenLop bit
as 
begin
	insert into DIEMDANH
	(
		MaBH, MaHV, CoTrenLop
	)values(
		@MaBH,
		@MaHV,
		@CoTrenLop
	);
		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end
go
create FUNCTION XemBuoiHoc(@MaHV char(10))
RETURNS TABLE
AS
	RETURN (
		SELECT bh.MaBH, bh.MaLH, dd.CoTrenLop, bh.ThoiGian
		FROM HOCVIEN hv, DIEMDANH dd, BUOIHOC bh
		WHERE hv.MaHV = dd.MaHV and bh.MaBH = dd.MaBH and hv.MaHV = @MaHV
		and bh.ThoiGian BETWEEN '2020-10-01 00:00:00' AND '2020-11-01 00:00:00' 
	)
go

create FUNCTION TESTXemBuoiHoc( @malop char(10), @start varchar(50), @end varchar(50))
RETURNS TABLE
AS
	RETURN (
		SELECT hv.MaHV, hv.HoTen, bh.MaBH, bh.MaLH, dd.CoTrenLop, bh.ThoiGian
		FROM HOCVIEN hv, DIEMDANH dd, BUOIHOC bh
		WHERE hv.MaHV = dd.MaHV and bh.MaBH = dd.MaBH and bh.MaLH = @malop
		and bh.ThoiGian BETWEEN @start AND @end 
	)
go

create FUNCTION [dbo].[TESTXemBuoiHoc2](@name nvarchar(50), @malop char(10), @start varchar(50), @end varchar(50))
RETURNS TABLE
AS
	RETURN (
		SELECT hv.MaHV, hv.HoTen, bh.MaBH, bh.MaLH, dd.CoTrenLop, bh.ThoiGian
		FROM HOCVIEN hv, DIEMDANH dd, BUOIHOC bh
		WHERE hv.MaHV = dd.MaHV and bh.MaBH = dd.MaBH and bh.MaLH = @malop and hv.HoTen = @name
		and bh.ThoiGian BETWEEN @start AND @end 
	)
go

--Đã kết hợp
alter procedure [dbo].[UpdateDD]
	@MaBH char(10),
	@MaHV char(6),
	@CoTrenLop bit
as 
begin
	update DIEMDANH
	set 			
		CoTrenLop = @CoTrenLop
	where MaBH = @MaBH and MaHV = @MaHV;
	EXEC UpdateBienLaiThuHP @MaHV;
		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end
go

alter FUNCTION XemDSHSTheoBuoi( @malop char(10), @maBH char(10))
RETURNS TABLE
AS
	RETURN (
		SELECT hv.MaHV, hv.HoTen, bh.MaBH, bh.MaLH, dd.CoTrenLop, bh.ThoiGian
		FROM HOCVIEN hv, DIEMDANH dd, BUOIHOC bh
		WHERE hv.MaHV = dd.MaHV and bh.MaBH = dd.MaBH and bh.MaLH = @malop
		and bh.MaBH = @maBH
	)
go

create FUNCTION XemDSHSTheoLop( @malop char(10))
RETURNS TABLE
AS
	RETURN (
		SELECT distinct hv.HoTen, bh.MaBH, bh.MaLH, dd.CoTrenLop, bh.ThoiGian
		FROM HOCVIEN hv, DIEMDANH dd, BUOIHOC bh
		WHERE hv.MaHV = dd.MaHV and bh.MaBH = dd.MaBH and bh.MaLH = @malop
	)
go

create TRIGGER XoaGV
ON GiaoVien
INSTEAD OF DELETE

AS
DECLARE @MA CHAR(10)
BEGIN
SELECT @MA=MaGV FROM DELETED

delete BienLaitraluong
where  BienLaitraluong.MaGV = @MA

delete GIAOVIEN
where  GIAOVIEN.MaGV = @MA


END

GO

-- so buổi dạy lớp ... trong tháng của GV ...

create function buoiday_thangcualop(@magv nvarchar(10),@malop nvarchar(10), @start varchar(50), @end varchar(50))
returns float (10)
as 
begin 
	declare @sobuoi float(10)
	set @sobuoi=(
		SELECT COUNT (bh.MaBH) AS N'Số buổi dạy'
		FROM Giaovien gv, LOPHOC lh, BUOIHOC bh
		WHERE gv.MaGV = lh.MaGV and lh.MaLH = bh.MaLH and gv.MaGV = @magv and lh.MaLH=@malop
		
		and bh.ThoiGian BETWEEN @start AND @end 
		)
	return @sobuoi
end


go

-- số lớp học theo tháng của giáo viên
create function lop_theothang(@magv nvarchar(10), @start varchar(50), @end varchar(50))
returns nvarchar(10)
as 
	begin 
	return(		
		SELECT distinct lh.MaLH
		FROM Giaovien gv, LOPHOC lh, BUOIHOC bh
		WHERE gv.MaGV = lh.MaGV and lh.MaLH = bh.MaLH and gv.MaGV = @magv 
		
		and bh.ThoiGian BETWEEN @start AND @end
		)
	end

go

-- lương của lớp ... theo tháng của giáo viên
create function luong_lopthang(@magv nvarchar(10), @malop nvarchar(10),@start varchar(50), @end varchar(50))
returns float(30)
as
	begin	
	declare @sobuoi  int = (
			
			SELECT COUNT (bh.MaBH) AS N'Số buổi dạy'
			FROM Giaovien gv, LOPHOC lh, BUOIHOC bh
			WHERE gv.MaGV = lh.MaGV and lh.MaLH = bh.MaLH and gv.MaGV= @magv and lh.MaLH=@malop
					
			and bh.ThoiGian BETWEEN @start AND @end 
		)
	declare @tien  int = @sobuoi * (select mhp.HocPhi1Buoi from LOPHOC lh, MUCHOCPHI mhp 
									where lh.MaMHP=mhp.MaMHP and lh.MaLH=@malop) 
						* (select distinct tt.TiLe from GIAOVIEN gv, MUCTHANHTOAN tt, LOPHOC lh 
						
							where gv.MaGV=lh.MaGV and tt.MaMTT=gv.MaMTT and lh.MaLH=@malop)

	return @tien

end
go

-- tổng lương trong tháng
go
create function testcount(@magv nvarchar(10),@start varchar(50), @end varchar(50))
returns float(30)
as
	begin	
	declare @solop  int = (			
			select count(*) 
			from LOPHOC
		)

		DECLARE @count INT = 1;
		DECLARE @sum float = 0;

		WHILE @count <= @solop
			BEGIN			 

			   declare @sobuoi int = (			
						SELECT COUNT (bh.MaBH) AS N'Số buổi dạy'
						FROM Giaovien gv, LOPHOC lh, BUOIHOC bh
						WHERE gv.MaGV = lh.MaGV and lh.MaLH = bh.MaLH and gv.MaGV= @magv 
						
						and lh.MaLH=(
						SELECT foo.malh FROM (select ROW_NUMBER() OVER (ORDER BY lh.malh ASC) AS rownumber, lh.MaLH  from LOPHOC lh ) as foo
						WHERE rownumber = @count						
						)					
						and bh.ThoiGian BETWEEN @start AND @end 
					)
					declare @tien  int = @sobuoi *(select mhp.HocPhi1Buoi from LOPHOC lh, MUCHOCPHI mhp 
									where lh.MaMHP=mhp.MaMHP 

									and lh.MaLH=(
										SELECT distinct foo.malh FROM (select ROW_NUMBER() OVER (ORDER BY lh.malh ASC) AS rownumber, lh.MaLH  from LOPHOC lh ) as foo
										WHERE rownumber =@count))

						* (select distinct tt.TiLe from GIAOVIEN gv, MUCTHANHTOAN tt, LOPHOC lh 
						
							where gv.MaGV=lh.MaGV and tt.MaMTT=gv.MaMTT

									and lh.MaLH=(
										SELECT distinct foo.malh FROM (select ROW_NUMBER() OVER (ORDER BY lh.malh ASC) AS rownumber, lh.MaLH  from LOPHOC lh ) as foo
										WHERE rownumber =@count))

					set @sum = @sum +@tien

					SET @count = @count + 1;
			END



	declare @str_tien nvarchar(20)
	set @str_tien= convert(nvarchar,@sum)

	return @sum
end
go

--dfsdf bảng thanh toán
create FUNCTION tesst(@magv nvarchar(10),@start varchar(50), @end varchar(50))
RETURNS  @rtnTable TABLE 
(
    -- columns returned by the function
    malop varchar(10),
    sobuoi float(10),
    sotien float(20)
)
AS
BEGIN
DECLARE @TempTable table (malop varchar(10),
    sobuoi float(10),
    sotien float(20))


Begin
	DECLARE @ma char(10)
	DECLARE tro CURSOR FORWARD_ONLY
	FOR Select dbo.lop_theothang( @magv ,@start, @end)

	OPEN tro

	FETCH NEXT FROM tro into @ma
	WHILE @@FETCH_STATUS=0
		BEGIN

			insert into @TempTable (malop,sobuoi,sotien)
			values(dbo.lop_theothang( @magv ,@start, @end),dbo.buoiday_thangcualop (@magv,@ma,@start , @end),dbo.luong_lopthang(@magv,@ma,@start , @end))

			FETCH NEXT FROM tro INTO  @ma
		END
	CLOSE tro
	DEALLOCATE tro
END
--fdsdfds

	

--This select returns data
insert into @rtnTable
SELECT * FROM @TempTable 
return
END

go

-- update lương
create proc updateluongs
as
begin
	DECLARE @ma char(10),@datestart DATETIME,@dateend DATETIME
	DECLARE tro CURSOR SCROLL

	FOR Select bl.MaGV,DATEADD(YEAR, -1, bl.NgayTra),bl.NgayTra
		From BIENLAITRALUONG bl 

	OPEN tro
FETCH FIRST FROM tro into @ma,@datestart,@dateend
	WHILE @@FETCH_STATUS=0
	BEGIN
		update BIENLAITRALUONG set TONGTIEN = dbo.testcount (@ma,@datestart,@dateend) where MaGV=@ma and NgayTra=@dateend

		print dbo.testcount (@ma,@datestart,@dateend)

		FETCH NEXT FROM tro INTO  @ma,@datestart,@dateend
	END

	CLOSE tro
DEALLOCATE tro
end

go

updateluongs

go


-- search giao vien
create procedure searchMGV @MaGV char(10)
as 
begin
	select maGV, HoTen, convert(varchar(10),NgaySinh,103) 
	as NgaySinh, DiaChi, GioiTinh, MaMTT, Sdt
	from GIAOVIEN
	where MaGV = @MaGV
end
go


create procedure searchTGV @TenGV nvarchar(50)
as 
begin
	select MaGV, HoTen, convert(varchar(10),NgaySinh,103) 
	as NgaySinh, DiaChi, GioiTinh, MaMTT, Sdt
	from GIAOVIEN
	where HoTen = @TenGV
end

-- them moi
go
create procedure [dbo].[ThemMoiGV]
	@Magv nvarchar(50),
	@HoTen nvarchar(50),
	@SDT nvarchar(50),
	@NgaySinh date,
	@DiaChi nvarchar(50),
	@GioiTinh nvarchar(50),
	@MaMTT char(10)

as 
begin
	insert into GIAOVIEN
	(
		MaGV,HoTen,sdt,NgaySinh,DiaChi,GioiTinh,MaMTT
	)values(
		@Magv,
		@HoTen,
		@SDT,
		@NgaySinh,
		@DiaChi,
		@GioiTinh,
		@MaMTT
		);

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end
go
-- update giao vien
create procedure [dbo].[UpdateGiaoVien]
	@MaGV char(10),
	@Hoten nvarchar(45),
	@SDT char(10),
	@NgaySinh datetime,
	@DiaChi nvarchar(45),
	@MaMTT char(10)
as 
begin
	update GIAOVIEN
	set 
		MaGV = @MaGV,
		Hoten = @Hoten,
		SDT = @SDT,
		NgaySinh = @NgaySinh,
		DiaChi = @DiaChi,
		MaMTT=@MaMTT

	where MaGV = @MaGV;

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;

end
go
create procedure [dbo].[SelectGVById]
	@maGV char(10)
as
begin
	select * from GIAOVIEN where MaGV = @maGV
end
go

-----
ALTER procedure [dbo].[UpdateGiaoVien]
	@MaGV char(10),
	@Hoten nvarchar(45),
	@SDT char(10),
	@NgaySinh datetime,
	@DiaChi nvarchar(45),	
	@GioiTinh nvarchar(5),
	@MaMTT char(10),
	
	@pass nvarchar(10)
as 
begin
	update GIAOVIEN
	set 
		Hoten = @Hoten,
		SDT = @SDT,
		NgaySinh = @NgaySinh,
		DiaChi = @DiaChi,
		GioiTinh = @GioiTinh,
		MaMTT=@MaMTT,
		pass=@pass


	where MaGV = @MaGV;

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;

end
create sequence giaovienSeq
	start with 1000 --bat dau tu 1000
	increment by 1; --moi lan tang 1 don vi
	go

ALTER procedure [dbo].[ThemMoiGV]
	@HoTen nvarchar(50),
	@SDT nvarchar(50),
	@NgaySinh date,
	@DiaChi nvarchar(50),
	@GioiTinh nvarchar(50),
	@MaMTT char(10),
	@pass nvarchar(10)

as 
begin
	insert into GIAOVIEN
	(
		MaGV,HoTen,sdt,NgaySinh,DiaChi,GioiTinh,MaMTT,pass
	)values(
		'GV' + cast(next value for giaovienSeq as char(10)),
		@HoTen,
		@SDT,
		@NgaySinh,
		@DiaChi,
		@GioiTinh,
		@MaMTT,
		@pass
		);

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end

go

------------------------
create sequence bienlaiSeq
	start with 2000 --bat dau tu 1000
	increment by 1; --moi lan tang 1 don vi
	go
create proc ThemMoiBL (@ngaytra date, @tongtien float(20), @magv nvarchar(10))
as
begin
insert into BIENLAITRALUONG
	(
		MaBL,ngaytra,TONGTIEN,MaGV
	)values(
		'BL' + cast(next value for bienlaiSeq as char(10)),
		@ngaytra,
		@tongtien,
		@magv
		);
end
go
ALTER procedure [dbo].[searchMGV] @MaGV char(10)
as 
begin
	select MaGV, HoTen, convert(varchar(10),NgaySinh,103) 
	as NgaySinh, DiaChi, GioiTinh, MaMTT, Sdt
	from GIAOVIEN
	where MaGV like '%'+@MaGV+'%'
end
go
ALTER procedure [dbo].[searchTGV] @TenGV nvarchar(50)
as 
begin
	select MaGV, HoTen, convert(varchar(10),NgaySinh,103) 
	as NgaySinh, DiaChi, GioiTinh, MaMTT, Sdt
	from GIAOVIEN
	where HoTen like '%'+@TenGV+'%'
end

--------
CREATE PROCEDURE SelectAllHV
AS
	SELECT MaHV, HoTen, SDT, CONVERT(VARCHAR, NgaySinh, 103) AS NgaySinh, DiaChi, GioiTinh
	FROM HOCVIEN

GO
CREATE PROCEDURE SelectAllBLThuHP
AS
	SELECT *
	FROM BIENLAITHUHOCPHI
	ORDER BY MaHV, Thang


--DROP PROCEDURE SelectAllBLThuHP

--GO
--CREATE PROCEDURE UpdateBienLaiThuHP (@MaHV CHAR(6))
--AS
--	UPDATE ThongTinDiHoc
--		SET MaHV = (SELECT a.MaHV
--					FROM HOCVIEN a, DIEMDANH b, BUOIHOC c, LOPHOC d
--					WHERE a.MaHV = b.MaHV AND b.CoTrenLop = 1 AND b.MaBH = c.MaBH AND c.MaLH = d.MaLH
--					GROUP BY a.MaHV
--					)
--	UPDATE ThongTinDiHoc
--		SET	SoLanDiHoc = (SELECT COUNT(b.CoTrenLop) AS SoLanDiHoc
--							FROM HOCVIEN a, DIEMDANH b, BUOIHOC c, LOPHOC d
--							WHERE a.MaHV = b.MaHV AND b.CoTrenLop = 1 AND b.MaBH = c.MaBH AND c.MaLH = d.MaLH
--							GROUP BY a.MaHV, d.TenLH)
--	UPDATE ThongTinDiHoc
--		SET	SoLanDiHoc = (SELECT d.TenLH
--							FROM HOCVIEN a, DIEMDANH b, BUOIHOC c, LOPHOC d
--							WHERE a.MaHV = b.MaHV AND b.CoTrenLop = 1 AND b.MaBH = c.MaBH AND c.MaLH = d.MaLH
--							GROUP BY a.MaHV, d.TenLH)
--	UPDATE BIENLAITHUHOCPHI
--	SET TongTien = (SELECT SUM(a.HocPhi1Buoi*d.SoLanDiHoc + c.SoThangChuaTra*a.HocPhi1Buoi*d.SoLanDiHoc)
--					FROM MUCHOCPHI a, LOPHOC b, THONGTINNO c, ThongTinDiHoc d
--					WHERE b.TenLH = d.TenLH AND b.MaMHP = a.MaMHP AND c.MaHV = d.MaHV AND c.MaHV = @MaHV
--					GROUP BY c.MaHV
--					)
--	WHERE MaHV = @MaHV

-- Đây là hàm để update toàn bộ biên lai

GO
CREATE FUNCTION ThongTinDiHoc ()
RETURNS TABLE
AS
RETURN (
		SELECT a.MaHV, COUNT(b.CoTrenLop) AS SoLanDiHoc, d.TenLH, MONTH(c.ThoiGian) AS N'Tháng'
		FROM HOCVIEN a, DIEMDANH b, BUOIHOC c, LOPHOC d
		WHERE a.MaHV = b.MaHV AND b.CoTrenLop = 1 AND b.MaBH = c.MaBH AND c.MaLH = d.MaLH
		GROUP BY a.MaHV, d.TenLH, MONTH(c.ThoiGian)
)
go
EXEC SelectAllBLThuHP
go
SELECT * FROM ThongTinDiHoc()
--DROP FUNCTION ThongTinDiHoc
GO
CREATE PROCEDURE UpdateBienLaiThuHP (@MaHV CHAR(6))
AS
	DECLARE @TongTien DECIMAL(19, 4)
	UPDATE BIENLAITHUHOCPHI
	SET TongTien = (SELECT SUM(a.HocPhi1Buoi*d.SoLanDiHoc)
					FROM MUCHOCPHI a, LOPHOC b, THONGTINNO c, ThongTinDiHoc() d
					WHERE b.TenLH = d.TenLH AND b.MaMHP = a.MaMHP AND c.MaHV = d.MaHV AND c.MaHV = @MaHV AND d.[Tháng] = Thang
					GROUP BY c.MaHV
					)
	WHERE MaHV = @MaHV
go
EXEC UpdateBienLaiThuHP 'HV0001'

--DROP PROC UpdateBienLaiThuHP

GO
CREATE FUNCTION TongHPTheoThang(@MaHV CHAR(6), @Thang INT)
RETURNS DECIMAL(19, 4)
AS
BEGIN
	DECLARE @TongTien DECIMAL(19, 4)
	--UPDATE BIENLAITHUHOCPHI
	--SET TongTien = (SELECT SUM(a.HocPhi1Buoi*d.SoLanDiHoc)
	--				FROM MUCHOCPHI a, LOPHOC b, THONGTINNO c, ThongTinDiHoc() d
	--				WHERE b.TenLH = d.TenLH AND b.MaMHP = a.MaMHP AND c.MaHV = d.MaHV AND c.MaHV = @MaHV AND d.[Tháng] = Thang
	--				GROUP BY c.MaHV
	--				)
	--WHERE MaHV = @MaHV AND Thang = @Thang
	SET @TongTien = (SELECT SUM(a.HocPhi1Buoi*d.SoLanDiHoc)
					FROM MUCHOCPHI a, LOPHOC b, THONGTINNO c, ThongTinDiHoc() d
					WHERE b.TenLH = d.TenLH AND b.MaMHP = a.MaMHP AND c.MaHV = d.MaHV AND c.MaHV = @MaHV AND d.[Tháng] = @Thang
					GROUP BY c.MaHV
					)
	RETURN @TongTien
END

--DROP FUNCTION dbo.TongHPTheoThang
--GO
--SELECT dbo.TongHPTheoThang('HV0002', 7)

GO
CREATE PROCEDURE ThemBienLai @MaBL CHAR(10), @NgayThu DATE, @TongTien INT, @Thang INT, @MaHV CHAR(6)
AS
BEGIN
	SET @TongTien = dbo.TongHPTheoThang(@MaHV, @Thang)
	INSERT INTO BIENLAITHUHOCPHI VALUES (@MaBL, @NgayThu, @TongTien, @Thang, @MaHV);
	IF @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
END

--DROP PROC ThemBienLai

GO
BEGIN
DECLARE @MaHV CHAR(6)
DECLARE Tro_HV CURSOR FOR
SELECT MaHV
FROM HOCVIEN
OPEN Tro_HV
FETCH NEXT FROM Tro_HV INTO @MaHV
WHILE @@FETCH_STATUS = 0
	BEGIN
		EXEC UpdateBienLaiThuHP @MaHV
		FETCH NEXT FROM Tro_HV INTO @MaHV
	END
CLOSE Tro_HV
DEALLOCATE Tro_HV
END

-- Kết thúc hàm update toàn bộ biên lai

GO
CREATE PROCEDURE SelectHocVienByMa (@MaHV CHAR(6))
AS
BEGIN
	select HoTen, SDT, convert(VARCHAR(10), NgaySinh, 103) as NgaySinh, DiaChi, GioiTinh 
	from HOCVIEN
	where MaHV = @MaHV
END

GO
CREATE PROCEDURE WatchBLDetail (@MaHV CHAR(6), @Thang INT)
AS
BEGIN
	SELECT d.MaHV, a.MaLH, a.TenLH, e.HocPhi1Buoi, f.SoLanDiHoc, MONTH(b.ThoiGian) AS N'Tháng'
	FROM LOPHOC a, BUOIHOC b, DIEMDANH c, HOCVIEN d, MUCHOCPHI e, ThongTinDiHoc() f
	WHERE a.MaLH = b.MaLH AND b.MaBH = c.MaBH AND c.MaHV = d.MaHV AND a.MaMHP= e.MaMHP AND f.MaHV = d.MaHV AND f.TenLH = a.TenLH AND d.MaHV = @MaHV
			AND MONTH(b.ThoiGian) = @Thang AND f.[Tháng] = @Thang
	GROUP BY d.MaHV, a.MaLH, a.TenLH, e.HocPhi1Buoi, f.SoLanDiHoc, MONTH(b.ThoiGian)
	--SELECT a.MaHV, b.MaLH, c.TenLH, d.HocPhi1Buoi, e.SoLanDiHoc, MONTH(f.ThoiGian) AS N'Tháng'
	--FROM HOCVIEN a, HOCVIEN_LOPHOC b, LOPHOC c, MUCHOCPHI d, ThongTinDiHoc() e, BUOIHOC f
	--WHERE a.MaHV = @MaHV AND b.MaHV = a.MaHV AND b.MaLH = c.MaLH AND c.MaMHP = d.MaMHP AND a.MaHV = e.MaHV AND MONTH(f.ThoiGian) = @Thang AND e.[Tháng] = @Thang
	--GROUP BY a.MaHV, b.MaLH, c.TenLH, d.HocPhi1Buoi, e.SoLanDiHoc, MONTH(f.ThoiGian)
END
--DROP PROC WatchBLDetail
go
EXEC WatchBLDetail 'HV0010', 9

GO
CREATE PROCEDURE SelectBienLaiHPByMaHVAndThang (@MaHV CHAR(6), @Thang INT)
AS
BEGIN
	SELECT b.MaHV, b.HoTen, convert(VARCHAR(10), a.NgayThu, 103) AS NgayThu, a.TongTien, a.Thang, c.SoThangChuaTra
	FROM BIENLAITHUHOCPHI a, HOCVIEN b, THONGTINNO c
	WHERE a.MaHV = b.MaHV AND b.MaHV = c.MaHV AND b.MaHV = @MaHV AND a.Thang = @Thang
END
--DROP PROC SelectBienLaiHPByMaHV
go
EXEC SelectBienLaiHPByMaHVAndThang 'HV0010', 9

GO
CREATE PROCEDURE searchMaHV (@MaHV CHAR(6))
AS
BEGIN
	SELECT MaHV, HoTen, SDT, CONVERT(VARCHAR, NgaySinh, 103) AS NgaySinh, DiaChi, GioiTinh
	FROM HOCVIEN
	WHERE MaHV = @MaHV
END

GO
CREATE PROCEDURE searchHoTenHV (@HoTen NVARCHAR(30))
AS
BEGIN
	SELECT MaHV, HoTen, SDT, CONVERT(VARCHAR, NgaySinh, 103) AS NgaySinh, DiaChi, GioiTinh
	FROM HOCVIEN
	WHERE HoTen = @HoTen
END

GO
CREATE PROCEDURE ThemHocVien
	@MaHV CHAR(6),
	@HoTen NVARCHAR(30),
	@SDT CHAR(10),
	@NgaySinh DATE,
	@DiaChi NVARCHAR(50),
	@GioiTinh NVARCHAR(5)
AS
BEGIN
	INSERT INTO HOCVIEN VALUES (@MaHV, @HoTen, @SDT, @NgaySinh, @DiaChi, @GioiTinh);
	DECLARE @temp CHAR(6) = CONCAT('MN', SUBSTRING(@MaHV, 3, 4))
	INSERT INTO THONGTINNO VALUES (@temp, 0, @MaHV)
	IF @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
END

GO
CREATE PROCEDURE ThemLopHocChoHocVien
	@MaHV CHAR(6),
	@MaLH CHAR(6)
AS
BEGIN
	INSERT INTO HOCVIEN_LOPHOC VALUES (@MaHV, @MaLH);
	IF @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
END

GO
CREATE PROCEDURE UpdateHocVien
	@MaHV CHAR(6),
	@HoTen NVARCHAR(30),
	@SDT CHAR(10),
	@NgaySinh DATE,
	@DiaChi NVARCHAR(50),
	@GioiTinh NVARCHAR(5)
AS
BEGIN
	UPDATE HOCVIEN
	SET HoTen = @HoTen,
		SDT = @SDT,
		NgaySinh = @NgaySinh,
		DiaChi = @DiaChi,
		GioiTinh = @GioiTinh
	WHERE MaHV = @MaHV
END

GO
CREATE PROCEDURE DongTien (@MaHV CHAR(6), @Thang INT, @NgayThu DATE)
AS
BEGIN
	UPDATE BIENLAITHUHOCPHI
	SET NgayThu = @NgayThu
	WHERE MaHV = @MaHV AND Thang = @Thang
	DECLARE @temp INT
	SET @temp = (SELECT SoThangChuaTra
				FROM THONGTINNO
				WHERE MaHV = @MaHV
				)
	IF (@temp > 0)
	BEGIN
		IF (@temp = 1)
		BEGIN
			UPDATE THONGTINNO
			SET SoThangChuaTra = 0
			WHERE MaHV = @MaHV
		END
		ELSE
		BEGIN
			UPDATE THONGTINNO
			SET SoThangChuaTra = @temp - 1
			WHERE MaHV = @MaHV
		END
	END

	IF @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
END

GO 
CREATE PROCEDURE GhiNo (@MaHV CHAR(6))
AS
BEGIN
	DECLARE @temp INT
	SET @temp = (SELECT SoThangChuaTra
				FROM THONGTINNO
				WHERE MaHV = @MaHV
				)
	UPDATE THONGTINNO
	SET SoThangChuaTra = @temp + 1
	WHERE MaHV = @MaHV

	IF @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
END
---------------login
go
alter table GIAOVIEN 
	add pass nvarchar(20)

go

create procedure checkLogin
	@username nvarchar(20),
	@pass nvarchar(20)
as 
begin
	IF EXISTS (SELECT * FROM GIAOVIEN WHERE GIAOVIEN.SDT = @username AND GIAOVIEN.pass = @pass) begin return 1 end
		else begin return 0 end;
end









