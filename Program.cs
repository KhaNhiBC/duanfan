internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Quat 1");
        Fan fan1 = new Fan();
        fan1.FanOn();
        fan1.Speed(3);
        fan1.Bkquat(10);
        fan1.Color("Yelow");
        Console.WriteLine("Quat 2");
        Fan fan2 = new Fan();
        fan2.FanOff();
        fan2.Speed(2);
        fan2.Bkquat();
        fan2.Color();
    }
}