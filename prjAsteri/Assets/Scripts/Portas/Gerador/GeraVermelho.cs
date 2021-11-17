using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraVermelho : MonoBehaviour
{
    ObjInventario obj_inventario;
    
    public GameObject IconVermelho;


     private void Start() {
        obj_inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<ObjInventario>();
    }
    
    private void Update() {
        if (SistemaPorta.Vermelho)
        {
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
