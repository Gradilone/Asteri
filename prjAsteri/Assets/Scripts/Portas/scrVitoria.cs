using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrVitoria : MonoBehaviour
{
    public static bool TemAzul = false;
    public static bool TemAmarelo = false;
    public static bool TemVerde = false;
    public static bool TemVermelho = false;
    Animator anim;

    public GameObject UIObjetivos;
    void Start()
    {
        anim = GetComponent<Animator>();
        UIObjetivos.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (TemAzul == true && TemVerde == true && TemVermelho == true && TemAmarelo == true)
        {
            anim.SetBool("ligou", true);
            Debug.Log("Venceu");
        }
        
        if (TemAzul == true || TemVerde == true || TemVermelho == true || TemAmarelo == true)
        {
            UIObjetivos.SetActive(true);
        }
    }
}
