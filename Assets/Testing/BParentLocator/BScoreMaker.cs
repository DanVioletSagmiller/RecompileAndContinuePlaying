using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BScoreMaker : MonoBehaviour
{
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

    public BScoreKeeper ScoreKeeper;

    public void Start()
    {
        ScoreKeeper = GetLocator().Get<BScoreKeeper>();
    }
    private void OnMouseDown()
    {
        this.ScoreKeeper.AddScore(1);
    }
}
