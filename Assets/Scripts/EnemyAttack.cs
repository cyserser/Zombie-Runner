using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    
    [SerializeField] Transform target;
    [SerializeField] float damage = 40f; 

    PlayerHealth playerHealth;

    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHitEvent()
    {
        if(target == null) return;
        Debug.Log("BOOOOOOOOOOOOM");
        playerHealth.GetDamaged(damage);
    }
   
}
