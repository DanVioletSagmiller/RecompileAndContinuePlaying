using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BScoreKeeper : MonoBehaviour
{
    [HideInInspector]
    public BLocator Locator;
    private BLocator GetLocator()
    {
        if (Locator != null)
        {
            return Locator;
        }

        Locator = BLocator.Get(Locator, transform);
        return Locator;
    }

    public int Score;
    public TextMeshProUGUI TextUI;

    public void Awake()
    {
        GetLocator().Set<BScoreKeeper>(this, true);
    }

    public void AddScore(int score)
    {
        Score += score;
        TextUI.text = "Score: " + Score;
    }
}
