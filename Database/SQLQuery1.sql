CREATE TABLE account
(
	id INT PRIMARY KEY IDENTITY(1, 1),
	userID INT,
	username VARCHAR(MAX) NULL,
	email VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	date_register DATE NULL,
)

SELECT * FROM account;

DROP TABLE account;

SET IDENTITY_INSERT account ON

INSERT INTO account (userID, username, email, password, date_register)
VALUES (1000, 'johnny', 'johnny_manager@gmail.com', 'thanhxuan2601', GETDATE());

SET IDENTITY_INSERT account OFF

CREATE TABLE account
(
	id INT PRIMARY KEY IDENTITY(1, 1),
	userID INT,
	username VARCHAR(MAX) NULL,
	email VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	date_register DATE NULL,
)

DROP TABLE entries;

CREATE TABLE entries
(
  word varchar(25) NOT NULL,
  wordtype varchar(20) NOT NULL,
  definition text NOT NULL
) 

SELECT * FROM entries;

