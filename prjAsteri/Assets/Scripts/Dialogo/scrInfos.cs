using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class scrInfos : MonoBehaviour
{
    public GameObject dBox;
    public TMP_Text txtDialogo;

    public bool dialogoAtivo;
    public  bool dialogoFim;


    public string[] dialogoLinhas;  
    public int linhaAtual = 0;

    public float veloDigitacao;

    public GameObject bntContinuar;


     void Start()
    {
        
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

    public void MostrarDialogo()
    {
        dialogoAtivo = true;
        dBox.SetActive(true);
        txtDialogo.text = "";
        StartCoroutine(Digitacao());
        bntContinuar.SetActive(false);
        
       

    }

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


        }
    }
}
