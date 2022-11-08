using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySummon : MonoBehaviour
{
    private float time = 0;

    void Update()
    {
        Summon();
    }

    void Summon()
    {
        time += Time.deltaTime;
        if(time >= 180)
        {
            Debug.Log("Perdiste");
            gameObject.SetActive(false);
        }
    }
}
