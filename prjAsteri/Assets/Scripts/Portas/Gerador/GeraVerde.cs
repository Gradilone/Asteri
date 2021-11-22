using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraVerde : MonoBehaviour
{
    ObjInventario obj_inventario;
    
    public GameObject IconVerde;
    public scrItemManager Manager;

     private void Start() {
        obj_inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<ObjInventario>();
        Manager = GameObject.FindGameObjectWithTag("ItemManager").GetComponent<scrItemManager>();
        if (Manager.FioVerde)
        {
            scrVitoria.TemVerde = true;
            Destroy(gameObject);
        }
    }
    
    private void Update() {
        if (SistemaPorta.Verde)
        {
            Manager.FioVerde=true;
            Instantiate(IconVerde, obj_inventario.Objetivos[2].transform, false);
            scrVitoria.TemVerde = true;
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
