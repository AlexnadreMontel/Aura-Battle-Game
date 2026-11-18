using UnityEngine;
using System.Collections.Generic;


public class GeneralManager : BaseManager
{

    List<BaseManager> AllManagers;

    private static GeneralManager _instance;
    
    public EventManager eventManager;
    
    
    private void Awake()
    {
        _instance = this;
    }
    
    public static GeneralManager Instance
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

    
}
