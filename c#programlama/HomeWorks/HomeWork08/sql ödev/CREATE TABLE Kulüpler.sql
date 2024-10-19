CREATE TABLE Kulüpler
(
    KulupID INT PRIMARY KEY,
    KulupAdi NVARCHAR(50),
    KurulusYili INT
);

CREATE TABLE OgrenciKulup
(
    OgrenciID INT,
    KulupID INT,
    Rol NVARCHAR(50),
    KatilimTarihi INT,
    PRIMARY KEY (OgrenciID,KulupID),
    FOREIGN KEY (KulupID) REFERENCES Kulüpler(KulupID)

)

CREATE TABLE Ogrenciler
(
    OgrenciID INT PRIMARY KEY,
    Ad VARCHAR(50),
    Soyad VARCHAR(50)
);

INSERT INTO Kulüpler (KulupID,KulupAdi,KurulusYili) VALUES
(1,'Tiyatro Kulübü',2010),
(2, 'Müzik Kulübü', 2012),
(3, 'Spor Kulübü', 2015),
(4, 'Bilim Kulübü', 2018),
(5, 'Resim Kulübü', 2020);

INSERT INTO OgrenciKulup
    (OgrenciID, KulupID, Rol, KatilimTarihi)
VALUES
    (1, 1, 'Başkan', '2022-09-01'),
    (2, 1, 'Üye', '2022-09-05'),
    (3, 1, 'Sekreter', '2022-09-10'),

    (4, 2, 'Başkan', '2023-01-15'),
    (5, 2, 'Üye', '2023-01-20'),
    (6, 2, 'Üye', '2023-01-22'),

    (7, 3, 'Başkan', '2023-02-05'),
    (8, 3, 'Üye', '2023-02-10'),
    (9, 3, 'Sekreter', '2023-02-15'),

    (10, 4, 'Üye', '2023-03-01'),
    (11, 4, 'Üye', '2023-03-05'),
    (12, 4, 'Sekreter', '2023-03-10'),

    (13, 5, 'Başkan', '2023-04-01'),
    (14, 5, 'Üye', '2023-04-05'),
    (15, 5, 'Üye', '2023-04-10');


    SELECT
    o.Ad + ' ' + O.Soyad AS IsimSoyisim,
    k.KulupAdi AS HangiKulüp

    FROM OgrenciKulup ok
    JOIN Ogrenciler o ON ok.OgrenciID=o.OgrenciID
    JOIN Kulüpler k ON ok.KulupID=k.KulupID;

    SELECT Ogrenciler.Ad, Ogrenciler.Soyad, OgrenciKulup.Rol
FROM OgrenciKulup
    JOIN Ogrenciler ON OgrenciKulup.OgrenciID = Ogrenciler.OgrenciID
    JOIN Kulüpler ON OgrenciKulup.KulupID = Kulüpler.KulupID
WHERE Kulüpler.KulupAdi = 'Tiyatro Kulübü';

SELECT
o.Ad AS Isım,
o.Soyad AS SoyIsım
FROM OgrenciKulup ok
JOIN Ogrenciler o ON ok.OgrenciID=O.OgrenciID

WHERE ok.Rol ='Başkan';

SELECT 
k.KulupAdi AS KulüpAdı,

COUNT(ok.OgrenciID) AS ÜyeSayısı
FROM Kulüpler k
JOIN OgrenciKulup ok on k.KulupID=ok.KulupID
GROUP BY k.KulupAdi;

SELECT Ogrenciler.Ad, Ogrenciler.Soyad, Kulüpler.KulupAdi
FROM OgrenciKulup
    JOIN Ogrenciler ON OgrenciKulup.OgrenciID = Ogrenciler.OgrenciID
    JOIN Kulüpler ON OgrenciKulup.KulupID = Kulüpler.KulupID
WHERE Kulüpler.KurulusYili = (
    SELECT MIN(KurulusYili)
FROM Kulüpler
);
SELECT Ogrenciler.Ad, Ogrenciler.Soyad, Kulüpler.KulupAdi, OgrenciKulup.KatilimTarihi
FROM OgrenciKulup
    JOIN Ogrenciler ON OgrenciKulup.OgrenciID = Ogrenciler.OgrenciID
    JOIN Kulüpler ON OgrenciKulup.KulupID = Kulüpler.KulupID;

    SELECT DISTINCT OgrenciKulup.Rol
FROM OgrenciKulup
    JOIN Kulüpler ON OgrenciKulup.KulupID = Kulüpler.KulupID
WHERE Kulüpler.KulupAdi = 'Müzik Kulübü';

SELECT Kulüpler.KulupAdi, COUNT(OgrenciKulup.OgrenciID) AS BaşkanSayisi
FROM OgrenciKulup
    JOIN Kulüpler ON OgrenciKulup.KulupID = Kulüpler.KulupID
WHERE OgrenciKulup.Rol = 'Başkan'
GROUP BY Kulüpler.KulupAdi;
SELECT Ogrenciler.Ad, Ogrenciler.Soyad, Kulüpler.KulupAdi, OgrenciKulup.KatilimTarihi
FROM OgrenciKulup
    JOIN Ogrenciler ON OgrenciKulup.OgrenciID = Ogrenciler.OgrenciID
    JOIN Kulüpler ON OgrenciKulup.KulupID = Kulüpler.KulupID
ORDER BY OgrenciKulup.KatilimTarihi DESC
LIMIT 1;
SELECT Ogrenciler.Ad, Ogrenciler.Soyad, GROUP_CONCAT(Kulüpler.KulupAdi) AS KatildigiKulüpler
FROM OgrenciKulup
    JOIN Ogrenciler ON OgrenciKulup.OgrenciID = Ogrenciler.OgrenciID
    JOIN Kulüpler ON OgrenciKulup.KulupID = Kulüpler.KulupID
GROUP BY Ogrenciler.OgrenciID
HAVING COUNT(Kulüpler.KulupID) > 1;





