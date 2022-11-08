using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject intIcon, lightOn, lightOff, switchOn, switchOff;
    private float toggle = 0;

    void Start()
    {
        lightOn.SetActive(false);
        lightOff.SetActive(true);
        switchOn.SetActive(false);
        switchOff.SetActive(true);
        intIcon.SetActive(false);
    }

    void OnTriggerStay(Collider col)
    {
        if (col.transform.gameObject.name == "SwitchHabitacion")
        {
            intIcon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (toggle == 0)
                {
                    lightOn.SetActive(true);
                    lightOff.SetActive(false);
                    switchOn.SetActive(true);
                    switchOff.SetActive(false);
                    toggle = 1;
                }
                else if (toggle == 1)
                {
                    lightOn.SetActive(false);
                    lightOff.SetActive(true);
                    switchOn.SetActive(false);
                    switchOff.SetActive(true);
                    toggle = 0;
                }
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.transform.gameObject.name == "SwitchHabitacion")
        {
            intIcon.SetActive(false);
        }
    }
}