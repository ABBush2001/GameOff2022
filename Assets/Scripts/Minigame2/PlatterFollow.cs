using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlatterFollow : MonoBehaviour
{
    public Camera mainCam;
    public GameObject platter;
    Vector3 mousePos;

    // Update is called once per frame
    void Update()
    {
        Vector3 worldPos = mainCam.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        platter.transform.SetPositionAndRotation(new Vector3(worldPos.x, platter.transform.position.y), new Quaternion());
    }
}
