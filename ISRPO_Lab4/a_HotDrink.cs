using System;
abstract internal class a_HotDrink
{
    protected double _sugar;
    protected double _milk;

    public string AddMilk()
    {
        Console.WriteLine("Milk was added");
        return "Milk was added";
    }

    public string Drink()
    {
        Console.WriteLine("Drink was drinked");
        return "Drink was drinked";
    }

    public string AddSugar()
    {
        Console.WriteLine("Sugar was added");
        return "Sugar was added";
    }

}
