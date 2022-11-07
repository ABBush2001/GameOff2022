using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float sensitivityX = 400f;
    [SerializeField] float sensitivityY = 400f;

    [SerializeField] Transform playerCamera;
    [SerializeField] float xClamp = 85f;
    float xRotation = 0f;
    float yRotation = 0f;
    float mouseX, mouseY;

    //
    

    public void RecieveInput(Vector2 mouseInput)
    {
        mouseX = mouseInput.x * sensitivityX * Time.deltaTime;
        mouseY = mouseInput.y * sensitivityY * Time.deltaTime;
    }
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        //able to look left and right
        //transform.Rotate(Vector3.up, mouseX);
        yRotation += mouseX;
        

        //look up and down
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -xClamp, xClamp);
        Vector3 targetRotation = transform.eulerAngles;

        //
        targetRotation.x = xRotation;
        targetRotation.y = yRotation;
        playerCamera.eulerAngles = targetRotation;

        //different vid
        //transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        //playerCamera.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
