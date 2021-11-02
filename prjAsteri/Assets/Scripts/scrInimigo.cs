using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrInimigo : MonoBehaviour
{
    [SerializeField]
    float velo = 2f;
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
}
