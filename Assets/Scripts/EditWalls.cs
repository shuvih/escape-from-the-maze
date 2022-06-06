using System.Collections.Generic;
using UnityEngine;

public class EditWalls : MonoBehaviour
{
    /*
     * Нужно активировать
     */
    [SerializeField] private List<GameObject> activateWalls = new List<GameObject>();
    /*
     * Нужно деактивировать
     */
    [SerializeField] private List<GameObject> deactivateWalls = new List<GameObject>();

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            foreach (GameObject wall in activateWalls)
            {
                wall.SetActive(true);
            }
            foreach (GameObject wall in deactivateWalls)
            {
                wall.SetActive(false);
            }
            EventManager.getOnExitFlameTrigger().Invoke();
            this.gameObject.SetActive(false);
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
