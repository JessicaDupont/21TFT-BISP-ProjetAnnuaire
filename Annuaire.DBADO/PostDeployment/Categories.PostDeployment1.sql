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
set identity_insert Categories on;

insert into Categories (Id, Nom) values (1, 'Général');
insert into Categories (Id, Nom, Categorie_Parent) values (2, 'Garderie', 1);
insert into Categories (Id, Nom, Categorie_Parent) values (3, 'Travaux', 1);
insert into Categories (Id, Nom, Categorie_Parent) values (4, 'Entretien', 1);
insert into Categories (Id, Nom, Categorie_Parent) values (5, 'Dépannage d''urgence', 1);
insert into Categories (Id, Nom, Categorie_Parent) values (6, 'Déplacements', 1);
insert into Categories (Id, Nom, Categorie_Parent) values (7, 'Mécanique', 1);

set identity_insert Categories off;

insert into Categories (Nom, Categorie_Parent) values ('Garderie d''enfants', 2);
insert into Categories (Nom, Categorie_Parent) values ('Garderie d''animaux', 2);
insert into Categories (Nom, Categorie_Parent) values ('Garde-malade', 2);

insert into Categories (Nom, Categorie_Parent) values ('Plomberie', 3);
insert into Categories (Nom, Categorie_Parent) values ('Électricité', 3);
insert into Categories (Nom, Categorie_Parent) values ('Menuiserie', 3);
insert into Categories (Nom, Categorie_Parent) values ('Extérieur', 3);

insert into Categories (Nom, Categorie_Parent) values ('Nettoyage régulier', 4);
insert into Categories (Nom, Categorie_Parent) values ('Soutien pour grand nettoyage', 4);

insert into Categories (Nom, Categorie_Parent) values ('Fuite d''eau', 5);
insert into Categories (Nom, Categorie_Parent) values ('Coupure d''électricité', 5);
insert into Categories (Nom, Categorie_Parent) values ('Nid aggressif', 5);
insert into Categories (Nom, Categorie_Parent) values ('Animal en péril', 5);
insert into Categories (Nom, Categorie_Parent) values ('Animal coincé', 5);

insert into Categories (Nom, Categorie_Parent) values ('Déménagement', 6);
insert into Categories (Nom, Categorie_Parent) values ('Faire les courses', 6);
insert into Categories (Nom, Categorie_Parent) values ('Aller à un rendez-vous médical', 6);
insert into Categories (Nom, Categorie_Parent) values ('Chauffeur', 6);

insert into Categories (Nom, Categorie_Parent) values ('Nettoyage du véhicule', 7);
insert into Categories (Nom, Categorie_Parent) values ('Changer pneus', 7);