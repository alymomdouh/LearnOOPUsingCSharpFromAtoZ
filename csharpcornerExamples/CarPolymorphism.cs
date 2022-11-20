namespace csharpcornerExamples
{
    public class CarPolymorphism
    {
        /*
         In this example, we have created three different functions with the same name (CarDetail) having a different set of parameters. 
          In the next topic I will discuss Polymorphism in more detail with its two types:
            1-Static Polymorphism
            2-Dynamic Polymorphism 
         */
        public void CarDetail()
        {
            Console.WriteLine("Car Toyota is available");
        }

        public void CarDetail(int priceRange)
        {
            Console.WriteLine("Car lamborghini is available its expensive car");
        }

        public void CarDetail(int priceRange, string colour)
        {
            Console.WriteLine("Car mercedes is available in white color");
        }
    }
}
