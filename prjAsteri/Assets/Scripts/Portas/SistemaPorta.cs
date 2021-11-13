using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaPorta : MonoBehaviour
{
    public static bool Tocou;
    public static bool DialogoAbriu = false;
  
    public void Usar()
    {
        if (Tocou)
        {
            Debug.Log("Abriu"); 
            DialogoAbriu = true;
            Destroy(gameObject);


        }
    }
}
