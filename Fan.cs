using System.Security.Cryptography.X509Certificates;

public class Fan 
{
    private int speed = 1;
    private double radius = 5;
    private string color = "Blue"; 
    private bool on = false;
    public Fan()
    { }
    public void FanOn()
    {
        on = true;
    }
    public void FanOff()
    {
        on = false;
    }
    public void Speed()
    {
        if (on&&speed == 1)
        {
            Console.WriteLine("Toc do quat la: SLOW");
        }
    }
    public void Speed(int speed)
    {
        
        if (on&&speed == 2)
        {
            Console.WriteLine("Toc do quat la: MEDIUM");
        }
        if (on&&speed == 3)
        {
            Console.WriteLine("Toc do quat la: FAST");
        }
    }
    public void Bkquat(double radius)
    {
        this.radius = radius;
        if (radius != 5)
        {
            Console.WriteLine("Ban kinh quat la: "+radius);
        }
    }
    public void Bkquat()
    {
        Console.WriteLine("Ban kinh quat la: "+radius);
    }
    public void Color()
    {
        Console.WriteLine("Mau quat la: "+color);
    }
    public void Color(string color)
    {
        this.color = color;
        Console.WriteLine("Mau quat la: "+color);
    }
    
}