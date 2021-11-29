using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrErradoOuro : MonoBehaviour
{
    [TextArea(3, 10)]
    public string[] dialogoLinhas;
    public string nome;
    [SerializeField] scrControladorDialogo txtDialogo, txtNome, imgMorpheus, imgHera, imgRobo; 
    //private string dialogo;

   
    //public GameObject dBox;

    void Start() 
    {
        
    }

    private void Update() 
    {
         if (SistemaPorta.NaoOuro) 
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
            SistemaPorta.ClicouOuro = true;  
        } 
    }

    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.ClicouOuro = true; 
            
        }
    }

}
