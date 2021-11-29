using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMusicaPerigo : MonoBehaviour
{
    public bool emContato = false;
 
    void Update()
    {
        if (emContato)
        {
            FindObjectOfType<scrAudio>().Stop("Theme");
        }
        
    }

    void OnTriggerEnter2D(Collider2D quem)
    {
        
        if (quem.CompareTag("Player"))
        {
            emContato = true;  
        } 
    }

    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            emContato = false;  
            
        }
    }
}
