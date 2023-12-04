using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlsyerAttack : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float attackRange = 0.5f;
    public int attackDamage = 40;
    
    public AudioSource audioSource;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
           //enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
           //Debug.Log("We hit" + enemy.name);
        }
        
        // เล่นเสียงเมื่อโจมตี
        if (audioSource != null)
        {
            audioSource.Play();
        }

    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);

    }
    
    
    
    
}
