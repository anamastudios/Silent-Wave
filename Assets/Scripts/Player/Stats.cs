using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public static int health = 50;
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
    public static void Damage(int damage)
    {
        health -= damage;
    }
    public static int GetHealth()
    {
        return health;
    }
}
