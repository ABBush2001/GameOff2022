using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed;
    [SerializeField] float gravity = -30f; //-9.81f
    [SerializeField] LayerMask groundMask;
    bool isGrounded;
    bool isRunning;

    Vector3 verticalVelocity = Vector3.zero;
    Vector2 horizontalInput;

    public void RecieveInput(Vector2 _horizontalInput)
    {
        horizontalInput = _horizontalInput;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundMask);
        if(isGrounded)
        {
            verticalVelocity.y = 0;
        }
        Vector3 horizontalVelocity = (transform.right * horizontalInput.x + transform.forward * horizontalInput.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);

        //gravity
        verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(verticalVelocity * Time.deltaTime);
    }

    public void OnSprintPressed(){
        speed = 8f;
    }

    public void OnSprintCanceled(){
        speed = 5f;
    }

    

}
