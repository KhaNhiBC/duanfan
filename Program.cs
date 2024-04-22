internal class Program
{
    private static void Main(string[] args)
    {
        Fan fan1 = new Fan();
        fan1.FanOn();
        fan1.Speed(2);
        fan1.Bkquat();
        fan1.Color("Green");
    }
}