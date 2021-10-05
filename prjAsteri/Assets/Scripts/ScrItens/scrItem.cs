using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrItem : MonoBehaviour
{
    [SerializeField] bool emContato = false;
    public DadosItem itens;

    void Update()
    {
        Pegou(); 
    }

    void Pegou()
    {
         if(emContato && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Pegou " + itens.name);
            bool foiPego = scrInventario.instance.Add(itens);
            if (foiPego){ Destroy(gameObject);}
        }

    }

    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            emContato = true; 
            
        } 
    }

    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            emContato = false;  
            
        }
    }

}
