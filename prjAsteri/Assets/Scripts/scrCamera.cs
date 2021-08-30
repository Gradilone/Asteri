using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrCamera : MonoBehaviour
{
    [SerializeField] Transform morpheus;
    private Vector3 posPlayer;
    public float moveSpeed = 10f;
    void Start()
    {
        //transform.position = new Vector3(morpheus.position.x, morpheus.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(morpheus.position.x, morpheus.position.y, transform.position.z);
        posPlayer = new Vector3(morpheus.transform.position.x, morpheus.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp (transform.position, posPlayer, moveSpeed * Time.deltaTime); 

    }
}
