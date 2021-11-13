using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrSentinela : MonoBehaviour
{
    [SerializeField] GameObject sentinela;
    [SerializeField] float velorotacao = 300f;

    // Update is called once per frame
    void Update()
    {
        sentinela.transform.Rotate(new Vector3 (0f,0f,1f), velorotacao * Time.deltaTime, Space.Self);
    }
}
