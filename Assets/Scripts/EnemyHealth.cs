using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    Animator myAnimator;
    EnemyAI enemyAI;
    bool isDead;

    void Start() 
    {
        myAnimator = FindObjectOfType<Animator>();
        enemyAI = GetComponent<EnemyAI>();
    }

    public void TakeDamage(float damage)
    {
        if(!isDead)
        {
            BroadcastMessage("OnDamageTaken");
            hitPoints -= damage;
            if (hitPoints <= 0)
            {
                isDead = true;
                enemyAI.enabled = false;
                myAnimator.SetTrigger("die");
            }
        }
        
    }
}
