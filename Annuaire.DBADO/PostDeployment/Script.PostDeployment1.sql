/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

/*____________________PAYS____________________*/
insert into Pays (Nom, Continent) values ('Belgique', 'Europe');

/*____________________REGIONS____________________*/
insert into Regions (Code_Postal, Ville, Pays) values (4570, 'Marchin', 1);/*1*/
insert into Regions (Code_Postal, Ville, Pays) values (4500, 'Huy', 1);/*2*/
insert into Regions (Code_Postal, Ville, Pays) values (4577, 'Modave', 1);/*3*/

/*____________________USERS____________________*/
set identity_insert Users on;
insert into Users (Id, [Role], MethodeDeConnexion) values (1, 0, 0); /*utilisateur "système"*/
set identity_insert Users off;
insert into Users (Inscription, [Role], MethodeDeConnexion, [Login]) 
values (getdate(), 1, 1, 'login2'); /*2*/
insert into Users (Inscription, [Role], MethodeDeConnexion, [Login]) 
values (getdate(), 1, 1, 'login3'); /*3*/
insert into Users (Inscription, [Role], MethodeDeConnexion, [Login]) 
values (getdate(), 1, 1, 'login4'); /*4*/
insert into Users (Inscription, [Role], MethodeDeConnexion, [Login]) 
values (getdate(), 1, 1, 'login5'); /*5*/

/*____________________REGIONS_USERS____________________*/
insert into Regions_Users (UserId, RegionId, frais, est_pro) values (2, 1, 0, 0);
insert into Regions_Users (UserId, RegionId, frais, est_pro) values (2, 2, 5, 0);
insert into Regions_Users (UserId, RegionId, frais, est_pro) values (2, 3, 5, 0);
insert into Regions_Users (UserId, RegionId, frais, est_pro) values (3, 3, 0, 1);
insert into Regions_Users (UserId, RegionId, frais, est_pro) values (3, 2, 0, 1);
insert into Regions_Users (UserId, RegionId, frais, est_pro) values (4, 1, 0, 1);
insert into Regions_Users (UserId, RegionId, frais, est_pro) values (4, 2, 0, 1);
insert into Regions_Users (UserId, RegionId, frais, est_pro) values (5, 2, 0, 2);

/*____________________PERSONNES____________________*/
insert into Personnes (UserId, Nom, Prenom, Ddn) values (2, 'deux', 'deux', getdate()); /*1*/
insert into Personnes (UserId, Nom, Prenom, Ddn) values (3, 'trois', 'trois', getdate()); /*2*/
insert into Personnes (UserId, Nom, Prenom, Ddn) values (5, 'cinq', 'cinq', getdate()); /*3*/
/*____________________PRO____________________*/
insert into Pro (UserId, Nom) values (3, 'troisPro'); /*1*/
insert into Pro (UserId, Nom) values (4, 'quatrePro'); /*2*/
/*____________________CONTACTS____________________*/
insert into Contacts (EstPro, UserId, [Type], Valeur) values (0, 2, 1, 'nan22222anna'); /*1*/
insert into Contacts (EstPro, UserId, [Type], Valeur) values (1, 3, 1, 'nanav33333rzrgvzPROnna'); /*2*/
insert into Contacts (EstPro, UserId, [Type], Valeur) values (0, 3, 2, 'na3333navcrzrnna'); /*3*/
insert into Contacts (EstPro, UserId, [Type], Valeur) values (1, 4, 2, 'nanavc44444rzPROrnna');/*4*/
insert into Contacts (EstPro, UserId, [Type], Valeur) values (0, 5, 2, 'nanav555crzrnna');/*5*/

/*____________________CONVERSATION____________________*/
/*____________________CONVERSATION_USER____________________*/
/*____________________MESSAGES____________________*/

/*____________________CATEGORIES____________________*/
set identity_insert Categories on;
insert into Categories (Id, Nom) values (1, 'Général');
insert into Categories (Id, Nom, Categorie_Parent) values (2, 'Garderie', 1);
insert into Categories (Id, Nom, Categorie_Parent) values (3, 'Travaux', 1);
insert into Categories (Id, Nom, Categorie_Parent) values (4, 'Entretien', 1);
insert into Categories (Id, Nom, Categorie_Parent) values (5, 'Dépannage d''urgence', 1);
insert into Categories (Id, Nom, Categorie_Parent) values (6, 'Déplacements', 1);
insert into Categories (Id, Nom, Categorie_Parent) values (7, 'Mécanique', 1);
set identity_insert Categories off;
insert into Categories (Nom, Categorie_Parent) values ('Garderie d''enfants', 2); /*8*/
insert into Categories (Nom, Categorie_Parent) values ('Garderie d''animaux', 2); /*9*/
insert into Categories (Nom, Categorie_Parent) values ('Garde-malade', 2); /*10*/
insert into Categories (Nom, Categorie_Parent) values ('Plomberie', 3); /*11*/
insert into Categories (Nom, Categorie_Parent) values ('Électricité', 3); /*12*/
insert into Categories (Nom, Categorie_Parent) values ('Menuiserie', 3); /*13*/
insert into Categories (Nom, Categorie_Parent) values ('Extérieur', 3); /*14*/
insert into Categories (Nom, Categorie_Parent) values ('Nettoyage régulier', 4); /*15*/
insert into Categories (Nom, Categorie_Parent) values ('Soutien pour grand nettoyage', 4); /*16*/
insert into Categories (Nom, Categorie_Parent) values ('Fuite d''eau', 5); /*17*/
insert into Categories (Nom, Categorie_Parent) values ('Coupure d''électricité', 5);/*18*/
insert into Categories (Nom, Categorie_Parent) values ('Nid aggressif', 5); /*19*/
insert into Categories (Nom, Categorie_Parent) values ('Animal en péril', 5); /*20*/
insert into Categories (Nom, Categorie_Parent) values ('Animal coincé', 5); /*21*/
insert into Categories (Nom, Categorie_Parent) values ('Déménagement', 6); /*22*/
insert into Categories (Nom, Categorie_Parent) values ('Faire les courses', 6); /*23*/
insert into Categories (Nom, Categorie_Parent) values ('Aller à un rendez-vous médical', 6);/*24*/
insert into Categories (Nom, Categorie_Parent) values ('Chauffeur', 6); /*25*/
insert into Categories (Nom, Categorie_Parent) values ('Nettoyage du véhicule', 7);/*26*/
insert into Categories (Nom, Categorie_Parent) values ('Changer pneus', 7);/*27*/

/*____________________SERVICES____________________*/
/*demandés*/
insert into [Services] (EstDemande, CategorieId, UserId, RegionId, Pourquoi) values (1, 8, 5, 1, 'vzqgvzet');/*1*/

/*proposes*/

/*____________________PRESTATIONS____________________*/
/*____________________EVALUATIONS____________________*/