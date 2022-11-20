// See https://aka.ms/new-console-template for more information
using csharpcornerExamples;

Console.WriteLine("Hello, World!");
// test class
FLOWER flow;
flow = new FLOWER("YELLOW");
Console.WriteLine(flow.display());
// test  get and set for Properties
BikeColor bikeColor = new BikeColor("Blue");
Console.WriteLine("User Bike Color is =" + bikeColor._MyBikeColor);
// test read only Properties
Car SportCar = new Car();
Console.WriteLine("Model: {0}", SportCar.Model_ID);
Console.WriteLine("Maker: {0}", SportCar.Maker_Name);
Console.ReadKey();
// test Write only Properties
Car2 SportsCar2 = new Car2();
SportsCar2._model = 2013;
SportsCar2._maker = "lamborghini";
SportsCar2.DisplayCustomerData();
Console.ReadKey();
// test Auto implemented Property
Car3 SportCar3 = new Car3();
SportCar3.model = 2014;
SportCar3.maker = "ferrari";
Console.WriteLine("Model: {0}", SportCar3.model);
Console.WriteLine("Maker: {0}", SportCar3.maker);
Console.ReadKey();
//test C# Constructor
//car4 sportscar1 = new car4();
car4 sportscar2 = new car4(2013, "mercedes");
car4 sportscar3 = new car4("mercedes", 7.8);
Console.WriteLine("Constructor without arguments");
//Console.WriteLine("Car Model is :{0} ", sportscar1.model_Id);
//Console.WriteLine("Car Name is :{0}", sportscar1.Maker_Name);
//Console.WriteLine("Car Engine Power is :{0}", sportscar1.Engine);
Console.WriteLine("\nConstructor with two arguments");
Console.WriteLine("Car Model is :{0} ", sportscar2.model_Id);
Console.WriteLine("Car Name is :{0}", sportscar2.Maker_Name);
Console.WriteLine("Car Engine Power is :{0}", sportscar2.Engine);
Console.WriteLine("\nConstructor with two arguments");
Console.WriteLine("Car Model is :{0} ", sportscar3.model_Id);
Console.WriteLine("Car Name is :{0} ", sportscar3.Maker_Name);
Console.WriteLine("Car Engine Power is :{0}", sportscar3.Engine);
// to test private Constructor
car4 sportscar = new car4(2013);
Console.ReadKey();
// Constructor chaining
carChaining sportscar1 = new carChaining(7.8);
Console.Read();
//test static constructors
CarStatic.Drive();
CarStatic.Drive();
Console.ReadKey();
//
CarEncapsulation crx = new CarEncapsulation("Naveed Zaman", "002020-1", 5000, 16.5);
crx.disbursement = 6999;
crx.display();
Console.ReadKey();
// test Polymorphism
CarPolymorphism cr = new CarPolymorphism();
cr.CarDetail();
cr.CarDetail(2200000);
cr.CarDetail(2200000, "White");
Console.ReadKey();
//test Inheritance 
truck tr = new truck();
Console.WriteLine("****************");
petrol pr = new petrol();
Console.WriteLine("****************");
electric el = new electric();
Console.WriteLine("****************");
Console.ReadKey();
// Abstract Methods
Netpay o = new Netpay();
o.CalculatePay();
Console.WriteLine("Officer Grad II pay = {0} \nOfficer Grad I pay = {1}", o.gradtwo, o.gradone);
Console.ReadKey();
Console.ReadLine();
