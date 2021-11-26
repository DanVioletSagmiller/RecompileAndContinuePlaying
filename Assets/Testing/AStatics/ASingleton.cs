namespace A
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class ASingleton : MonoBehaviour
    {
        public AScriptable AScriptableRef;
        public static AScriptable AScriptableStatic;
        public static ASingleton InstObject;
        public static string InstString;
        public static GameObject InstGameObj;
        public static Transform InstTransform;
        public static int InstInt;
        public static float InstF;

        void Start()
        {
            AScriptableStatic = AScriptableRef;
            InstObject = this;
            InstString = "test";
            InstGameObj = this.gameObject;
            InstTransform = this.transform;
            InstInt = 21;
            InstF = 21.21f;
            AScriptable.ChangeMe += "Started\n";
        }

        void Update()
        {
            var msg = "";
            if (msg == null)
            {
                msg = "wg5";
                msg = "another";
            }
        }
    }
}