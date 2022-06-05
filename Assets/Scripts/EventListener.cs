using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventListener : MonoBehaviour
{
    private void OnEnable()
    {
        LampTrigger.ON_LAMP_TRIGGERED += TriggerAction;
        Debug.Log("Listening event");
    }
    private void OnDisable()
    {
        LampTrigger.ON_LAMP_TRIGGERED -= TriggerAction;
    }
    void TriggerAction()
    {
        Debug.Log("Event Method Triggered");
        Debug.Log(SceneManager.GetActiveScene().buildIndex + " " + SceneManager.sceneCountInBuildSettings);
        if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
        {

            SceneManager.LoadScene("MainMenu");
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
