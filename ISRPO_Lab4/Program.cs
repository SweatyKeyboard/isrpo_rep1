using System;

namespace ISRPO_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Angle angle1 = new Angle(47, 53, 'N');
            Console.WriteLine(angle1.GetString());
            Angle angle2 = new Angle();
            angle2.SetCoordinates();
            Console.WriteLine(angle2.GetString());

            Console.ReadLine();*/

            ProcessCup(new CupOfCoffee());
        }

        private static void ProcessCup(a_HotDrink drink)
        {            
            drink.AddMilk();
            drink.AddSugar();
            drink.Drink();
            ((ICup)drink).Refill();
            ((ICup)drink).Wash();
        }
    }
}
