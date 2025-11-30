using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text magazinetext;
    public GameObject pauseMenu;

    bool pauseMenuOn = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
        }
        
        if (Input.GetKeyDown(KeyCode.Escape) && pauseMenuOn)
        {
            pauseMenu.SetActive(false);
        }

        if (pauseMenu.activeSelf)
        {
            pauseMenuOn = true;
            Time.timeScale = 0;
        }
        else
        {
            pauseMenuOn = false;
            Time.timeScale = 1;
        }

        if (Gun.GetMagazine() > 0)
        {
            magazinetext.text = "Ammo: " + Gun.GetMagazine().ToString() + "/7";
        }
        else if (Gun.GetTimePass() != 0)
        {
            magazinetext.text = Gun.GetTimePass().ToString();
        }
    }
    public void SetPauseMenuOff()
    {
        pauseMenuOn = false;
    }
}
