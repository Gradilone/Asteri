using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrChoque : MonoBehaviour
{
    public GameObject fio;
    public GameObject fio2;
    public GameObject fio3;
    public static bool emContato;

    private void Start() {
        fio.SetActive (true);
        fio2.SetActive (true);
        fio3.SetActive (true);
    }

    private void Update() 
    {
        if (emContato)
        {
            fio.SetActive(false);
            fio2.SetActive (false);
            fio3.SetActive (false);
        }
        else
        {
            fio.SetActive(true);
            fio2.SetActive (true);
            fio3.SetActive (true);
        }
    }
    
}
