using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lab1
{
    public class CardManager : MonoBehaviour
    {
        public List<CardData> cardDeck;
        public List<CardData> currentDeck;

        private void Start()
        {
            IntializeDeck();
        }

        public void IntializeDeck()
        {
            currentDeck.AddRange(cardDeck);

            ShuffleDeck();
        }

        public void ShuffleDeck()
        {
            ShuffleDeck(currentDeck);
        }

        private void ShuffleDeck<T>(List<T> list)
        {
            int n = list.Count;
            System.Random rng = new System.Random();

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}