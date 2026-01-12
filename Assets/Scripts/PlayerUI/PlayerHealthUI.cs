using UnityEngine;
using TMPro;
public class PlayerHealthUI : MonoBehaviour
{
    public PlayerCombat playerCombat;
    public TMP_Text healthText;

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + playerCombat.currentHealth;
    }
}
