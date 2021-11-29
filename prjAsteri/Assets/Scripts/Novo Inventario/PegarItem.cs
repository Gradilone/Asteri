//using System.Reflection.PortableExecutable;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarItem : MonoBehaviour
{
    private Inventario inventario;
    public GameObject bntItem;
    public scrItemManager Manager;
    string nome;

    public bool emContato;
    

    private void Start() 
    {
        nome= gameObject.name;
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
         
        Manager = GameObject.FindGameObjectWithTag("ItemManager").GetComponent<scrItemManager>();

        Manager.Compare(gameObject);
    }

    private void Update() 
    {
        if (emContato && Input.GetKeyDown(KeyCode.E))
        {
            Manager.AddItemToInv(gameObject,bntItem);
            
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
