// In c# heb je geen reference symbool, alle non-primitive types zijn referentie types
// C# heeft wel pointers, maar deze worden vrijwel nooit gebruikt en zijn niet nodig voor de meeste applicaties
// C# heeft ook geen pass by reference, maar je kan wel een referentie van een variabele doorgeven

// primitive types zijn: int, float, double, char, bool, byte, sbyte, short, ushort, uint, long, ulong

/// <summary>
/// Een class die een int randomVariable bevat
/// </summary>
public class RandomClass
{
    /// <summary>
    /// Een random variabele
    /// </summary>
    public int RandomVariable;

    /// <summary>
    /// Maak een nieuwe instantie van RandomClass
    /// </summary>
    /// <param name="randomVariable">De random variabele</param>
    public RandomClass(int randomVariable)
    {
        sbyte
        this.RandomVariable = randomVariable;
    }
};

class Program
{
    /// <summary>
    /// Verander de waarde van een RandomClass instantie
    /// </summary>
    /// <param name="h">De RandomClass instantie</param>
    private static void changeFunction(RandomClass h)
    {
        h.RandomVariable = 10;
    }

    /// <summary>
    /// De main functie
    /// </summary>
    static void Main()
    {
        RandomClass h = new RandomClass(6); // maak een nieuwe instantie van RandomClass
        changeFunction(h); // dit veranderd de waarde van h.randomVariable naar 10 
        Console.WriteLine(h.RandomVariable); // 10
    }
}