INSERT INTO dbo.Author 
VALUES (
	'Дмитрий',
	'Глуховский',
	'06-12-1979',
	NULL,
	'Россия'
), (
	'Нил',
	'Стивенсон',
	'31-10-1959',
	NULL,
	'Америка'
)

SELECT * FROM dbo.Author;

INSERT INTO dbo.Ganre 
VALUES (
	'Фантастика'
), (
	'Постапокалипсис'
)

SELECT * FROM dbo.Ganre;

INSERT INTO dbo.Book 
VALUES (
	'Метро 2033',
	1,
	'24-10-2005',
	2,
	'Прочитано',
	7
), (
	'Криптономикон',
	2,
	'24-10-2005',
	1,
	'Прочитано',
	10
)

SELECT * FROM dbo.Book;
SELECT Book.Id, Title, 
FirsName, LastName as FullName, ReleaseDate, Name, Status, Rating FROM dbo.Book
INNER JOIN Author ON Book.Author_Id = Author.Id
INNER JOIN Ganre ON Book.Ganre_Id = Ganre.Id
;