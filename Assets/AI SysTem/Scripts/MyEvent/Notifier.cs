using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="GameUtility/EventNotifiers")]
public class Notifier :ScriptableObject
{
    private List<IListener> _listeners = new List<IListener>();


    public void AddListener(IListener _listener) {


        _listeners.Add(_listener);
    
    }
    public void RemoveListener(IListener _listener)
    {


        _listeners.Remove(_listener);

    }
    public void Notify()
    {
        foreach (var listener in _listeners)
        {
            listener.OnNotify();
        }
    }
}
