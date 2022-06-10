using UnityEngine;
using UnityEngine.SceneManagement;

public class FlameRestarter : MonoBehaviour
{
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            EventManager.getOnExitFlameTrigger().Invoke();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnTriggerEnter()
    {
        EventManager.getOnEnterFlameTrigger().Invoke();
    }

    void OnTriggerExit()
    {
        EventManager.getOnExitFlameTrigger().Invoke();
    }
}
