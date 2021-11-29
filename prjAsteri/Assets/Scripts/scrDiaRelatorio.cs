using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrDiaRelatorio : MonoBehaviour
{
    [TextArea(3, 10)]
    public string[] dialogoLinhas;
    public string nome;
    [SerializeField] scrControladorDialogo txtDialogo, txtNome; 
    //private string dialogo;
    public bool emContato = false; 

    public scrItemManager Manager;
    string nomeRela;



   
    //public GameObject dBox;

    void Start() 
    {
        nomeRela= gameObject.name;
        Manager = GameObject.FindGameObjectWithTag("ItemManager").GetComponent<scrItemManager>();

        Manager.Compare(gameObject);
    }

    private void Update() 
    {
        if (emContato && Input.GetKeyDown(KeyCode.E)) 
        {
            //txtDialogo.MostrarBox(dialogo);
        
            if (!txtDialogo.dialogoAtivo)
            {
                txtDialogo.dialogoLinhas = dialogoLinhas;
                txtDialogo.linhaAtual = 0;
                txtDialogo.MostrarDialogo();
                txtNome.nome = nome;
                txtNome.MostrarNome();
                 
            }
            if (txtDialogo.dialogoAtivo)
            {
                Manager.itensInv.Add(nomeRela); 
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
