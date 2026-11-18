using UnityEngine;

public abstract class Card : MonoBehaviour
{
    public string CardName;
    public string eventToSubscribe;

    public virtual void Use()
    {
        GeneralManager.Instance.eventManager.FindEvent(eventToSubscribe).AddListener(Effect);
    }

    public virtual void Effect()    
    {
        Debug.Log(GeneralManager.Instance.eventManager.currentPlayer.GetName()+ " use move : " + CardName);
        GeneralManager.Instance.eventManager.FindEvent(eventToSubscribe).RemoveListener(Effect);
    }
    
}



