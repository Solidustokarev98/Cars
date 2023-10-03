using car;
namespace sport_car;
class Sport_Car : Car
{
    public string Name = "Спорткар";

    public void Ride()
    {
        Go(Name, My_Speed(new Random(), 500, 800));
    }
}