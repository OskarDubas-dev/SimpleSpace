using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;

    float horizontal;
    float vertical;


    private void Start()
    {
      
    }


    private void Update()
    {
        Vector3 moveDirection = Vector3.right * horizontal;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

       // Vector2 moveDirection = Vector2.up * vertical + Vector2.right * horizontal;
        //transform.position += moveDirection * moveSpeed * Time.deltaTime;


    }

    public void onMoveInput(float horizontal, float vertical)
    {
        this.horizontal = horizontal;
        this.vertical = vertical;
        Debug.Log($"Player Controller: Move Input : {horizontal} and {vertical}");
    }

    public void onShootInput()
    {
        Debug.Log("player pow");
    }

}
