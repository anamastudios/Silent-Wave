using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public int health;
    public Text healthText;

    int maxHealth;

    private void Start()
    {
        maxHealth = health;
    }
    private void Update()
    {
        healthText.text = "Health: " + health + "/" + maxHealth;
    }
}
