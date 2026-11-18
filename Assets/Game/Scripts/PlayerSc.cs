using UnityEngine;
using System.Collections.Generic;

public class PlayerSc : MonoBehaviour
{
    private int playerAura;
    [SerializeField] private string playerName;
    List<Card> cardHand , cardDeck;

    public void Init()
    {
        cardHand = new List<Card>();
        cardDeck = new List<Card>();
    }
    
    public void DrawCard(int nbToDraw)
    {
        for (int i = 0; i < nbToDraw; i++)
        {
            cardHand.Add(cardDeck[0]);
            cardDeck.RemoveAt(0);
        }
    }

    public string GetName()
    {
        return playerName;
    }
    
    public void AddAura(int  nbToAdd)
    {
        playerAura = +nbToAdd;
    }
    public void RemoveAura(int   nbToRemove)
    {
        playerAura=-nbToRemove;
    }
    
    
}
