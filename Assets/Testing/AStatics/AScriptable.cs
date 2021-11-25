namespace A
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    [CreateAssetMenu(menuName = "A Static Scriptable")]
    public class AScriptable : ScriptableObject
    {
        public static string OnDestroyS = "";
        private void OnDestroy()
        {
            OnDestroyS += "|" + Time.deltaTime;
        }
        public static string OnDisableS = "";
        private void OnDisable()
        {
            OnDisableS += "|" + Time.deltaTime;
        }
        public static string OnEnableS = "";
        private void OnEnable()
        {
            OnEnableS += "|" + Time.deltaTime;
        }
        public static string OnValidateS = "";
        private void OnValidate()
        {
            OnValidateS += "|" + Time.deltaTime;
        }
        public static string AwakeS = "";
        private void Awake()
        {
            AwakeS += "|" + Time.deltaTime;
        }
    }
}