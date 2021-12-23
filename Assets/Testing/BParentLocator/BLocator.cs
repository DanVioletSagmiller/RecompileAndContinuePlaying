using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-1000)]
/// <summary>Locator Service that is based on parents within </summary>
public class BLocator : MonoBehaviour
{
    // Searches same object and then all parents for BLocator
    public static BLocator Get(BLocator locator, Transform t)
    {

        if (locator != null)
        {
            //locator.SetParent();
            return locator;
        }

        if (t == null)
        {
            return null;
        }

        locator = t.GetComponent<BLocator>();
        if (locator != null)
        {
            return locator;
        }

        locator = t.GetComponentInParent<BLocator>();
        if (locator == null)
        {
            return null;
        }

        locator.SetParent();
        return locator;
    }

    private void SetParent()
    {
        if (CheckedForParent)
        {
            return;
        }

        var t = transform.parent;
        LocatorParent = Get(null, t);
        CheckedForParent = true;
    }

    private bool CheckedForParent = false;

    public BLocator LocatorParent = null;

    [SerializeField]
    private SerializableDictionary<Type, object> Map = new SerializableDictionary<Type, object>();

    /// <summary>
    /// Sets a value for others to look up
    /// </summary>
    /// <typeparam name="T">The type that will be referenced</typeparam>
    /// <param name="value">The value to set</param>
    /// <param name="toRoot">when true, every BLocator reference upto the root object will also store this.</param>
    public void Set<T>(T value, bool toRoot = false)
    {
        Map[typeof(T)] = value;
        if (!toRoot)
        {
            return;
        }

        if (!CheckedForParent)
        {
            SetParent();
        }

        if (LocatorParent != null)
        {
            LocatorParent.Set<T>(value, toRoot);
        }
    }

    /// <summary>
    /// Finds an object known based on type for this locator.
    /// If nothing is found, it will also seek its parent for 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public T Get<T>() where T : class
    {
        if (Map.ContainsKey(typeof(T)))
        {
            return (T)Map[typeof(T)];
        }

        if (!CheckedForParent)
        {
            SetParent();
        }
        
        if (LocatorParent == null)
        {
            return null;
        }

        return LocatorParent.Get<T>();
    }

}
