CREATE DATABASE Restaurant;
GO

USE Restaurant;
GO

-- Table Table (Restaurant Table)
CREATE TABLE TableRestaurant (
    id INTEGER PRIMARY KEY,
    nbplaces INTEGER NOT NULL
);

-- Table Poste
CREATE TABLE Poste (
    id INTEGER PRIMARY KEY,
    titre VARCHAR(30) NOT NULL
);

-- Table Employee
CREATE TABLE Employee (
    id INTEGER PRIMARY KEY,
    nom VARCHAR(30) NOT NULL,
    poste_id INTEGER,
    FOREIGN KEY (poste_id) REFERENCES Poste(id)
);

-- Table Client
CREATE TABLE Client (
    id INTEGER PRIMARY KEY,
    nom VARCHAR(30) NOT NULL,
    table_id INTEGER,
    FOREIGN KEY (table_id) REFERENCES TableRestaurant(id)
);

-- Table Recette
CREATE TABLE Recette (
    id INTEGER PRIMARY KEY,
    formule TEXT,
    category VARCHAR(20),
    nbrepersonne INTEGER,
    titre VARCHAR(30),
    preparation INTEGER,
    cuisson INTEGER,
    repos INTEGER
);

-- Table Ingredient
CREATE TABLE Ingredient (
    id INTEGER PRIMARY KEY,
    nom VARCHAR(30) NOT NULL,
    quantite INTEGER
);

-- Table RecetteIngredients (association entre Recette et Ingredient)
CREATE TABLE RecetteIngredients (
    id INTEGER PRIMARY KEY,
    recette_id INTEGER,
    ingredient_id INTEGER,
    FOREIGN KEY (recette_id) REFERENCES Recette(id),
    FOREIGN KEY (ingredient_id) REFERENCES Ingredient(id)
);

-- Table Materiel
CREATE TABLE Materiel (
    id INTEGER PRIMARY KEY,
    nom VARCHAR(30) NOT NULL,
    quantite INTEGER
);

-- Table MaterielRecette (association entre Materiel et Recette)
CREATE TABLE MaterielRecette (
    id INTEGER PRIMARY KEY,
    materiel_id INTEGER,
    recette_id INTEGER,
    FOREIGN KEY (materiel_id) REFERENCES Materiel(id),
    FOREIGN KEY (recette_id) REFERENCES Recette(id)
);

-- Table Nourriture
CREATE TABLE Nourriture (
    id INTEGER PRIMARY KEY,
    nom VARCHAR(30) NOT NULL,
    recette_id INTEGER,
    prix INTEGER NOT NULL,
    cuisinier_id INTEGER,
    FOREIGN KEY (recette_id) REFERENCES Recette(id),
    FOREIGN KEY (cuisinier_id) REFERENCES Employee(id)
);

-- Table Commande
CREATE TABLE Commande (
    id INTEGER PRIMARY KEY,
    client_id INTEGER NOT NULL,
    nourriture_id INTEGER NOT NULL,
    serveur_id INTEGER NOT NULL,
    etat BIT NOT NULL,
    FOREIGN KEY (client_id) REFERENCES Client(id),
    FOREIGN KEY (nourriture_id) REFERENCES Nourriture(id),
    FOREIGN KEY (serveur_id) REFERENCES Employee(id)
);

