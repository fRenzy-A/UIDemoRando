using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update

    public int health;
    public int currentHealth;




    public PlayerUI playerUI; 

    public GameManager gameManager;

    void Start()
    {
        playerUI.SetInitialHealth(health);
        currentHealth = health;

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            TakeDamage(1);
        }
        playerUI.UpdateHealth(currentHealth);
        Kill();
    }

    public void TakeDamage(int dmg)
    {
        currentHealth -= dmg;

    }

    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
        if (currentHealth > health) currentHealth = health;
    }

    public void Kill()
    {
        if (currentHealth <= 0)
        {
            gameManager.gameState = GameManager.GameState.Lose;
        }
    }
}
