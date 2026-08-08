# Návrh architektury hry

## 1. Hráč

### `class Player`

Hráč je objekt obsahující objekty s hráčem úzce související. Hráč je může získávat, používat a zobrazovat.

Například:
- dobírací balíček karet
- lístky
- žetony

---

## 2. Balíčky karet

Všechny balíčky budou postaveny nad rozhraním `Card`.

### 2.1 Dobírací balíček

#### `DrawDeck`

##### Struktura

- seznam karet (`List`)

##### Počáteční stav

- Na začátku je seznam zamíchaný.
- Obsahuje startovní deck.
- Postupně se do něj přidávají koupené karty.

##### Chování

- Funkce dobírání karet je kontrolována vedlejším algoritmem, který musí líznutí vždy povolit.
- Kontroluje se, zda v balíčku nedošly karty.
- Pokud karty dojdou, použije se funkce zamíchání odhazovacího balíčku.

##### Zobrazení balíčku

Hráč má možnost se do balíčku podívat v rámci vedlejší akce odstranění karty.

Při zobrazení se však karty jeví jako promíchané, aby hráč neměl možnost zjistit, které karty mu přijdou do ruky v budoucnu.

Zobrazení nesmí změnit původní stav balíčku, s výjimkou odstranění karty.

---

### 2.2 Odhazovací balíček

#### `TrashDeck`

##### Struktura

- množina (`Set`) karet

##### Důvod použití množiny

Na pořadí karet nezáleží.

##### Chování

- Hráč se do tohoto balíčku může kdykoli podívat.
- Hráč může kartu z balíčku odstranit.

---

### 2.3 Karty v ruce

##### Struktura

- množina (`Set`) karet

##### Důvod použití množiny

Na pořadí karet nezáleží.

##### Chování

- Hráč má karty kdykoli k dispozici.
- Hráč je může libovolně používat na začátku svého tahu.

---

### 2.4 Karty odstraněné ze hry

Karty odstraněné ze hry nebudou představovány jako balíček.

Po odstranění jsou ze hry navždy odstraněny.

---

## 3. Přihrádky pro použité karty

### Struktura

- listy v listu
- maximálně 4 listy, odpovídající 4 tahům

### Další informace

- Vedlejší množina informací o svrchních kartách (konvičky).

---

## 4. Čajové lístky

### Struktura

- 6 škatulek
- v každé škatulce jsou dvě proměnné:
  - fermentované
    - nefermentované
### Poznámka

Jednotlivé lístečky nebudou jinak definované, protože na jejich celkovém počtu ve hře nezáleží.