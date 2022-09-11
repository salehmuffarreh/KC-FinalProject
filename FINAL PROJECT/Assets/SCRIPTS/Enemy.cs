using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;

    int currantHealth;

    void Start()
    {
        currantHealth = maxHealth;

    }


    public void TakeDamage(int damage)
    {
        currantHealth -= damage;

        animator.SetTrigger("Hurt");

        if (currantHealth <= 0)
        {
            Die();
            
        }
    }
    void Die()
    {
        Debug.Log("Enemy died");
        animator.SetBool("isDead", true);

        GetComponent<Collider2D>().enabled = false;

        this.enabled = false;

    }
}
