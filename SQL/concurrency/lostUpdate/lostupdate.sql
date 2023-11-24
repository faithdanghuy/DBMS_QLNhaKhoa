/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

-- TRAN 1
CREATE OR ALTER PROC USP_THUOC_UPD
    @MATHUOC VARCHAR(5),
    @TENTHUOC NVARCHAR(25),
    @DONVITINH NVARCHAR(5),
    @CHIDINH NVARCHAR(50),
    @SOLUONGTONKHO INT,
    @NGAYHETHAN DATE,
    @GIATIEN INT,
    @MANVQUANLY VARCHAR(5),
    @NGUOIUPDATE VARCHAR(5)
AS BEGIN TRAN
    IF NOT EXISTS (SELECT * FROM THUOC WHERE MATHUOC = @MATHUOC) BEGIN
        RAISERROR('INVALID MATHUOC', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF @DONVITINH != N'VIÊN' AND @DONVITINH != N'GÓI'
        AND @DONVITINH != N'HỘP' BEGIN
        RAISERROR(N'INVALID DONVITINH, MUST BE EITHER VIÊN, HỘP, OR GÓI', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    IF @SOLUONGTONKHO < 0 BEGIN
        RAISERROR('INVALID SOLUONGTONKHO', 16, 1)
        ROLLBACK TRAN
        RETURN -3
    END

    IF @GIATIEN < 0 BEGIN
        RAISERROR('INVALID GIATIEN', 16, 1)
        ROLLBACK TRAN
        RETURN -4
    END

    IF @TENTHUOC IS NULL OR @CHIDINH IS NULL OR @NGAYHETHAN IS NULL
        OR @NGUOIUPDATE IS NULL BEGIN
        RAISERROR('INVALID DATA', 16, 1)
        ROLLBACK TRAN
        RETURN -5
    END

    IF @NGUOIUPDATE NOT LIKE 'AD%' OR @NGUOIUPDATE != @MANVQUANLY BEGIN
        RAISERROR('ONLY ADMIN MANAGING THIS THUOC CAN UPDATE IT', 16, 1)
        ROLLBACK TRAN
        RETURN -6
    END

    WAITFOR DELAY '00:00:10'

    UPDATE THUOC SET TENTHUOC = @TENTHUOC, DONVITINH = @DONVITINH,
        CHIDINH = @CHIDINH, SOLUONGTONKHO = @SOLUONGTONKHO,
        NGAYHETHAN = @NGAYHETHAN, GIATIEN = @GIATIEN,
        MANVQUANLY = @MANVQUANLY
    WHERE MATHUOC = @MATHUOC
COMMIT TRAN
RETURN 0
GO

-- TRAN 2
CREATE OR ALTER PROC USP_TOATHUOC_UPD
    @MAHSBA VARCHAR(5),
    @MAGIAYKHAMBENH VARCHAR(5),
    @MATHUOC VARCHAR(5),
    @SOLUONG INT = 1
AS BEGIN TRAN
    IF NOT EXISTS (SELECT * FROM TOATHUOC
        WHERE MAHSBA = @MAHSBA AND MAGIAYKHAMBENH = @MAGIAYKHAMBENH
            AND MATHUOC = @MATHUOC) BEGIN
        RAISERROR('INVALID TOATHUOC', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF NOT EXISTS (SELECT * FROM THUOC WHERE MATHUOC = @MATHUOC
        AND SOLUONGTONKHO >= @SOLUONG) BEGIN
        RAISERROR('INVALID MATHUOC, OR SOLUONGTONKHO IS INSUFFICIENT', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    DECLARE @DIFFSOLUONG INT, @DIFFCOST INT
    SELECT @DIFFSOLUONG = SOLUONG FROM TOATHUOC WHERE MAHSBA = @MAHSBA
        AND MAGIAYKHAMBENH = @MAGIAYKHAMBENH AND MATHUOC = @MATHUOC

    SET @DIFFSOLUONG = @SOLUONG - @DIFFSOLUONG
    SET @DIFFCOST = (SELECT GIATIEN FROM THUOC
        WHERE MATHUOC = @MATHUOC) * @DIFFSOLUONG

    UPDATE TOATHUOC SET SOLUONG = @SOLUONG
    WHERE MAHSBA = @MAHSBA AND MAGIAYKHAMBENH = @MAGIAYKHAMBENH
        AND MATHUOC = @MATHUOC

    UPDATE THUOC SET SOLUONGTONKHO -= @DIFFSOLUONG WHERE MATHUOC = @MATHUOC

    UPDATE GIAYKHAMBENH SET TONGTIENTHUOC += @DIFFCOST
    WHERE MAHSBA = @MAHSBA AND MAGIAYKHAMBENH = @MAGIAYKHAMBENH
COMMIT TRAN
RETURN 0
GO