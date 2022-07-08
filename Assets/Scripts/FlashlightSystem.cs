using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightSystem : MonoBehaviour
{
    [SerializeField] float lightDecay = 0.1f;
    [SerializeField] float angleDecay = 1f;
    [SerializeField] float minimumAngle = 40f;

    Light flashLight;
    
    void Start()
    {
        flashLight = GetComponent<Light>();
    }

   
    void Update()
    {
        DecreaseLightAngle();
        DecreaseLightIntensity();
    }

    public void RestoreLightAngle(float restoreAngle)
    {
        flashLight.spotAngle = restoreAngle;
    }

    public void RestoreLightIntensity(float intensityAmount)
    {
        flashLight.intensity += intensityAmount;
    }

    void DecreaseLightAngle()
    {
        if(flashLight.spotAngle >= minimumAngle)
        {
            flashLight.spotAngle -= angleDecay * Time.deltaTime;
        }
    }
        

    void DecreaseLightIntensity()
    {
        flashLight.intensity -= lightDecay * Time.deltaTime;
    }

}
