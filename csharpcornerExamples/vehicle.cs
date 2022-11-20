namespace csharpcornerExamples
{
    public class vehicle
    {
        public vehicle()
        {
            Console.WriteLine("I am Vehicle");
        }
    }
    public class carInheritance : vehicle
    {
        public carInheritance()
        {
            Console.WriteLine("I am Car");
        }
    }

    public class truck : vehicle
    {
        public truck()
        {
            Console.WriteLine("I am truck");
        }
    }

    public class electric : carInheritance
    {
        public electric()
        {
            Console.WriteLine("I am electric car");
        }
    }

    public class petrol : carInheritance
    {
        public petrol()
        {
            Console.WriteLine("I am patrol car");
        }
    }

}
