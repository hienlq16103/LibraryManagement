CREATE DATABASE LibraryManagement
GO

CREATE TABLE LibraryManager(
username varchar(50) PRIMARY KEY,
password varchar (50) NOT NULL,
managerName varchar (50) NOT NULL,
email varchar(50) NOT NULL,
phoneNumber char(100) NOT NULL
);


