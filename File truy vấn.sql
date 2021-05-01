USE [Quản lý trung tâm học thêm]

GO
CREATE PROCEDURE SelectAllHV
AS
	SELECT MaHV, HoTen, SDT, CONVERT(VARCHAR, NgaySinh, 103) AS NgaySinh, DiaChi, GioiTinh
	FROM HOCVIEN

GO
CREATE PROCEDURE SelectAllBLThuHP
AS
	SELECT *
	FROM BIENLAITHUHOCPHI
	ORDER BY MaHV, NgayThu

DROP PROCEDURE SelectAllBLThuHP

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
EXEC SelectAllBLThuHP
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

DROP PROC ThemBienLai

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
DROP PROC WatchBLDetail

EXEC WatchBLDetail 'HV0001', 9

GO
CREATE PROCEDURE SelectBienLaiHPByMaHVAndThang (@MaHV CHAR(6), @Thang INT)
AS
BEGIN
	SELECT b.MaHV, b.HoTen, convert(VARCHAR(10), a.NgayThu, 103) AS NgayThu, a.TongTien, a.Thang
	FROM BIENLAITHUHOCPHI a, HOCVIEN b, THONGTINNO c
	WHERE a.MaHV = b.MaHV AND b.MaHV = c.MaHV AND b.MaHV = @MaHV AND a.Thang = @Thang
END
--DROP PROC SelectBienLaiHPByMaHV

EXEC SelectBienLaiHPByMaHVAndThang 'HV0001', 9

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