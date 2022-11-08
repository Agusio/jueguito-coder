using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cases : MonoBehaviour
{
    public GameObject intIcon, smartphone, watch, goldIngot, videogameConsole, laptop;
    public Transform spawnSmartphone, spawnWatch, spawnGoldIngot, spawnVideogameConsole, spawnLaptop;
    private GameObject smartphoneSpawned, watchSpawned, goldIngotSpawned, videogameConsoleSpawned, laptopSpawned;
    public
    
    void Start ()
    {
        Summon();
    }

    void Update()
    {

    }

    void Summon()
    {
        smartphoneSpawned = Instantiate(smartphone, spawnSmartphone.position, spawnSmartphone.rotation);
        watchSpawned = Instantiate(watch, spawnWatch.position, spawnWatch.rotation);
        goldIngotSpawned = Instantiate(goldIngot, spawnGoldIngot.position, spawnGoldIngot.rotation);
        videogameConsoleSpawned = Instantiate (videogameConsole, spawnVideogameConsole.position, spawnVideogameConsole.rotation);
        laptopSpawned = Instantiate (laptop, spawnLaptop.position, spawnLaptop.rotation);
    }


    void OnTriggerStay(Collider col)
    {
        if (col.transform.gameObject.tag == "SmartphoneCollider")
        {
            intIcon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Destroy(smartphoneSpawned,0.1f);
                Debug.Log("Smartphone adquirido");
            }
        }

        if (col.transform.gameObject.tag == "WatchCollider")
        {
            intIcon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Destroy(watchSpawned,0.1f);
                Debug.Log("reloj adquirido");
            }
        }
        
        if (col.transform.gameObject.tag == "GoldIngotCollider")
        {
            intIcon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Destroy(goldIngotSpawned,0.1f);
                Debug.Log("lingote de oro adquirido");
            }
        }

        if (col.transform.gameObject.tag == "VideogameConsoleCollider")
        {
            intIcon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Destroy(videogameConsoleSpawned,0.1f);
                Debug.Log("Consola de videojuegos adquirida");
            }
        }

        if (col.transform.gameObject.tag == "LaptopCollider")
        {
            intIcon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Destroy(laptopSpawned,0.1f);
                Debug.Log("laptop adquirida");
            }
        }
    }

}