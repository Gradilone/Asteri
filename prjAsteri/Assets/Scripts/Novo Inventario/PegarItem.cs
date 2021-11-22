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
            FindObjectOfType<scrAudio>().Play("Item");
            Debug.Log("Item Pego");
            for (int i = 0; i < inventario.slots.Length; i++)
            {
                if (inventario.taCheio[i] == false)
                {
                    inventario.taCheio[i] = true;
                    Instantiate(bntItem, inventario.slots[i].transform, false);
                    Manager.itensInv.Add(nome);
                    Destroy(gameObject);  
                    break;
                }
            }
            
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
