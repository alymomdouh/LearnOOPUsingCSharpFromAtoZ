namespace csharpcornerExamples
{
    public class Car  // thats for read  only 
    {
        private int model = 2012;
        private string maker = "mercedes";
        public int Model_ID
        {
            get
            {
                return model;
            }
        }
        public string Maker_Name
        {
            get
            {
                return maker;
            }
        }
    }
}
