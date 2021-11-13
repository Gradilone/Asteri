using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class scrInteracao : MonoBehaviour
{
    [TextArea(3, 10)]
    public string[] dialogoLinhas;
    public string nome;
    [SerializeField] scrControladorDialogo txtDialogo, txtNome, imgMorpheus; 
    //private string dialogo;
    [SerializeField] bool emContato = false; 


   
    //public GameObject dBox;

    void Start() 
    {
        
    }

    private void Update() 
    {
        if (emContato && Input.GetKeyDown(KeyCode.E)) 
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
