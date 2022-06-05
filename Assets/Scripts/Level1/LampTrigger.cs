using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LampTrigger : MonoBehaviour
{
    [SerializeField] private Text text;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
            SceneManager.LoadScene("Level2");
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
