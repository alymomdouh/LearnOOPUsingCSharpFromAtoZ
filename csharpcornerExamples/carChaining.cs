namespace csharpcornerExamples
{
    public class carChaining
    {
        public string carname;
        public int model;
        public double engine;
        public carChaining(string _carname)
        {
            carname = _carname;
        }
        public carChaining(int _model) : this("lamborghini")
        {
            model = _model;
        }
        public carChaining(double _engine) : this(2013)
        {
            engine = _engine;
            Console.WriteLine("Model Year:{0}", model);
            Console.WriteLine("Maker Name:{0}", carname);
            Console.WriteLine("Engine Type:{0}", engine);
        }
        ~carChaining()
        {
            // Destructor
        }
    }
}
