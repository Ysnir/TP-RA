using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Card : MonoBehaviour, IComparable<Card>
{

    [SerializeField]
    private int cardValue;
    [SerializeField]
    private CardColor cardColor;

    public CardColor CardColor { get { return cardColor; } }
    public int CardValue { get { return cardValue; } }

    public int CompareTo(Card other)
    {
        if ((this.CardColor == CardColor.BLUE && other.CardColor == CardColor.RED) || (this.CardColor == CardColor.RED && other.CardColor == CardColor.GREEN) || (this.CardColor == CardColor.GREEN && other.CardColor == CardColor.BLUE))
        {
            return 1;
        }
        else if (this.CardColor == other.cardColor || this.cardColor == CardColor.GREY || other.cardColor == CardColor.GREY)
        {
            return this.CardValue - other.CardValue;
        }
        else
        {
            return -1;
        }
    }
}
