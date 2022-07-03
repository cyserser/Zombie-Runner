using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] float zoomedOutFov = 60f;
    [SerializeField] float zoomedInFov = 20f;
    [SerializeField] float zoomedOutSensitivity = 2f;
    [SerializeField] float zoomedInSensitivity = 0.5f;
    Camera myCamera;
    RigidbodyFirstPersonController fpsController;

    bool isZoomed;

    void Start()
    {
        myCamera = GetComponentInParent<Camera>();
        fpsController = GetComponentInParent<RigidbodyFirstPersonController>();
        
    }

    void Update()
    {

        if(Input.GetMouseButtonDown(1))
        {
            if(!isZoomed)
            {
                myCamera.fieldOfView = zoomedInFov;
                fpsController.mouseLook.XSensitivity = zoomedInSensitivity;
                fpsController.mouseLook.YSensitivity = zoomedInSensitivity;

                isZoomed = !isZoomed;
            }
            else
            {
                myCamera.fieldOfView = zoomedOutFov;
                fpsController.mouseLook.XSensitivity = zoomedOutSensitivity;
                fpsController.mouseLook.YSensitivity = zoomedOutSensitivity;

                isZoomed = !isZoomed;
            }
        }
    }
}
