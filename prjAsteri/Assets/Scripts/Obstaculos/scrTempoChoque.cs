using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrTempoChoque : MonoBehaviour
{
    
    [SerializeField]
    float velo = 4f;
    [SerializeField] 
    Vector3[] pontos;
    private int index;

    private void Update() 
    {
        transform.position = Vector2.MoveTowards(transform.position, pontos[index], Time.deltaTime * velo);
        if (transform.position == pontos[index])
        {
            if (index == pontos.Length -1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
        }

        
    }

     void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.CompareTag("pontoA"))
        {
            scrChoque.emContato = false;
        } 
    }

    void OnTriggerExit2D(Collider2D quem)
    {
        if (quem.CompareTag("pontoA"))
        {
            scrChoque.emContato = true; 
            
        }
    }
}
