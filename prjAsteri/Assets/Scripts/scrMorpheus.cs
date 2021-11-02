using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMorpheus : MonoBehaviour
{
    private Rigidbody2D rbMorpheus;
    [SerializeField] GameObject inicio;



    void Start()
    {
        rbMorpheus = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.CompareTag("Inimigo"))
        {
            rbMorpheus.transform.position = new Vector2(inicio.transform.position.x, inicio.transform.position.y);
            
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
