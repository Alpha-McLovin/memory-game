namespace Domain;
public class Card
{
    public int Number { get; set; }
    public bool IsFaceUp { get; set; } = false;

    public Card(int num)
    {
        this.Number = num;
    }

    


    public void TurnCard()
    {
        IsFaceUp = !IsFaceUp;
    }
}
