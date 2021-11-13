﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrDialogoHera : MonoBehaviour
{
    [TextArea(3, 10)]
    public string[] dialogoLinhas;
    public string nome;
    [SerializeField] scrControladorDialogo txtDialogo, txtNome, imgHera, imgMorpheus; 
    [SerializeField] bool emContato = false; 

    

    void Start()
    {

    }

    private void Update() 
    {
        if (emContato && Input.GetKeyDown(KeyCode.E)) 
        {

            if (!txtDialogo.dialogoAtivo)
            {
                txtDialogo.dialogoLinhas = dialogoLinhas;
                txtNome.nome = nome;
                txtDialogo.linhaAtual = 0;
                txtDialogo.MostrarDialogo();
            }
        }  

        if (txtDialogo.linhaAtual == 2 || txtDialogo.linhaAtual == 4 || txtDialogo.linhaAtual == 7 || txtDialogo.linhaAtual == 11 || txtDialogo.linhaAtual == 21 || txtDialogo.linhaAtual == 26)
        {
            //Falas Morpheus

            txtNome.Nome_Morpheus();
            imgMorpheus.MostrarMorpheus();
            imgHera.RetirarHera();
        }
        else
        {
            //Falas Hera

            txtNome.Nome_Hera();
            imgMorpheus.RetirarMorpheus();
            imgHera.MostrarHera();
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