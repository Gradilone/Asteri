using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarItem : MonoBehaviour
{
    private Inventario inventario;
    public GameObject bntItem;

    public bool emContato;
    

    private void Start() 
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
         
    }

    private void Update() 
    {
        if (emContato && Input.GetKeyDown(KeyCode.E))
        {
            FindObjectOfType<scrAudio>().Play("Item");
            Debug.Log("Item Pego");
            for (int i = 0; i < inventario.slots.Length; i++)
            {
                 if (inventario.taCheio[i] == false)
                 {
                     inventario.taCheio[i] = true;
                     Instantiate(bntItem, inventario.slots[i].transform, false);
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
