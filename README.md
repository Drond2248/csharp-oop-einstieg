# ZooDB (WinForms + MySQL)

ZooDB ist ein Portfolio-/Lernprojekt zur Verwaltung eines Zoos mit **WinForms (C#)** und **MySQL**.  
Fokus: **CRUD**, saubere Datenmodellierung (IDs/FKs), UI-Logik, sowie Import/Export und Zustands-Synchronisation.

> Hinweis: Alle Daten sind Beispiel-/Testdaten. Kein Bezug zu einem realen Zoo.

---

## Features

- **Kontinente** verwalten (Anlegen/Ändern/Löschen)
- **Gehege** verwalten (inkl. Zuordnung zu Kontinenten)
- **Tierarten** verwalten
- **Tiere** verwalten (Name, Gewicht, Geburtsdatum, Tierart, Gehege)
- **Import/Export** für Tiere (XML)
  - Import als Vorschau (Preview) + bewusstes Übernehmen in die Datenbank
- UI-Synchronisation über Reload/Display-Trennung (DB → Liste → UI)

---

## Tech-Stack

- C# WinForms
- MySQL (lokal, z. B. XAMPP oder MySQL Server)
- Connector: `MySql.Data` (MySqlConnector)
- XML (Import/Export)

---

## Datenbank-Modell (Kurzüberblick)

- `Kontinent` (1) → (n) `Gehege`
- `Tierart` (1) → (n) `Tiere`
- `Gehege` (1) → (n) `Tiere`

---

## Projekt starten (lokal)

### 1) Voraussetzungen
- Visual Studio (oder Rider)
- .NET / WinForms (je nach Projekt: .NET Framework oder .NET)
- MySQL lokal (XAMPP oder MySQL Server)
- Zugriffsdaten in `Database.cs` korrekt gesetzt

### 2) Datenbank anlegen
1. MySQL starten
2. SQL-Script ausführen (falls im Repo enthalten)  
   z. B. `ZooDB.sql`

> Falls du kein SQL-Script im Repo hast: Erstelle die Tabellen entsprechend deiner Struktur (Kontinent, Gehege, Tierart, Tiere) inkl. Primär-/Fremdschlüssel.

### 3) Connection-String prüfen
In `Database.cs` (Beispiel):
```txt
"ConnectionString": "SERVER=localhost;UID=root;PASSWORD=DEINPASSWORT;DATABASE=ZooDB;"
