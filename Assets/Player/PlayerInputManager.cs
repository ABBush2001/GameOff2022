using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    private static PlayerInputManager _instance;
    private PlayerController movement;
    private AudioSource footstepsfx;

    public static PlayerInputManager Instance{
        get{
            return _instance;
        }
    }
    private PlayerControl playerControls;
    private void Awake()
    {
        footstepsfx = GameObject.Find("footstep").GetComponent<AudioSource>();
        if(_instance != null && _instance != this){
            Destroy(this.gameObject);
        }
        else{
            _instance = this;
        }
        playerControls = new PlayerControl();
        movement = new PlayerController();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        playerControls.Player.Sprint.performed += _ => movement.OnSprintPressed();
        playerControls.Player.Sprint.canceled += _ => movement.OnSprintCanceled();

    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDestroy()
    {
        playerControls.Disable();
    }

    public Vector2 GetPlayerMovement(){
        return playerControls.Player.Movement.ReadValue<Vector2>();
        footstepsfx.enabled = true;
    }

    public Vector2 GetMouseDelta(){
        return playerControls.Player.Look.ReadValue<Vector2>();
    }
}
