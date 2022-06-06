using UnityEngine;

public class CallMenu : MonoBehaviour
{
    private Canvas canvas;
    void Start()
    {
        canvas = GetComponent<Canvas>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            callMenu();
        }
    }

    private void callMenu()
    {
        if (canvas.enabled)
        {
            Cursor.lockState = CursorLockMode.Locked;
            canvas.enabled = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            canvas.enabled = true;
        }
    }
}
