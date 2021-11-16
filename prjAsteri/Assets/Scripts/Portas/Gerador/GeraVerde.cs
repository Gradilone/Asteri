using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraVerde : MonoBehaviour
{
    ObjInventario obj_inventario;
    
    public GameObject IconVerde;


     private void Start() {
        obj_inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<ObjInventario>();
    }
    
    private void Update() {
        if (SistemaPorta.Verde)
        {
            Instantiate(IconVerde, obj_inventario.Objetivos[2].transform, false);
            Destroy(gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.VerdeTocou = true;
        } 
    }

    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.VerdeTocou = false;
        } 
    }
}
