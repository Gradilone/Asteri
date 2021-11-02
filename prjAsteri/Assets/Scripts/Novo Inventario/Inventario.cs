using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public bool[] taCheio;
    public GameObject[] slots;
    public GameObject UIInventario;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventario"))
        {
            UIInventario.SetActive(!UIInventario.activeSelf);
        }
    }
    

}
