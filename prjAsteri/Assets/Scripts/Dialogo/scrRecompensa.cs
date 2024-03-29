﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrRecompensa : MonoBehaviour
{

    private Inventario inventario;
    public GameObject bntItem;
    public scrItemManager Manager;
    
    [TextArea(3, 10)]
    public string[] dialogoLinhas;
    public string nome;
    [SerializeField] scrControladorDialogo txtDialogo, txtNome, imgMorpheus, imgRobo; 
    //private string dialogo;
    public bool emContatoRecompensa = false; 


   
    //public GameObject dBox;

    void Start() 
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
        Manager = GameObject.FindGameObjectWithTag("ItemManager").GetComponent<scrItemManager>();

        if (Manager.CompareName("bntOuro"))
        {
            Destroy(gameObject);
        }
    }

    private void Update() 
    {
        if (emContatoRecompensa && Input.GetKeyDown(KeyCode.E)) 
        {
            //txtDialogo.MostrarBox(dialogo); 

            if (!txtDialogo.dialogoAtivo)
            {
                txtDialogo.dialogoLinhas = dialogoLinhas;
                txtNome.nome = nome;
                txtDialogo.linhaAtual = 0;
                txtDialogo.MostrarDialogo();
                txtNome.MostrarNome(); 
                imgMorpheus.MostrarMorpheus();
                imgRobo.RetirarRobo();
                
            }

                for (int i = 0; i < inventario.slots.Length; i++)
            {
                if (inventario.taCheio[i] == false)
                {
                    inventario.taCheio[i] = true;
                    FindObjectOfType<scrAudio>().Play("Item");
                    Instantiate(bntItem, inventario.slots[i].transform, false);
                    Manager.itensInv.Add("fioRobo");
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
            emContatoRecompensa = true;  
        } 
    }

    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            emContatoRecompensa = false;  
            
        }
    }
}
