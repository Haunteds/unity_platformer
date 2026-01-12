using UnityEditor;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public PlayerStats baseStats;
    public int currentHealth;
    public int currentAmmo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = baseStats.maxHealth;
        currentAmmo = baseStats.maxAmmo;
    }

    public void PlayerTakesDamage(int amount)
    {
        currentHealth -= amount;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Player hit");
            PlayerTakesDamage(1);
        }
    }



}
