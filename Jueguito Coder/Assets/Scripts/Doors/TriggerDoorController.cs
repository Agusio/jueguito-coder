using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator Door = null;

    [SerializeField] private bool openTrigger = false;

    private void OnTriggerEnter(Collider other)

    {
        if(other.CompareTag("Player"))
        {
            if(openTrigger)
            {
                Door.Play("DoorOpen", 0, 0f);
                gameObject.SetActive(false);
            }
        }
    }

}
