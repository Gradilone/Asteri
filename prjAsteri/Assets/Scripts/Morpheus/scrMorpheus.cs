using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMorpheus : MonoBehaviour
{
    private Rigidbody2D rbMorpheus;
    [SerializeField] GameObject inicio1;
    [SerializeField] GameObject inicio2;
    [SerializeField] GameObject inicio3;


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
        if (quem.CompareTag("Inimigo1"))
        {
            rbMorpheus.transform.position = new Vector2(inicio1.transform.position.x, inicio1.transform.position.y);
            
        }

        if (quem.CompareTag("Inimigo2"))
        {
            rbMorpheus.transform.position = new Vector2(inicio2.transform.position.x, inicio2.transform.position.y);
            
        }

        if (quem.CompareTag("Inimigo3"))
        {
            rbMorpheus.transform.position = new Vector2(inicio3.transform.position.x, inicio3.transform.position.y);
            
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
