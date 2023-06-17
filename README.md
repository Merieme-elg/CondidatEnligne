# un portail web pour recevoir les candidatures en ligne

## Description du projet
La structure globale contiendra deux espaces :
  --> Espace public permettant aux candidats de postuler à une offre en trois étapes :
    1. Remplissez les informations du candidat sur un formulaire (Nom, Prénom, Mail, Téléphone, Niveau d’étude, Nombre d’années d’expérience, Dernier employeur)
    2. Uploader le cv du candidat (PDF ou IMG) : les CVs sont mis dans un répertoire "CV" avec des sous répertoires "nom_prénom" du candidat.
    3. Afficher un message de confirmation.
  
  --> Espace admin pour gérer les candidats 
    1. Une page de connexion pour accéder à l'espace admin (login, mot de passe)
    2. Une page pour afficher toutes les applications sous forme de tableau avec les fonctions 
       Une recherche multi critères (Nom, prénom, email).
       Ajouter un bouton pour supprimer une candidature.

  --> Spécifications techniques.
 Frontend : HTML / CSS / JQUERY.
 Backend : ASP.NET CORE MVC 
 BDD : SQL SERVER (ENTITY FRAMEORK Code First)

## Architecture et structure du projet:
Le projet utilise l'architecture MVC (Modèle-Vue-Contrôleur) pour organiser le code et séparer les préoccupations. Voici une brève description de chaque composant de l'architecture :

------------------------------------------------------------Modèles (Models)--------------------------------------------------------------
Les modèles représentent les données de l'application et les règles métier associées. Ils sont responsables de l'accès aux données et de la validation des entrées. Les modèles sont généralement représentés par des classes qui encapsulent les propriétés et les méthodes associées.

Le dossier Models contient les définitions des modèles utilisés dans le projet, tels que Candidat.cs et Admin.cs.

------------------------------------------------------------------Vues (Views)---------------------------------------------------------------
Les vues sont responsables de l'interface utilisateur de l'application. Elles fournissent la présentation des données et interagissent avec les utilisateurs. Dans ce projet, les vues sont généralement représentées par des fichiers .cshtml qui contiennent du code HTML avec des éléments dynamiques.

Le dossier Views contient les fichiers .cshtml associés à chaque action du contrôleur, nous avons 4 dossiers dans  les Vues, une pour representer les fonctions d'admin l'autre pour le condidat.

----------------------------------------------------------Contrôleurs (Controllers)----------------------------------------------------------
Les contrôleurs gèrent la logique de l'application et agissent comme une interface entre les vues et les modèles. Ils sont responsables de la manipulation des requêtes HTTP, de l'appel des services nécessaires et de la gestion des actions de l'utilisateur. Les contrôleurs sont généralement représentés par des classes qui héritent de la classe Controller.

Le dossier Controllers contient les classes de contrôleur pour différentes fonctionnalités, telles que AdminController.cs et CondidatController.cs.

----------------------------------------------------------Autres dossiers et fichiers----------------------------------------------------------
->Le dossier Views/Shared contient des vues partagées qui peuvent être utilisées par plusieurs contrôleurs ou vues.
Le fichier Program.cs contient la configuration initiale de l'application, y compris la configuration des services et du pipeline de requêtes.
Le fichier appsettings.json contient les paramètres de configuration de l'application, tels que les chaînes de connexion à la base de données.

## Guide d'utilisation :
pour se connecter comme administrateur :  
email :admin@example.com
password : admin123
