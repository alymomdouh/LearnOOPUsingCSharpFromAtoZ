namespace csharpcornerExamples
{
    public class FLOWER
    {
        public string flowercolor;
        public FLOWER(string color)
        {
            this.flowercolor = color;
        }
        public string display()
        {
            return "Color of the flower : " + this.flowercolor;
        }
    }
}
