use projeto2019;

/*drop table users;
drop table componentesComprados;
drop table componentes;


CREATE TABLE IF NOT EXISTS users(
userid INT NOT NULL AUTO_INCREMENT,
     username varchar(45) NOT NULL,
     pass varchar(45) NOT NULL,
     email varchar(45) NOT NULL,
     sexo varchar(45) NOT NULL,
     telemovel int(9) NOT NULL,
     PRIMARY KEY (userid)
);

CREATE TABLE IF NOT EXISTS componentes(
	id INT NOT NULL AUTO_INCREMENT,
	nome varchar(45) NOT NULL,
    preco float4 NOT NULL,
    PRIMARY KEY (id)
);


CREATE TABLE IF NOT EXISTS componentesComprados(
	id INT NOT NULL AUTO_INCREMENT,
    componente_id INT NOT NULL,
	nome varchar(45) NOT NULL,
    preco float4 NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (componente_id) references componentes (id)
);*/

/*Componentes*/
INSERT componentes (nome, preco) values ("CPUintel_i3", 122);
INSERT componentes (nome, preco) values ("CPUintel_i5", 339);
INSERT componentes (nome, preco) values ("CPUintel_i7", 669);
INSERT componentes (nome, preco) values ("CPUintel_i9", 1399);

INSERT componentes (nome, preco) values ("FACorsairTX550M", 79);
INSERT componentes (nome, preco) values ("FACorsair850x", 122);
INSERT componentes (nome, preco) values ("FACorsairRM850x", 172);
INSERT componentes (nome, preco) values ("FACorsairAX1000", 254);

INSERT componentes (nome, preco) values ("GRAmsiArmor", 294);
INSERT componentes (nome, preco) values ("GRAmsiGeForce", 339);
INSERT componentes (nome, preco) values ("GRAmsiVentus", 734);
INSERT componentes (nome, preco) values ("GRAmsiDuke", 1309);

/*delete from componentes;*/

select * from componentes;











