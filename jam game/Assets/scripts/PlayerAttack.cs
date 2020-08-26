using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timebtwAttack;
    public float startTimebtwAttack;

    public Transform attackpos;
    public LayerMask whatIsEnemie; 
    public float attackrange;

    public int damages;


    //public Animator playeranim;
    //public Animation camanim;

    private void Update()
    {
        if(timebtwAttack <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                Collider2D[] enemiesToDamaga = Physics2D.OverlapCircleAll(attackpos.position,attackrange, whatIsEnemie);
                for (int i = 0; i < enemiesToDamaga.Length; i++)
                {
                    
                    enemiesToDamaga[i].GetComponent<Enemy>().takedamags(damages);
                }
                
            }
            timebtwAttack = startTimebtwAttack;
        }
        else
        {
            timebtwAttack -= Time.deltaTime;
        }
    }

    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.blue;
    //    Gizmos.DrawWireSphere(attackpos.position, attackrange);
    //}
}
