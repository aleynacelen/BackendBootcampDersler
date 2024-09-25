
USE Okul
CREATE TABLE Bolumler(
    BolumId INT PRIMARY KEY IDENTITY(1,1),
    BolumAdi NVARCHAR(50) not NULL
    ) 

    CREATE TABLE Dersler(
        DersID INT PRIMARY KEY IDENTITY(1,1) ,
        DersAdi NVARCHAR(100) Not NULL,
        Kredi TINYINT NOT NULL,
        BolumId INT not NULL,
        FOREIGN KEY(BolumId) REFERENCES Bolumler(BolumId)




    )
    CREATE table Ogrenciler(
        OgrenciId INT PRIMARY KEY IDENTITY (1,1),
        Ad NVARCHAR(50) not NULL,
        SoyAd NVARCHAR(50) not NULL,
        DogumTarihi DATE NULL,
        BolumId INT NOT NULL,
        FOREIGN KEY(BolumId) REFERENCES Bolumler(BolumId)




    )
    CREATE TABLE DersKayıtlari (
    OgrenciId INT,
    DersId INT, 
    PRIMARY KEY(OgrenciId, DersID),
    FOREIGN KEY (OgrenciId) REFERENCES Ogrenciler(OgrenciId),
    FOREIGN KEY (DersID) REFERENCES dersler(DersID)



    )
