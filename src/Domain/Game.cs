using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;


public class Game
{
    private readonly int _amoutOfCards;
    private readonly List<Card> _turnedCards = new();
    private readonly Random _random = new();

    public List<Card> Cards { get; private set; } = new();
    public bool GameWon { get; private set; } = false;

    public Game(int amount)
    {
        _amoutOfCards = amount;
    }

    public void InitializeGame()
    {
        MakeDeck();
        ShuffleDeck();
        TurnAllCardsBack(_turnedCards);
    }

    public void GameLogic(Card card1 , Card card2)
    {
        _turnedCards.Add(card1);
        _turnedCards.Add(card2);

        if (!CheckPair(card1 ,card2)){
            TurnAllCardsBack(_turnedCards);
            _turnedCards.Clear();
        } else
        {
            GameWon = (_turnedCards.Count == _amoutOfCards * 2);
        }
    }

    public static bool CheckPair(Card a, Card b)
    {
        return a.Number == b.Number;
    }

    public static void TurnAllCardsBack(List<Card> cards)
    {
        foreach (Card card in cards)
        {
            card.IsFaceUp = false;
        }
    }

    private void MakeDeck()
    {
        for (int i = 0; i < _amoutOfCards; i++)
        {
            Cards.Add(new Card(i + 1));
            Cards.Add(new Card(_amoutOfCards - i));
        }
    }

    private void ShuffleDeck()
    {
        // Shuffel based on the Fisher-Yates algorithm
        int n = Cards.Count;
        while (n > 1)
        {
            n--;
            int k = _random.Next(n + 1);
            (Cards[n], Cards[k]) = (Cards[k], Cards[n]);
        }
    }
}

