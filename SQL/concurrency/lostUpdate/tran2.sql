/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

DECLARE @ERR INT

EXEC @ERR = USP_THUOC_UPD 'TH001', N'Augmentin 875mg/125mg', N'Viên',
    N'Uống sau khi ăn', 5, '2025/12/22', 10000, 'AD001', 'AD001'

IF @ERR != 0 PRINT('UPDATE FAILED!')
ELSE PRINT('UPDATE SUCCESSFUL!')

SELECT * FROM THUOC WHERE MATHUOC = 'TH001'