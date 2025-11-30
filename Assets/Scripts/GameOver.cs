using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    public string sceneName;

    void Update()
    {
        if (Stats.GetHealth() <= 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
            Stats.health = 50;
        }
    }
    public void ReloadScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }
}
