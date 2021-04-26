using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;




//ok so this is unity event I have no idea about <REASERCH!!!> <TODO>
[Serializable]
public class MoveInputEvent : UnityEvent<float,float> { }

public class InputController : MonoBehaviour
{

    public Controls controls;
    public MoveInputEvent moveInputEvent;
    



    private void Awake()
    {
        controls = new Controls();
    }


    void Update()
    {
        
    }

    private void Move()
    {

        Debug.Log("lefty");
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
        controls.Gameplay.Move.performed += OnMovePerformed;
        controls.Gameplay.Move.canceled += OnMovePerformed;

        controls.Gameplay.Shoot.performed += Shoot_performed;
        
    }

    private void Shoot_performed(InputAction.CallbackContext context)
    {
       
        Debug.Log("pow");
    }

    private void OnMovePerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
     //still unity events
        moveInputEvent.Invoke(moveInput.x, moveInput.y);
        //Debug.Log($"Move Input:  {moveInput}");
    }


    

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
