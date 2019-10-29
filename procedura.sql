CREATE TABLE CPL
(
	ID_CPL INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_Stafi INT NOT NULL FOREIGN KEY (ID_Stafi) REFERENCES Stafi(ID_Stafi) ON DELETE CASCADE ON UPDATE CASCADE,
	ID_Lenda INT NOT NULL FOREIGN KEY (ID_Lenda) REFERENCES Lendet(ID_Lenda) ON DELETE CASCADE ON UPDATE CASCADE
);

ALTER TABLE Oraret
ADD ID_CPL INT FOREIGN KEY (ID_CPL) REFERENCES CPL(ID_CPL) ON DELETE CASCADE ON UPDATE CASCADE NOT NULL

CREATE PROCEDURE sp_getProfessor (@subject NVARCHAR(150))
AS
BEGIN
SELECT CONCAT(S.Emri,' ',S.Mbiemri) AS [Emri Mbiemri], C.CPA FROM CPL INNER JOIN Stafi S ON CPL.ID_Stafi = S.ID_Stafi INNER JOIN CPA C ON S.ID_CPA=C.ID_CPA INNER JOIN Lendet L ON CPL.ID_Lenda = L.ID_Lenda WHERE L.Lenda = @subject AND C.CPA = 'Professor';
END
go

CREATE PROCEDURE sp_getAssistent (@subject NVARCHAR(150))
AS
BEGIN
SELECT CONCAT(S.Emri,' ',S.Mbiemri) AS [Emri Mbiemri], C.CPA FROM CPL INNER JOIN Stafi S ON CPL.ID_Stafi = S.ID_Stafi INNER JOIN CPA C ON S.ID_CPA=C.ID_CPA INNER JOIN Lendet L ON CPL.ID_Lenda = L.ID_Lenda WHERE L.Lenda = @subject AND C.CPA = 'Assistent';
END
go

CREATE PROCEDURE sp_getSubjectType (@subject NVARCHAR(150))
AS
BEGIN
SELECT Ll.LlojiL FROM [Lloji i Lendeve] AS Ll INNER JOIN Lendet AS L ON Ll.ID_LlojiLendes = L.ID_LlojiLendes WHERE L.Lenda = @subject;
END

EXEC sp_getProfessor 'Programim 1'

SELECT CONCAT(S.Emri,' ',S.Mbiemri) AS [Emri Mbiemri], C.CPA FROM CPL INNER JOIN Stafi S ON CPL.ID_Stafi = S.ID_Stafi INNER JOIN CPA C ON S.ID_CPA=C.ID_CPA INNER JOIN Lendet L ON CPL.ID_Lenda = L.ID_Lenda WHERE L.Lenda = 'Programim 1';

INSERT INTO CPL VALUES(1005, 1)
INSERT INTO CPL VALUES(1021, 1)

SELECT * FROM Departamentet
SELECT * FROM Oraret
SELECT * FROM CPA
SELECT * FROM Stafi
SELECT * FROM Dep_Lendet
SELECT * FROM Lendet
SELECT * FROM Staf_Dep

SELECT COUNT(*) FROM Lendet AS L INNER JOIN Dep_Lendet AS DL ON L.ID_Lenda = DL.ID_Lenda INNER JOIN Departamentet AS D ON DL.ID_Dep=D.ID_Dep WHERE D.Dep = 'Shkenca Kompjuterike'

CREATE PROCEDURE sp_InsertSubject (@lenda VARCHAR(150), @ECTS TINYINT, @Semester TINYINT, @type INT, @dep INT)
AS
BEGIN
	DECLARE @insertedSubject INT;
	INSERT INTO Lendet VALUES(@lenda, @ECTS, @Semester, @type);

	SET @insertedSubject = (SELECT TOP 1 ID_Lenda FROM Lendet ORDER BY ID_Lenda DESC);

	INSERT INTO Dep_Lendet VALUES(@dep, @insertedSubject);
END

CREATE PROCEDURE sp_insertStaff (@dep INT)
AS 
BEGIN
	DECLARE @insertedStaff INT;
	SET @insertedStaff = (SELECT TOP 1 ID_Stafi FROM Stafi ORDER BY ID_Stafi DESC);

	INSERT INTO Staf_Dep VALUES(@insertedStaff, @dep);
END

SELECT TOP 1 ID_Stafi FROM Stafi ORDER BY ID_Stafi DESC

TRUNCATE TABLE Dep_Lendet
TRUNCATE TABLE Lendet
TRUNCATE TABLE Departamentet
TRUNCATE TABLE Disponueshmeria
TRUNCATE TABLE Fakultetet
TRUNCATE TABLE Lendet
TRUNCATE TABLE [Llojet e Sallave]
TRUNCATE TABLE [Lloji i Lendeve]
TRUNCATE TABLE LUSH
TRUNCATE TABLE Sallat
TRUNCATE TABLE Stafi
TRUNCATE TABLE [Titujt Shkencor]
TRUNCATE TABLE CPA
TRUNCATE TABLE CPL
TRUNCATE TABLE Staf_Dep

SELECT * FROM Stafi
SELECT * FROM [Titujt Shkencor]
SELECT * FROM CPA
INSERT INTO [Titujt Shkencor] VALUES('Dr.');
INSERT INTO CPA VALUES('Professor');

ALTER TABLE Stafi
ALTER 

INSERT INTO Stafi(Emri, Mbiemri, ID_Titulli, ID_CPA, Numri_Personal, Foto, Foto_Emri, Fjalekalimi, Email, Roli) VALUES('Xhevahir','Bajrami',1,1,'1111111111',0x010203040506, 'Koala.jpg', '123','xhevahir.bajrami@gmail.com', 'Admin')
INSERT INTO [Titujt Shkencor] VALUES('Obligative');
INSERT INTO [Titujt Shkencor] VALUES('Optional');