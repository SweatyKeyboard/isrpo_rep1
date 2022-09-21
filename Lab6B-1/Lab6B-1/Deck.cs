using System;

class Deck
{
    private Card[] _cards = new Card[52];

    public Deck()
    {
        int i = 0;
        for (int s = 0; s < 4; s++)
        {
            for (int r = 0; r < 13; r++, i++)
            {
                _cards[i] = new Card(s,r);
            }
        }
        Shuffle();
    }

    public void SetCard(int index, Card card)
    {
        _cards[index] = card;
    }

    public Card GetCard(int index)
    {
        return _cards[index];
    }

    public void Shuffle()
    {
        Random random = new Random();

        for (int i = 0; i < random.Next(20,40); i++)
        {
            ChangeCards(random.Next(0, 52), random.Next(0, 52));
        }
    }

    private void ChangeCards(int card1Index, int card2Index)
    {
        Card tempCard = _cards[card1Index];
        _cards[card1Index] = _cards[card2Index];
        _cards[card2Index] = tempCard;
    }
}