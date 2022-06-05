using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LampTrigger : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] bool trigeringWalls;
    public static Action ON_LAMP_TRIGGERED;
    public static Action ON_WALLS_TRIGGERED;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (trigeringWalls) { ON_WALLS_TRIGGERED?.Invoke(); return; }
            ON_LAMP_TRIGGERED?.Invoke();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        text.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        text.gameObject.SetActive(false);
    }
}
