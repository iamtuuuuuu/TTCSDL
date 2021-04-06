use [Quản lý trung tâm học thêm]

select * from DIEMDANH where MAHV = 'HV0001'
select * from BUOIHOC

SELECT distinct hv.MaHV, hv.HoTen, dd.CoTrenLop,bh.ThoiGian, bh.MaBH
FROM HOCVIEN hv, DIEMDANH dd, BUOIHOC bh
WHERE  bh.ThoiGian BETWEEN '2020-09-01 00:00:00' AND '2020-10-01 00:00:00' 
and bh.MaLH = 'LH0001'
and bh.MaBH = dd.MaBH
and dd.MaHV = hv.MaHV

ALTER FUNCTION XemBuoiHoc(@MaHV char(10))
RETURNS TABLE
AS
	RETURN (
		SELECT bh.MaBH, bh.MaLH, dd.CoTrenLop, bh.ThoiGian
		FROM HOCVIEN hv, DIEMDANH dd, BUOIHOC bh
		WHERE hv.MaHV = dd.MaHV and bh.MaBH = dd.MaBH and hv.MaHV = @MaHV
		and bh.ThoiGian BETWEEN '2020-10-01 00:00:00' AND '2020-11-01 00:00:00' 
	)

SELECT * FROM dbo.XemBuoiHoc('HV0001')

ALTER FUNCTION TESTXemBuoiHoc( @malop char(10), @start varchar(50), @end varchar(50))
RETURNS TABLE
AS
	RETURN (
		SELECT hv.HoTen, bh.MaBH, bh.MaLH, dd.CoTrenLop, bh.ThoiGian
		FROM HOCVIEN hv, DIEMDANH dd, BUOIHOC bh
		WHERE hv.MaHV = dd.MaHV and bh.MaBH = dd.MaBH and bh.MaLH = @malop
		and bh.ThoiGian BETWEEN @start AND @end 
	)

SELECT * FROM dbo.TESTXemBuoiHoc('LH0008' ,'2020-09-01 00:00:00', '2020-10-01 00:00:00')

