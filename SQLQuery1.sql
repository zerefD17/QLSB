﻿CREATE TABLE NHANVIEN
(
	MANV VARCHAR(50),
	TENNV NVARCHAR(100),
	SDT VARCHAR(20),
	DIACHI NVARCHAR(50),
	NGAYSINH DATETIME,
	GIOITINH VARCHAR(20),
	PRIMARY KEY (MANV)
)


CREATE TABLE KHACHHANG
(
    MAKH VARCHAR(50) NOT NULL,
    TENKH NVARCHAR(30),
    SODT INT,
    DIACHI NVARCHAR(30),
    GIOITINH NCHAR(5),
    PRIMARY KEY (MAKH),
)
CREATE TABLE SANBONG
(
	MASAN VARCHAR(50),
	TENSAN NVARCHAR(50),
	
	LOAISAN VARCHAR(50),
	GIASAN INT,
	PRIMARY KEY(MASAN),
)
CREATE TABLE DATSAN
(
	MADATSAN VARCHAR(50) PRIMARY KEY NOT NULL,
	MAKH VARCHAR(50),
	MASAN VARCHAR(50),
	
	GIODATSAN DATETIME,
	GIOTRASAN DATETIME,
	NGAYDATSAN DATE
	FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH),
	FOREIGN KEY(MASAN) REFERENCES SANBONG(MASAN),
)
CREATE TABLE HOADON  
(
    MAHD VARCHAR(5) NOT NULL,
    NGAYNHAP DATE,
    MADATSAN VARCHAR(50),
    MANV VARCHAR(50),    
    TONGTIEN MONEY NULL,
    PRIMARY KEY (MAHD),
    FOREIGN KEY(MADATSAN) REFERENCES DATSAN(MADATSAN),
    FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
)
CREATE TABLE DICHVU
(
	MADV VARCHAR(10) PRIMARY KEY NOT NULL,
	TENDV NVARCHAR(50),
	GIA FLOAT,

)
CREATE TABLE CTDICHVU
(
	MADATSAN VARCHAR(50) NOT NULL,
	MADV VARCHAR(10) NOT NULL,
	SOLUONG INT,
	PRIMARY KEY(MADATSAN, MADV),
	FOREIGN KEY(MADATSAN) REFERENCES DATSAN(MADATSAN),
	FOREIGN KEY(MADV) REFERENCES DICHVU(MADV),
)
CREATE TABLE TUSER
(
	TAIKHOAN VARCHAR(50) PRIMARY KEY NOT NULL,
	MATKHAU VARCHAR(50),
	QUYEN VARCHAR(20),
)
INSERT INTO NHANVIEN 
VALUES ('NV001',N'Dương Minh Sang','0123123123',N'Biên Hòa','05/17/2002','Nam'),
('NV002',N'Nguyễn Hoàng Dự','0456456456',N'Đồng Nai','10/18/2002','Nam'),
('NV003',N'Nguyễn Thanh Phúc','0789789789',N'TP.HCM','03/17/2002','Nam')

INSERT INTO TUSER
VALUES('sang', 'sang123','Admin'),
('phuc','phuc1','user'),
('du','du123','user')
select * from TUSER

print getdate()
select * from NHANVIEN
update NHANVIEN set TENNV=N'aaa', SDT='123',DIACHI=N'aaa',NGAYSINH='05/14/2002',GIOITINH='Nu' where MANV='a'
delete NHANVIEN where MANV='a'

INSERT INTO DICHVU
VALUES('DV001', N'Trọng tài',100000),
('DV002', N'Coca cola',11000),
('DV003', N'Pessi',10000),
('DV004', N'Sting',12000),
('DV005', N'Revive',10000),
('DV006', N'Thuốc lá',22000),
('DV007', N'Áo tập',5000),
('DV008', N'Trà đá',10000),
('DV009', N'Khăn ướt',2000)
select * from DICHVU
delete DICHVU where MADV='DV0010'

INSERT INTO SANBONG
VALUES(N'S001', N'Sân 5-1','Sân 5',200000),
(N'S002', N'Sân 5-2','Sân 5',200000),
(N'S003', N'Sân 5-3','Sân 5',200000),
(N'S004', N'Sân 5-4','Sân 5',200000),
(N'S005', N'Sân 5-5','Sân 5',200000),
(N'S006', N'Sân 7-1','Sân 7',600000),
(N'S007', N'Sân 7-2','Sân 7',600000)
select * from SANBONG
delete SANBONG where MASAN='S007'
update SANBONG set TENSAN=N'', LOAISAN='',GIASAN=2 where MASAN=''