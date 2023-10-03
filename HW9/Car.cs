namespace car;

//Создаем абстрактный класс Car
abstract class Car
{
    public delegate void Start();       
    public delegate void Message();
    public event Message Display;

    //Генерация скорости автомобиля случайных образом
    public int My_Speed(Random rnd, int r1, int r2)
    {
        int speed;
        return speed = rnd.Next(r1, r2 + 1);
    }
    //Сообщение о прибытии к финишу
    public void Win(string name)
    {
        Console.WriteLine($"{name} прибыл");
    }

    //Метод езды
    public void Go(string name, int speed)
    {
        int distance = 0;
        Display += () => Win(name);
        for (int i = 0; i < 110; i += 10, distance += 10)
        {
            Thread.Sleep(speed);
            if (distance == 100)
                Display();
        }
    }
}