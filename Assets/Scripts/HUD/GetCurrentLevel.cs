using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetCurrentLevel : MonoBehaviour
{
    private Text levelInfo;
    void Start()
    {
        levelInfo = GetComponent<Text>();
        levelInfo.text = "Уровень " + SceneManager.GetActiveScene().buildIndex;
    }
}
