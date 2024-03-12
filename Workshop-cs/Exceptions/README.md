# Exceptions

Exceptions zijn heel cool, maar probeer niet voor elk klein dingetje een exception te gooien. Exceptions zijn bedoeld
voor wanneer je systeem echt door een onverwachte fout niet meer kan functioneren. Neem als voorbeeld als je geen
connectie kan maken met een database, dan is het logisch om een exception te gooien. Maar als je een bestand niet kan
vinden, dan is het beter om een boolean terug te geven.

## Inhoudsopgave

- [Exceptions](#exceptions)
    - [Basics](#basics)
        - [Throw](#throw)
        - [Try Catch](#try-catch)
        - [Finally](#finally)
    - [Custom Exceptions](#custom-exceptions)
    - [Exception Filters](#exception-filters)
    - [Inner Exception](#inner-exception)
    - [Conclusie](#conclusie)

## Basics

### Throw

Exceptions worden gegooid met het `throw` keyword. Dit kan je gebruiken om een foutmelding te geven.

```csharp
using System;
```

```csharp
void Divide(int a, int b)
{
    if (b == 0)
    {
        throw new Exception("Delen door 0 is niet toegestaan");
    }
    Console.WriteLine(a / b);
}

Divide(10, 0); // Exception: Delen door 0 is niet toegestaan
```

### Try Catch

Een try catch block is een manier om een exception te vangen. Dit is handig als er een fout kan optreden in je code.

```csharp
try
{
    Divide(10, 0); // THROW
}
catch (Exception e) // e is de exception die gegooid is
{
    Console.WriteLine(e.Message); // Delen door 0 is niet toegestaan
}
```

### Finally

Finally wordt altijd uitgevoerd, als er een exception is of niet. Dit kan handig zijn voor een database connectie die
altijd gesloten moet worden anders hou je een open connectie.

```csharp
try
{
    Database.Connect();
    // ...
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Database.Disconnect();
}
```

## Custom Exceptions

Je kan ook je eigen exceptions maken. Dit is handig als je een bepaalde foutmelding wilt geven.

```csharp
/// <summary>
/// Deze exception wordt gegooid als er gedeeld wordt door 0
/// </summary>
public class ZeroException : Exception
{
    public ZeroException(string message) : base(message)
    {
    }
}

void Divide(int a, int b)
{
    if (b == 0)
    {
        throw new ZeroException("Delen door 0 is niet toegestaan");
    }
    Console.WriteLine(a / b);
}

try
{
    Divide(10, 0); // THROW zero exception
}
catch (ZeroException e) // we vangen alleen ZeroExceptions op
{
    Console.WriteLine(e.Message); // Delen door 0 is niet toegestaan
}
```

Hier hebben we een custom exception gemaakt die we kunnen gebruiken in onze code. We kunnen deze exception specifiek
opvangen in een catch block. \
Belangrijk om van exceptions te erven. Dit zorgt ervoor dat we alle functionaliteit van een exception hebben. Ook wordt
de ZeroException opgevangen als een `Exception` gebruikt wordt in het catch block.

## Exception Filters

Je kan ook een exception filteren. Dit is handig als je een exception wilt opvangen die aan een bepaalde conditie
voldoet.

```csharp
try
{
    Divide(10, 0); // THROW
}
catch (Exception e) when (e.Message.Contains("0"))
{
    Console.WriteLine(e.Message); // Delen door 0 is niet toegestaan
}
```

## Inner Exception

Je kan ook een inner exception meegeven. Dit is handig als je een exception wilt gooien in een exception.

```csharp
try
{
    try
    {
        throw new Exception("Inner exception");
    }
    catch (Exception e)
    {
        throw new Exception("Outer exception", e);
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message); // Outer exception
    Console.WriteLine(e.InnerException?.Message); // Inner exception
}
```

## Conclusie

Exceptions zijn heel handig, maar gebruik ze met mate. Probeer niet voor elk klein dingetje een exception te gooien. \
Als je een exception gooit, zorg er dan voor dat je een duidelijke foutmelding geeft. Dit is handig voor de persoon die
de foutmelding moet oplossen.


## Volgende Stap

Ga door met [References](../References/README.md).