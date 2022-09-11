using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{   
    public Animator animator;

    public Transform attack;
    public float attackRange = 0.5f;
    public LayerMask enemyLeyers;

    public int attackDamage = 40;
    public float attackRate = 2f;
    float nextAttackTime=0f;

    void Update()
    {
        if (Time.time > nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    } 
    void Attack()
    {
        animator.SetTrigger("Attack");

       Collider2D[]hitEnimies= Physics2D.OverlapCircleAll(attack.position,attackRange, enemyLeyers);

        foreach(Collider2D enemy in hitEnimies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }
    void OnDrawGizmosSelected()
    {
        if(attack==null)
               return;
        Gizmos.DrawWireSphere(attack.position, attackRange);
    }
}
