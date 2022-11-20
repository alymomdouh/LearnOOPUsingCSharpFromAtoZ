namespace csharpcornerExamples
{
    public class BikeColor
    {
        private string MyBikeColor;

        public BikeColor(string MyBikeColor)
        {
            this.MyBikeColor = MyBikeColor;
        }
        public string _MyBikeColor
        {
            get { return this.MyBikeColor; }
            set { this.MyBikeColor = value; }
        }
        ~BikeColor()
        {
            // Destructor
        }
    }
}
