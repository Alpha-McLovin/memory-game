using Domain;

namespace Client.Pages;

public partial class Index
{
    private Game _game = new Game();

    protected override void OnInitialized()
    {
        _game.InitializeGame();
    }

    public void TurnCard(Card card)
    {
        card.TurnCard();
    }
}


