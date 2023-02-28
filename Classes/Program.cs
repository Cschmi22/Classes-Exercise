namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2018;

            Car wifeCar= new Car();
            wifeCar.Make = "Toyota";
            wifeCar.Model = "Camry";
            wifeCar.Year = 2019;

            var carList = new List<Car>() { myCar, wifeCar};

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
