use [Quản lý trung tâm học thêm]

select * from LOPHOC

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
exec searchMaLop 'LH0002'

-- Ten lop --
create procedure searchTenLop @tenlop char(10)
as 
begin
	select MaLH, TenLH, MaMH, MaGV, MaMHP
	from LOPHOC
	where TenLH = @tenlop
end
go
exec searchTenLop N'Toán 10A1'
go
-- -----------------


alter procedure ThemMoiLH
	@MaLH char(6),
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
		@MaLH,
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
SELECT * FROM dbo.XemBuoiHoc('HV0001')
go
create FUNCTION TESTXemBuoiHoc( @malop char(10), @start varchar(50), @end varchar(50))
RETURNS TABLE
AS
	RETURN (
		SELECT hv.HoTen, bh.MaBH, bh.MaLH, dd.CoTrenLop, bh.ThoiGian
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
create procedure [dbo].[UpdateDD]
	@MaBH char(10),
	@MaHV char(6),
	@CoTrenLop bit
as 
begin
	update DIEMDANH
	set 			
		CoTrenLop = @CoTrenLop
	where MaBH = @MaBH and MaHV = @MaHV;

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end
go
