namespace C
{
    // Review: https://youtu.be/wDOoYTD62BU
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class ScoreClickerC : MonoBehaviour
    {
        public int PointsPerClick = 5;

        private void OnMouseDown()
        {
            ScoreManagerC.Instance.AddScore(this.PointsPerClick);
        }
    }
}