using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrIntContato : MonoBehaviour
{
    [TextArea(3, 10)]
    public string[] dialogoLinhas;
    public string nome;
    [SerializeField] scrControladorDialogo txtDialogo, txtNome, imgMorpheus; 
    //private string dialogo;
    [SerializeField] bool emContato = false; 
    

    void Start()
    {
        imgMorpheus.RetirarMorpheus();
    }

    private void Update() 
    {
        if (emContato) 
        {
            //txtDialogo.MostrarBox(dialogo); 
            if (txtDialogo.dialogoAtivo)
            {
                Destroy(gameObject); 
            }
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
        if (SistemaPorta.DialogoAbriu) 
        {
            Destroy(gameObject); 
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
