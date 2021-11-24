namespace A
{
    // Review: https://youtu.be/Dwj6Ryodty4?list=PLnRmXj9gwMNeFwWtX8ay6UG7mH6pRyggA)
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using TMPro;
    using UnityEngine;
    using UnityEngine.UI;

    public interface IScoreCounterA
    {
        void AddScore(int score);
    }

    public class ScoreCounterA : MonoBehaviour, IScoreCounterA
    {
        //[SerializeField] // did not matter if attribute was here or not
        public static ScoreCounterA Instance;
        public TextMeshProUGUI TextUi;
        public int Score = 0;



        public void AddScore(int score)
        {
            //Score = score;
            Score += score;
            TextUi.text = Score.ToString();
        }

        private void Awake()
        {
            Instance = this;
            //LocatorA.Instance.Set<IScoreCounterA>(this);
        }
    }
}