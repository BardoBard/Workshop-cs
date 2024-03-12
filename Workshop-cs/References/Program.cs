namespace References;

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
        this.RandomVariable = randomVariable;
    }
};

class Program
{
    /// <summary>
    /// Verander de waarde van een RandomClass instantie
    /// </summary>
    /// <param name="h">De RandomClass instantie</param>
    private static void ChangeFunction(RandomClass h)
    {
        h.RandomVariable = 10;
    }

    /// <summary>
    /// De main functie
    /// </summary>
    static void Main()
    {
        RandomClass h = new RandomClass(6); // maak een nieuwe instantie van RandomClass
        ChangeFunction(h); // dit veranderd de waarde van h.randomVariable naar 10 
        Console.WriteLine(h.RandomVariable); // 10
    }
}