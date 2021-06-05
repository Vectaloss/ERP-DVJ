USE erp;
drop table if exists Members, Customers, Contacts ,Prospections;

CREATE TABLE Members(
idMember INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
firstName VARCHAR(20) NOT NULL,
lastName VARCHAR(20) NOT NULL,
birth DATE,
email VARCHAR(45),
schoolEmail VARCHAR(45),
phone VARCHAR(20),
promo VARCHAR(20) ,
school ENUM('ESILV','EMLV','IIM'),
spe VARCHAR(20),
picture VARCHAR(20),
cotisation BOOL,
nationality VARCHAR(15),
idAdhesionBulletin INt,
idAdresse INT,
idUser INT
);

CREATE TABLE `Customers` (
  `idCustomer` INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `name` VARCHAR(25),
  `idAdress` INT,
  `SIREN` INT,
  `sector` VARCHAR(32),
  `website` VARCHAR(200),
  `size` ENUM("Autoentrepreneur", "GE", "ETI", "PME", "TPE")
);

CREATE TABLE `Contacts` (
  `idContact` INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `lastName` VARCHAR(50),
  `firstName` VARCHAR(50),
  `origin` VARCHAR(50),
  `job` VARCHAR(50),
  `phone` VARCHAR(15),
  `email` VARCHAR(50),
  `commentary` VARCHAR(1000),
  `idCustomer` INT
);

CREATE TABLE `Prospections` (

  `idProspection` INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `needs` VARCHAR(1000),
  `concernedBU` VARCHAR(10),
  `preparationDate` DATE,
  `type` ENUM('Phoning','Mailing'),
  `firstApproachQuality` ENUM('Mauvaise','Mitigée','Bonne','Excellente'),
  `contactDate` DATE,
  `leadedTo` VARCHAR(256),
  `commentary` VARCHAR(1000),
  `opportunityOfImprovement` VARCHAR(128),
  `idContact` INT,
  `idUser` INT
);




INSERT INTO `erp`.`members` (`idMember`, `firstName`, `lastName`, `birth`, `email`, `phone`, `promo`, `school`, `spe`, `cotisation`) VALUES ('1', 'Arnaud', 'SCHWARTZ', '2000-09-12', 'arnaud.schwartz@edu.devinci.fr', '+33676529223', '2023', 'ESILV', 'Data & IA', true);

INSERT INTO `erp`.`members` (`firstName`, `lastName`, `birth`, `email`, `phone`, `promo`, `school`, `spe`, `cotisation`) VALUES ( 'Anais', 'Zanucchi', '1999-04-13', 'anais.zanzucchi@edu.devinci.fr', '+33676529223', '2024', 'ESILV', 'Finance', true);

INSERT INTO `erp`.`Customers` (`name`,`idAdress`,`SIREN`,`sector`,`website`,`size`) VALUES ('Dassault','2','1235465','Aéronautique','www.google.com','PME');

INSERT INTO `erp`.`Contacts`  (`lastName`,`firstName`, `origin`,`job`,`phone`, `email`,`commentary`,`Idcustomer`) VALUES('Jean','Marchand','Linkedin','Commerciale','0676569536','jean@march@edu.devinci.fr','Très attaché au RSE','1');

INSERT INTO `erp`.`prospections` (`Needs`, `ConcernedBU`, `PreparationDate`, `type`, `firstApproachQuality`, `ContactDate`, `LeadedTo`, `Commentary`, `OpportunityOfImprovement`, `IdContact`, `idUser`) 
VALUES ('Site internet', 'ESILV','1999-04-13','Phoning','Mauvaise','1999-04-13','Envoi devis','Jetais malade','Je pourrais mieux préparer',1,1);

select *
from prospections
left join contacts using (idContact)
left join  customers using (idCustomer);