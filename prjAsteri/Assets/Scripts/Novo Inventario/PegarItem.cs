using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarItem : MonoBehaviour
{
    private Inventario inventario;
    public GameObject bntItem;

    private void Start() 
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
         
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
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
}
