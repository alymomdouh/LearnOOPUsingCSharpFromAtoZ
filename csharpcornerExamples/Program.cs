// See https://aka.ms/new-console-template for more information
using csharpcornerExamples;

Console.WriteLine("Hello, World!");
FLOWER flow;
flow = new FLOWER("YELLOW");
Console.WriteLine(flow.display());

BikeColor bikeColor = new BikeColor("Blue");
Console.WriteLine("User Bike Color is =" + bikeColor._MyBikeColor);

Car SportCar = new Car();
Console.WriteLine("Model: {0}", SportCar.Model_ID);
Console.WriteLine("Maker: {0}", SportCar.Maker_Name);
Console.ReadKey();

Car2 SportsCar2 = new Car2();
SportsCar2._model = 2013;
SportsCar2._maker = "lamborghini";
SportsCar2.DisplayCustomerData();
Console.ReadKey();

Car3 SportCar3 = new Car3();
SportCar3.model = 2014;
SportCar3.maker = "ferrari";
Console.WriteLine("Model: {0}", SportCar3.model);
Console.WriteLine("Maker: {0}", SportCar3.maker);
Console.ReadKey();

Console.ReadLine();
