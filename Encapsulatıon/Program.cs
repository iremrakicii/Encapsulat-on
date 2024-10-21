using Encapsulatıon;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Wolkswagen", "Polo", "Beyaz", 4);
        car1.DisplayCarInfo();

        Console.WriteLine("\r\n----------------------------------------------\r\n");

        Car car2 = new Car("Opel", "Corsa", "Gri", 3);
        car2.DisplayCarInfo();

        Console.WriteLine("\r\n----------------------------------------------\r\n");


    }
}
