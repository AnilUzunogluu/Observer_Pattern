using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Event", menuName = "New Event", order = 52)]
public class Event : ScriptableObject
{
    private List<EventListener> _eventListeners = new List<EventListener>();

    public void Register(EventListener listener)
    {
        _eventListeners.Add(listener);
    }

    public void Unregister(EventListener listener)
    {
        _eventListeners.Remove(listener);
    }

    public void Occured(GameObject obj)
    {
        foreach (EventListener listener in _eventListeners)
        {
            listener.OnEventOccured(obj);
        }
    }
}
