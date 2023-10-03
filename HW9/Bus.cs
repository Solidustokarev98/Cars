using car;
namespace bus;

class Bus : Car
{
    public string Name = "Автобус";
    public void Ride()
    {
        Go(Name, My_Speed(new Random(), 800, 1100));
    }
}