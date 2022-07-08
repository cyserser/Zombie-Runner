using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] float damage = 40f; 

    PlayerHealth playerHealth;
    DisplayDamage displayDamage;
    

    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        displayDamage = FindObjectOfType<DisplayDamage>();
    }

    public void AttackHitEvent()
    {
        if(playerHealth == null) return;
        displayDamage.ShowDamageImpact();
        Debug.Log("BOOOOOOOOOOOOM");
        playerHealth.GetDamaged(damage);
    }
   
}
