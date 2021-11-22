using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraAzul : MonoBehaviour
{
    ObjInventario obj_inventario;
    
    public GameObject IconAzul;
    public scrItemManager Manager;
    



     private void Start() {
        obj_inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<ObjInventario>();
        Manager = GameObject.FindGameObjectWithTag("ItemManager").GetComponent<scrItemManager>();
        if (Manager.FioAzul)
        {
            scrVitoria.TemAzul = true;
            Destroy(gameObject);
        }
    }
    
    private void Update() {
        if (SistemaPorta.Azul)
        {
            Manager.FioAzul=true;
            Instantiate(IconAzul, obj_inventario.Objetivos[3].transform, false);
            scrVitoria.TemAzul = true;
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

    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.AzulTocou = false;
        } 
    }
}
