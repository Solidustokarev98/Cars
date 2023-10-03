using sport_car;
using automobile;
using bus;
using cargo_car;

//Создаем объекты
Sport_Car car = new Sport_Car();
Bus bus = new Bus();
Cargo_Car cargo_Car = new Cargo_Car();
Automobile automobile = new Automobile();

List<Thread> threads = new List<Thread>()
{
    new Thread(cargo_Car.Ride),
    new Thread(car.Ride),
    new Thread(bus.Ride),
    new Thread(automobile.Ride)
};
foreach (Thread list in threads)
{
    list.Start();
}
Console.ReadKey();