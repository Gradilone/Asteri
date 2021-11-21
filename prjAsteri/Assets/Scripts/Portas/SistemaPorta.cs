using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaPorta : MonoBehaviour
{
    public static bool Tocou;
    public static bool AmareloTocou;
    public static bool VerdeTocou;
    public static bool VermelhoTocou;
    public static bool AzulTocou;
    public static bool DialogoAbriu = false;
    public static bool Amarelo = false;
    public static bool Azul = false;
    public static bool Vermelho = false;
    public static bool Verde = false;

    public static bool OuroTocou = false;

    public static bool PrataTocou = false;

    public static bool BronzeTocou = false;

    public static bool Ouro = false;

    public static bool Prata = false;

    public static bool Bronze = false;

    private scrControladorDialogo dialogo;

    private void Start() 
    {
        dialogo = GetComponent<scrControladorDialogo>();
        
    }

  
    public void Usar()
    {
        if (Tocou)
        {
            Debug.Log("Abriu");
            FindObjectOfType<scrAudio>().Play("Porta"); 
            DialogoAbriu = true;
            Destroy(gameObject);
        }
    }

    public void UsarAmarelo()
    {
        if (AmareloTocou)
        {
            Amarelo = true;
            Destroy(gameObject);
        }
        
    }

    public void UsarAzul()
    {
        if (AzulTocou)
        {
            Azul = true;
            Destroy(gameObject);
        }
    }

    public void UsarVerde()
    {
        if (VerdeTocou)
        {
            Verde = true;
            Destroy(gameObject);
        }
    }

    public void UsarVermelho()
    {
        if (VermelhoTocou)
        {
            Vermelho = true;
            Destroy(gameObject);
        }
    }

    public void UsarOuro()
    {
        if (OuroTocou)
        {
            Ouro = true;
            Destroy(gameObject);
            
        }
    }

    public void UsarPrata()
    {
        if (PrataTocou)
        {
            Prata = true;
            Destroy(gameObject);
        }
    }

    public void Usarbronze()
    {
        if (BronzeTocou)
        {
            Bronze = true;
            Destroy(gameObject);
        }
    }
}
