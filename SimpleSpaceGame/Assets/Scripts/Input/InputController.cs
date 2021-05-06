using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

//Unity Events: https://www.youtube.com/watch?v=oc3sQamIh-Q
//Unity Input Sys: https://www.youtube.com/watch?v=kGykP7VZCvg&t=1781s
//                  https://www.youtube.com/watch?v=dyyjhwyX20M



[Serializable] public class MoveInputEvent : UnityEvent<float,float> { }
[Serializable] public class ShootEvent : UnityEvent { }

public class InputController : MonoBehaviour
{

    public Controls controls;
    public MoveInputEvent moveInputEvent;
    public ShootEvent shootEvent;
    private bool fireDown;
    



    private void Awake()
    {
        controls = new Controls();
    }


    void Update()
    {
        if(fireDown) shootEvent.Invoke();
    }


    private void OnEnable()
    {
        controls.Gameplay.Enable();
        controls.Gameplay.Move.performed += OnMovePerformed;
        controls.Gameplay.Move.canceled += OnMovePerformed;

        controls.Gameplay.Shoot.performed += onShootPerformed;
        controls.Gameplay.Shoot.canceled += onShootCanceled;
        
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
        controls.Gameplay.Move.performed -= OnMovePerformed;
        controls.Gameplay.Move.canceled -= OnMovePerformed;

        controls.Gameplay.Shoot.performed -= onShootPerformed;
        controls.Gameplay.Shoot.canceled -= onShootCanceled;
    }



    private void OnMovePerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        moveInputEvent.Invoke(moveInput.x, moveInput.y);
    }
    private void onShootPerformed(InputAction.CallbackContext context)
    {
        fireDown = true;
    }

    private void onShootCanceled(InputAction.CallbackContext context)
    {
        fireDown = false;
    }
    
    
    

 
}
