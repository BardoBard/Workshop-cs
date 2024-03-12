namespace Generics
{
    class Program
    {
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

        /// <summary>
        /// De main functie
        /// </summary>
        static void Main()
        {
            Paar<int> paar = new Paar<int>(5, 10);
            Console.WriteLine(paar.Eerste); // 5
            Console.WriteLine(paar.Tweede); // 10

            Paar<string> paar2 = new Paar<string>("a", "b");
            Console.WriteLine(paar2.Eerste); // "a"
            Console.WriteLine(paar2.Tweede); // "b"

            // Een paar van paren
            Paar<Paar<int>> nestedPaar = new Paar<Paar<int>>(
                new Paar<int>(5, 10),
                new Paar<int>(15, 20));
            
            Console.WriteLine(nestedPaar.Eerste.Eerste); // 5
            Console.WriteLine(nestedPaar.Eerste.Tweede); // 10
            Console.WriteLine(nestedPaar.Tweede.Eerste); // 15
            Console.WriteLine(nestedPaar.Tweede.Tweede); // 20
        }
    }
}