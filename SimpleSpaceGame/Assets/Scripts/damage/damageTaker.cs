using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageTaker : MonoBehaviour
{
    [SerializeField] int health = 1;

    [SerializeField] private AudioClip deathSound;
    private float deathSoundVolume = 0.1f;


    private void Update()
    {
        if(health <= 0)
        { destroyItself(); }
    }

    private void destroyItself()
    {
        AudioSource.PlayClipAtPoint(deathSound, Camera.main.transform.position, deathSoundVolume);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        damageDealer _damageDealer = collision.gameObject.GetComponent<damageDealer>();

        if (_damageDealer != null) {
            if (((_damageDealer.tag == "fromEnemy") || (_damageDealer.tag == "Enemy")) && gameObject.tag == "Player")
            { health -= _damageDealer.Damage(); }

            if (_damageDealer.tag == "fromPlayer" && gameObject.tag == "Enemy")
            { health -= _damageDealer.Damage(); }
        }
       
    }


}
