using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour
{
    [SerializeField] float timeBetweenShots = 1.0f;
    [SerializeField] GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fire());
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    private IEnumerator fire()
    {

        while (true)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
            bullet.tag = "fromEnemy";
            yield return new WaitForSeconds(timeBetweenShots);
        }
    }
}
