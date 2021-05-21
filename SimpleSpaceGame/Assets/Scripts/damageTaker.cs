using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageTaker : MonoBehaviour
{
    [SerializeField] int health = 1;


    private void Update()
    {
        if(health <= 0)
        { destroyItself(); }
    }

    private void destroyItself()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        damageDealer _damageDealer = collision.gameObject.GetComponent<damageDealer>();

        health -= _damageDealer.Damage();
    }


}
