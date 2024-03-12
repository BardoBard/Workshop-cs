namespace Reflection
{
    /// <summary>
    /// Dit is een random class
    /// </summary>
    class RandomClass
    {
        private int RandomVariable;
        
        public int RandomVariable2;
        
        private void IAmAPrivateFunction()
        {
            System.Console.WriteLine("I am a private function");
        }
        
        public void IAmAPublicFunction()
        {
            System.Console.WriteLine("I am a public function");
        }

        public RandomClass(int randomVariable, int randomVariable2)
        {
            this.RandomVariable = randomVariable;
            RandomVariable2 = randomVariable2;
        }
    }
    class Program
    {
        /// <summary>
        /// De main functie
        /// </summary>
        static void Main()
        {
            RandomClass h = new RandomClass(6, 7); // maak een nieuwe instantie van RandomClass
            
            // Haal de type van RandomClass op
            System.Type type = h.GetType();
            
            // Haal alle fields van RandomClass op
            var fields = type.GetFields(); // note: dit zijn alleen public fields
            
            // Print alle fields van RandomClass
            foreach (var fieldInfo in fields)
            {
                System.Console.WriteLine(fieldInfo.Name);
            }
            
            // Haal alle methods van RandomClass op
            var methods = type.GetMethods(); // note: dit zijn alleen public methods
            
            // Print alle methods van RandomClass
            foreach (var methodInfo in methods)
            {
                System.Console.WriteLine(methodInfo.Name);
            }
        }
    }
}

