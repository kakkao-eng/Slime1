using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class log : Enemy
{
    private Rigidbody2D myRigidboby;
    
    public Transform target;

    public float chaseRaidus;

    public float attaclRadius;

    public Transform homePosition;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        currentState = EnemyState.idle;
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckDistance();
    }

    void CheckDistance()
    {
        if(Vector3.Distance(target.position, transform.position) <= chaseRaidus && Vector3.Distance(target.position, transform.position) > attaclRadius)
        {
            if (currentState == EnemyState.idle || currentState == EnemyState.walk && currentState != EnemyState.stagger)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
                ChangeState(EnemyState.walk);

                Vector2 temp = target.position - transform.position; // ประกาศและกำหนดค่า temp
                changAnim(temp);
                anim.SetBool("wakeUp", true);
            }
        }
        else
        {
            anim.SetBool("wakeUp", false);
        }
    }
    
    
    private void SetAnimFloat(Vector2 setVector)
    {
        anim.SetFloat("moveX" , setVector.x);
        anim.SetFloat("moveY" , setVector.y);
    }
    private void changAnim(Vector2 direction)
    {
        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
        {
            if (direction.x > 0)
            {
                SetAnimFloat(Vector2.right);
            }
            else if (direction.x < 0)
            {
                SetAnimFloat(Vector2.left);
            }
        }
        else if (Mathf.Abs(direction.x) < Mathf.Abs(direction.y))
        {
            if (direction.y > 0)
            {
                SetAnimFloat(Vector2.up);
            }
            else if (direction.y < 0)
            {
                SetAnimFloat(Vector2.down);
            }
        }
    }

    private void ChangeState(EnemyState newState)
    {
        if (currentState != newState)
        {
            currentState = newState;
        }
    }
    
    
    
    
}
