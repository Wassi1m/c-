-- SQLite
CREATE TABLE utilisateurs (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    nom TEXT NOT NULL,
    email TEXT NOT NULL UNIQUE
);

INSERT INTO utilisateurs (nom, email) VALUES ('Alice', 'alice@example.com');
INSERT INTO utilisateurs (nom, email) VALUES ('Bob', 'bob@example.com');
