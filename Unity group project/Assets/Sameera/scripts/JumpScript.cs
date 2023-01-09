using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpScript : MonoBehaviour
{
    private Rigidbody rb;
    private PlayerInput playerInput;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        PlayerInputActions playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Jump.performed += Jump;
    }
    public void Jump(InputAction.CallbackContext context) {
        Debug.Log(context);
        if (context.performed) {
            Debug.Log("Jump" + context.phase);
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
        
    }
}
