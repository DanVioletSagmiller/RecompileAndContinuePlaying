using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AStatics2Component : MonoBehaviour
{
    public static AStatics2Component This;
    // Start is called before the first frame update
    void Start()
    {
        AStaticHold.AnotherReference = this;
        This = this;
    }

    // Update is called once per frame
    void Update()
    {
        var l = 1;
        if (l == 2) Debug.LogWarning(l);
    }
}
