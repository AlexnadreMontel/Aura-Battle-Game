using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : BaseManager
{
    public PlayerSc currentPlayer;
    public List<PlayerSc> lstPlayer;
    
    public List<GameEvent> myEvents;
    [SerializeField] private int currentEvent;
    private static EventManager _instance;

    #region turnBaseSystem
    [Serializable]
    public class GameEvent
    {
        public string name;
        public UnityEvent action;
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

    public void NextEvent()
    {
        currentEvent++;

        if (currentEvent >= myEvents.Count)
        {
            currentEvent = 0;
            NextPlayer();
        }

        Debug.Log(currentEvent);
    }

    private void NextPlayer()
    {
        var i = lstPlayer.IndexOf(currentPlayer) ;

        currentPlayer = i >= lstPlayer.Count-1 ? lstPlayer[0] : lstPlayer[(lstPlayer.IndexOf(currentPlayer)) + 1];
    }
    
    private void Awake()
    {
        currentEvent = 0;
        currentPlayer  = lstPlayer[0];
    }
    #endregion
}