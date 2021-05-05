using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletConfiguration : MonoBehaviour
{

    [SerializeField] float projectileSpeed = 0.5f;
    float rotationSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
