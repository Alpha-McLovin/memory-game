namespace Domain;
public class Card
{
    public int Number { get; set; }
    public bool IsFaceUp { get; set; } = false;

    public Card(int num)
    {
        Number = num;
    }

    public void TurnCard()
    {
        IsFaceUp = !IsFaceUp;
    }
}
