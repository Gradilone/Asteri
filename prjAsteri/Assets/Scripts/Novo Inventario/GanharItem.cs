using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GanharItem : MonoBehaviour
{
    public GameObject item;
    private Transform interagivel;
    public scrControladorDialogo Sla;


    private void Start() 
    {
        interagivel = GameObject.FindGameObjectWithTag("PodeItem").transform;
        Sla = GetComponent<scrControladorDialogo>();

    }

    public void DarItem()
    {
        Vector2 objetoPOs = new Vector2(interagivel.position.x, interagivel.position.y + 3);
        Instantiate(item, objetoPOs, Quaternion.identity);

    }
}
