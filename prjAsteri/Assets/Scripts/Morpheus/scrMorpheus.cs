using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMorpheus : MonoBehaviour
{
    private Rigidbody2D rbMorpheus;
    scrMovimentoTest Movimento;
    [SerializeField] GameObject inicio1;
    [SerializeField] GameObject inicio2;
    [SerializeField] GameObject inicio3;

    [SerializeField] GameObject campoVisao;

    public float tempo = 30f;
    public bool eletrico = false;
    public float speedTirada = 100;
    public float speedLimite = 100;



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
        Movimento = GameObject.FindGameObjectWithTag("Player").GetComponent<scrMovimentoTest>();
        campoVisao.transform.localRotation = Quaternion.Euler(0,0,180);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            campoVisao.transform.localRotation = Quaternion.Euler(0,0,90);
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            campoVisao.transform.localRotation = Quaternion.Euler(0,0,0);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            campoVisao.transform.localRotation = Quaternion.Euler(0,0,180);
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            campoVisao.transform.localRotation = Quaternion.Euler(0,0,-90);
        }

        if (!Input.anyKey)
        {
            campoVisao.transform.localRotation = Quaternion.Euler(0,0,180);
        }

    }

    void OnTriggerEnter2D(Collider2D quem)
    {
        if (quem.CompareTag("Inimigo1"))
        {
            rbMorpheus.transform.position = new Vector2(inicio1.transform.position.x, inicio1.transform.position.y);
            Movimento.moveSpeed = 200;
            FindObjectOfType<scrAudio>().Play("GameOver");
            
        }

        if (quem.CompareTag("Inimigo2"))
        {
            rbMorpheus.transform.position = new Vector2(inicio2.transform.position.x, inicio2.transform.position.y);
            Movimento.moveSpeed = 200;
            FindObjectOfType<scrAudio>().Play("GameOver");
        }

        if (quem.CompareTag("Inimigo3"))
        {
            rbMorpheus.transform.position = new Vector2(inicio3.transform.position.x, inicio3.transform.position.y);
            Movimento.moveSpeed = 200;
            FindObjectOfType<scrAudio>().Play("GameOver");
        }

        if (quem.CompareTag("choque"))
        {
            FindObjectOfType<scrAudio>().Play("Choque");
            StartCoroutine(Choque());
            eletrico = true;
        }
    }

    IEnumerator Choque()
    {
        if (eletrico == true && Movimento.moveSpeed > speedLimite)
        {
            Movimento.moveSpeed -= speedTirada;            
        }
       yield return new WaitForSeconds(tempo); 
       Movimento.moveSpeed = 200;
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
