using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text magazinetext;
    public GameObject OpenDoorUI;

    void Update()
    {
        if (Gun.GetMagazine() > 0)
        {
            magazinetext.text = "Ammo: " + Gun.GetMagazine().ToString() + "/7";
        }
        else if (Gun.GetTimePass() != 0)
        {
            magazinetext.text = Gun.GetTimePass().ToString();
        }

        if (Device.gotSignal)
        {
            OpenDoorUI.SetActive(true);
        }
        else
        {
            OpenDoorUI.SetActive(false);
        }
    }
}
