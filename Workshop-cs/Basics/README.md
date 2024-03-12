# Basics

## Inhoudsopgave

- [Basics](#basics)
    - [Const](#Const)
    - [Readonly](#readonly)
    - [Null](#null)
        - [Null Coalescing Operator](#null-coalescing-operator)
        - [Null Conditional Operator](#null-conditional-operator)
    - [Ternary Operator](#ternary-operator)
    - [Functies (this)](#functies-this)

## Const

Een const is een variabele die niet veranderd kan worden.

```csharp
const int a = 5;
a = 10; // dit geeft een compile error
```

## Readonly

Een readonly variabele kan alleen in de constructor veranderd worden.

```csharp
public class Persoon
{
    public readonly string Naam;

    public Persoon(string naam)
    {
        Naam = naam;
    }
}

Persoon p = new Persoon("Jan");
p.Naam = "Piet"; // dit geeft een compile error
```

## Null

Null is een waarde die aangeeft dat er geen waarde is. Dit kan handig zijn om aan te geven dat een waarde niet bestaat.

```csharp
int? a = null;

if (a == null)
{
    Console.WriteLine("a is null");
}

int b = 5;
int? c = 10;

//int d = a + b; // dit geeft een compile error
int? e = a + c; // dit is toegestaan

Console.WriteLine(a); // ""
Console.WriteLine(e); // ""
```

### Null Coalescing Operator

De null coalescing operator is een manier om een default waarde te geven aan een variabele als deze null is.

```csharp
int? a = null;
int b = a ?? 5; // als a null is, dan is b 5

Console.WriteLine(b); // 5
```

### Null Conditional Operator

De null conditional operator is een manier om te checken of een waarde null is.

```csharp
string? a = null;
int? b = a?.Length; // als a null is, dan is b ook null

string? c = "hello people";
int? d = c?.Length;

Console.WriteLine(b); // null
Console.WriteLine(d); // 12
```

## Ternary Operator

De ternary operator is een manier om een if else statement te schrijven in 1 regel. Dit maakt je code korter en
leesbaarder.

```csharp
int a = 5;
int b = 10;

int c = a > b 
    ? a 
    : b;
// if (a > b)
//     c = a;
// else
//     c = b;

Console.WriteLine(c); // 10
```

Eigenlijk is een ternary operator branchless code, met een if else statement wordt er een branch gemaakt in de code. Dit
kan ervoor zorgen dat de CPU niet optimaal gebruikt wordt. Maar dit is alleen relevant als je code heel HEEL vaak wordt
uitgevoerd. Daarnaast is de compiler heel slim en doet het vaak wel voor je.

## Functies (this)

Je kan functies toevoegen aan bestaande klassen. Dit kan handig zijn als je een bepaalde functionaliteit vaak nodig
hebt.

```csharp
public static class IntExtensions
{
    /// <summary>
    /// Deze functie verdubbeld de waarde van een integer
    /// </summary>
    /// <param name="i"> de integer die verdubbeld moet worden </param>
    /// <returns> de verdubbelde integer </returns>
    public static int Double(this int i)
    {
        return i * 2;
    }
}

int a = 5;
Console.WriteLine(a.Double()); // 10
```

Dit kan natuurlijk met alles, arrays, strings, classes, etc. Dit komt heel veel voor. Bijvoorbeeld in Linq, waar we het
later over gaan hebben.

## Volgende Stap

Ga verder naar [Exceptions](../Exceptions/README.md).
