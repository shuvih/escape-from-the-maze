using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            EventManager.getOnExitFlameTrigger().Invoke();
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings);
            Cursor.lockState = CursorLockMode.None;
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
