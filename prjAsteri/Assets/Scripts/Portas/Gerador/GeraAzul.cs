using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraAzul : MonoBehaviour
{
    ObjInventario obj_inventario;
    
    public GameObject IconAzul;


     private void Start() {
        obj_inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<ObjInventario>();
    }
    
    private void Update() {
        if (SistemaPorta.Azul)
        {
            Instantiate(IconAzul, obj_inventario.Objetivos[3].transform, false);
            Destroy(gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.AzulTocou = true;
        } 
    }
}
