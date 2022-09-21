class Card
{
    public int Suit { get; }
    public int Rank { get; }

    public Card(int suit, int rank)
    {
        Suit = suit % 4;
        Rank = rank % 13;
    }

    public override string ToString()
    {
        string suit = "?";
        string rank = "?";
        
        if (Rank < 9)
        {
            rank = (Rank + 2).ToString();
        }
        else if (Rank == 9)
        {
            rank = "J";
        }
        else if (Rank == 10)
        {
            rank = "Q";
        }
        else if (Rank == 11)
        {
            rank = "K";
        }
        else if (Rank == 12)
        {
            rank = "A";
        }

        if (Suit == 0)
        {
            suit = "♥";
        }
        else if (Suit == 1)
        {
            suit = "♦";
        }
        else if (Suit == 2)
        {
            suit = "♣";
        }
        else if (Suit == 3)
        {
            suit = "♠";
        }

        return rank + suit;
    }
}
