using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;


public class Game
{
    private readonly int _amoutOfCards;
    public List<Card> Cards { get; private set; } = new();

    private readonly Random _random = new Random();

    

    public void InitializeGame()
    {
        MakeDeck();
        ShuffleDeck();
    }


    private void MakeDeck() {
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

