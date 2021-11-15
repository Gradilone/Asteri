using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorItem : MonoBehaviour
{
    /*
    ObjInventario obj_inventario;
    
    public GameObject bntItem;

    public bool emContatoGerador;

    private void Start() {
        obj_inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<ObjInventario>();
    }

    private void Update() 
    {
        if (emContatoGerador && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Item Pego");
            for (int i = 0; i < obj_inventario.Objetivos.Length; i++)
            {
                 if (obj_inventario.encheu[i] == false)
                 {
                     obj_inventario.encheu[i] = true;
                     Instantiate(bntItem, obj_inventario.Objetivos[i].transform, false);
                     Destroy(gameObject); 
                     break;
                 }
            }
            
        }
        
    }

    void OnTriggerEnter2D(Collider2D quem)
    {
        
        if (quem.CompareTag("Player"))
        {
            emContatoGerador = true;  
        } 
    }

    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            emContatoGerador = false;  
            
        }
    }
    */
}
