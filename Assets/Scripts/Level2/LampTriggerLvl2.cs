using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LampTriggerLvl2: MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private GameObject wall1;
    [SerializeField] private GameObject wall2;
    [SerializeField] private GameObject wall3;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            wall1.SetActive(true);
            wall2.SetActive(false);
            wall3.SetActive(false);
            this.gameObject.SetActive(false);
            text.gameObject.SetActive(false);
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
