# Generics

## Inhoudsopgave

- [Generics](#generics)
    - [Voorbeeld (functies)](#voorbeeld-functies)
        - [Unity voorbeeld](#unity-voorbeeld)
    - [Constraints](#constraints)
    - [Voorbeeld (klassen)](#voorbeeld-klassen)
    - [Diepere materie](#diepere-materie)

Generics is een manier om code te schrijven die werkt voor verschillende types. In plaats van een specifiek type te
gebruiken, kan je een generieke parameter gebruiken. Dit is handig als je een klasse of functie wil schrijven die werkt
voor verschillende types.

Dit kan ook voor problemen zorgen, omdat je minder informatie hebt over de types die je gebruikt. Dit kan leiden tot
bugs.

Eigenlijk weten we al wat generics zijn, een `std::vector<T>` in c++ en een `List<T>` in c# is een voorbeeld van een
generieke klasse.

## Voorbeeld (functies)

```csharp
/// <summary>
/// Haal een random element uit een array
/// </summary>
/// <param name="array"> De array waaruit je een random element wilt halen</param>
/// <typeparam name="T"> Het type van de array</typeparam>
/// <returns> Een random element uit de array</returns>
public static T GetRandom<T>(T[] array)
{
    Random random = new Random(); // Random is een klasse die random getallen genereert
    return array[random.Next(array.Length)]; // Next geeft een random getal tussen 0 en array.Length
}

int[] numbers = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine(GetRandom(numbers)); // voorbeeld output: 3

string[] words = new string[] { "a", "b", "c", "d", "e" };
Console.WriteLine(GetRandom(words)); // voorbeeld output: "c"
```

Dit is natuurlijk een heel simpel voorbeeld, maar het laat zien hoe je een generieke functie kan schrijven.

#### Unity voorbeeld

Dit is een voorbeeld uit de Unity engine, hier wordt een lijst geshuffeld, jullie hebben deze misschien al eens gebruikt
zonder er bij stil te staan.

```csharp
/// <summary>
/// Shuffle een lijst
/// </summary>
/// <param name="list"> De lijst die je wilt shufflen</param>
/// <typeparam name="T"> Het type van de lijst</typeparam>
public static void Shuffle<T>(this IList<T> list)
        {
            int count = list.Count;
            while (count > 1)
            {
                int index = Rand.Range(0, count--);
                (list[index], list[count]) = (list[count], list[index]);
            }
        }
```

### Constraints

Je kan constraints toevoegen aan generieke parameters. Dit zorgt ervoor dat je meer informatie hebt over de types. \
Bijvoorbeeld, je kan een constraint toevoegen dat de generieke parameter een klasse moet zijn.

```csharp
/// <summary>
/// Haal een random element uit een array
/// </summary>
/// <param name="array"> De array waaruit je een random element wilt halen</param>
/// <typeparam name="T"> Het type van de array, mag alleen een klasse zijn</typeparam>
/// <returns> Een random element uit de array</returns>
public static T GetRandom<T>(T[] array) where T : class
{
    Random random = new Random(); // Random is een klasse die random getallen genereert
    return array[random.Next(array.Length)]; // Next geeft een random getal tussen 0 en array.Length
}

int[] numbers = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine(GetRandom(numbers)); // compile error

string[] words = new string[] { "a", "b", "c", "d", "e" };
// dit is wel toegestaan omdat string een klasse is
Console.WriteLine(GetRandom(words)); // voorbeeld output: "c"
```

## Voorbeeld (klassen)

```csharp
/// <summary>
/// Een klasse die een paar waardes bijhoudt
/// </summary>
/// <typeparam name="T"> Het type van de waardes</typeparam>
public class Paar<T>
{
    public T Eerste { get; set; }
    public T Tweede { get; set; }

    public Paar(T eerste, T tweede)
    {
        Eerste = eerste;
        Tweede = tweede;
    }
}

Paar<int> paar = new Paar<int>(5, 10);
Console.WriteLine(paar.Eerste); // 5
Console.WriteLine(paar.Tweede); // 10

Paar<string> paar2 = new Paar<string>("a", "b");
Console.WriteLine(paar2.Eerste); // "a"
Console.WriteLine(paar2.Tweede); // "b"
```

## Diepere materie

Generics worden runtime opgelost. Eigenlijk wordt er voor elke type een nieuwe versie van de klasse of functie gemaakt,
dat is wel grappig om te weten. In c++ is dit meer een dingetje want daar worden compile time optimalisaties gedaan
waardoor het van belang is dat de templated code zichtbaar is.

## Volgende Stap

Ga door met [Linq](../Linq/README.md).