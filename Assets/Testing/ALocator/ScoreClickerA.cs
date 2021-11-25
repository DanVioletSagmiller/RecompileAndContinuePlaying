namespace A
{
    // Review: https://youtu.be/Dwj6Ryodty4?list=PLnRmXj9gwMNeFwWtX8ay6UG7mH6pRyggA)
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    
    public class ScoreClickerA : MonoBehaviour
    {
        //[SerializeField] // did not matter if attribute was here or not
        public IScoreCounterA IScoreCounter; 
        public ScoreCounterA ScoreCounter;

        private void Start()
        {
            //this.IScoreKeeper = LocatorA.Instance.Get<IScoreCounterA>();
            this.IScoreCounter = ScoreCounterA.Instance;
            this.ScoreCounter = (ScoreCounterA)this.IScoreCounter;
        }

        private void OnMouseDown()
        {
            this.IScoreCounter.AddScore(1);
            this.ScoreCounter.AddScore(2);
        }
    }
}