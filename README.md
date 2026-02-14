#  Databaser Labb 3 - Dungeon Crawler Improved

> En förbättrad version av Dungeon Crawler från Labb 2 i C#-kursen, med MongoDB-integration.

[![.NET](https://img.shields.io/badge/.NET-6.0+-512BD4?style=flat&logo=dotnet)](https://dotnet.microsoft.com/)
[![MongoDB](https://img.shields.io/badge/MongoDB-2.x-47A248?style=flat&logo=mongodb&logoColor=white)](https://www.mongodb.com/)
[![C#](https://img.shields.io/badge/C%23-11.0-239120?style=flat&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)

##  Om projektet

Detta projekt är en konsolbaserad roguelike dungeon crawler där spelaren utforskar en labyrint & slåss mot fiender i tärningsbaserad strid.

###  Nytt i denna version

**MongoDB-integration** gör det möjligt att spara:
-  Vald karaktärsklass.
-  Utforskad karta och upptäckta väggar.
-  Antal spelade rundor (turn counter).
-  Nuvarande HP (Hälsa).
-  Fiende (position, HP, typ).

###  Huvudfunktioner

**Objektorienterad design:**
- Arv och abstrakta klasser för spelentiteter (`LevelElement` → `Enemy` → `Rat`/`Snake`)
- Polymorfism för olika fiendesbeteenden.
- Repository Pattern för databasoperationer.

**Gameplay-funktioner:**
-  **Begränsat synfält** - Utforska dungeon med en synradie på 5 rutor.
-  **Tärningsbaserad strid** - Combat med attack- och försvarstärningar.
-  **Kartutforskning** - Upptäckta väggar förblir synliga mellan sessioner.
-  **Fienderörelsemönster** - Råttor rör sig slumpmässigt, ormar drar sig tillbaka från spelaren.
-  **Spara & Fortsätt** - Spara med ESC.
-  **Gameplay-logg** - Se stridsutfall och information under kartan.

##  Skärmdumpar

<div align="center">

**Spelvy med synfält och fiender**

<img width="440" alt="Spelvy" src="https://github.com/user-attachments/assets/8c601ce7-cf0d-4327-b3bd-d18bfd6ccc81" />

**Huvudmeny med sparfunktioner**

<img width="506" alt="Huvudmeny" src="https://github.com/user-attachments/assets/0e58321c-aba7-4b6b-b477-760d15c04d24" />

**Klassval med färgkodning**

<img width="239" alt="Klassval" src="https://github.com/user-attachments/assets/eacca7d6-9ff6-42f6-89f3-6da226286071" />

</div>

##  Tekniska krav:

### Systemkrav
- **.NET 6.0** eller högre
- **MongoDB** (lokal installation eller MongoDB Atlas)

### NuGet-paket
- `MongoDB.Driver` (version 2.x eller högre)

## Installation & Konfiguration:

1. **Klona repositoryt**

2. **Installera MongoDB**
 - Ladda ner och installera [MongoDB Community Server](https://www.mongodb.com/try/download/community)
 - Eller använd [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) (molnversion)
 - Se till att MongoDB körs på `localhost:27017` (standard)

3. **Bygg och kör**

### Kontroller
- **WASD** eller **Piltangenter** - Flytta din karaktär
- **Mellanslag** - Stå kvar (hoppa över tur)
- **ESC** - Spara spelet och avsluta


Skapad av Charlie Carlegrund.
