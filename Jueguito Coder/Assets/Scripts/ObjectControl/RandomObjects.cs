using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjects : MonoBehaviour
{
    public GameObject FirstCase,SecondCase,ThirdCase,FourthCase,FifthCase;
    int rndm;

    void Awake()
    {
        Randomizer();
    }

    void Start()
    {
        ObjectsSelection();
    }

    void Randomizer()
    {
        rndm = Random.Range (1,2);
        FirstCase.SetActive(false);
        SecondCase.SetActive(false);
        ThirdCase.SetActive(false);
        FourthCase.SetActive(false);
        FifthCase.SetActive(false);
    }

    void ObjectsSelection()
    {
        if (rndm == 1)
        {
            FirstCase.SetActive(true);
        }
        else if (rndm == 2)
        {
            SecondCase.SetActive(true);
        }
        else if (rndm == 3)
        {
            ThirdCase.SetActive(true);
        }
        else if (rndm == 4)
        {
            FourthCase.SetActive(true);
        }
        else if (rndm == 5)
        {
            FifthCase.SetActive(true);
        }
        
    }
}

