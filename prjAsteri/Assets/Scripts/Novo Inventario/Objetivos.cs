using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivos : MonoBehaviour
{
    public int i;
    private ObjInventario obj_inventario;

    private void Start() {
        obj_inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<ObjInventario>();
    }

    private void Update() 
    {
        if (transform.childCount <= 0)
        {
            obj_inventario.encheu[i] = false;
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
