# Databaser labb 3 - Dungeon Crawler improved.

Detta är en förbättrad version av Dungeon Crawler från Labb 2 i C#-kursen.

Fokus på denna labb var att med hjälp av MongoDB kunna spara val av karaktär och hur mycket den har utforskat på kartan, antal rundor, samt HP kvar & vilka fiender man har dödat.

Spelet använder arv & abstrakta klasser för att skapa element som väggar och fiender med olika rörelsemönster och beteende.
Spelaren har begränsat synfält och utforskar en karta inläst från en textfil och stöter på fiender som man kan slåss mot i tärningsbaserad strid.

Information om spelarens hälsa och strid syns i en textlogg under kartan.

Spelet styrs med piltangenter eller WASD.


<img width="440" height="299" alt="Skärmbild 2025-10-17 033343" src="https://github.com/user-attachments/assets/8c601ce7-cf0d-4327-b3bd-d18bfd6ccc81" />
<br><br>
<img width="506" height="182" alt="image" src="https://github.com/user-attachments/assets/0e58321c-aba7-4b6b-b477-760d15c04d24" />
<br><br>
<img width="239" height="123" alt="image" src="https://github.com/user-attachments/assets/eacca7d6-9ff6-42f6-89f3-6da226286071" />


## Krav

### Systemkrav
- .NET 6.0 eller högre
- MongoDB (lokal installation eller MongoDB Atlas)

### NuGet-paket
- `MongoDB.Driver` (version 2.x eller högre)

## Installation & Konfiguration

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
