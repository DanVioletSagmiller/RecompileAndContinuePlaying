namespace A
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    [CreateAssetMenu(menuName = "A Static Scriptable")]
    public class AScriptable : ScriptableObject
    {
        public static string ChangeMe = "";
        public static string OnDestroyS = "";
        private void OnDestroy()
        {
            OnDestroyS += "|" + Time.realtimeSinceStartup;
        }
        public static string OnDisableS = "";
        private void OnDisable()
        {
            OnDisableS += "|" + Time.realtimeSinceStartup;
        }
        public static string OnEnableS = "";
        private void OnEnable()
        {
            OnEnableS += "|" + Time.realtimeSinceStartup;
        }
        public static string OnValidateS = "";
        private void OnValidate()
        {
            OnValidateS += "|" + Time.realtimeSinceStartup;
        }
        public static string AwakeS = "";
        private void Awake()
        {
            AwakeS += "|" + Time.realtimeSinceStartup;
        }
    }
}