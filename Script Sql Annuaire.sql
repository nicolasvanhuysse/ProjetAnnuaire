CREATE TABLE Service(
   idService INT Auto_increment  NOT NULL,
   name VARCHAR(100),
   PRIMARY KEY(idService)
);

CREATE TABLE Admin(
   id INT Auto_increment  NOT NULL,
   login VARCHAR(50),
   password VARCHAR(200),
   PRIMARY KEY(id)
);

CREATE TABLE SiteType(
   id_SiteType INT Auto_increment  NOT NULL,
   name VARCHAR(100),
   PRIMARY KEY(id_SiteType)
);

CREATE TABLE Site(
   idSite INT Auto_increment  NOT NULL,
   name VARCHAR(100),
   id_SiteType INT NOT NULL,
   PRIMARY KEY(idSite),
   FOREIGN KEY(id_SiteType) REFERENCES SiteType(id_SiteType)
);

CREATE TABLE employee(
   id INT Auto_increment  NOT NULL,
   firstName VARCHAR(100),
   lastName VARCHAR(100),
   phone VARCHAR(50),
   cellPhone VARCHAR(50),
   mail VARCHAR(50),
   idService INT NOT NULL,
   idSite INT NOT NULL,
   PRIMARY KEY(id),
   FOREIGN KEY(idService) REFERENCES Service(idService),
   FOREIGN KEY(idSite) REFERENCES Site(idSite)
);

INSERT INTO `admin` (`id`, `login`, `password`) VALUES (NULL, 'Admin', 'pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM=');
INSERT INTO `sitetype` (`id_SiteType`, `name`) VALUES (NULL, 'Siège Administratif'), (NULL, 'Site de Production');

INSERT INTO `site` (`idSite`, `name`, `id_SiteType`) VALUES
(1, 'Paris', 1),
(2, 'Nantes', 2),
(3, 'Toulouse', 2),
(4, 'Nice', 2),
(5, 'Lille', 2),
(11, 'Arras', 2);

INSERT INTO `service` (`idService`, `name`) VALUES
(1, 'Comptabilité'),
(2, 'Production'),
(3, 'Accueil'),
(4, 'Informatique'),
(10, 'Commercial'),
(13, 'Ressource humaine');
