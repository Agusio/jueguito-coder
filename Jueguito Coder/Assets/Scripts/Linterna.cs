using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public Light luzLinterna;
    public bool activeLight;
    public AudioSource SwitchSound; 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SwitchSound.Play();
            activeLight = !activeLight;
        }
            if (activeLight == true)
        {
            luzLinterna.enabled = true;
        }

        if(activeLight == false)
        {
            luzLinterna.enabled = false;
        }

    }
}
