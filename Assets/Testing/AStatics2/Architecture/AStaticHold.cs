using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AStaticHold : MonoBehaviour
{
    public static string LocalTest = "";
    public static int LocalTestInt = 1;
    public static AStaticHold SelfReference;
    public static object AnotherReference;
    // Start is called before the first frame update
    void Awake()
    {
        SelfReference = this;
        LocalTestInt = 2;
        LocalTest = "asdf";
    }

    // Update is called once per frame
    void Update()
    {
        var l = 1;
        if (l == 2) Debug.Log(l);
    }
}
