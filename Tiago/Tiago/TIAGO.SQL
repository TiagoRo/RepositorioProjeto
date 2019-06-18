use tiago;


CREATE TABLE users (
     id MEDIUMINT NOT NULL AUTO_INCREMENT,
     username varchar(45) NOT NULL,
     pass varchar(45) NOT NULL,
     email varchar(45) NOT NULL,
     sexo varchar(45) NOT NULL,
     telemovel int(9) NOT NULL,
     PRIMARY KEY (id)
);

SELECT * FROM users;