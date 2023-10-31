CREATE DATABASE BB206Class

USE BB206Class

CREATE TABLE Students
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(20) NOT NULL,
	Surname NVARCHAR(25) CHECK(LEN(Surname) > 5),
	Email NVARCHAR(30) DEFAULT 'mail hele ki yoxdur'
)

SELECT * FROM Students

INSERT INTO Students (Email, Surname, Name)
VALUES
('Perviz','Elishkayev', 'Salam@gmail.com')



SELECT * FROM Students

INSERT INTO Students
VALUES
('Veli','Veliyev','v@gmail.com'),
('Remzi','HasanovH','ramzes@gmail.com')

UPDATE Students
SET Surname = 'Hasanov'
WHERE Id = 3

UPDATE Students
SET Surname = 'Eliyev'
WHERE Name = 'Veli'

DELETE FROM Students

TRUNCATE TABLE Students





