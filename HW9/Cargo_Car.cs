using car;
namespace cargo_car;

class Cargo_Car : Car
{
    public string Name = "Грузовик";
    public void Ride()
    {
        Go(Name, My_Speed(new Random(), 700, 1000));
    }
}
