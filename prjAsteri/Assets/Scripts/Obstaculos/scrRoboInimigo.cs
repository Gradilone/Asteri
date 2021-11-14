using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrRoboInimigo : MonoBehaviour
{
    public GameObject[] Pontos;
    int atual = 0;

    public float moveSpeed;

    float raioPonto = 0.1f;

    private void Update() 
    {
        if (Vector3.Distance(Pontos[atual].transform.position, transform.position) < raioPonto)
        {
            atual++;
            if (atual >= Pontos.Length)
            {
                atual = 0;
            }
            
        }
        transform.position = Vector3.MoveTowards(transform.position, Pontos[atual].transform.position, Time.deltaTime * moveSpeed);
        
    }
}
