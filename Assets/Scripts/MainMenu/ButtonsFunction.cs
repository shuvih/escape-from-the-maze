using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsFunction : MonoBehaviour
{
    public void game()
    {
        SceneManager.LoadScene("Level1");
    }

    public void exit()
    {
        Application.Quit();
    }

    void settings()
    {

    }
}
