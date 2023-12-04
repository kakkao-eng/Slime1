using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    walk,
    attack,
    interact
}

public class PlayerMovements : MonoBehaviour
{
    public PlayerState currentState;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Animator animator;
    public FloatValue currentHealth;

    [HideInInspector] public float Sp;
    private bool isStop = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        Sp = speed;
    }

    void FixedUpdate()
    {

        if (!isStop)
        {
            movement = Vector2.zero;
            movement.x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
            movement.y = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
            if (movement != Vector2.zero)
            {
                transform.Translate(new Vector2(movement.x, movement.y));
                animator.SetFloat("moveX", movement.x);
                animator.SetFloat("moveY", movement.y);
                animator.SetBool("moving", true);
            }
            else
            {
                animator.SetBool("moving", false);
            }
        }

        
    }
    void MoveCharacter(){
    rb.MovePosition(rb.position + movement * Sp * Time.fixedDeltaTime);
    }

    
}
    
    

    