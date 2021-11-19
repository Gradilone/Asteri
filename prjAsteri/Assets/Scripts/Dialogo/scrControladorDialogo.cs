using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class scrControladorDialogo : MonoBehaviour
{
    public GameObject dBox;
    public TMP_Text txtDialogo;
    public TMP_Text txtNome;
    [SerializeField] Image pnlHera;
    [SerializeField] Image pnlMorpheus;
    [SerializeField] Image imgHera;
    [SerializeField] Image imgMorpheus;
    public string nome;
    public bool dialogoAtivo; 
    public  bool dialogoFim;


    public string[] dialogoLinhas;  
    public int linhaAtual = 0;

    public float veloDigitacao;

    public GameObject bntContinuar;

    private scrMovimentoTest Player;

    public string nomeMorpheus = "Morpheus";

    public string nomeHera = "Hera";
    


    


    void Start()
    {
        imgHera.enabled = false;
        imgMorpheus.enabled = false;
        Player = FindObjectOfType<scrMovimentoTest>();
        StartCoroutine(Digitacao());
         
        


    }

    void Update()
    {
        
        
        if  (txtDialogo.text == dialogoLinhas[linhaAtual])
        {
            bntContinuar.SetActive(true);
            
        if (scrPauseMenu.jogoPausado == false && dialogoAtivo && Input.GetKeyDown(KeyCode.Space))
        {
            
            ProxDialogo();  
        }  
        }
    }

    #region Exibição

    public void MostrarDialogo()
    {
        dialogoAtivo = true;
        dBox.SetActive(true);
        txtDialogo.text = "";
        StartCoroutine(Digitacao());
        bntContinuar.SetActive(false);
        
        Player.podeMover = false;

    }

    public void MostrarNome()
    {
        txtNome.text = nome;
    }

    public void Nome_Morpheus()
    {
        txtNome.text = nomeMorpheus;
    }

    public void Nome_Hera()
    {
        txtNome.text = nomeHera;
    }

    public void MostrarHera()
    {
        imgHera.enabled = true;
        pnlHera.enabled = true;
    }

    public void RetirarHera()
    {
        imgHera.enabled = false;
        pnlHera.enabled = false;
    }

    public void MostrarMorpheus()
    {
        imgMorpheus.enabled = true;
        pnlMorpheus.enabled = true; 
    }

    public void RetirarMorpheus()
    {
        imgMorpheus.enabled = false;
        pnlMorpheus.enabled = false; 
    }

    #endregion

    IEnumerator Digitacao()
    {
        foreach (char letra in dialogoLinhas[linhaAtual].ToCharArray())
        {
            txtDialogo.text += letra;
            yield return new WaitForSeconds(veloDigitacao);
        }

    }

    public void ProxDialogo()
    {
        bntContinuar.SetActive(false);
        
        
        
        if (linhaAtual < dialogoLinhas.Length -1)
        {
            linhaAtual++;
            txtDialogo.text = "";
            dialogoFim = false;
            StartCoroutine(Digitacao());
        }
        else
        {
            dialogoFim = true;
            dBox.SetActive(false);
            dialogoAtivo = false;
            linhaAtual = 0;
            bntContinuar.SetActive(false);

            Player.podeMover = true;

           
        } 
   

    }


}
