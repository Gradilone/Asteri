using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMovimentoTest : MonoBehaviour
{
    public float moveSpeed = 200f;
    private Rigidbody2D myRigidBody;
    private Vector2 ultimoMov;
    public bool MovPlayer;
    public bool movVertical;

    public bool podeMover;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        podeMover = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float currentMoveSpeed = moveSpeed * Time.deltaTime;

        float horizontal = Input.GetAxisRaw("Horizontal");
        bool isMovingHorizontal = Mathf.Abs(horizontal) > 0.5f;

        float vertical = Input.GetAxisRaw("Vertical");
        bool isMovingVertical = Mathf.Abs(vertical) > 0.5f;

        if(!podeMover)
        {
            myRigidBody.velocity = Vector2.zero;
            return;
        }
        
        MovPlayer = true;


        if (isMovingVertical && isMovingHorizontal)
        {
            //moving in both directions, prioritize later
            if (movVertical)
            {
                myRigidBody.velocity = new Vector2(horizontal * currentMoveSpeed, 0);
                ultimoMov = new Vector2(horizontal, 0f);
            }
            else
            {
                myRigidBody.velocity = new Vector2(0, vertical * currentMoveSpeed);
                ultimoMov = new Vector2(0f, vertical);
            }
        }
        else if (isMovingHorizontal)
        {
            myRigidBody.velocity = new Vector2(horizontal * currentMoveSpeed, 0);
            movVertical = false;
            ultimoMov = new Vector2(horizontal, 0f);
        }
        else if (isMovingVertical)
        {
            myRigidBody.velocity = new Vector2(0, vertical * currentMoveSpeed);
            movVertical = true;
            ultimoMov = new Vector2(0f, vertical);
        }
        else
        {
            MovPlayer = false;
            myRigidBody.velocity = Vector2.zero;
        }
            
        }
}
