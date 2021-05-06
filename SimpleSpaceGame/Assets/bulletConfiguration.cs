using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletConfiguration : MonoBehaviour
{

    [SerializeField] float projectileSpeed = 9f;
    float rotationSpeed = 25f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0, rotationSpeed);
    }
}
