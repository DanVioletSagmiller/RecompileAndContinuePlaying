namespace C
{
    using System.Collections;
    using System.Collections.Generic;
    using TMPro;
    using UnityEngine;


    public interface IScoreManagerC
    {
        void AddScore(int score);
    }
    public class ScoreManagerC : MonoBehaviour, IStaticResettableC, IScoreManagerC
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