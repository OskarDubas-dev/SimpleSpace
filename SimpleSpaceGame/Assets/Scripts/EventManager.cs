using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public delegate void death();
    public static event death OnDeath;

    void restart()
    {
        Debug.Log("restart");
    }

}
