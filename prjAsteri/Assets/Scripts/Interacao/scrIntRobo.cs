using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrIntRobo : MonoBehaviour
{
   [TextArea(3, 10)]
    public string[] dialogoLinhas;
    public string nome;
    [SerializeField] scrControladorDialogo txtDialogo, txtNome, imgHera, imgMorpheus, imgRobo; 
    //private string dialogo;
    public bool emContato = false; 


   
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
                imgRobo.MostrarRobo();
                imgMorpheus.RetirarMorpheus();
                imgHera.RetirarHera();
                
                
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
