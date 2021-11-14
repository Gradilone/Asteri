using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    private Inventario inventario;
    public int i;

    private void Start() 
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
    }

    private void Update() 
    {
        if (transform.childCount <= 0)
        {
            inventario.taCheio[i] = false;
        }
    }
    public void RemoverItem()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject); 
        }

    }
}
