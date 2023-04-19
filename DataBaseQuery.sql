CREATE DATABASE LibraryManagement
GO

USE LibraryManagement

DROP DATABASE LibraryManagement
DROP TABLE Loan
DROP TABLE WrittenBy
DROP TABLE CopiedBook
DROP TABLE Author
DROP TABLE Book
DROP TABLE Student
DROP TABLE LibraryManager


CREATE TABLE LibraryManager(
username VARCHAR(50) PRIMARY KEY,
password VARCHAR (50) NOT NULL,
managerName VARCHAR (50) NOT NULL,
email VARCHAR(50) NOT NULL,
phoneNumber CHAR(100) NOT NULL
);

CREATE TABLE Book(
bookId CHAR(7) PRIMARY KEY,
title VARCHAR(50) NOT NULL,
publisher VARCHAR(50),
yearOfPublication DATE,
);

CREATE TABLE Author(
authorName VARCHAR(50) PRIMARY KEY,
);

CREATE TABLE Student(
studentId CHAR(7) PRIMARY KEY,
studentName VARCHAR(50) NOT NULL,
email VARCHAR(50)
);

CREATE TABLE CopiedBook(
bookId CHAR(7) FOREIGN KEY REFERENCES Book (bookId) NOT NULL,
copyNumber INT NOT NULL,
availability BIT NOT NULL,
PRIMARY KEY (bookId, copyNumber)
);

CREATE TABLE WrittenBy(
bookId CHAR(7) FOREIGN KEY REFERENCES Book(bookId) NOT NULL,
authorName VARCHAR(50) FOREIGN KEY REFERENCES Author(authorName) NOT NULL,
PRIMARY KEY (bookId, authorName)
);

CREATE TABLE Loan(
bookId CHAR(7) NOT NULL,
copyNumber INT NOT NULL,
studentId CHAR(7) FOREIGN KEY REFERENCES Student(studentId) NOT NULL,
loanDate DATE NOT NULL,
dueDate DATE,
FOREIGN KEY (bookId,copyNumber) REFERENCES CopiedBook(bookId,copyNumber),
PRIMARY KEY (bookId,copyNumber)
);

---------INSERT DATA---------------------
INSERT INTO LibraryManager VALUES ('admin','netcafe','deffaultManager','admin@gmail.com','0359110455');

INSERT INTO Student VALUES ('2113376', 'Le Quang Hien', 'hien.lequang@hcmut.edu.vn');
INSERT INTO Student VALUES ('2114511', 'Nguyen Van Ngoc Quang', 'vanngocquang@hcmut.edu.vn');
INSERT INTO Student VALUES ('2110060', 'Mai Doan Chien', 'chiendoan07@hcmut.edu.vn');
INSERT INTO Student VALUES ('2114445', 'Nguyen Pham Thien Phuc', 'phucphamktpro@hcmut.edu.vn');
INSERT INTO Student VALUES ('2114672', 'Tran Hoang Son', 'tranhoangson@hcmut.edu.vn');
INSERT INTO Student VALUES ('2111023', 'Nong Sy Dat', 'datvilla@hcmut.edu.vn');

SET DATEFORMAT dmy;
GO
INSERT INTO Book VALUES('1000001','Dai So Tuyen Tinh','Nha xuat ban Dai hoc Quoc gia','18-2-2020');
INSERT INTO Book VALUES('1000002','kien truc may tinh','Nha xuat ban Dai hoc Quoc gia','20-1-2021');
INSERT INTO Book VALUES('1000003','Cau truc du lieu va giai thuat','Nha xuat ban Dai hoc Quoc gia','30-3-2014');
INSERT INTO Book VALUES('1000004','Giao trinh Triet hoc Mac - Lenin','Nha xuat ban Chinh tri Quoc gia Su That','31-5-2020');
INSERT INTO Book VALUES('1000005','Giao trinh Kinh te Chinh tri Mac - Lenin','Nha xuat ban Chinh tri Quoc gia Su That','30-6-2021');
INSERT INTO Book VALUES('1000006','A Game of Thrones','Harper Collins','12-12-2011');

INSERT INTO Author VALUES('Dang Van Vinh');
INSERT INTO Author VALUES('Pham Quoc Cuong');
INSERT INTO Author VALUES('Nguyen Trung Truc');
INSERT INTO Author VALUES('Pham Van Duc');
INSERT INTO Author VALUES('Ngo Tuan Nghia');
INSERT INTO Author VALUES('George Raymond Richard Martin');

INSERT INTO CopiedBook VALUES('1000001','1',1);
INSERT INTO CopiedBook VALUES('1000001','2',1);
INSERT INTO CopiedBook VALUES('1000001','3',1);
INSERT INTO CopiedBook VALUES('1000001','4',1);
INSERT INTO CopiedBook VALUES('1000001','5',1);
INSERT INTO CopiedBook VALUES('1000002','1',1);
INSERT INTO CopiedBook VALUES('1000002','2',1);
INSERT INTO CopiedBook VALUES('1000002','3',1);
INSERT INTO CopiedBook VALUES('1000002','4',1);
INSERT INTO CopiedBook VALUES('1000002','5',1);
INSERT INTO CopiedBook VALUES('1000003','1',1);
INSERT INTO CopiedBook VALUES('1000003','2',1);
INSERT INTO CopiedBook VALUES('1000003','3',1);
INSERT INTO CopiedBook VALUES('1000003','4',1);
INSERT INTO CopiedBook VALUES('1000003','5',1);
INSERT INTO CopiedBook VALUES('1000003','6',1);
INSERT INTO CopiedBook VALUES('1000003','7',1);
INSERT INTO CopiedBook VALUES('1000004','1',1);
INSERT INTO CopiedBook VALUES('1000004','2',1);
INSERT INTO CopiedBook VALUES('1000004','3',1);
INSERT INTO CopiedBook VALUES('1000004','4',1);
INSERT INTO CopiedBook VALUES('1000005','1',1);
INSERT INTO CopiedBook VALUES('1000005','2',1);
INSERT INTO CopiedBook VALUES('1000005','3',1);
INSERT INTO CopiedBook VALUES('1000006','1',0);

INSERT INTO WrittenBy VALUES('1000001','Dang Van Vinh');
INSERT INTO WrittenBy VALUES('1000002','Pham Quoc Cuong');
INSERT INTO WrittenBy VALUES('1000003','Nguyen Trung Truc');
INSERT INTO WrittenBy VALUES('1000004','Pham Van Duc');
INSERT INTO WrittenBy VALUES('1000005','Ngo Tuan Nghia');
INSERT INTO WrittenBy VALUES('1000006','George Raymond Richard Martin');

INSERT INTO Loan VALUES ('1000006','1','2113376','1-4-2023','8-4-2023');


SELECT *
FROM LibraryManager

DELETE FROM LibraryManager
WHERE username = ''

INSERT INTO LibraryManager VALUES (null,'','','','')

SELECT * 
FROM Student
WHERE studentId = '2113376'
