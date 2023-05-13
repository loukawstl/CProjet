CREATE DATABASE GestionCommercialesNew;
GO
USE GestionCommercialesNew;
GO


CREATE TABLE "client" (
  "code_client" int IDENTITY(1,1) NOT NULL,
  "nom_client" varchar(255) NOT NULL,
  "prenom_client" varchar(255) NOT NULL,
  "rue_facturation_client" varchar(255) NOT NULL,
  "cp_facturation_client" varchar(5) NOT NULL,
  "ville_facturation_client" varchar(255) NOT NULL,
  "rue_livraison_client" varchar(255) NOT NULL,
  "cp_livraison_client" varchar(5) NOT NULL,
  "ville_livraison_client" varchar(255) NOT NULL,
  "telephone_client" varchar(15) NOT NULL,
  "fax_client" varchar(15) NOT NULL,
  "email_client" varchar(255) NOT NULL
);

--Client

SET IDENTITY_INSERT client ON;

INSERT INTO "client" ("code_client", "nom_client", "prenom_client", "rue_facturation_client", "cp_facturation_client", "ville_facturation_client", "rue_livraison_client", "cp_livraison_client", "ville_livraison_client", "telephone_client", "fax_client", "email_client") VALUES
(1, 'John', 'Doe', 'Joe', '69420', 'Creil', 'Jacques chirac', '69420', 'Bruce sur mer', '0612345678', '1234567876', 'JohnDoe@gmail.com'),
(2, 'Dupont', 'Robert', 'Jesus Christ', '10101', 'Marseille', 'Jesus Christ', '10101', 'Marseille', '011111111111', '1234567890', 'richard@entreprise.fr'),
(3, 'De nazareth', 'Jesus', 'Jules ferry', '60700', 'Puteaux', 'Jean Jacques', '60601', 'Nice', '0909090909', '1357908642', 'fan2shrek@yahoo.fr'),
(4, 'Mama', 'Joe', 'Jean Boin', '01420', 'Senlis', 'Jean Boin', '01420', 'Senlis', '0622334455', '2711200320', 'joeMama@outlook.fr'),
(5, 'Joestar', 'Jotaro', 'Diego Brando', '08123', 'Morioh', 'Higashikata', '12308', 'Salomon', '0611223344', '1235467809', 'JotaroBg@gmail.com'),
(6, 'Ammar', 'Mikael', 'Jacques chirace', '01420', 'Senlis', 'Pont-ste-maxence', '69420', 'Chantilly', '0325678256', '1234567809', 'Mammar@lyceestvincent.fr'),
(7, 'Dupond', 'Jean', 'president Wilson', '01550', 'Toulon', 'president Wilson', '01550', 'Toulon', '0657493658', '52638027309', 'JeanDupond@yahoo.com\r'),
(8, 'Chervin', 'Bernard', 'Marechal Petain', '75045', 'Paris', 'Barack Obama', '75045', 'Paris', '0634987346', '2345678767', 'darkBerber@gmail.com'),
(9, 'Higashikata', 'Josuke', 'Araki', '12121', 'Yoshikage', 'Churchill', '43012', 'Toulouse', '0638263946', '8973420993', 'jojolion@higashikata.fr'),
(10, 'Chimerre', 'Benoit', 'Obama', '50230', 'Corbeille-et-son', 'Obama', '50230', 'Corbeille-et-son', '078362982', '932897309', 'Benito@outlook.fr'), 
(11, 'Electo', 'Jeanne', 'De gaulle', '12121', 'Grenoble', 'Robespierre', '60120', 'Montargy', '072786322', '1628732989', 'Jeane@gmail.com');

SET IDENTITY_INSERT client OFF;

--categorie

CREATE TABLE "categorie"(
  "code_categorie" int IDENTITY(1,1) NOT NULL,
  "libelle_categorie" varchar(255) NOT NULL,
);

SET IDENTITY_INSERT categorie ON;

INSERT INTO "categorie" ("code_categorie", "libelle_categorie") VALUES
(1, 'Composant'),
(2, 'Materiel'),
(3, 'Television'),
(4, 'Appareil'),
(5, 'Aspirateur'),
(6, 'Cuisine'),
(7, 'Equipement'),
(8, 'Telephonie'),
(9, 'Bureautique'),
(10, 'Laverie');

SET IDENTITY_INSERT categorie OFF;

--Contenir

CREATE TABLE "contenir" (
  "code_devis" int NOT NULL,
  "code_produit" int NOT NULL,
  "quantite" int NOT NULL,
  "remise" float NOT NULL,
);

INSERT INTO "contenir" ("code_devis", "code_produit", "quantite", "remise") VALUES
(1, 11, 10, 5),
(1, 13, 3, 0),
(2, 9, 20, 0),
(3, 7, 1, 20),
(4, 3, 70, 0),
(5, 2, 800, 5),
(6, 5, 2, 13),
(6, 12, 30, 5),
(7, 10, 1, 0),
(9, 9, 20, 20);

--Devis

CREATE TABLE "devis" (
  "code_devis" int IDENTITY(1,1) NOT NULL,
  "date_devis" date NOT NULL,
  "taux_tva_devis" float NOT NULL,
  "code_client" int NOT NULL,
  "code_statut" int NOT NULL
);

SET IDENTITY_INSERT devis ON;

INSERT INTO "devis" ("code_devis", "date_devis", "taux_tva_devis", "code_client", "code_statut") VALUES
(1, '2022-10-11', 12, 1, 1),
(2, '2022-10-12', 5, 3, 2),
(3, '2022-10-11', 12, 1, 3),
(4, '2022-10-12', 5, 3, 2),
(5, '2022-10-02', 20, 1, 3),
(6, '2013-10-16', 15.5, 6, 1),
(7, '2022-08-15', 17, 3, 1),
(8, '2022-10-12', 5, 3, 2),
(9, '2022-10-20', 7, 5, 3),
(10, '2022-10-05', 12.9, 1, 2);

SET IDENTITY_INSERT devis OFF;

--Produit

CREATE TABLE "produit" (
  "code_produit" int IDENTITY(1,1) NOT NULL,
  "libelle_produit" varchar(255) NOT NULL,
  "prix_vente_ht_produit" float NOT NULL,
  "code_categorie" int NOT NULL,
);

SET IDENTITY_INSERT produit ON;

INSERT INTO "produit" ("code_produit", "libelle_produit", "prix_vente_ht_produit", "code_categorie") VALUES
(1, 'Television TV110', 130, 3),
(2, 'Aspirateur dyson DY-12', 59.99, 5),
(3, 'Television TV150', 220, 3),
(4, 'Aspirateur darty DT-20', 79.99, 5),
(5, 'Ordinateur Asus 178-L7', 989.99, 4),
(6, 'Clavier Bureautique CB19', 9.99, 9),
(7, 'Television LG420', 1230, 3),
(8, 'Souris', 6.59, 9),
(9, 'Disque dur', 59.99, 7),
(10, 'Carte mere TY-123-HG', 359.99, 1),
(11, 'Four TOP-16', 129.89, 6),
(12, 'Telephone A70', 309, 8),
(13, 'Tapis de souris AT-03', 5.56, 9);

SET IDENTITY_INSERT produit OFF;

--Statut

CREATE TABLE "statut" (
  "code_statut" int IDENTITY(1,1) NOT NULL,
  "libelle_statut" varchar(255) NOT NULL
);

SET IDENTITY_INSERT statut ON;

INSERT INTO "statut" ("code_statut", "libelle_statut") VALUES
(1, 'Accepté'),
(2, 'Refusé'),
(3, 'En attente');

SET IDENTITY_INSERT statut OFF;

--Utilisateur

CREATE TABLE "utilisateur" (
  "code_utilisateur" int IDENTITY(1,1) NOT NULL,
  "login_utilisateur" varchar(255) NOT NULL,
  "mot_de_passe_utilisateur" varchar(255) NOT NULL
);


SET IDENTITY_INSERT utilisateur ON;

INSERT INTO "utilisateur" ("code_utilisateur", "login_utilisateur", "mot_de_passe_utilisateur") VALUES
(1, 'admin', 'admin'),
(2, 'Pierrot', 'aspicot'),
(5, 'Kevin', 'kanjuro'),
(6, 'Charles', 'charles2011'),
(7, 'Shrek', 'fiona'),
(8, 'Charlie', 'riz'),
(9, 'Patrick', 'patou420'),
(10, 'Louis', '@@@'),
(12, 'Nabil', 'reviensStp'),
(13, 'Clarence', 'plastique'),
(14, 'chou', 'fleur');

SET IDENTITY_INSERT utilisateur OFF;

--Clés primaires 

ALTER TABLE "client"
  ADD PRIMARY KEY ("code_client");

ALTER TABLE "contenir"
  ADD PRIMARY KEY ("code_devis","code_produit");

ALTER TABLE "devis"
  ADD PRIMARY KEY ("code_devis");

ALTER TABLE "produit"
  ADD PRIMARY KEY ("code_produit");

ALTER TABLE "statut"
  ADD PRIMARY KEY ("code_statut");

ALTER TABLE "utilisateur"
  ADD PRIMARY KEY ("code_utilisateur");

ALTER TABLE "categorie"
  ADD PRIMARY KEY ("code_categorie");

--Clés étrangères

ALTER TABLE "contenir"
  ADD CONSTRAINT "Contenir_Devis_FK" FOREIGN KEY ("code_devis") REFERENCES "devis" ("code_devis");
ALTER TABLE "contenir"
  ADD CONSTRAINT "Contenir_Produit0_FK" FOREIGN KEY ("code_produit") REFERENCES "produit" ("code_produit");

ALTER TABLE "devis"
  ADD CONSTRAINT "Devis_Client_FK" FOREIGN KEY ("code_client") REFERENCES "client" ("code_client");
ALTER TABLE "devis"
  ADD CONSTRAINT "Devis_Statut0_FK" FOREIGN KEY ("code_statut") REFERENCES "statut" ("code_statut");

ALTER TABLE "produit"
  ADD CONSTRAINT "Produit_Categorie0_FK" FOREIGN KEY ("code_categorie") REFERENCES "categorie" ("code_categorie");

GO
  
CREATE VIEW informations
AS
SELECT C.code_client, C.nom_client, C.prenom_client, C.rue_facturation_client, C.cp_facturation_client, C.ville_facturation_client, C.rue_livraison_client, C.cp_livraison_client, C.ville_livraison_client, C.telephone_client, C.fax_client, C.email_client,
Ca.code_categorie, Ca.libelle_categorie, 
Co.code_produit, Co.quantite, Co.remise,
D.code_devis, D.date_devis, D.taux_tva_devis,
P.libelle_produit, P.prix_vente_ht_produit,
S.code_statut, S.libelle_statut
FROM statut S, produit P, devis D, client C, contenir Co, categorie Ca
WHERE Co.code_devis = D.code_devis
AND D.code_client = C.code_client
AND D.code_statut = S.code_statut
AND Co.code_produit = P.code_produit
AND P.code_categorie = Ca.code_categorie
GO
