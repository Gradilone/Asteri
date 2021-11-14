using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortaContato : MonoBehaviour
{ 
   

    private void Update() 
    {
         if (SistemaPorta.DialogoAbriu) 
        {
            Destroy(gameObject); 
        }
        
        
    }
   
   void OnTriggerEnter2D(Collider2D quem)
    {
        
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.Tocou = true;  
        } 
    }

    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.Tocou = false;  
            
        }
    }



  

}
