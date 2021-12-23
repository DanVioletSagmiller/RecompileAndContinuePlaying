namespace C
{
    using System.Collections;
    using System.Collections.Generic;
    using TMPro;
    using UnityEngine;

    public class ScoreManagerC : MonoBehaviour, IStaticResettableC
    {
        public static ScoreManagerC Instance;

        public void Awake()
        {
            ResetStatics();
        }

        public void ResetStatics()
        {
            Instance = this;
        }

        public int Score = 0;
        public TextMeshProUGUI UiText;
        public void AddScore(int score)
        {
            Score += score;
            //Score += 1;
            UiText.text = $"${this.Score}";
        }
    }
}