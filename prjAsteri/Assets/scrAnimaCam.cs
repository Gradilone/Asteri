using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrAnimaCam : MonoBehaviour
{
    public GameObject cameraCut;
    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            cameraCut.SetActive(true);
            scrControladorDialogo.podeMover = false;
           
        } 
    }
}
