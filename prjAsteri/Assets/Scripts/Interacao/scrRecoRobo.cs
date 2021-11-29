using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrRecoRobo : MonoBehaviour
{
   private Inventario inventario;
   public scrItemManager Manager;
    public GameObject bntItem;
    
    [TextArea(3, 10)]
    public string[] dialogoLinhas;
    public string nome;
    [SerializeField] scrControladorDialogo txtDialogo, txtNome, imgMorpheus, imgRobo, imgHera; 
    //private string dialogo;
    public bool emContatoRecompensa = false; 



   
    //public GameObject dBox;

    void Start() 
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();

        Manager = GameObject.FindGameObjectWithTag("ItemManager").GetComponent<scrItemManager>();

        if (Manager.CompareName("fioRobo"))
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
                imgRobo.MostrarRobo();
                imgMorpheus.RetirarMorpheus();
                imgHera.RetirarHera();
                
            }

            Manager.AddItemToInv(gameObject,bntItem);
            
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
