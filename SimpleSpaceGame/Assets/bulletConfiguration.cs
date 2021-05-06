using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletConfiguration : MonoBehaviour
{

    [SerializeField] float projectileSpeed = 9f;
    float rotationSpeed = 25f;
    float timeBeforeDestroyed = 2.0f;

    GameObject bullet;

    private void Awake()
    {
        bullet = this.gameObject;
    }
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
        StartCoroutine(deleteItself());
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0, rotationSpeed);
    }

    IEnumerator deleteItself()
    {
        yield return new WaitForSeconds(timeBeforeDestroyed);
        Destroy(bullet);
    }
}
