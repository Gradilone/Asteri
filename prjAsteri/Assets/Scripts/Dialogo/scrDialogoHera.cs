using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrDialogoHera : MonoBehaviour
{
    [TextArea(3, 10)]
    public string[] dialogoLinhas;
    public string nome;
    [SerializeField] scrControladorDialogo txtDialogo, txtNome, imgHera, imgMorpheus; 
    [SerializeField] bool emContato = false; 

    public int LinhaFinal = 26;


    

    void Start()
    {

    }

    private void Update() 
    {
        
        if (emContato) 
        {
            if (!txtDialogo.dialogoAtivo)
            {
                txtDialogo.dialogoLinhas = dialogoLinhas;
                txtNome.nome = nome;
                txtDialogo.linhaAtual = 0;
                txtDialogo.MostrarDialogo();
            }

            if (txtDialogo.linhaAtual == 2 || txtDialogo.linhaAtual == 4 || txtDialogo.linhaAtual == 7 || txtDialogo.linhaAtual == 11 || txtDialogo.linhaAtual == 17 || txtDialogo.linhaAtual == 22)
        {
            //Falas Morpheus

            txtNome.Nome_Morpheus();
            imgMorpheus.MostrarMorpheus();
            imgHera.RetirarHera();
            
        }
        else
        {
            //Falas Hera

            txtNome.Nome_Hera();
            imgMorpheus.RetirarMorpheus();
            imgHera.MostrarHera();
        }

        if (txtDialogo.linhaAtual == LinhaFinal)
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
