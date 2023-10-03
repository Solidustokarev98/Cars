using car;
namespace automobile;

class Automobile : Car
{
    public string Name = "Автомобиль";

    public void Ride()
    {
        Go(Name, My_Speed(new Random(), 600, 900));
    }
}
