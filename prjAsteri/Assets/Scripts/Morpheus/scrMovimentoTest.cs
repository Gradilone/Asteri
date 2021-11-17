using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMovimentoTest : MonoBehaviour
{
    public float moveSpeed = 200f;
    private Rigidbody2D rbMorpheus;
    private Vector2 ultimoMov;
    public bool MovPlayer;
    public bool movVertical; 
    public bool podeMover;
    public Animator anim;
    public float movendo = 1.0f;
    public float naomovendo = 0.0f;

    public VectorValor comecaPosicao;
    [SerializeField] GameObject CampoVisao;

    void Start()
    {
        rbMorpheus = GetComponent<Rigidbody2D>();
        podeMover = true; 

        //transform.position = comecaPosicao.valorInicial;
    }

    private void Update() 
    {
         
    }

    void FixedUpdate()
    {
        float currentMoveSpeed = moveSpeed * Time.deltaTime;

        float horizontal = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("Horizontal", horizontal);
        bool isMovingHorizontal = Mathf.Abs(horizontal) > 0.5f;

        float vertical = Input.GetAxisRaw("Vertical");
        anim.SetFloat("Vertical", vertical);
        if (MovPlayer)
        {
            anim.SetFloat("Velocidade", movendo);
        }
        else
        {
            anim.SetFloat("Velocidade", naomovendo);
        }
        bool isMovingVertical = Mathf.Abs(vertical) > 0.5f;

        if(!podeMover)
        {
         rbMorpheus.velocity = Vector2.zero;
            anim.SetFloat("Velocidade", naomovendo);
            return;
        }
        
        MovPlayer = true;


        if (isMovingVertical && isMovingHorizontal)
        {
            if (movVertical)
            {
             rbMorpheus.velocity = new Vector2(horizontal * currentMoveSpeed, 0);
                ultimoMov = new Vector2(horizontal, 0f);
                
            }
            else
            {
             rbMorpheus.velocity = new Vector2(0, vertical * currentMoveSpeed);
                ultimoMov = new Vector2(0f, vertical);
                
            }
        }
        else if (isMovingHorizontal)
        {
         rbMorpheus.velocity = new Vector2(horizontal * currentMoveSpeed, 0);
            movVertical = false;
            ultimoMov = new Vector2(horizontal, 0f);
        }
        else if (isMovingVertical)
        {
         rbMorpheus.velocity = new Vector2(0, vertical * currentMoveSpeed);
            movVertical = true;
            ultimoMov = new Vector2(0f, vertical);
        }
        else
        {
            MovPlayer = false;
         rbMorpheus.velocity = Vector2.zero;
        }
            
        }

}
