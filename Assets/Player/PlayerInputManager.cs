using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    [SerializeField] Movement movement;
    [SerializeField] MouseLook mouseLook;
    PlayerControl controls;
    PlayerControl.GroundMovementActions groundMovement;

    Vector2 horizontalInput;
    Vector2 mouseInput;

    private void Awake()
    {
        controls = new PlayerControl();
        groundMovement = controls.GroundMovement;

        //groundMovement.[action].performed += context => do something
        groundMovement.HorizontalMovement.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();

        groundMovement.Sprint.performed += _ => movement.OnSprintPressed();
        groundMovement.Sprint.canceled += _ => movement.OnSprintCanceled();

        groundMovement.MouseX.performed +=  ctx => mouseInput.x = ctx.ReadValue<float>();
        groundMovement.MouseY.performed +=  ctx => mouseInput.y = ctx.ReadValue<float>();

    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDestroy()
    {
        controls.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.RecieveInput(horizontalInput);
        mouseLook.RecieveInput(mouseInput);
    }
}
