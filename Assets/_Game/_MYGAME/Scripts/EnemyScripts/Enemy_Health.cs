using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class Enemy_Health : MonoBehaviour
{

    public int expReward = 3;
    public delegate void MonsterDefeated(int exp);
    public static event MonsterDefeated OnMonsterDefeated;
    public int currentHealth;
    public int maxHealth;
    public GameWin gameWin;



    private void Start()
    {
        currentHealth = maxHealth;
    }


    public void Changehealth(int amount)
    {
        currentHealth += amount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        
        else if(currentHealth <= 0)
        {
            OnMonsterDefeated(expReward);
            Destroy(gameObject);
            GameWin.destroyedEnemies++; // This adds to the variable “destroyedEnemies” in the “GameWinner” script.
        }

    }
}
