USE Orari_v1

SELECT * FROM stafi

UPDATE Stafi
SET Fjalekalimi=123
WHERE ID_Stafi = 1018

ALTER TABLE Stafi
ADD passChanged BIT 

sp_rename 'Stafi.Stafi.passNderruar', 'passNderruar', 'COLUMN';

UPDATE Stafi
SET passChanged = 0

CREATE TRIGGER tr_changePasswordState
ON Stafi AFTER UPDATE 
AS BEGIN
	SET NOCOUNT ON;
	IF UPDATE(Fjalekalimi)
	BEGIN
		DECLARE @id INT;
		SET @id = (SELECT ID_Stafi FROM INSERTED)
		UPDATE Stafi
		SET passNderruar = 1
		WHERE ID_Stafi = @id
	END
END