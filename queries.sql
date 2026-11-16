CREATE TABLE Books
(
    BookID INT PRIMARY KEY,
    BookName VARCHAR(100),
    Author VARCHAR(50),
    Category VARCHAR(30),
    Price INT,
    PublishedYear INT
);

INSERT INTO Books VALUES
(1, 'Python Basics', 'Ramesh', 'Programming', 500, 2022),
(2, 'Java Complete', 'Kumar', 'Programming', 800, 2021),
(3, 'Database Design', 'Arun', 'Database', 650, 2023),
(4, 'English Grammar', 'Priya', 'Language', 300, 2020),
(5, 'Web Development', 'Bala', 'Programming', 900, 2024),
(6, 'SQL Master', 'Divya', 'Database', 700, 2022),
(7, 'Computer Networks', 'Ravi', 'Networking', 550, 2021),
(8, 'AI Fundamentals', 'Sara', 'Technology', 1000, 2025);
SELECT *
FROM Books
WHERE Price>600;

SELECT * FROM Books
WHERE Price <= 500;

SELECT * FROM Books
WHERE Category IN ('Programming', 'Database');

SELECT * FROM Books
WHERE Category NOT IN ('Programming', 'Language');

SELECT TOP 3*
FROM Books
ORDER BY Price DESC;

SELECT * FROM Books
WHERE PublishedYear BETWEEN 2021 AND 2024;

SELECT * FROM Books
WHERE BookName LIKE '%s';

SELECT * FROM Books
WHERE BookName LIKE 'C%';

SELECT * FROM Books
WHERE BookName LIKE '%SQL%';

SELECT *
FROM Books
WHERE PublishedYear IS NULL;
