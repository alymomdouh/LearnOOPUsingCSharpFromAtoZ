namespace csharpcornerExamples
{
    public class CarStatic
    {
        static CarStatic()
        {
            System.Console.WriteLine(@"Lamborghini is the best sports car owned by Audi AG 1998 (its static info)");
        }
        public static void Drive()
        {
            System.Console.WriteLine("Audi is the stable company");
        }
        ~CarStatic()
        {
            // Destructor
        }
    }
}
