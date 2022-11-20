namespace csharpcornerExamples
{
    public class CarEncapsulation
    {
        private string customername = string.Empty;
        private string cardno = string.Empty;
        private double creditamount = -1;
        private double markuprate = -1;
        public CarEncapsulation(string _customername, string _cardno, double _creditamount, double _markuprate)
        {
            customername = _customername;
            cardno = _cardno;
            creditamount = _creditamount;
            markuprate = _markuprate;
        }
        public double disbursement
        {
            get
            {
                return creditamount;
            }
            set
            {
                creditamount = creditamount + value;
                creditamount = creditamount * markuprate / 100 + creditamount;
            }
        }
        public void display()
        {
            Console.WriteLine("Customer Name :{0}", customername);
            Console.WriteLine("Card Number :{0}", cardno);
            Console.WriteLine("Markup Rate :{0}", markuprate);
            Console.WriteLine("Current Balance with Markup:{0}", creditamount);
        }
    }
}
