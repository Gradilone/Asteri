using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrInventario : MonoBehaviour
{

    #region Singleton

    

    public static scrInventario instance;

    void Awake() 
    {
        if (instance != null)
        {
            Debug.LogWarning("Eita bixo deu erro aqui em");
            return; 
        }
        instance = this;
    }

    #endregion
    
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int espaco = 6;
    public List<DadosItem> itens = new List<DadosItem>();

    public bool Add (DadosItem Item)
    {
        if (!Item.PodePegar)
        {
            if (itens.Count >= espaco)
            {
                Debug.Log("Sem espaço");
                return false;
            }
            itens.Add(Item);
            if (onItemChangedCallback != null)
            {
                onItemChangedCallback.Invoke(); 
            }
        }
        return true;
    }
    
}
