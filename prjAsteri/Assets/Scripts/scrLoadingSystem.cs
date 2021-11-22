using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrLoadingSystem : MonoBehaviour
{
    [SerializeField] public string cenaDesejada;

    public void Carregar()
    {
        
        DontDestroyOnLoad(gameObject);
        
        if (SceneManager.GetActiveScene().name!="Loading")
        {
            SceneManager.LoadScene("Loading");
        }

        Invoke("Atraso",1f);      
    }

    void Atraso()
    {
        AsyncOperation operacao=SceneManager.LoadSceneAsync(cenaDesejada);

        Destroy(gameObject);
    }
}
