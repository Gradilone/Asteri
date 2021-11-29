﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrItemManager : MonoBehaviour
{
    [SerializeField] public List<string> itensInv = new List<string>();

    [SerializeField] public bool portaAbriu=false;

    public static scrItemManager Instance { get; private set; }

    public bool FioAmarelo=false;

    public bool FioAzul=false;

    public bool FioVermelho=false;

    public bool FioVerde=false;

    private Inventario inventario;

    private void Awake()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        
        DontDestroyOnLoad(gameObject);
    }

    public void Compare(GameObject atual)
    {
        if(itensInv.Contains(atual.name))
        {
            Destroy(atual);
        }
    }

    public bool CompareName(string atualis)
    {
        if(itensInv.Contains(atualis))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void AddItemToInv(GameObject presente, GameObject btnPresente)
    {
        for (int i = 0; i < inventario.slots.Length; i++)
            {
                if (inventario.taCheio[i] == false)
                {
                    inventario.taCheio[i] = true;
                    FindObjectOfType<scrAudio>().Play("Item");
                    Instantiate(btnPresente, inventario.slots[i].transform, false);
                    itensInv.Add(presente.name);
                    Destroy(presente);  
                    break;
                }
            }
    }
}