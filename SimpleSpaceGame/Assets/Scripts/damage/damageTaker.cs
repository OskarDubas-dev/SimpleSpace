using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageTaker : MonoBehaviour
{
    [SerializeField] int health = 1;
    

    [SerializeField] private AudioClip deathSound;
    private float deathSoundVolume = 0.1f;

    [SerializeField] private GameObject deathVFX;

   



    private void Update()
    {
        if(health <= 0)
        { destroyItself(); }
    }

    private void destroyItself()
    {
        if (gameObject.tag == "Player") playerDeath();
        else if (gameObject.tag == "Enemy") enemyDeath();
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


    private void enemyDeath()
    {
        AudioSource.PlayClipAtPoint(deathSound, Camera.main.transform.position, deathSoundVolume);
        GameObject explosion = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void playerDeath()
    {

        

        AudioSource.PlayClipAtPoint(deathSound, Camera.main.transform.position, deathSoundVolume);
        GameObject explosion = Instantiate(deathVFX, transform.position, transform.rotation);
        // Destroy(gameObject);

        FindObjectOfType<LevelManager>().deathScreen();
        Destroy(gameObject);
    }

   


}
