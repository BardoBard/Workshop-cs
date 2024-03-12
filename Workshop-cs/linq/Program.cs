namespace linq;

class Program
{
    /// <summary>
    /// De main functie
    /// </summary>
    static void Main()
    {
        // Een array van integers
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        
        // Een IEnumerable van alle getallen die kleiner zijn dan 5
        var lowNums = numbers.Where(n => n < 5);
        
        // Print alle getallen die kleiner zijn dan 5
        lowNums.ToList().ForEach(Console.WriteLine); // 4 1 3 2 0
    }
}