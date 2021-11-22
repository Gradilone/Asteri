using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraVermelho : MonoBehaviour
{
    ObjInventario obj_inventario;
    
    public GameObject IconVermelho;
    public scrItemManager Manager;

     private void Start() {
        obj_inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<ObjInventario>();
        Manager = GameObject.FindGameObjectWithTag("ItemManager").GetComponent<scrItemManager>();
        if (Manager.FioVermelho)
        {
            scrVitoria.TemVermelho = true;
            Destroy(gameObject);
        }
    }
    
    private void Update() {
        if (SistemaPorta.Vermelho)
        {
            Manager.FioVermelho=true;
            Instantiate(IconVermelho, obj_inventario.Objetivos[1].transform, false);
            scrVitoria.TemVermelho = true;
            Destroy(gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.VermelhoTocou = true;
        } 
    }

    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.VermelhoTocou = false;
        } 
    }
}
