﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMorpheus : MonoBehaviour
{
    private Rigidbody2D rbMorpheus;
    [SerializeField] GameObject inicio;


    public static scrMorpheus Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        rbMorpheus = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.CompareTag("Inimigo"))
        {
            Destroy(gameObject);
            
        }
    }

    /*

    void Movimento()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            //transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            rbMorpheus.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rb.velocity.y);
            

        }
        else if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            //transform.Translate (new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            rbMorpheus.velocity = new Vector2(rb.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
        }

        if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            rbMorpheus.velocity = new Vector2(0f, rb.velocity.y);

        }
        if(Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            rbMorpheus.velocity = new Vector2(rb.velocity.x, 0f);

        }

    }

    */
}