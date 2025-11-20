using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text magazinetext;

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
    }
}
