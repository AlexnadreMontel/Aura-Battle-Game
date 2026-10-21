using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public List<gameEvent> myEvents;

    private static EventManager _instance;
    
    //public Dictionary<string, UnityAction> gameEvents;

    [Serializable]
    public class gameEvent
    {
        public string name;
        public UnityEvent action;
        
    }
    
    public static EventManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("EventManager not found");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public UnityEvent FindEvent(string str)
    {
        foreach (var v in myEvents)
        {
            if (v.name == str)
                return v.action;
        }
        
        Debug.LogError(str + " not found");    
        return null;
    }

    public void PlayEvent(string str)
    {
        foreach (var v in myEvents)
        {
            if (v.name == str)
            {
                v.action.Invoke();
            }
        }
    }
    
    
    
}