using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrMudarScene : MonoBehaviour
{
    [SerializeField] string carregandoCena;
    [SerializeField] string inicial;
    [SerializeField] Vector3 playerPosition;
    Transform playerValor; 
    string atual;
    bool trigger=false;

    void Awake()
    {
        inicial = SceneManager.GetActiveScene().name;
        
        Debug.Log(playerPosition.x+" "+playerPosition.y);
        
        playerValor=GameObject.FindWithTag("Player").transform;
        
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        atual=SceneManager.GetActiveScene().name;
        if(atual != inicial && atual == carregandoCena && !trigger)
        {
            playerValor.position = new Vector3(playerPosition.x,playerPosition.y,0f);

            trigger=true;
            
        }
        else if (atual != inicial)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            SceneManager.LoadScene(carregandoCena); 

            GetComponent<Collider2D>().enabled = false;

            Debug.Log(playerPosition.x+" "+playerPosition.y);
            //Load();
        }
        
    }
}
