using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortaContato : MonoBehaviour
{ 
    [TextArea(3, 10)]
    public string[] dialogoLinhas;
    public string nome;
    [SerializeField] scrControladorDialogo txtDialogo, txtNome, imgMorpheus, imgHera, imgRobo; 

    public GameObject DiaAntes;
    [SerializeField]bool isOpen=false;
    public scrItemManager Manager;

    private void Awake() 
    {
        Manager = GameObject.FindGameObjectWithTag("ItemManager").GetComponent<scrItemManager>();
        isOpen=Manager.portaAbriu;
        if (isOpen)
        {
            Destroy(gameObject);
        }
    }
    
    private void Update() 
    {
         if (SistemaPorta.DialogoAbriu) 
        {
            Destroy(DiaAntes);
            if (!txtDialogo.dialogoAtivo)
            {
                if (txtDialogo.linhaAtual < dialogoLinhas.Length -1)
                {
                    txtDialogo.dialogoLinhas = dialogoLinhas;
                    txtNome.nome = nome;
                    txtDialogo.linhaAtual = 0;
                    txtDialogo.MostrarDialogo();
                    txtNome.MostrarNome(); 
                    imgMorpheus.MostrarMorpheus();
                    imgHera.RetirarHera();
                    imgRobo.RetirarRobo();
                    SistemaPorta.DialogoAbriu = false; 
                }
                else
                {
                   txtDialogo.AcabaDialogo();
                } 
            }   

             Destroy(gameObject); 
        } 

            
        
    }
   
   void OnTriggerEnter2D(Collider2D quem)
    {
        
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.Tocou = true; 
            
        } 
    }

    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.CompareTag("Player"))
        {
            SistemaPorta.Tocou = false;  
            
        }
    }
}
