using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bullet class:
//- Speed of each bullet
//- Its visual behaviour
//- Object deletes itself upon going out of camera range

public class bulletConfiguration : MonoBehaviour
{

    [SerializeField] float projectileSpeed = 9f;
    float rotationSpeed = 25f;
    float timeBeforeDestroyed = 2.0f; //for coroutine (not using this for now)

    GameObject bullet;

    [SerializeField] private AudioClip standardFireSound;
    private float standardFireSoundVolume = 0.1f;

    private void Awake()
    {
        bullet = this.gameObject;
    }
 
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
        //StartCoroutine(deleteItself());
        AudioSource.PlayClipAtPoint(standardFireSound, Camera.main.transform.position, standardFireSoundVolume);
    }

  
    void Update()
    {
        bulletVisuals();
    }

    private void bulletVisuals() //just rotation for now, but I created this method in case I'll add more
    {
        transform.Rotate(0, 0, rotationSpeed);
    }

    private void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }

    IEnumerator deleteItself() //not using this for now, left in case coroutine would be better option
    {
        yield return new WaitForSeconds(timeBeforeDestroyed);
        Destroy(bullet);
    }
}
