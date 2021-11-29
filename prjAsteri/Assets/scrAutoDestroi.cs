using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class scrAutoDestroi : MonoBehaviour
{

    public GameObject dBox;
    public TMP_Text txtDialogo;

    public bool dialogoAtivo;
    public float veloDigitacao;
    public string dialogoLinhas; 
    void autoDestroi()
    {
        this.gameObject.SetActive(false);
        scrControladorDialogo.podeMover = true;
    }

    void texto()
    {
        FindObjectOfType<scrAudio>().Play("Dialogo");
        dialogoAtivo = true;
        dBox.SetActive(true);
        txtDialogo.text = "";
        StartCoroutine(Digitacao());

    }

    void interropeTexto()
    {
        dialogoAtivo = false;
        dBox.SetActive(false);
        txtDialogo.text = "";
        StopCoroutine(Digitacao());
    }

     IEnumerator Digitacao()
    {
        foreach (char letra in dialogoLinhas.ToCharArray())
        {
            txtDialogo.text += letra;
            yield return new WaitForSeconds(veloDigitacao);
        }

    }
}
