using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health = 100f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void GetDamaged(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Debug.Log("You ded");
        }
    }
}
