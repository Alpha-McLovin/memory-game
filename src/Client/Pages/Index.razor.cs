using Domain;

namespace Client.Pages;

public partial class Index
{
    private readonly Game _game = new(8);
    private List<Card> _cards = new();
    private Card? _previous = null;

    public string Back = "back";

    protected override void OnInitialized()
    {
        _game.InitializeGame();
        _cards = _game.Cards;
    }

    public async Task CardClicked(Card card)
    {
        card.TurnCard();
        await Task.Delay(500);
        if (_previous == null)
        {
            _previous = card;
        }
        else
        {
            _game.GameLogic(_previous, card);
            _previous = null;
        }
    }
}


