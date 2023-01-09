using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestingInputSystem : MonoBehaviour
{

    private Rigidbody mainRigidbody;
    private PlayerInput playerInput;
    private PlayerInputActions playerInputActions;



    private void Awake(){
        mainRigidbody = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Jump.performed += Jump;
        

    }
    private void FixedUpdate()
    {
        
        Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        float speed = 5f;
        mainRigidbody.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }
    
    public void Jump(InputAction.CallbackContext context) {
        Debug.Log(context);
        if (context.performed)
        {
            Debug.Log("Jump!" + context.phase);
            mainRigidbody.AddForce(Vector3.up * 3f, ForceMode.Impulse);
        }
    }
}
