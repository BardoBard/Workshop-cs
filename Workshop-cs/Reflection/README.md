# Reflection

Reflection is een manier om informatie te krijgen over een object tijdens runtime. Dit kan handig zijn als je
bijvoorbeeld wilt weten welke properties een object heeft of welke methodes je kan aanroepen.

## Voorbeelden

```csharp
using System;
using System.Reflection;
```

```csharp
/// <summary>
/// Een klasse die een persoon voorstelt
/// </summary>
public class Persoon
{
    public string Naam { get; set; }
    public int Leeftijd { get; set; }

    public void ZegHallo()
    {
        Console.WriteLine(Naam + " zegt hallo!");
    }
}


Persoon p = new Persoon();
p.Naam = "Jan";
p.Leeftijd = 30;

Type type = p.GetType();
PropertyInfo[] properties = type.GetProperties();
foreach (PropertyInfo property in properties)
{
    Console.WriteLine(property.Name);
}

MethodInfo[] methods = type.GetMethods();
foreach (MethodInfo method in methods)
{
    Console.WriteLine(method.Name);
}
```

**Output:**

```text
Naam
Leeftijd
get_Naam
set_Naam
get_Leeftijd
set_Leeftijd
ZegHallo
GetType
ToString
Equals
GetHashCode
```

De `GetType` functie geeft een `Type` object terug. Dit object bevat informatie over de klasse `Persoon`. Met
de `GetProperties` en `GetMethods` functies kunnen we de properties en methodes van de klasse ophalen. \
De reder waarom we ToString, Equals en GetHashCode zien is omdat elke klasse in c# overerft van de `Object` klasse.

## Advanced

Je kan hier bijvoorbeeld een functie van maken die een property van een object aanpast.

```csharp
/// <summary>
/// Je kan een property van een object aanpassen met reflection
/// </summary>
public static void SetPropertyByName(object? obj, string? propertyName, object? value)
{
    obj?.GetType().GetProperty(propertyName ?? string.Empty)?.SetValue(obj, value, null);
}

Persoon p = new Persoon();
SetPropertyByName(p, "Naam", "Piet");
Console.WriteLine(p.Naam); // Piet
```