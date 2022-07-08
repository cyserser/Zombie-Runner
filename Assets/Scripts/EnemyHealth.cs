using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    Animator myAnimator;
   
    [SerializeField] bool isDead = false;

    void Start() 
    {
        myAnimator = FindObjectOfType<Animator>();
    }

    public bool IsDead()
    {
        return isDead;
    }

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            Destroy(gameObject);
            //Die(); BUG
        }
    }

    void Die()
    {
        if(isDead) return;
        isDead = true;
        myAnimator.SetTrigger("die");
    }
}