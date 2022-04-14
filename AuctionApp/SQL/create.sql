CREATE TABLE user(
 userID INT(11) AUTO_INCREMENT PRIMARY KEY,
 username VARCHAR(30) UNIQUE NOT NULL,
 password VARCHAR(30)
);

CREATE TABLE Item(
 itemID INT(11) AUTO_INCREMENT PRIMARY KEY,
 size VARCHAR(30),
 state VARCHAR(30),
 category VARCHAR(30),
 name VARCHAR(30),
 price DOUBLE,
 imageSource VARCHAR(60),
 userID INT(11),
 FOREIGN KEY (userID) REFERENCES user(userID)
);

INSERT INTO `item` (`itemID`, `size`, `state`, `category`,
 `name`, `price`, `imageSource`, `userID`) 
VALUES (NULL, '30', 'Dobry', 'Mezczyzna', 'Spodnie', '100',
 '/AuctionApp;component/Images/logo_transparent.png', '1');
