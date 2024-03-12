# References

## Inhoudsopgave

- [Inleiding](#inleiding)
- [Datatypes](#datatypes)
  - [Primative vs complex datatypes](#primative-vs-complex-datatypes)
- [Functies](#functies)
  - [Ref en out](#ref-en-out)
- [Strings](#strings)
- [Diepere materie](#diepere-materie)
- [Conclusie](#conclusie)

## Inleiding

Wanneer we het hebben over `references` in c++, dan hebben we het over een variabele die refereert naar een andere
variabele. Dit betekent dat de twee variablen hetzelfde geheugenadres delen en dus hetzelfde zijn. In c++ kunnen we een
reference maken door een `&` te plaatsen achter de variabele die we willen refereren.

```c++
int a = 5;
int &b = a; // b is nu een reference naar a

b = 10; // a is nu ook 10

std::cout << a << std::endl; // 10
```

## Datatypes

In c# is een reference precies hetzelfde, alleen wordt dit impliciet (voor complex datatypes) gedaan. Dit betekent
dat we geen `&` hoeven te schrijven.

```csharp
// primative datatype (int)
int a = 5;
int b = a; // b is nu een copy van a

b = 10; // a is nog steeds 5

Console.WriteLine(a); // 5
```

Je kan zien dat voor `primative datatypes` in c# de waarde wordt gecopieerd.

### Primative vs complex datatypes

We kennen een aantal `primative datatypes`:

- int, float, double, char, bool, byte, sbyte, short, ushort, uint, long, ulong.

Voor `complex datatypes` wordt een referentie gemaakt. We kennen een aantal `complex datatypes`:

- object, array, class.

```csharp
// complex datatype (array)
int[] a = new int[] { 1, 2, 3 };
int[] b = a; // b is nu een reference naar a

b[0] = 10; // a[0] is nu ook 10

Console.WriteLine(a[0]); // 10
```

## Functies

Functies werken precies hetzelfde als variabelen. Wanneer een variable meegegeven wordt aan een functie zal deze een
kopie of referentie zijn.

```csharp
/// <summary>
/// Deze functie veranderd de waarde van a niet omdat het een primative datatype is
/// </summary>
/// <param name="a"> copy van originele variable </param>
void ChangeValue(int a)
{
    a = 10;
}

/// <summary>
/// Deze functie veranderd de waarde van a wel omdat het een complex datatype is
/// </summary>
/// <param name="a"> de referentie naar a </param>
void ChangeValue(int[] a)
{
    a[0] = 10;
}

int a = 5;
ChangeValue(a);
Console.WriteLine(a); // 5

int[] b = new int[] { 1, 2, 3 };
ChangeValue(b);
Console.WriteLine(b[0]); // 10
```

### Ref en out

In c# kunnen we ook expliciet aangeven dat we een referentie willen meegeven aan een functie. Dit doen we met het `ref`
keyword.

```csharp
/// <summary>
/// Deze functie veranderd de waarde van a wel omdat we dit expliciet aangeven
/// </summary>
/// <param name="a"> de referentie naar a </param>
void ChangeValue(ref int a)
{
    a = 10;
}

int a = 5;
ChangeValue(ref a);
Console.WriteLine(a); // 10
```

Het `out` keyword werkt hetzelfde, alleen hoeft de variabele niet geinitialiseerd te zijn.

```csharp
/// <summary>
/// Deze functie veranderd de waarde van a wel omdat we dit expliciet aangeven
/// </summary>
/// <param name="a"> de referentie naar a </param>
void ChangeValue(out int a)
{
    a = 10;
}

int a; // a hoeft niet geinitialiseerd te zijn
ChangeValue(out a);
Console.WriteLine(a); // 10
```

## Strings

Strings zijn een beetje een uitzondering. Strings zijn namelijk complex
datatypes, maar worden wel gecopieerd. Hier zit wel een [reden](https://stackoverflow.com/a/54807876/22090072) achter,
dat is dat strings immutable zijn.

```csharp
string a = "Hello";
string b = a; // b is nu een reference naar a

b = "World"; // a is nog steeds "Hello"

Console.WriteLine(a); // Hello
```

## Diepere materie

Uiteindelijk is het zo dat references immutabel zijn. Dit betekent dat we de referentie niet kunnen veranderen, maar wel
de waarde van de referentie. Dit is een belangrijk concept in c# en c++.

```csharp
int[] a = new int[] { 1, 2, 3 };
int[] b = a; // b is nu een reference naar a

// b point nu naar een nieuwe array, maar a blijft naar de oude array wijzen
b = new int[] { 4, 5, 6 }; // a is nog steeds { 1, 2, 3 }

Console.WriteLine(a[0]); // 1
```

Dit is uiteindelijk ook de reden waarom strings gecopieerd worden. Omdat strings immutable zijn. \
Als je het dit wel wilt doen moet je `ref` gebruiken.

```csharp
/// <summary>
/// Deze functie veranderd de waarde van a wel omdat we dit expliciet aangeven
/// </summary>
/// <param name="a"> de referentie naar a </param>
void ChangeValue(ref int[] a)
{
    a = new int[] { 4, 5, 6 };
}

int[] a = new int[] { 1, 2, 3 };
ChangeValue(ref a);
Console.WriteLine(a[0]); // 4
```

## Conclusie

In c++ moeten we expliciet aangeven dat we een referentie willen maken, terwijwijl dit in c# impliciet gebeurd. Dit is
een belangrijk concept om te begrijpen, omdat het veel invloed heeft op hoe je code werkt. Het is belangrijk om te weten
wanneer je een referentie maakt en wanneer je een kopie maakt. Dit kan namelijk veel invloed hebben op de performance
van je code.