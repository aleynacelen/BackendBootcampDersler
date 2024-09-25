USE master

DROP DATABASE IF EXISTS Okul

CREATE DATABASE Okul


 
USE Okul
CREATE TABLE Bolumler
(
    BolumId INT PRIMARY KEY IDENTITY(1,1),
    BolumAdi NVARCHAR(50) not NULL
)

CREATE TABLE Dersler
(
    DersID INT PRIMARY KEY IDENTITY(1,1) ,
    DersAdi NVARCHAR(100) Not NULL,
    Kredi TINYINT NOT NULL,
    BolumId INT not NULL,
    FOREIGN KEY(BolumId) REFERENCES Bolumler(BolumId)




)
CREATE table Ogrenciler
(
    OgrenciId INT PRIMARY KEY IDENTITY (1,1),
    Ad NVARCHAR(50) not NULL,
    SoyAd NVARCHAR(50) not NULL,
    DogumTarihi DATE NULL,
    BolumId INT NOT NULL,
    FOREIGN KEY(BolumId) REFERENCES Bolumler(BolumId)




)
USE Okul
CREATE TABLE DersKayıtlari
(
    OgrenciId INT,
    DersId INT,
    PRIMARY KEY(OgrenciId, DersID),
    FOREIGN KEY (OgrenciId) REFERENCES Ogrenciler(OgrenciId),
    FOREIGN KEY (DersID) REFERENCES dersler(DersID)
    




)

USE Okul
INSERT INTO Bolumler
    (BolumAdi)
VALUES
    ('Bilgisayar Mühendisliği'),
    ('Hukuk'),
    ('Mekatronik Mühendisliği')
    
    Insert INTO Dersler (BolumId, DersAdi, Kredi)
    VALUES
    (1,'Temel Programlama',5),
    (1,'Temel Elektronik',6),
    (1,'Yapay zekaya giriş',5)

    INSERT Into Ogrenciler(BolumId,Ad,SoyAd,DogumTarihi)
    VALUES
   (1,'alican','Kintuta','2000-05-19'),
   (1,'Seda','serden','1990-06-12'),

   (1,'candan','tutankaçan','2000-28-02'),
   (1,'kemal','evrim','1999-05-02')
  

  INSERT INTO DersKayıtlari(OgrenciId,DersId)
  VALUES
  (2,3),
  (2,1)


    




