using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    private static UnityEvent onEnterFlameTrigger = new UnityEvent();
    private static UnityEvent onExitFlameTrigger = new UnityEvent();

    public static UnityEvent getOnEnterFlameTrigger()
    {
        return onEnterFlameTrigger;
    }

    public static UnityEvent getOnExitFlameTrigger()
    {
        return onExitFlameTrigger;
    }
}
