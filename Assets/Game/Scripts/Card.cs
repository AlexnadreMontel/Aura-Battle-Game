using UnityEngine;

public abstract class Card : MonoBehaviour
{
    public string eventToSubscribe;

    public virtual void Use()
    {
        EventManager.Instance.FindEvent(eventToSubscribe).AddListener(Effect);
    }

    public virtual void Effect()
    {
        Debug.Log(gameObject.name);
        
        EventManager.Instance.FindEvent(eventToSubscribe).RemoveListener(Effect);
        
    }
}
