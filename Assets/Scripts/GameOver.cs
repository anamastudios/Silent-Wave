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
            Stats.isPlayerDead = true;
            Stats.health = 50;
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(sceneName);
        Stats.isPlayerDead = false;
    }
}
