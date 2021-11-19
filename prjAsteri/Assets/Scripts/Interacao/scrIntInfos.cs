using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class scrIntInfos : MonoBehaviour
{
    [TextArea(3, 10)]
    public string[] dialogoLinhas;
    [SerializeField] scrInfos txtDialogo; 
    //private string dialogo;
    public bool emContato = false; 


   
    //public GameObject dBox;

    void Start() 
    {
        
    }

    private void Update() 
    {
        if (emContato) 
        {
            //txtDialogo.MostrarBox(dialogo); 

            if (!txtDialogo.dialogoAtivo)
            {
                txtDialogo.dialogoLinhas = dialogoLinhas;
                txtDialogo.linhaAtual = 0;
                txtDialogo.MostrarDialogo();
                
            }
            else
            {
                Destroy(gameObject);
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
