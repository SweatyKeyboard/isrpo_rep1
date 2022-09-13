using System;
class CupOfCoffee : a_HotDrink, ICup
{
    public string Type { get; set; }
    public string Capacity { get; set; }
    public string BeanType { get; set; }

    public void Refill()
    {
        Console.WriteLine("Cup is refilled");
    }

    public void Wash()
    {
        Console.WriteLine("Cup is washed");
    }
}
