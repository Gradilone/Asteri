using System.Diagnostics;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrMudarScene : MonoBehaviour
{
    [SerializeField] public string carregandoCena;
    [SerializeField] public string inicial;
    [SerializeField] public Vector3 playerPosition;


    GameObject playerValor; 
    
    public string atual;
    public bool trigger=false;

    void Awake()
    {


        inicial = SceneManager.GetActiveScene().name;
        
        UnityEngine.Debug.Log(playerPosition.x+" "+playerPosition.y);
        
        playerValor=GameObject.FindWithTag("Player");
        
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        atual=SceneManager.GetActiveScene().name;
        // if(atual != inicial && atual == carregandoCena && !trigger)
        // {
        //     playerValor.transform.position = new Vector3(playerPosition.x,playerPosition.y,0f);

        //     trigger=true;
        // }
        if (atual != inicial && atual != "Loading" && trigger==false)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerValor.GetComponentInChildren<scrAudio>().Play("Porta");
            trigger=true;
            SceneManager.LoadScene("Loading");
            playerValor.transform.position = new Vector3(playerPosition.x,playerPosition.y,0f);
            playerValor.SetActive(false);
            
            Invoke("Atraso",1f);     
            
        }
        
    }

    void Atraso()
    {
        AsyncOperation operacao=SceneManager.LoadSceneAsync(carregandoCena);
        playerValor.SetActive(true);
        
        trigger=false;
    }
}
