using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;

    public GameObject bloodparticals;

    private void Start()
    {
        
    }
    private void Update()
    {
        if(health == 0)
        {
            Destroy(gameObject);
        }
    }

    public void takedamags(int damage)
    {
        gameObject.SetActive(true);
        health -= damage;

    }
}
