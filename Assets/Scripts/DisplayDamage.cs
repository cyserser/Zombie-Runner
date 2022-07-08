using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{

    [SerializeField] Canvas splashCanvas;
    [SerializeField] float impactTime = 0.15f;
    
    void Start()
    {
        splashCanvas.enabled = false;
    }

  
    public void ShowDamageImpact()
    {
        StartCoroutine(ShowSplatter());
    }

    IEnumerator ShowSplatter()
    {
        splashCanvas.enabled = true;
        yield return new WaitForSeconds(impactTime);
        splashCanvas.enabled = false;

    }
}
