INSERT INTO dbo.Author 
VALUES (
	'�������',
	'����������',
	'06-12-1979',
	NULL,
	'������'
), (
	'���',
	'���������',
	'31-10-1959',
	NULL,
	'�������'
)

SELECT * FROM dbo.Author;

INSERT INTO dbo.Ganre 
VALUES (
	'����������'
), (
	'���������������'
)

SELECT * FROM dbo.Ganre;

INSERT INTO dbo.Book 
VALUES (
	'����� 2033',
	1,
	'24-10-2005',
	2,
	'���������',
	7
), (
	'�������������',
	2,
	'24-10-2005',
	1,
	'���������',
	10
)

SELECT * FROM dbo.Book;
SELECT Book.Id, Title, 
FirsName, LastName as FullName, ReleaseDate, Name, Status, Rating FROM dbo.Book
INNER JOIN Author ON Book.Author_Id = Author.Id
INNER JOIN Ganre ON Book.Ganre_Id = Ganre.Id
;