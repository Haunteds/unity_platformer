using UnityEngine;

[CreateAssetMenu(menuName = "Stats/Player Stats")]
public class PlayerStats : ScriptableObject
{
    public int maxHealth = 3;
    public int attackDamage = 1;
    public int maxAmmo = 3;
}
