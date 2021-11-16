using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorContato : MonoBehaviour
{
    ObjInventario obj_inventario;
    
    public GameObject IconAmarelo;


     private void Start() {
        obj_inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<ObjInventario>();
    }
    private void Update() 
    {
        if (SistemaPorta.Amarelo)
        {
            Instantiate(IconAmarelo, obj_inventario.Objetivos[0].transform, false);
            Destroy(gameObject);

        }
    }

    void OnTriggerEnter2D(Collider2D quem)
    {
        
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.AmareloTocou = true;
        } 
    }

    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.AmareloTocou = false;
        } 
    }

}
