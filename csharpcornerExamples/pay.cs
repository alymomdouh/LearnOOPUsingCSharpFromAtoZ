namespace csharpcornerExamples
{
    /*
     Abstract Methods
        Dear readers, this article is the fourth and last pillar of OOP. 
        It's confusing for the beginners of OOP. So we provide an example in very simple words.
        "Abstraction is used to manage complexity. No objects of an abstract class are can be created. 
         An abstract class is used for inheritance."
     */
    abstract class pay // Abstract class  
    {
        protected int _basicpay = 20000;
        protected int _houserent = 15000;
        protected int _Tax = -500;
        protected int _NetPay = -500;
        public abstract int gradtwo { get; }
        public abstract int gradone { get; }
    }

    class Netpay : pay
    {
        public void CalculatePay()
        {
            _NetPay = _basicpay + _houserent + _Tax;
        } 
        public override int gradtwo // overriding property  
        {
            get
            {
                return _NetPay;
            }
        } 
        public override int gradone // overriding property  
        {
            get
            {
                return _NetPay = _NetPay + _NetPay * 10 / 100;
            }
        }
    }
}
