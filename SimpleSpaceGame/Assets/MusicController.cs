using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioClip levelMusic;
    [SerializeField] private float musicVolume = 0.3f;

    private void Start()
    {
        AudioSource.PlayClipAtPoint(levelMusic, Camera.main.transform.position, musicVolume);
    }
}
