namespace C
{
    using TMPro;
    using UnityEngine;
    // review: https://youtu.be/wDOoYTD62BU
    public class ScoreManagerC : MonoBehaviour, ISerializationCallbackReceiver
    {
        public static ScoreManagerC Instance;
        public void OnAfterDeserialize() 
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

        public void OnBeforeSerialize() { }
    }
}