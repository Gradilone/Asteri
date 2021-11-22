using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrIntHera : MonoBehaviour
{
    [TextArea(3, 10)]
    public string[] dialogoLinhas;
    public string nome;
    [SerializeField] scrControladorDialogo txtDialogo, txtNome, imgHera, imgMorpheus, imgRobo; 
    //private string dialogo;
    public bool emContato = false; 
    Animator anim;


   
    //public GameObject dBox;

    void Start() 
    {
        anim = GetComponent<Animator>();
    }

    private void Update() 
    {
        if (txtDialogo.dialogoAtivo && emContato)
        {
            anim.SetBool("isOn", true);
        }
        else
        {
            anim.SetBool("isOn", false);
        }
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
                imgHera.MostrarHera();
                imgMorpheus.RetirarMorpheus();
                imgRobo.RetirarRobo();
                
                
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
