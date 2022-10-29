using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class UnityGameObjectEvent : UnityEvent<GameObject>{}
public class EventListener : MonoBehaviour
{
    [SerializeField] private Event gEvent;
    [SerializeField] private UnityGameObjectEvent response = new UnityGameObjectEvent();

    private void OnEnable()
    {
        gEvent.Register(this);
    }

    private void OnDisable()
    {
        gEvent.Unregister(this);
    }

    public void OnEventOccured(GameObject obj)
    {
        response.Invoke(obj);
    }
}
