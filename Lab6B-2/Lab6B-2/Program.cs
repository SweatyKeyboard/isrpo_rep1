using System;

class Program
{
    static void Main(string[] args)
    {
        Deck deck = new Deck();
        for (int c = 0; c < 52; c++)
        {
            Console.Write(deck.GetCard(c).ToString() + "  ");
            if ((c+1)%13 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}