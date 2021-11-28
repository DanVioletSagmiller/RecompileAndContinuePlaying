using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
// based on https://docs.unity3d.com/ScriptReference/ISerializationCallbackReceiver.html
public class SerializableDictionary<KEY, VALUE> : Dictionary<KEY, VALUE>, ISerializationCallbackReceiver
{
    [SerializeField]
    private List<KEY> _Keys = new List<KEY>();

    [SerializeField]
    private List<VALUE> _Values = new List<VALUE>();

    public void OnAfterDeserialize()
    {
        for (int i = 0; i < _Keys.Count; i++)
        {
            this.Add(_Keys[i], _Values[i]);
        }

        _Keys.Clear();
        _Values.Clear();
    }

    public void OnBeforeSerialize()
    {
        _Keys = new List<KEY>(Count);
        _Values = new List<VALUE>(Count);
        foreach(var pair in this)
        {
            _Keys.Add(pair.Key);
            _Values.Add(pair.Value);
        }
    }
}
