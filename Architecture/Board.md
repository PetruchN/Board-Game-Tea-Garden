## Herní deska

### `class Board`

Herní deska je objekt obsahující všechny objekty, které se na ní ve hře nacházejí.

## 1. Balíček akčních karet

Vytvořený na začátku hry míchacím algoritmem pro akční karty (algoritmus není součástí objektu `Board`) - ze seznamu všech akčních karet se vezmou karty podle pravidel a balíček se připraví

##### Účel objektu

- Slouží jako dolízací balíček akčních karet do výběru pro jejich koupi a jako sám výběr

##### Struktura

- Jednoduchý seznam karet
- Pouze prvních šest karet bude k zobrazení (otočeny lícem nahoru), což reprezentuje výběr, ze kterého si v průběhu hry mohou hráči nakupovat. Zbytek seznamu bude v podstatě dolízavacím balíčkem

##### Odpovědnost

- Kontrolovat sebe sama zda ve výběru karty nechybí, tedy že prvních šest je vždy otočeno

##### Poznámka ke struktuře

- Takto nemusíme řešit jakékoli doplňovaní a otáčení karet, jelikož po koupi se karta ze seznamu odstraní a karty se automaticky "posunou"

---

## 2. Balíček císařských karet

- Funguje stejně jako balíček akčních karet, akorát se zobrazují karty pouze tři
- Příprava balíčku spočívá pouze v zamíchaní všech císařských karet, které ve hře jsou

## 3. Balíček karavan

- Znovu funguje stejně jako akční karty, ale zobrazují se pouze karty tři
- Také vytvořený na začátku hry svým algoritmem, který není součástí objektu `Board`

---

## 4. Hromádky destiček šálků

##### Účel objektu

- Slouží hráči jako výběr šálků při vedlejší akci šálků
- Jsou to v podstatě balíčky karet z jejichž vrchu se dá vzít jeden šálek

#####  Struktura

- 5 seznamů destiček šálků (právě jeden pro každou barvu polí zahrad, 5 barev polí 5 seznamů)
- První vždy k zobrazení

##### Odpovědnost

- Pamatovat si všechny destičky, co ve hře jsou, a hráči zobrazovat ty vrchní, aby si je mohl vybrat

##### Poznámka

- Hromádky se připraví svým vlastním vedlejším algoritmem

---

## 5. Pole čajových zahrad

##### Účel objektu

Pamatovat si všechny informace o všech polích zahrad na desce:
- Zda mají na poli hráči postaveny čajové zahrady
- Vlastněný bonus regionu přidělený na začátku hry
- Jeho barvu
- Jeho sousední pole
- Úroveň čajových lístků, které na ní rostou
- Kolik míst pro čajové zahrady má a zda neudělují body po postavení

##### Struktura

- Každé pole jako samostatný objekt, což znamená 16 objektů (polí), každy držící výše uvedené informace

##### Odpovědnost

- Slouží jako hlavní objekt pamatující si stav čajových zahrad

---

## 6. Čajová univerzita

##### Účel objektu

- Ukazatel kolikrát každý hráč provedl vedlejší akci univerzity
- Jaké bonusy každá část (úroveň) má

##### Struktura

- N proměnných pro N hráčů (jedna pro každého hráče)
- Čtyři objekty pro každou úroveň, ve které bude zakodováno jaké bonusy může přinést (hráč má na výběr mezi dvěmi)

##### Odpovědnost

- Pamatovat si kolik vedlejších akcí tohoto typu hráč udělal pro počítání bodů na konci hry
- Databáze bonusů pro průběžné přidělování daných bonusů

##### Poznámka

- Bonusy budou přidělovány separátní funkcí vedlejšího tahu, která není v tomto objektu zahrnuta

## 7. Řeka

##### Účel objektu

- Ukazatel kolikrát hráči provedli vedlejší akci řeky
- Jaké bonusy každý úsek řeky vlastní

##### Struktura

- Znovu N proměnných pro N hráčů
- Seznam všech bonusů, které řeka obsahuje (jedna položka seznamu jeden úsek řeky a jeho bonusy)

##### Odpovědnost

*Stejná jako u minulého objektu

---

## 8. Stupnice císaře

##### Účel objektu

- Ukazatel jak daleku na stupnici císaře hráč je
- Jakou cenu a jaké bonusy každý stupeň má

##### Struktura

- Znovu N proměnných pro N hráčů
- Seznam všech bonusů, co každá úroveň má + kdy má hráč možnost vzít si kartu císaře

##### Odpovědnost

*Opět stejná jako u objektu čajové univerzity

---

## 9. Počítadlo vítězných bodů

##### Účel objektu

- Záznamník bodů, které každý hráč přes celou hrů dostává

##### Struktura

- N proměnných pro N hráčů

## 10. Počítadlo kol

##### Účel objektu 

- Udržovat stav hry

##### Struktura

- Jedna proměnná