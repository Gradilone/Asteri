using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scrControladorDialogo : MonoBehaviour
{
    public GameObject dBox;
    public TMP_Text txtDialogo;
    public TMP_Text txtNome;
    public string nome;
    public bool dialogoAtivo;

    public string[] dialogoLinhas;  
    public int linhaAtual = 0;

    public float veloDigitacao;

    public GameObject bntContinuar;

    private scrMovimentoTest Player;


    void Start()
    {
        Player = FindObjectOfType<scrMovimentoTest>();
        StartCoroutine(Digitacao());


    }

    void Update()
    {
        if  (txtDialogo.text == dialogoLinhas[linhaAtual])
        {
            bntContinuar.SetActive(true);
        if (dialogoAtivo && Input.GetKeyDown(KeyCode.Space))
        {
            ProxDialogo(); 
        }  
        }

        /*
        if (dialogoAtivo && Input.GetKeyDown(KeyCode.Space))
        {
            linhaAtual++;
            
        }

        if (linhaAtual >= dialogoLinhas.Length)
        {
            dBox.SetActive(false);
            dialogoAtivo = false;
            linhaAtual = 0;
            StartCoroutine(Digitacao());
            
        }

     txtDialogo.text = dialogoLinhas[linhaAtual];
        */

        
    }

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
            StartCoroutine(Digitacao());
        }
        else
        {
            dBox.SetActive(false);
            dialogoAtivo = false;
            linhaAtual = 0;
            bntContinuar.SetActive(false);

            Player.podeMover = true;
        }

    }


}
