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
    [SerializeField] Camera myCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;

    bool isZoomed;


    void Update()
    {

        if(Input.GetMouseButtonDown(1))
        {
            if(!isZoomed)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    void ZoomIn()
    {
        GetComponentInParent<WeaponSwitcher>().SetCanSwitch(false);
        myCamera.fieldOfView = zoomedInFov;
        fpsController.mouseLook.XSensitivity = zoomedInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomedInSensitivity;

        isZoomed = !isZoomed;
    }

    void ZoomOut()
    {
        GetComponentInParent<WeaponSwitcher>().SetCanSwitch(true);
        myCamera.fieldOfView = zoomedOutFov;
        fpsController.mouseLook.XSensitivity = zoomedOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomedOutSensitivity;

        isZoomed = !isZoomed;
    }
}
