using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInventario : MonoBehaviour
{
    public bool[] encheu;
    public GameObject[] Objetivos;
    public GameObject UIObjetivos;

    private void Start() {
        UIObjetivos.SetActive(false);
    }

    private void Update() {
        if (Input.GetButtonDown("Inventario"))
        {
            UIObjetivos.SetActive(!UIObjetivos.activeSelf);
            DontDestroyOnLoad(gameObject);
        }
    }
}
