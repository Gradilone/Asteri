using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GanharItem : MonoBehaviour
{
    private Inventario inventario;
    public GameObject bntItem;

    private void Start() 
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
         
    }

    public void GanItem()
    {
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
