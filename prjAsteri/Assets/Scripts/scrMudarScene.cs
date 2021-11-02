using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrMudarScene : MonoBehaviour
{
    public string carregandoCena;
    public Vector2 playerPosition;
    public VectorValor playerValor; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerValor.valorInicial = playerPosition;
            SceneManager.LoadScene(carregandoCena); 
        }
        
    }

}
