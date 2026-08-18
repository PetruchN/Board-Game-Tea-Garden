## 1. Karta Karavan

### `class Caravan`

##### Účel objektu

Je to základní objekt představující kartu karavany, který se využívá při stejnojmenné hlavní akci. Pamatuje si jaké má ceny a jaké má náležité odměny.

##### Struktura

Každá karavana má dvě části - tu na kterou je potřeba síla a tu na kterou čajové lístky a každá tato část má na výběr ze dvou možností (zda dá více nebo méně lístku nebo síly)
To tedy vytváří čtyři kombinace, kterými muže hráč karavanu provést.
Pod samotnou kartou karavany bude další objekt `class CaravanOption`, který bue obsahovat:
- počet potřebných normálních lístků
- počet fermentovaných lístků (je pouze u pokročilých modrých karavan, u základních žlutých je vždy null)
- minimální sílu
- maximalní sílu (může být i null)
- celkovou odměnu (množina bonusů)
Do každé karty karavan se tedy uloží seznam (Array) těchto čtyř objektů

##### Shrnutí struktury

- Array 4 objektů `class CaravanOption` se čtyřmi možnostmi použití karavany
- ID (značená pro karavany začíná písmenem K a poté dvojčíslí pořadí - KXX)
- Barva (žlutá/modrý - základní/pokročilá karavana) - slouží pro jednoduší připravování hry

---

## 2. Destička šálků

### `class CupTile`

##### Účel objektu

Základní objekt destičky šálků ve hře. Má si pamatovat jaký bonus v sobě má a jakou má barvu spoje vlevo a vpravo.

##### Struktura

- Bonus (vždy pouze jeden)
- Barva vlevo
- Barva vpravo
- ID (začíná písmenem T jako Tile a dvojčíslí - TXX)
Barvy budou pravděpodobny pod enumem `CupTileColor`

---

## 3. Bonus regionu

### `class RegionBonus`

##### Účel objektu

Slouží k uložení bonusů regionů v databázi hry, jelikož je ve hře omezených počet konkretních bonusů.

##### Struktura
- Co přinášejí (bonus)
- ID (BXX)