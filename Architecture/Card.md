## Karta

### `interface ICard`

Představuje jakoukoli hratelnou (použitelnou) kartu


##### Struktura

Každá karta má:
- sílu, kterou může zahrát
- nějaký identifikátor (ID)
- vedlejší akci nebo konvici (může bát i null + jich může být více - poté seznam bonusů)

##### Poznámka
Ve hře jsou tři druhy takových karet, které pod tento interface spadají:
- Akční
- Císařské
- Začátečnické

V průběhu hry se postupně přidávají akční a císařské do balíčku hráče

##### Poznámka k ID karet

ID se skláda ze tří částí:
- první znak říká, že jde o kartu (písmeno C)
- druhý o jaký druh jde (A (action) / I (imperial) / S (starter))
- třetí je dvojčíslí kolikáta karta daného druhu to je

Tedy např. ID: CA12 je 12. akční karta z 44 akčních karet ve hře

---

## 1. Akční karta

### `class ActionCard`

Implementuje interface `ICard`

##### Struktura

Obsahuje:
- sílu
- ID (CAXX)
- vedlejší akci a bonusy (většinou seznam všeho)
- Cenu
  - kolik lístků jaké minimální kvality (dvě přirozená čísla)
  - kolik a jak barevné konvice (jeden string pro jednu konvici - u pokročilejších karet je potřeba více konvicí různých barev - seznam stringů)
- Úroveň (1-5)

##### Poznámka ke konvicím

Barva konvicí bude uložena ve  jednopísmeném stringu (R/G/B/U - červená, zelená, modrá, universální).
Tedy seznam stringů bude např. B, B, U jako dvě modré a jedna jakákoli

---

## 2. Císařská karta

### `class ImperialCard`

Implementuje interface `Card`

##### Struktura

- síla
- ID (CIXX)
- vedlejší akce a bonusy (vždy seznam)
- ID bonusu císařské karty, ze kterého dostane hráč na konci hry body (je potřeba až na konci hry, tudíž není důvod, aby se funkce bonusu stále přenášela s kartou, je tedy jednoduší uložit pouze jako string, kterému se porozumí na konci hry)

---

## 3. Začátečnická karta

### `class StarterCard`

Reprezentuje všechny karty, co hráč dostává na začátku hry do svého lízacího balíčku

##### Struktura

- síla
- ID (CSXX)
- vedlejší akce nebo konvice
  
Má tedy pouze to co interface a nic víc.

