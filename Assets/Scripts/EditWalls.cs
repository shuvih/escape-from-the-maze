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
            for (int i = 0; i < activateWalls.Count; i++)
            {
                activateWalls[i].SetActive(true);
            }
            for (int i = 0; i < deactivateWalls.Count; i++)
            {
                deactivateWalls[i].SetActive(false);
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
