using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrChoque : MonoBehaviour
{
    public GameObject fio;
    public static bool emContato;

    private void Start() {
        fio.SetActive (true);
    }

    private void Update() 
    {
        if (emContato)
        {
            fio.SetActive(false);
        }
        else
        {
            fio.SetActive(true);
        }
    }
    
}
