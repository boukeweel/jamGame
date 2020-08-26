using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doos : MonoBehaviour
{

    public bool Holding;
    private Collider2D col_;

    private AudioSource AuS;

    private bool playonce;
    private float timer;
    private void Start()
    {
        AuS = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if(Holding == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                this.transform.parent = col_.transform;
                
            }
            if (Input.GetMouseButtonUp(1))
                this.transform.parent = null;

            if (playonce == true)
            {
                AuS.Play();
                playonce = false;
            }
        }
        else
        {
            this.transform.parent = null;
        }
        if(playonce == false)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                timer = 2f;
                playonce = true;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("au");
        
        if (col.gameObject.tag == "Player")
        {
            col_ = col.collider;
            Holding = true;
        }
        
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
            Holding = false;
    }
}
