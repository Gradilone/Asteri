using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrErradoPrata : MonoBehaviour
{
    [TextArea(3, 10)]
    public string[] dialogoLinhas;
    public string nome;
    [SerializeField] scrControladorDialogo txtDialogo, txtNome, imgMorpheus, imgHera, imgRobo; 
    //private string dialogo;
    public bool emContato = false; 


   
    //public GameObject dBox;

    void Start() 
    {
        
    }

    private void Update() 
    {
        if (SistemaPorta.NaoPrata) 
        {
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
                imgHera.RetirarHera();
                imgRobo.RetirarRobo();
            }
            
        }
            
    }

    void OnTriggerEnter2D(Collider2D quem)
    {
        
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.ClicouPrata = true;  
        } 
    }

    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.ClicouPrata = true; 
            
        }
    }

}
