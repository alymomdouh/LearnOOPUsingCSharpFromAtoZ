namespace csharpcornerExamples
{
    public class car4
    {
        /*
         C# Constructor
            Part 1 was only about the basics of class constructors. In this lesson we will discuss various types of constructors in detail. 
            Types of Properties 
            Default Constructor
            Constructor Overloading
            Private Constructors
            Constructor Chaining
            Static Constructors
            Destructors
            Please note a few basic concepts of constructors and ensure that your understanding is crystal clear,
            otherwise you can't understand OOP (constructors). 
            Constructors have the same name as the class name.
            The purpose of constructors is for initialization of member variables.
            A constructor is automatically invoked when the object is created.
            A constructor doesn't have any return type, not even void.
            If we want some code to be executed automatically then the code that we want to execute must be put in the constructor.
            We can't call the constructor explicitly.
         */
        private int model = -1;
        private string maker = string.Empty;
        private double Enginetype = 0.0;
        public string carname;
        // to test Default Constructor
        //public car4()
        //{
        //    //Default Constructor
        //}
        public car4(int _model, string _maker)
        {
            model = _model;
            maker = _maker;
        }
        public car4(string _maker, double _power)
        {
            maker = _maker;
            Enginetype = _power;
        }
        /*
         Private Constructors
           as we know, 
        the private access modifier is a bit of a special case.
        We neither create the object of the class, nor can we inherit the class with only private constructors. But yes, 
        we can have the set of public constructors along with the private constructors in the class 
        and the public constructors can access the private constructors from within the class through constructor chaining.
        Private constructors are commonly used in classes that contain only static members.
         */
        // to test private Constructor
        private car4()
        {
            carname = "lamborghini";
        }
        public car4(int model) : this()
        {
            Console.WriteLine("Model Year:{0}", model);
            Console.WriteLine("Maker Name:{0}", carname);
        }
        public int model_Id
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
        public double Engine
        {
            get
            {
                return Enginetype;
            }
            set
            {
                Enginetype = value;
            }
        }
    }
}
