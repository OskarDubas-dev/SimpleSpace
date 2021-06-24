using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f;
    [SerializeField] GameObject target;
    [SerializeField] bool isMoving = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (isMoving) 
        {
        var movementThisFrame = moveSpeed * Time.deltaTime;

        if (transform.position.y != target.transform.position.y)
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, movementThisFrame); 
        }
    }


}
