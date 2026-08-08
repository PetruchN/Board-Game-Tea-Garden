# Objektový návrh hry

> Tento dokument slouží jako pracovní dokumentace objektového návrhu hry.
>
> Cílem není pouze popsat výslednou architekturu, ale také zaznamenávat důležitá návrhová rozhodnutí, jejich důvody a změny během vývoje.

---

# 1. Přehled architektury

## 1.1 Hlavní objekty

Seznam hlavních objektů, které se ve hře nacházejí:

- `Game`
- `Player`
- `Card`
- `Board`
- ...

> Zde zatím pouze seznam objektů. Podrobnější popis bude u jednotlivých objektů níže.

---

## 1.2 Vztahy mezi hlavními objekty

Zde popsat, jaké objekty obsahují nebo používají jiné objekty.

```text
Game
├── Player
├── Board
└── ...

Player
├── ...
└── ...
```

> Diagram průběžně aktualizovat při změnách architektury.

---

# 2. Objekty

## 2.1 `<Název objektu>`

### Účel objektu

> Co tento objekt reprezentuje?
>
> Proč v systému existuje?

---

### Struktura

> Jaká data objekt obsahuje?

| Název | Typ | Význam |
|---|---|---|
| `...` | `...` | ... |
| `...` | `...` | ... |

---

### Vztahy

> S jakými dalšími objekty tento objekt souvisí?

```text
<Název objektu>
├── ...
├── ...
└── ...
```

---

### Odpovědnosti

> Co má tento objekt na starosti?
>
> Co by měl objekt umět nebo zajišťovat?

- ...
- ...
- ...

---

### Pravidla související s objektem

> Jaká pravidla hry se tohoto objektu týkají?

- ...
- ...
- ...

> Tato část popisuje **pravidla hry**, nikoliv způsob jejich naprogramování.

---

### Návrhová rozhodnutí

> Zde zaznamenávat rozhodnutí, u kterých existovalo více možností.

#### `<Název rozhodnutí>`

**Problém:**

> Jaký problém bylo potřeba vyřešit?

**Možná řešení:**

- ...
- ...
- ...

**Zvolené řešení:**

> ...

**Důvod:**

> Proč bylo zvoleno právě toto řešení?

**Důsledky:**

> Co toto rozhodnutí znamená pro zbytek návrhu?

---

### Implementační poznámky

> Zde zapisovat konkrétní myšlenky týkající se budoucí implementace v C#.

- ...
- ...
- ...

> Tato část nemusí být definitivní. Implementace se může během programování změnit.

---

# 3. Herní akce

## 3.1 Hlavní akce

> Seznam a popis hlavních akcí, které může hráč provést.

### `<Název akce>`

**Účel:**

> ...

**Co akce způsobí:**

> ...

**Objekty zapojené do akce:**

- ...
- ...

**Pravidla:**

- ...
- ...

**Implementační poznámky:**

- ...
- ...

---

## 3.2 Vedlejší akce

> Seznam a popis vedlejších akcí.

### `<Název akce>`

**Účel:**

> ...

**Co akce způsobí:**

> ...

**Objekty zapojené do akce:**

- ...
- ...

**Pravidla:**

- ...
- ...

**Implementační poznámky:**

- ...
- ...

---

# 4. Herní stav

> Zde popsat informace, které určují aktuální stav hry.

## 4.1 Stav celé hry

- ...
- ...
- ...

## 4.2 Stav hráče

- ...
- ...
- ...

## 4.3 Stav jednotlivých objektů

- ...
- ...
- ...

---

# 5. Herní pravidla

> Pravidla hry, která mají vliv na návrh objektů.

## 5.1 `<Název pravidla>`

**Pravidlo:**

> ...

**Objekty, kterých se týká:**

- ...
- ...

**Důsledek pro návrh:**

> ...

---

# 6. Datové struktury

> Zde zaznamenávat rozhodnutí týkající se reprezentace herních dat.

| Data | Použitá struktura | Důvod |
|---|---|---|
| ... | `List<...>` | ... |
| ... | `HashSet<...>` | ... |
| ... | `Dictionary<...>` | ... |

---

# 7. Návrhová rozhodnutí

> Centrální seznam důležitých rozhodnutí, která ovlivnila architekturu.

## D001 – `<Název rozhodnutí>`

**Problém:**

> ...

**Původní návrh:**

> ...

**Možné alternativy:**

- ...
- ...

**Zvolené řešení:**

> ...

**Důvod:**

> ...

**Výsledek:**

> ...

---

# 8. Změny návrhu

> Zde zaznamenávat významné změny oproti předchozím verzím návrhu.

## Z001 – `<Název změny>`

**Původní návrh:**

> ...

**Problém původního návrhu:**

> ...

**Nový návrh:**

> ...

**Důvod změny:**

> ...

**Datum:**

> ...

---

# 9. Otázky a problémy k vyřešení

> Místa, u kterých ještě není rozhodnuto.

- [ ] ...
- [ ] ...
- [ ] ...

---

# 10. Implementace

> Tato část slouží jako spojení mezi objektovým návrhem a skutečnou implementací v C#.

## 10.1 Stav implementace

| Objekt | Návrh | Implementace | Poznámka |
|---|---|---|---|
| `...` | Hotový / Rozpracovaný | Hotová / Rozpracovaná | ... |
| `...` | ... | ... | ... |

---

## 10.2 Odlišnosti od návrhu

> Pokud se skutečná implementace liší od původního návrhu, zaznamenat zde proč.

### `<Objekt>`

**Původní návrh:**

> ...

**Skutečná implementace:**

> ...

**Důvod rozdílu:**

> ...

---

# 11. Poznámky k budoucímu vývoji

> Nápady a věci, které mohou být řešeny později.

- ...
- ...
- ...

---

# Pravidla pro práci s dokumentem

### 1. Neřešit implementaci příliš brzy

Nejdříve určit:

> **Co objekt reprezentuje a za co odpovídá?**

A až potom:

> **Jak to implementuji v C#?**

---

### 2. Oddělovat pravidla od implementace

**Pravidlo:**

> Hráč může udělat X.

**Návrh:**

> Objekt `X` je zodpovědný za ...

**Implementace:**

```csharp
public void X()
{
    // ...
}
```

---

### 3. Zaznamenávat důležitá rozhodnutí

Pokud existují dvě nebo více rozumných možností, zapsat:

```text
Problém
↓
Možná řešení
↓
Zvolené řešení
↓
Důvod
↓
Důsledek
```

---

### 4. Nemazat staré významné návrhy

Pokud je důležitý návrh později změněn, zaznamenat změnu v části **Změny návrhu**.

Cílem je zachovat nejen výslednou architekturu, ale také proces, kterým k ní návrh dospěl.

---

### 5. Ne všechno musí být třída

To, že se něco objevuje v pravidlech hry, ještě neznamená, že to musí být samostatná C# třída.

U každého kandidáta na objekt nejprve zvážit:

- Má vlastní stav?
- Má vlastní odpovědnosti?
- Má vlastní chování?
- Potřebují s ním pracovat jiné objekty?

Teprve potom rozhodnout, jak bude reprezentován.