-- LibraryDB schema and seed data
-- Run in MySQL (XAMPP phpMyAdmin or MySQL Command Line)

-- Create database if it doesn't exist
CREATE DATABASE IF NOT EXISTS librarydb;
USE librarydb;

-- Users table: passwords stored as SHA-256 hash (BINARY)
CREATE TABLE IF NOT EXISTS Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password BINARY(32) NOT NULL,
    Role VARCHAR(10) NOT NULL DEFAULT 'User',
    CreatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);

-- Books table
CREATE TABLE IF NOT EXISTS Books (
    BookID INT AUTO_INCREMENT PRIMARY KEY,
    BookCode VARCHAR(20) NULL,
    Title VARCHAR(200) NOT NULL,
    Author VARCHAR(200) NULL,
    YearPublished INT NULL,
    Quantity INT NOT NULL DEFAULT 0
);

-- Borrow table
CREATE TABLE IF NOT EXISTS Borrow (
    BorrowID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL,
    BookID INT NOT NULL,
    BorrowDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    ReturnDate DATETIME NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Borrowed',
    CONSTRAINT FK_Borrow_Users FOREIGN KEY (UserID) REFERENCES Users(UserID),
    CONSTRAINT FK_Borrow_Books FOREIGN KEY (BookID) REFERENCES Books(BookID)
);

-- BorrowRequests table
CREATE TABLE IF NOT EXISTS BorrowRequests (
    BorrowRequestID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL,
    BookID INT NOT NULL,
    RequestDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Status VARCHAR(20) NOT NULL DEFAULT 'Pending',
    CONSTRAINT FK_BorrowRequests_Users FOREIGN KEY (UserID) REFERENCES Users(UserID),
    CONSTRAINT FK_BorrowRequests_Books FOREIGN KEY (BookID) REFERENCES Books(BookID)
);

-- ReturnRequests table
CREATE TABLE IF NOT EXISTS ReturnRequests (
    ReturnRequestID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL,
    BookID INT NOT NULL,
    RequestDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Status VARCHAR(20) NOT NULL DEFAULT 'Pending',
    CONSTRAINT FK_ReturnRequests_Users FOREIGN KEY (UserID) REFERENCES Users(UserID),
    CONSTRAINT FK_ReturnRequests_Books FOREIGN KEY (BookID) REFERENCES Books(BookID)
);

-- Seed admin user (username: admin, password: admin123)
-- Password stored as SHA-256 hash
INSERT INTO Users (FullName, Username, Password, Role)
SELECT * FROM (SELECT 
    'System Admin' AS FullName,
    'admin' AS Username,
    UNHEX(SHA2('admin123', 256)) AS Password,
    'Admin' AS Role
) AS tmp
WHERE NOT EXISTS (
    SELECT Username FROM Users WHERE Username = 'admin'
) LIMIT 1;

-- Sample books
INSERT INTO Books (BookCode, Title, Author, YearPublished, Quantity)
SELECT * FROM (
    SELECT 'JAVA01' AS BookCode, 'Java Programming' AS Title, 'James Gosling' AS Author, 2015 AS YearPublished, 5 AS Quantity
    UNION ALL SELECT 'PYTHON01', 'Python for Beginners', 'Guido van Rossum', 2018, 3
    UNION ALL SELECT 'CSHARP01', 'C# in Depth', 'Jon Skeet', 2019, 4
    UNION ALL SELECT 'WEB01', 'Web Development Basics', 'Tim Berners-Lee', 2020, 6
    UNION ALL SELECT 'DB01', 'Database Design', 'Edgar Codd', 2017, 2
) AS tmp
WHERE NOT EXISTS (
    SELECT BookCode FROM Books WHERE BookCode = 'JAVA01'
) LIMIT 5;

SELECT 'Database setup completed successfully!' AS Message;
