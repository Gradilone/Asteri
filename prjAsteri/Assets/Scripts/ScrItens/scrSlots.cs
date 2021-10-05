using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrSlots : MonoBehaviour
{
    DadosItem item;
    public Image icon;

    public void AddItem(DadosItem novoItem)
    {
        item = novoItem;

        icon.sprite = item.icon;
        icon.enabled = true; 
    }

    public void LimparSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false; 
    }

    public void UsarItem()
    {
        if (item != null)
        {
            item.Usar();
        }
    }
}
