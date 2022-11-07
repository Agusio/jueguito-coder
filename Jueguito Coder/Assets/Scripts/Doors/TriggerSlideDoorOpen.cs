using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSlideDoorOpen : MonoBehaviour
{
    [SerializeField] private Animator Door = null;

    [SerializeField] private bool openTrigger = false;

    private void OnTriggerEnter(Collider other)

    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                Door.Play("slidedooropen", 0, 0f);
                gameObject.SetActive(false);
            }
        }
    }

}
