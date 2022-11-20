namespace csharpcornerExamples
{
    public class Car2 // thats for Write only Property
    {
        private int model = -1;
        public int _model
        {
            set
            {
                model = value;
            }
        }
        private string maker = string.Empty;
        public string _maker
        {
            set
            {
                maker = value;
            }
        }
        public void DisplayCustomerData()
        {
            Console.WriteLine("Model: {0}", model);
            Console.WriteLine("Maker: {0}", maker);
        }
    }
}
