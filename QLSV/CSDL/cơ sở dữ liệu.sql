create database QLSV
go
USE QLSV
CREATE TABLE BOOK
(
	ID VARCHAR(10) NOT NULL PRIMARY KEY,
    TITLE NVARCHAR(50) NOT NULL,
    AUTHOR NVARCHAR(50) NOT NULL,
    CATEGORY NVARCHAR(50) NOT NULL,
    PUBLISH_YEAR DATE NOT NULL,
    QUANTITY INT NOT NULL,
    RENTAL_QUANTITY INT NOT NULL,
    LOCATION NVARCHAR(30) NOT NULL,
    IS_EMPTY bit  NOT NULL
)

CREATE TABLE STUDENT
(
	ID VARCHAR(10) NOT NULL PRIMARY KEY,
    NAME NVARCHAR(50) NOT NULL,
    CLASS VARCHAR(10) NOT NULL,
    NUMBER_PHONE VARCHAR(10) NOT NULL,
    EMAIL VARCHAR(20) NOT NULL
);

CREATE TABLE RENTAL_CARD
(
	ID VARCHAR(10) NOT NULL PRIMARY KEY,
    ID_STUDENT VARCHAR(10) NOT NULL,
    RENTAL_DAY DATE NOT NULL,
    EXPIRATION_DAY DATE NOT NULL,
    EXPIRED Bit NOT NULL
)

CREATE TABLE DETAIL_RENTAL_CARD
(
	ID_RENTAL_CARD VARCHAR(10) NOT NULL,
    ID_BOOK VARCHAR(10) NOT NULL,
    QUANTITY INT NOT NULL,
    PRIMARY KEY (ID_RENTAL_CARD, ID_BOOK)
);

CREATE TABLE STAFF
(
	ID VARCHAR(10) NOT NULL PRIMARY KEY,
    NAME NVARCHAR(50) NOT NULL,
    POSITION NVARCHAR(20) NOT NULL,
    PHONENUMBER NVARCHAR(10) NOT NULL,
    EMAIL NVARCHAR(20) NOT NULL
)

CREATE TABLE ACCOUNT
(
	ID_STAFF VARCHAR(10) NOT NULL PRIMARY KEY,
    USER_ID VARCHAR(30) NOT NULL,
    PASSWORD_ID VARCHAR(30) NOT NULL
);


-- TAO KHOA NGOAI CHO SINHVIEN-RENTAL_CARD
ALTER TABLE RENTAL_CARD
ADD FOREIGN KEY (ID_STUDENT)
REFERENCES STUDENT(ID)


-- TAO KHOA NGOAI CHO DETAIL_RENTAL_CARD-RENTAL_CARD
ALTER TABLE DETAIL_RENTAL_CARD
ADD FOREIGN KEY (ID_RENTAL_CARD)
REFERENCES RENTAL_CARD(ID);

-- TAO KHOA NGOAI CHO BOOK-DETAIL_RENTAL_CARD
ALTER TABLE DETAIL_RENTAL_CARD
ADD FOREIGN KEY (ID_BOOK)
REFERENCES BOOK(ID)

-- TAO KHOA NGOAI CHO STAFF-ACCOUNT
ALTER TABLE ACCOUNT
ADD FOREIGN KEY (ID_STAFF)
REFERENCES STAFF(ID)