# Linq (Language Integrated Query)

Linq is een extensie op c# die het mogelijk maakt om queries te schrijven op collecties (arrays, lists, etc) van data.
Linq is heel populair omdat het een hele hoop functionaliteit biedt en het schrijven van queries veel makkelijker maakt.

## Inhoudsopgave

- [Linq (Language Integrated Query)](#linq-language-integrated-query)
    - [Inhoudsopgave](#inhoudsopgave)
    - [Voorbeelden](#voorbeelden)
        - [Where](#where)
        - [Select](#select)
        - [First](#first)
        - [Any](#any)
    - [Query Syntax](#query-syntax)
    - [Conclusie](#conclusie)

## Voorbeelden

### Where

We beginnen met de `Where` functie. Deze functie filtert de elementen uit een lijst die voldoen aan een bepaalde
conditie.

```csharp
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// n gaat over alle elementen in numbers en n < 5 is de conditie
// n = 1
// n < 5 = true, dus 1 wordt toegevoegd aan de nieuwe lijst
// ...
// n = 7
// n < 5 = false, dus 7 wordt niet toegevoegd aan de nieuwe lijst
var kleinerDan5 = numbers.Where(n => n < 5).ToList(); // n => n < 5 is een lambda expression

kleinerDan5.ForEach(n => Console.WriteLine(n)); // 1 2 3 4
```

Een lambda expression is een manier om een functie mee te geven aan een andere functie. In dit geval is `n => n < 5` de
lambda expression. `n` is de parameter en `n < 5` is de body van de functie.

```csharp
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// n & 1 == 0 is een bitwise AND operator
// n = 1
// 0001 & 0001 = 0001, dus 1 is oneven
// ...
// n = 8
// 1000 & 0001 = 0000, dus 8 is even
var evenNumbers = numbers.Where(n => (n & 1) == 0).ToList();

evenNumbers.ForEach(n => Console.WriteLine(n)); // 2 4 6 8 10
```

#### Functie vs Lambda Expression

Het een paar [verschillen](https://stackoverflow.com/questions/40943117/local-function-vs-lambda-c-sharp-7-0) tussen een
functie en een lambda expression. Maar de belangrijkste is dat een functie een naam heeft en een lambda expression niet.

```csharp
/// <summary>
/// Deze functie kijkt of een getal even is
/// </summary>
bool IsEven(int n)
{
    return (n & 1) == 0;
}

int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// we geven de naam van de functie mee
var evenNumbers = numbers.Where(IsEven).ToList();

// hier geven we de lambda expression mee
evenNumbers.ForEach(n => Console.WriteLine(n)); // 2 4 6 8 10
```

### Select

Select is een functie die een transformatie uitvoert op alle elementen in een lijst.

```csharp
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// n gaat over alle elementen in numbers en n * 2 is de transformatie
// n = 1
// n * 2 = 2, dus 2 wordt toegevoegd aan de nieuwe lijst
// ...
// n = 10
// n * 2 = 20, dus 20 wordt toegevoegd aan de nieuwe lijst
var verdubbeld = numbers.Select(n => n * 2).ToList();

// method group syntax, we kunnen ook de naam van een functie meegeven
verdubbeld.ForEach(Console.WriteLine); // 2 4 6 8 10 12 14 16 18 20
```

### First

First is een functie die het eerste element uit een lijst pakt die voldoet aan een bepaalde conditie. \
Dit wordt ook wel een `predicate` genoemd, dat ga je veel voorbij zien komen op het gebied van programmeren.

```csharp
/// <summary>
/// Deze functie pakt het eerste element uit de lijst die even is
/// </summary>
/// <param name="numbers"> de lijst met getallen </param>
/// <returns> het eerste element dat even is </returns>
int EersteEvenGetal(int[] numbers)
{
    return numbers.First(n => (n & 1) == 0);
}

int[] numbers = new int[] { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };

Console.WriteLine(EersteEvenGetal(numbers)); // 2
```

### Any

Any is een functie die kijkt of er een element in een lijst zit die voldoet aan een bepaalde conditie.

```csharp
/// <summary>
/// Deze functie kijkt of er een even getal in de lijst zit
/// </summary>
/// <param name="numbers"> de lijst met getallen </param>
/// <returns> true als er een even getal in de lijst zit, anders false </returns>
bool HeeftEvenGetal(int[] numbers)
{
    return numbers.Any(n => (n & 1) == 0);
}

int[] numbers = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

Console.WriteLine(HeeftEvenGetal(numbers)); // false
```

Er zijn nog veel meer functies die je kan gebruiken in Linq. Hier zijn een paar voorbeelden:

- `All`
- `Average`
- `Count`
- `Distinct`
- `Max`
- `Min`
- `OrderBy`
- `Reverse`
- `Sum`

## Query Syntax

Naast de method syntax die we hierboven hebben gezien is er ook een query syntax. Dit is een meer SQL-achtige manier van
queries schrijven.

```csharp
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var kleinerDan5 = from n in numbers
                  where n < 5
                  select n;

kleinerDan5.ToList().ForEach(n => Console.WriteLine(n)); // 1 2 3 4
```

```csharp
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var verdubbeld = from n in numbers
                select n * 2;

verdubbeld.ToList().ForEach(Console.WriteLine); // 2 4 6 8 10 12 14 16 18 20
```

## Conclusie

Linq is een hele krachtige tool die het schrijven van queries veel makkelijker maakt.