using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrUIInventario : MonoBehaviour
{
    scrInventario inventario;
    
    public Transform todosItens;

    scrSlots[] slots;

    void Start()
    {
        inventario = scrInventario.instance;
        inventario.onItemChangedCallback += UpdateUI;

        slots = todosItens.GetComponentsInChildren<scrSlots>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventario.itens.Count)
            {
                slots[i].AddItem(inventario.itens[i]);
            }
            else
            {
                slots[i].LimparSlot();
            }
        }
    }
}
