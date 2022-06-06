using UnityEngine;

public class GetPressE : MonoBehaviour
{
    private Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>();
    }

    void OnEnable()
    {
        EventManager.getOnEnterFlameTrigger().AddListener(showCanvas);
        EventManager.getOnExitFlameTrigger().AddListener(hideCanvas);
    }

    void OnDisable()
    {
        EventManager.getOnEnterFlameTrigger().RemoveListener(showCanvas);
        EventManager.getOnExitFlameTrigger().RemoveListener(hideCanvas);
    }

    private void showCanvas()
    {
        canvas.enabled = true;
    }

    private void hideCanvas()
    {
        canvas.enabled = false;
    }
}
