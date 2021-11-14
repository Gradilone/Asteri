using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrRecompensa : MonoBehaviour
{

    private Inventario inventario;
    public GameObject bntItem;

    private void Start() 
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
         
    }
    void Update()
    {
        if (scrControladorDialogo.dialogoFim)
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

    void Recompensa()
    {
        
    }
}
