# Návrh architektury hry

## 1. Hráč

### `class Player`

Hráč je objekt obsahující objekty s hráčem úzce související. Hráč může objekty získávat, používat a zobrazovat.

Například:
- dobírací balíček karet
- čajové lístky
- žetony
- atd.

---

## 2. Balíčky karet

Všechny balíčky budou postaveny nad rozhraním `Card`.

### 2.1 Dobírací balíček

#### `class DrawDeck`

##### Struktura

- seznam karet (`List`)

##### Počáteční stav

- Na začátku je seznam zamíchaný.
- Obsahuje startovní deck.
- Postupně se do něj přidávají koupené karty.

##### Chování

- Většina dobírání karet z balíčku bude provázena vedlejším algoritmem (na konci kola nebo bonusová akce líznutí karty) - hráč nebude mít možnost do balíčku nijak zasahovat. Jedinou výjimkou bude akce vyměnění si karty (zahození karty/karet z ruky a líznutí nové), kdy dostane hráč pouze možnost akci provést a algoritmus mu s balíčkem na chvíli dovolí manipulovat.
- Sám kontroluje, zda v něm nedošly karty.
- Pokud karty dojdou, použije se funkce zamíchání odhazovacího balíčku.

##### Zobrazení balíčku

Hráč má možnost se do balíčku podívat v rámci vedlejší akce odstranění karty.

Při zobrazení se však karty jeví jako promíchané, aby hráč neměl možnost zjistit, které karty mu přijdou do ruky v budoucnu.

Zobrazení nesmí změnit původní stav balíčku, s výjimkou odstranění karty.

---

### 2.2 Odhazovací balíček

#### `class TrashDeck`

##### Struktura

- množina (`Set`) karet

##### Důvod použití množiny

Na pořadí karet nezáleží.

##### Chování

- Hráč se do tohoto balíčku může kdykoli podívat.
- Hráč může kartu z balíčku odstranit v rámci vedlejší akce.

---

### 2.3 Karty v ruce

##### Struktura

- množina (`Set`) karet

##### Důvod použití množiny

Na pořadí karet nezáleží.

##### Chování

- Hráč má karty kdykoli k dispozici.
- Hráč je může libovolně používat na začátku svého tahu.
  
##### Poznámka

Po rozšíření uživatelského rozhraní bude lepší struktura seznamu (`List`) v případě zahrnutí možnosti hráče si karty v ruce přeházet pro lepší přehlednost.

---

### 2.4 Karty odstraněné ze hry

Karty odstraněné ze hry nebudou představovány jako balíček.

Po odstranění jsou z konkrétní hry navždy odstraněny.

---

## 3. Přihrádky pro použité karty

##### Struktura

- Seznamy karet použitých v daném tahu v seznamu všech tahů (`Listy v listu`)
- maximálně 4 listy, odpovídající 4 tahům

##### Další informace

- Vedlejší množina informací o svrchních kartách (konvičky).

---

## 4. Čajové lístky

##### Účel objektu

- Drží informaci o počtu fermentovaných a čerstvých čajových lístkách vypěstovaných hráčem.

##### Struktura

- 6 škatulek
- v každé škatulce jsou dvě proměnné:
  - fermentované
  - čerstvé
##### Poznámka

Jednotlivé lístečky nebudou jinak definované, protože na jejich celkovém počtu ve hře nezáleží.

---

## 5. Čajové zahrady

##### Účel objektu

- Reprezentuje seznam čajových zahrad, které si hráč ještě může postavit a s tím sílu, která je k postavení zapotřebí.

##### Struktura

- Jednoduchý True/False seznam s danou délkou (`Array`)

##### Odpovědnost

- Držet informaci, jaké čajové zahrady jsou stále k využití

##### Poznámka
Samotná čajová zahrada nebude samostatný objekt, pouze `bool` hodnota buď na desce hráče nebo na hracím plánu.

---

## 6. Dokončené karavany

##### Účel objektu

- Obsahuje všechny karavany, které hráč již ve hře provedl. Slouží pouze pro počítání bodů na konci (v rámci jedné císařské karty je možnost získat body na konci hry za počet dokončených karavan) a kdyby hráč potřeboval ze strategických důvodů vědět, co za karavany dokončil.

##### Struktura

- Jednoduchý seznam karavan

##### Poznámka

- Karavany jsou stejně jako karta samostatný objekt

---

## 7. Svitky a žetony

##### Účel objektu

- Pamatovat si, kolik a jaké žetony hráč vlastní a může využít jako volnou akci
- Kontrolovat, zda má hráč bonusy k dispozici

##### Struktura

- Čtyři proměnné (přirozená čísla) pro každý druh (Svitky x2, +1, konvička + žeton císaře)

##### Odpovědnost

- Když bude chtít hráč svitky/žetony použít, pouze se zkontroluje, zda konkrétní druh nechybí (tedy zda se proměnná nerovná 0), a když ne, tak se zavolá funkce dané volné akce a počet se zmenší o 1.

---

## 8. Vlastněné šálky

Tento objekt je postavený nad objektem šálku, který sám obsahuje všechny bonusy a barvy jeho krajů.

##### Účel objektu

Pamatuje si: 
  - jaké šálky ze stejnojmenné vedlejší akce hráč vlastní
  - jak jsou na sebe šálky napojené (včetně barev spoje)
  - zda leží na spoji žeton šálků, který při odebrání aktivuje bonusy jednoho z šálků, mezi kterými leží.

##### Struktura

- Jedna řada šálků bude reprezentována dvěma seznamy (seznam šálků a seznam spojení)
- Jelikož má hráč možnost udělat více řad, jednotlivé řady (2 seznamy) budou v ještě jednom seznamu
- List jedné nebo více dvojic listů

##### Odpovědnost

Musí držet informaci o celé řadě/řadách šálků, tedy:
  - jaké bonusy každý šálek má
  - všechny spoje a jejich barvy (tedy zda jsou stejnobarevné)
  - kde leží žetony šálků