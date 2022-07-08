using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 70f;
    [SerializeField] float intensityAmount = 2f;
    FlashlightSystem myFlashLight;

    void Awake() 
    {
        myFlashLight = FindObjectOfType<FlashlightSystem>();
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            myFlashLight.RestoreLightAngle(restoreAngle);
            myFlashLight.RestoreLightIntensity(intensityAmount);
            Destroy(gameObject);
        }
    }
}
